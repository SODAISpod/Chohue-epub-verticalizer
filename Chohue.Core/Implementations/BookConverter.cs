using Chohue.Core.Enums;
using Chohue.Core.Interfaces;
using Chohue.Core.Models;
using Microsoft.Extensions.Logging;

namespace Chohue.Core.Implementations;

/// <summary>
/// Orchestrates the full EPUB conversion pipeline.
/// Maps to Load() + Convert() in the original Book.cs.
/// Split into two phases: LoadAsync (extract + parse) and ConvertAsync (process + repackage).
/// </summary>
public class BookConverter : IBookConverter
{
    private readonly IEpubPacker _packer;
    private readonly IEpubParser _parser;
    private readonly IHtmlProcessor _htmlProcessor;
    private readonly ICssVerticalizer _cssVerticalizer;
    private readonly IImageReplacer _imageReplacer;
    private readonly IToolRunner _toolRunner;
    private readonly IDialogPresenter _dialog;
    private readonly ILogger<BookConverter> _logger;

    public BookConverter(
        IEpubPacker packer,
        IEpubParser parser,
        IHtmlProcessor htmlProcessor,
        ICssVerticalizer cssVerticalizer,
        IImageReplacer imageReplacer,
        IToolRunner toolRunner,
        IDialogPresenter dialog,
        ILogger<BookConverter> logger)
    {
        _packer = packer;
        _parser = parser;
        _htmlProcessor = htmlProcessor;
        _cssVerticalizer = cssVerticalizer;
        _imageReplacer = imageReplacer;
        _toolRunner = toolRunner;
        _dialog = dialog;
        _logger = logger;
    }

    /// <inheritdoc/>
    public async Task<ConversionResult> LoadAsync(string inputPath)
    {
        _logger.LogInformation("Loading book: {InputPath}", inputPath);

        try
        {
            // Step 1: Handle TXT → EPUB conversion via Calibre
            if (Path.GetExtension(inputPath).Equals(".txt", StringComparison.OrdinalIgnoreCase))
            {
                string? converted = await ConvertTxtToEpubAsync(inputPath);
                if (converted == null)
                    return Fail("Failed to convert TXT to EPUB.");
                inputPath = converted;
            }

            // Step 2: Extract EPUB
            string uncompressedPath = _packer.Extract(inputPath);

            // Step 3: Parse manifest
            EpubManifest manifest = _parser.ReadManifest(uncompressedPath);

            // Step 4: Check EPUB version — EPUB 2.x needs Pandoc upgrade
            if (!manifest.EpubVersion.StartsWith("3"))
            {
                _logger.LogInformation("EPUB 2.x detected, upgrading to EPUB 3 via Pandoc");
                var (upgraded, newPath) = await UpgradeEpub2Async(inputPath);
                if (!upgraded)
                {
                    await _dialog.ShowErrorAsync(
                        "EPUB 2.x files require Pandoc. Please configure the Pandoc path in Settings.");
                    return Fail("EPUB 2 to 3 upgrade failed.");
                }
                // Re-extract the upgraded EPUB
                uncompressedPath = _packer.Extract(newPath);
                manifest = _parser.ReadManifest(uncompressedPath);
            }

            _logger.LogInformation("Book loaded: \"{Title}\" by {Author}, EPUB {Version}, {XhtmlCount} XHTML, {CssCount} CSS",
                manifest.Title, manifest.Author, manifest.EpubVersion,
                manifest.XhtmlFiles.Count, manifest.CssFiles.Count);

            return new ConversionResult
            {
                Success = true,
                Manifest = manifest,
                UncompressedPath = uncompressedPath
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to load {InputPath}", inputPath);
            return Fail(ex.Message);
        }
    }

    /// <inheritdoc/>
    public async Task<ConversionResult> ConvertAsync(EpubManifest manifest, ConversionOptions options)
    {
        _logger.LogInformation("Converting: \"{Title}\"", manifest.Title);

        try
        {
            // Step 1: Truncate title if needed
            if (options.TruncateTitle)
                manifest.Title = TruncateTitle(manifest.Title);

            // Step 2: Process CSS files
            var cssOptions = new CssProcessingOptions
            {
                EmbedFont = options.EmbedFont,
                Verticalize = !options.DoNotVerticalize,
                DoNotVerticalize = options.DoNotVerticalize,
                ClearStylesheet = options.ClearStylesheet,
                AddCustomCss = options.AddCustomCss,
                CustomCss = options.CustomCss
            };
            foreach (var cssPath in manifest.CssFiles)
            {
                _logger.LogDebug("Processing CSS: {Path}", cssPath);
                _cssVerticalizer.ProcessFile(cssPath, cssOptions);
            }

            // Step 3: Process XHTML files
            var htmlOptions = new HtmlProcessingOptions
            {
                ConvertChinese = options.ConvertChinese,
                ToTraditional = options.ToTraditional,
                ReplacePunctuation = options.ReplacePunctuation,
                RemoveInlineStyles = options.RemoveInlineStyles,
                DecodeBeforeParsing = options.DecodeHtmlBeforeParsing
            };
            foreach (var xhtmlPath in manifest.XhtmlFiles)
            {
                _logger.LogDebug("Processing XHTML: {Path}", xhtmlPath);
                _htmlProcessor.ProcessFile(xhtmlPath, htmlOptions);
            }

            // Step 4: Replace images if requested
            if (options.ReplacePicture)
                _imageReplacer.ReplaceImages(manifest.ImageFiles);

            // Step 5: Write OPF metadata (page direction, etc.)
            _parser.WriteOpf(manifest, options);

            // Step 6: Package back to EPUB
            string outputPath = _packer.Package(manifest.UncompressedPath, manifest.Title);
            _logger.LogInformation("EPUB packaged: {OutputPath}", outputPath);

            // Step 7: Optional format conversions
            if (options.ConvertMobi)
                await ConvertToMobiAsync(outputPath);

            if (options.ConvertKepub)
                await ConvertToKepubAsync(outputPath);

            return new ConversionResult
            {
                Success = true,
                OutputPath = outputPath,
                Manifest = manifest
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Conversion failed for \"{Title}\"", manifest.Title);
            return Fail(ex.Message);
        }
        finally
        {
            // Clean up temp directory
            if (Directory.Exists(manifest.UncompressedPath))
            {
                try { Directory.Delete(manifest.UncompressedPath, recursive: true); }
                catch (Exception ex)
                {
                    _logger.LogWarning(ex, "Failed to clean up temp dir: {Path}", manifest.UncompressedPath);
                }
            }
        }
    }

    /// <inheritdoc/>
    public async Task<ConversionResult> ConvertAsync(string inputPath, ConversionOptions options)
    {
        // Full pipeline: load first, then convert
        var loadResult = await LoadAsync(inputPath);
        if (!loadResult.Success || loadResult.Manifest is null)
            return loadResult;

        return await ConvertAsync(loadResult.Manifest, options);
    }

    // ─── Private helpers ───

    private async Task<string?> ConvertTxtToEpubAsync(string txtPath)
    {
        if (!_toolRunner.IsAvailable(ExternalTool.CalibreTxtToEpub))
        {
            await _dialog.ShowErrorAsync("Converting TXT requires Calibre. Please configure the Calibre path in Settings.");
            return null;
        }

        string outName = Path.GetRandomFileName().Replace(".", "");
        string outPath = Path.Combine("temp", $"{outName}.epub");
        string args = $"\"{txtPath}\" \"{outPath}\" --epub-version 3 --no-default-epub-cover";

        var result = await _toolRunner.RunAsync(ExternalTool.CalibreTxtToEpub, args);
        return result == ToolResult.Success || result == ToolResult.Finished ? outPath : null;
    }

    private async Task<(bool success, string outputPath)> UpgradeEpub2Async(string epubPath)
    {
        if (!_toolRunner.IsAvailable(ExternalTool.PandocWithReload))
            return (false, "");

        string outName = Path.GetRandomFileName().Replace(".", "");
        string outPath = Path.Combine("temp", $"{outName}.epub");
        string args = $"-o \"{outPath}\" -t epub3 \"{epubPath}\"";

        var result = await _toolRunner.RunAsync(ExternalTool.PandocWithReload, args);
        return (result == ToolResult.Success, outPath);
    }

    private async Task ConvertToMobiAsync(string epubPath)
    {
        string outName = Path.GetFileNameWithoutExtension(epubPath);
        string outDir = Path.GetDirectoryName(epubPath) ?? "output";

        if (_toolRunner.IsAvailable(ExternalTool.Calibre))
        {
            string args = $"\"{epubPath}\" \"{Path.Combine(outDir, outName)}.mobi\" --mobi-file-type=both";
            await _toolRunner.RunAsync(ExternalTool.Calibre, args);
        }
        else if (_toolRunner.IsAvailable(ExternalTool.KindleGen))
        {
            string args = $"\"{epubPath}\" -o \"{outName}.mobi\" -c1 -dont_append_source";
            await _toolRunner.RunAsync(ExternalTool.KindleGen, args);
        }
        else
        {
            await _dialog.ShowErrorAsync("MOBI conversion requires Calibre or KindleGen. Please configure in Settings.");
        }
    }

    private async Task ConvertToKepubAsync(string epubPath)
    {
        if (!_toolRunner.IsAvailable(ExternalTool.Kepubify))
        {
            await _dialog.ShowErrorAsync("KEPUB conversion requires Kepubify. Please configure in Settings.");
            return;
        }

        string outDir = Path.GetDirectoryName(epubPath) ?? "output";
        string outName = Path.GetFileNameWithoutExtension(epubPath);
        string args = $"\"{epubPath}\" --output \"{Path.Combine(outDir, outName)}.kepub.epub\"";
        await _toolRunner.RunAsync(ExternalTool.Kepubify, args);
    }

    private static string TruncateTitle(string title)
    {
        if (title.Length <= 18) return title;
        return $"{title[..9]}…{title[^8..]}";
    }

    private static ConversionResult Fail(string message) =>
        new() { Success = false, ErrorMessage = message };
}
