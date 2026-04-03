using Chohue.Core.Enums;
using Chohue.Core.Interfaces;
using Chohue.Core.Models;
using HtmlAgilityPack;
using Microsoft.Extensions.Logging;
using System.Text;

namespace Chohue.Core.Implementations;

/// <summary>
/// Processes XHTML files: Chinese conversion, punctuation replacement,
/// inline style removal, and vertical CSS injection.
/// Maps to HtmlEdit(), RecursivelyReplaceText(), RemoveHtmlStyle() in the original Book.cs.
/// </summary>
public class HtmlProcessor : IHtmlProcessor
{
    private readonly IChineseConverter _chineseConverter;
    private readonly ILogger<HtmlProcessor> _logger;

    // Embedded fallback vertical CSS (injected when XHTML has no linked stylesheet)
    private const string VerticalCss =
        "html, body { writing-mode: vertical-rl; -webkit-writing-mode: vertical-rl; -epub-writing-mode: vertical-rl; margin: 1%; }";

    public HtmlProcessor(IChineseConverter chineseConverter, ILogger<HtmlProcessor> logger)
    {
        _chineseConverter = chineseConverter;
        _logger = logger;
    }

    /// <inheritdoc/>
    public void ProcessFile(string xhtmlPath, HtmlProcessingOptions options)
    {
        _logger.LogDebug("Processing HTML: {Path}", xhtmlPath);

        string source = File.ReadAllText(xhtmlPath, Encoding.UTF8);

        // Decode HTML entities before parsing if needed (fixes pre-encoded content)
        if (options.DecodeBeforeParsing)
            source = System.Net.WebUtility.HtmlDecode(source);

        var doc = new HtmlDocument();
        doc.OptionWriteEmptyNodes = true;
        doc.OptionOutputOriginalCase = true;  // Preserve original tag casing
        doc.LoadHtml(source);

        bool hasLinkedStylesheet = false;

        foreach (HtmlNode node in doc.DocumentNode.ChildNodes)
        {
            if (node.Name != "html") continue;

            foreach (HtmlNode sectionNode in node.ChildNodes)
            {
                if (sectionNode.Name == "head")
                {
                    // Check for linked stylesheet
                    foreach (HtmlNode item in sectionNode.ChildNodes)
                    {
                        if (item.Name == "link" && item.Attributes["rel"]?.Value == "stylesheet")
                        {
                            hasLinkedStylesheet = true;
                            break;
                        }
                    }

                    // Inject inline vertical CSS if no external stylesheet exists
                    if (!hasLinkedStylesheet)
                    {
                        _logger.LogDebug("No stylesheet found, injecting vertical CSS into {Path}", xhtmlPath);
                        HtmlNode styleNode = doc.CreateElement("style");
                        styleNode.InnerHtml = VerticalCss;
                        sectionNode.AppendChild(styleNode);
                    }
                }

                if (sectionNode.Name == "body")
                {
                    foreach (HtmlNode bodyChild in sectionNode.ChildNodes)
                    {
                        RecursivelyProcessText(bodyChild, options);

                        if (options.RemoveInlineStyles)
                            RemoveInlineStyles(bodyChild);
                    }
                }
            }
        }

        using FileStream fs = new FileStream(xhtmlPath, FileMode.Create);
        doc.Save(fs, Encoding.UTF8);
    }

    private void RecursivelyProcessText(HtmlNode node, HtmlProcessingOptions options)
    {
        foreach (HtmlNode child in node.ChildNodes)
        {
            if (child.ChildNodes.Count == 0)
            {
                // Leaf node — apply text transformations
                string text = child.InnerHtml;

                if (options.ConvertChinese)
                {
                    var direction = options.ToTraditional
                        ? ChineseConversionDirection.SimplifiedToTraditional
                        : ChineseConversionDirection.TraditionalToSimplified;
                    text = _chineseConverter.Convert(text, direction);
                }

                // Re-encode HTML entities (preserves valid XHTML)
                text = System.Net.WebUtility.HtmlEncode(text);

                if (options.ReplacePunctuation)
                    text = ReplacePunctuation(text);

                child.InnerHtml = text;
            }
            else
            {
                RecursivelyProcessText(child, options);
            }
        }
    }

    private static void RemoveInlineStyles(HtmlNode node)
    {
        foreach (HtmlNode child in node.ChildNodes)
        {
            var styleAttr = child.Attributes["style"];
            styleAttr?.Remove();

            if (child.ChildNodes.Count > 0)
                RemoveInlineStyles(child);
        }
    }

    private static string ReplacePunctuation(string text)
    {
        // Replace horizontal punctuation with vertical equivalents (Taiwan style)
        var sb = new StringBuilder(text);
        sb.Replace("「", "\uFE41"); // ﹁
        sb.Replace("\u201C", "\uFE41"); // " → ﹁
        sb.Replace("\u201D", "\uFE42"); // " → ﹂
        sb.Replace("『", "\uFE43"); // ﹃
        sb.Replace("\u2018", "\uFE43"); // ' → ﹃
        sb.Replace("\u2019", "\uFE44"); // ' → ﹄
        sb.Replace("』", "\uFE44"); // ﹄
        sb.Replace("」", "\uFE42"); // ﹂
        sb.Replace("（", "\uFE35"); // ︵
        sb.Replace("）", "\uFE36"); // ︶
        sb.Replace("\uFE10", "\uFF0C"); // ，
        return sb.ToString();
    }
}
