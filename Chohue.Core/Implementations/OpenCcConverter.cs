using Chohue.Core.Enums;
using Chohue.Core.Interfaces;
using Microsoft.Extensions.Logging;
using OpenCCNET;

namespace Chohue.Core.Implementations;

/// <summary>
/// Chinese converter using OpenCCNET, replacing Windows-only Microsoft ChineseConverter COM.
/// Supports Simplified ↔ Traditional (Taiwan) conversion.
/// </summary>
public class OpenCcConverter : IChineseConverter
{
    private readonly ILogger<OpenCcConverter> _logger;

    public OpenCcConverter(ILogger<OpenCcConverter> logger)
    {
        _logger = logger;
    }

    /// <inheritdoc/>
    public string Convert(string text, ChineseConversionDirection direction)
    {
        if (string.IsNullOrEmpty(text))
            return text;

        try
        {
            return direction switch
            {
                ChineseConversionDirection.SimplifiedToTraditional =>
                    ZhConverter.HansToTW(text, true),   // s2twp: Simplified → Traditional (Taiwan, with idioms)
                ChineseConversionDirection.TraditionalToSimplified =>
                    ZhConverter.TWToHans(text, true),   // tw2sp: Traditional (Taiwan) → Simplified
                _ => text
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Chinese conversion failed for direction {Direction}", direction);
            return text;
        }
    }
}
