using Chohue.Core.Enums;
using Chohue.Core.Interfaces;
using Chohue.Core.Models;
using Microsoft.Extensions.Logging;
using System.Xml;

namespace Chohue.Core.Implementations;

/// <summary>
/// Parses and writes EPUB metadata from container.xml and OPF files.
/// Maps to Container(), OpfReader(), OpfWriter() in the original Book.cs.
/// </summary>
public class EpubParser : IEpubParser
{
    private readonly ILogger<EpubParser> _logger;

    public EpubParser(ILogger<EpubParser> logger)
    {
        _logger = logger;
    }

    /// <inheritdoc/>
    public EpubManifest ReadManifest(string uncompressedPath)
    {
        var manifest = new EpubManifest
        {
            UncompressedPath = uncompressedPath
        };

        // Step 1: Read container.xml to find OPF path
        string containerPath = Path.Combine(uncompressedPath, "META-INF", "container.xml");
        _logger.LogInformation("Reading container.xml: {Path}", containerPath);
        manifest.OpfPath = ReadContainerXml(containerPath);

        // Step 2: Read OPF file
        string opfFullPath = Path.Combine(uncompressedPath, manifest.OpfPath.Replace("/", Path.DirectorySeparatorChar.ToString()));
        opfFullPath = Path.GetFullPath(opfFullPath);
        _logger.LogInformation("Reading OPF: {Path}", opfFullPath);

        manifest.BasePath = Path.GetDirectoryName(opfFullPath) + Path.DirectorySeparatorChar;
        ReadOpf(opfFullPath, manifest);

        return manifest;
    }

    /// <inheritdoc/>
    public void WriteOpf(EpubManifest manifest, ConversionOptions options)
    {
        string opfFullPath = Path.Combine(manifest.UncompressedPath, manifest.OpfPath.Replace("/", Path.DirectorySeparatorChar.ToString()));
        opfFullPath = Path.GetFullPath(opfFullPath);

        _logger.LogInformation("Writing OPF: {Path}", opfFullPath);

        XmlDocument xdoc = new XmlDocument();
        xdoc.Load(opfFullPath);
        XmlNode root = xdoc.DocumentElement!;

        // Update metadata (title, author)
        foreach (XmlNode node in root.ChildNodes)
        {
            if (node.Name == "metadata")
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    if (child.Name == "dc:title")
                        child.InnerText = manifest.Title;
                    if (child.Name == "dc:creator")
                        child.InnerText = manifest.Author;
                }
            }

            // Update page-progression-direction
            if (node.Name == "spine")
            {
                string direction = options.ChangePageDirection ? "ltr" : "rtl";
                _logger.LogDebug("Setting page-progression-direction: {Direction}", direction);

                if (node.Attributes?["page-progression-direction"] != null)
                {
                    node.Attributes["page-progression-direction"]!.Value = direction;
                }
                else
                {
                    XmlAttribute attr = xdoc.CreateAttribute("page-progression-direction");
                    attr.Value = direction;
                    node.Attributes!.Append(attr);
                }
            }
        }

        // Save with UTF-8 (no BOM)
        XmlWriterSettings writerSettings = new XmlWriterSettings
        {
            Encoding = new System.Text.UTF8Encoding(false),
            Indent = true
        };
        using XmlWriter writer = XmlWriter.Create(opfFullPath, writerSettings);
        xdoc.Save(writer);
        _logger.LogDebug("OPF saved: {Path}", opfFullPath);
    }

    private string ReadContainerXml(string containerPath)
    {
        XmlDocument xdoc = new XmlDocument();
        xdoc.Load(containerPath);
        XmlNode root = xdoc.DocumentElement!;

        foreach (XmlNode node in root.ChildNodes)
        {
            if (node.Name == "rootfiles")
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    if (child.Name == "rootfile")
                        return child.Attributes!["full-path"]!.Value;
                }
            }
        }

        throw new InvalidOperationException("Could not find rootfile in container.xml");
    }

    private void ReadOpf(string opfPath, EpubManifest manifest)
    {
        XmlDocument xdoc = new XmlDocument();
        xdoc.Load(opfPath);
        XmlNode root = xdoc.DocumentElement!;

        manifest.EpubVersion = root.Attributes?["version"]?.Value ?? "3.0";
        _logger.LogDebug("EPUB version: {Version}", manifest.EpubVersion);

        foreach (XmlNode node in root.ChildNodes)
        {
            if (node.Name == "metadata")
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    if (child.Name == "dc:title")
                        manifest.Title = child.InnerText;
                    if (child.Name == "dc:creator")
                        manifest.Author = child.InnerText;
                }
            }

            if (node.Name == "manifest")
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    if (child.Name != "item") continue;

                    string mediaType = child.Attributes?["media-type"]?.Value ?? "";
                    string href = child.Attributes?["href"]?.Value ?? "";
                    string fullPath = Path.Combine(manifest.BasePath, href.Replace("/", Path.DirectorySeparatorChar.ToString()));

                    switch (mediaType)
                    {
                        case "text/css":
                            manifest.CssFiles.Add(fullPath);
                            break;
                        case "application/xhtml+xml":
                            manifest.XhtmlFiles.Add(fullPath);
                            break;
                        case "image/gif":
                            manifest.ImageFiles["gif"].Add(fullPath);
                            break;
                        case "image/jpeg":
                            manifest.ImageFiles["jpeg"].Add(fullPath);
                            break;
                        case "image/png":
                            manifest.ImageFiles["png"].Add(fullPath);
                            break;
                    }
                }
            }
        }

        _logger.LogInformation(
            "Manifest read: Title={Title}, CSS={CssCount}, XHTML={XhtmlCount}",
            manifest.Title, manifest.CssFiles.Count, manifest.XhtmlFiles.Count);
    }
}
