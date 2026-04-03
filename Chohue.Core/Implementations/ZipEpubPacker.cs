using Chohue.Core.Interfaces;
using Ionic.Zip;
using Microsoft.Extensions.Logging;

namespace Chohue.Core.Implementations;

/// <summary>
/// EPUB packer using DotNetZip.Original.
/// Handles extraction and repackaging of EPUB files with EPUB-spec-compliant ZIP layout
/// (mimetype entry must be first and uncompressed).
/// </summary>
public class ZipEpubPacker : IEpubPacker
{
    private readonly ILogger<ZipEpubPacker> _logger;

    public ZipEpubPacker(ILogger<ZipEpubPacker> logger)
    {
        _logger = logger;
    }

    /// <inheritdoc/>
    public string Extract(string epubPath)
    {
        string directoryName = Path.GetRandomFileName().Replace(".", "");
        string uncompressedPath = Path.Combine("temp", directoryName);

        _logger.LogInformation("Extracting {EpubPath} to {UncompressedPath}", epubPath, uncompressedPath);

        try
        {
            using ZipFile zip = ZipFile.Read(epubPath);
            foreach (ZipEntry entry in zip)
            {
                entry.Extract(uncompressedPath, ExtractExistingFileAction.OverwriteSilently);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to extract EPUB: {EpubPath}", epubPath);
            throw;
        }

        // Remove mimetype file — it will be re-added first (uncompressed) during Package()
        string mimetypePath = Path.Combine(uncompressedPath, "mimetype");
        if (File.Exists(mimetypePath))
        {
            _logger.LogDebug("Removing extracted mimetype file: {Path}", mimetypePath);
            File.Delete(mimetypePath);
        }

        return uncompressedPath;
    }

    /// <inheritdoc/>
    public string Package(string sourceDir, string title)
    {
        string safeTitle = SanitizeFileName(title);
        string outputDir = "output";
        string outputPath = Path.Combine(outputDir, $"{safeTitle}.epub");

        if (!Directory.Exists(outputDir))
            Directory.CreateDirectory(outputDir);

        // Deduplicate filename if already exists
        if (File.Exists(outputPath))
        {
            int index = 1;
            while (File.Exists(Path.Combine(outputDir, $"{safeTitle} ({index}).epub")))
                index++;
            outputPath = Path.Combine(outputDir, $"{safeTitle} ({index}).epub");
        }

        _logger.LogInformation("Packaging EPUB to {OutputPath}", outputPath);

        try
        {
            // Step 1: Write mimetype as first entry with no compression (EPUB spec requirement)
            using (var zs = new ZipOutputStream(outputPath))
            {
                var entry = zs.PutNextEntry("mimetype");
                entry.CompressionLevel = Ionic.Zlib.CompressionLevel.None;
                byte[] mimeBytes = System.Text.Encoding.ASCII.GetBytes("application/epub+zip");
                zs.Write(mimeBytes, 0, mimeBytes.Length);
            }

            // Step 2: Add all other files with normal compression
            using var zip = new ZipFile(outputPath);
            zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Default;
            zip.EmitTimesInWindowsFormatWhenSaving = false;
            zip.UseZip64WhenSaving = Zip64Option.Never;
            zip.AddDirectory(sourceDir);
            zip.Save();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to package EPUB: {OutputPath}", outputPath);
            throw;
        }

        return outputPath;
    }

    private static string SanitizeFileName(string fileName)
    {
        var replacements = new Dictionary<string, string>
        {
            { "<", " " }, { ">", " " }, { ":", "：" }, { "\"", " " },
            { "\\", " " }, { "//", " " }, { "|", " " }, { "?", " " }, { "*", " " }
        };
        foreach (var pair in replacements)
            fileName = fileName.Replace(pair.Key, pair.Value);
        return fileName;
    }
}
