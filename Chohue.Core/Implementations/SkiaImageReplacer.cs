using Chohue.Core.Interfaces;
using Microsoft.Extensions.Logging;
using SkiaSharp;

namespace Chohue.Core.Implementations;

/// <summary>
/// Replaces EPUB images using SkiaSharp, replacing Windows-only System.Drawing.
/// </summary>
public class SkiaImageReplacer : IImageReplacer
{
    private readonly ISettingsProvider _settings;
    private readonly ILogger<SkiaImageReplacer> _logger;

    public SkiaImageReplacer(ISettingsProvider settings, ILogger<SkiaImageReplacer> logger)
    {
        _settings = settings;
        _logger = logger;
    }

    /// <inheritdoc/>
    public void ReplaceImages(Dictionary<string, List<string>> imageFiles)
    {
        SKBitmap? replacement = LoadReplacementImage();
        if (replacement is null)
        {
            _logger.LogWarning("No replacement image available, skipping image replacement");
            return;
        }

        ReplaceByFormat(imageFiles, "gif", SKEncodedImageFormat.Gif, replacement);
        ReplaceByFormat(imageFiles, "jpeg", SKEncodedImageFormat.Jpeg, replacement);
        ReplaceByFormat(imageFiles, "png", SKEncodedImageFormat.Png, replacement);

        replacement.Dispose();
    }

    private SKBitmap? LoadReplacementImage()
    {
        bool useBuiltin = _settings.UseBuiltinImage();
        string? customPath = _settings.GetCustomImagePath();

        if (!useBuiltin && !string.IsNullOrEmpty(customPath) && File.Exists(customPath))
        {
            try
            {
                _logger.LogDebug("Loading custom replacement image: {Path}", customPath);
                return SKBitmap.Decode(customPath);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "Failed to load custom image, falling back to built-in");
            }
        }

        // Return a small blank white bitmap as built-in placeholder
        _logger.LogDebug("Using built-in blank replacement image");
        var bitmap = new SKBitmap(1, 1);
        bitmap.SetPixel(0, 0, SKColors.White);
        return bitmap;
    }

    private void ReplaceByFormat(
        Dictionary<string, List<string>> imageFiles,
        string key,
        SKEncodedImageFormat format,
        SKBitmap bitmap)
    {
        if (!imageFiles.TryGetValue(key, out var paths) || paths.Count == 0)
            return;

        foreach (string path in paths)
        {
            try
            {
                _logger.LogInformation("Replacing image: {Path}", path);
                using var image = SKImage.FromBitmap(bitmap);
                using var data = image.Encode(format, 90);
                using var fs = new FileStream(path, FileMode.Create);
                data.SaveTo(fs);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to replace image: {Path}", path);
            }
        }
    }
}
