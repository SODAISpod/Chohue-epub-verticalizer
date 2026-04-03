using Chohue.Core.Interfaces;
using Chohue.Core.Models;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Text.RegularExpressions;

namespace Chohue.Core.Implementations;

/// <summary>
/// Injects vertical writing CSS (writing-mode: vertical-rl) into EPUB CSS files.
/// Maps to CSSEdit() and LagecyCssStyle in the original Book.cs.
/// </summary>
public class CssVerticalizer : ICssVerticalizer
{
    private readonly ILogger<CssVerticalizer> _logger;

    private static readonly Regex ReBody = new Regex(@"[bB][oO][dD][yY][\s]*[{]", RegexOptions.Compiled);
    private static readonly Regex ReHtml = new Regex(@"[Hh][Tt][Mm][Ll][\s]*[{]", RegexOptions.Compiled);

    public CssVerticalizer(ILogger<CssVerticalizer> logger)
    {
        _logger = logger;
    }

    /// <inheritdoc/>
    public void ProcessFile(string cssPath, CssProcessingOptions options)
    {
        _logger.LogDebug("Processing CSS: {Path}", cssPath);

        List<string> lines = new();

        if (!options.ClearStylesheet)
        {
            lines = File.ReadAllLines(cssPath).ToList();
        }

        if (!options.DoNotVerticalize)
        {
            _logger.LogDebug("Applying vertical writing-mode to body selector");
            lines = InjectWritingMode(lines, ReBody, "body");

            _logger.LogDebug("Applying vertical writing-mode to html selector");
            lines = InjectWritingMode(lines, ReHtml, "html");
        }

        var sb = new StringBuilder();
        foreach (var line in lines)
            sb.AppendLine(line);

        if (options.AddCustomCss && !string.IsNullOrWhiteSpace(options.CustomCss))
        {
            _logger.LogDebug("Appending custom CSS");
            sb.AppendLine(options.CustomCss);
        }

        File.WriteAllText(cssPath, sb.ToString(), Encoding.UTF8);
    }

    /// <summary>
    /// Finds the given CSS selector in the lines, injects vertical writing-mode properties,
    /// and replaces the original selector block.
    /// Ports the logic from LagecyCssStyle.FindRawStyle() + Replace() + SetWritingMode().
    /// </summary>
    private List<string> InjectWritingMode(List<string> lines, Regex selectorRegex, string selectorName)
    {
        int startRow = -1, startPos = -1, endRow = -1;
        string writeBackSelector = "";

        // Find the selector block boundaries
        for (int i = 0; i < lines.Count; i++)
        {
            if (startRow == -1)
            {
                var match = selectorRegex.Match(lines[i]);
                if (match.Success)
                {
                    startRow = i;
                    startPos = lines[i].IndexOf('{') + 1;
                    writeBackSelector = lines[i].Substring(0, startPos);

                    if (lines[i].Contains('}'))
                        endRow = i;
                }
            }
            else if (endRow == -1 && lines[i].Contains('}'))
            {
                endRow = i;
            }
        }

        // Build the new vertical writing-mode styles
        var verticalStyles = new Dictionary<string, string>
        {
            ["writing-mode"] = "vertical-rl",
            ["-webkit-writing-mode"] = "vertical-rl",
            ["-epub-writing-mode"] = "vertical-rl",
            ["margin"] = "1%"
        };

        // If selector not found, append new block at end
        if (startRow == -1 && endRow == -1)
        {
            _logger.LogDebug("Selector '{Selector}' not found, appending new block", selectorName);
            lines.Add($"{selectorName} {{");
            foreach (var kv in verticalStyles)
                lines.Add($"  {kv.Key}: {kv.Value};");
            lines.Add("}");
            return lines;
        }

        if (endRow == -1)
        {
            _logger.LogWarning("Could not find closing brace for selector '{Selector}', skipping", selectorName);
            return lines;
        }

        // Build replacement lines
        var replacement = new List<string> { writeBackSelector };
        foreach (var kv in verticalStyles)
            replacement.Add($"  {kv.Key}: {kv.Value};");
        replacement.Add("}");

        // Replace original block
        int removeCount = endRow - startRow + 1;
        lines.RemoveRange(startRow, removeCount);
        lines.InsertRange(startRow, replacement);

        return lines;
    }
}
