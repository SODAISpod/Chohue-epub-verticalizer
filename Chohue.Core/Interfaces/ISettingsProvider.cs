using Chohue.Core.Models;

namespace Chohue.Core.Interfaces;

/// <summary>
/// Abstraction for reading/writing settings, replacing Properties.Settings.Default.
/// 設定讀寫抽象，取代原本的 Properties.Settings.Default。
/// </summary>
public interface ISettingsProvider
{
    ConversionOptions GetConversionOptions();
    void SaveConversionOptions(ConversionOptions options);

    string? GetToolPath(string toolName);
    void SetToolPath(string toolName, string path);

    string? GetCustomImagePath();
    bool UseBuiltinImage();
}
