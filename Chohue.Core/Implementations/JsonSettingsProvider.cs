using Chohue.Core.Interfaces;
using Chohue.Core.Models;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace Chohue.Core.Implementations;

/// <summary>
/// JSON-based settings provider, replacing Windows-only Properties.Settings.Default.
/// Settings are stored in a platform-agnostic JSON file in the user's AppData directory.
/// </summary>
public class JsonSettingsProvider : ISettingsProvider
{
    private readonly string _settingsPath;
    private AppSettingsData _data;

    public JsonSettingsProvider()
    {
        string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string dir = Path.Combine(appData, "Chohue");
        Directory.CreateDirectory(dir);
        _settingsPath = Path.Combine(dir, "settings.json");
        _data = Load();
    }

    /// <inheritdoc/>
    public ConversionOptions GetConversionOptions() => _data.ConversionOptions ?? new ConversionOptions();

    /// <inheritdoc/>
    public void SaveConversionOptions(ConversionOptions options)
    {
        _data.ConversionOptions = options;
        Save();
    }

    /// <inheritdoc/>
    public string? GetToolPath(string toolName) =>
        _data.ToolPaths.TryGetValue(toolName, out var path) ? path : null;

    /// <inheritdoc/>
    public void SetToolPath(string toolName, string path)
    {
        _data.ToolPaths[toolName] = path;
        Save();
    }

    /// <inheritdoc/>
    public string? GetCustomImagePath() => _data.CustomImagePath;

    /// <inheritdoc/>
    public bool UseBuiltinImage() => _data.UseBuiltinImage;

    private AppSettingsData Load()
    {
        if (!File.Exists(_settingsPath))
            return new AppSettingsData();

        try
        {
            string json = File.ReadAllText(_settingsPath);
            return JsonSerializer.Deserialize<AppSettingsData>(json) ?? new AppSettingsData();
        }
        catch
        {
            return new AppSettingsData();
        }
    }

    private void Save()
    {
        string json = JsonSerializer.Serialize(_data, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(_settingsPath, json);
    }

    private class AppSettingsData
    {
        public ConversionOptions? ConversionOptions { get; set; }
        public Dictionary<string, string> ToolPaths { get; set; } = new();
        public string? CustomImagePath { get; set; }
        public bool UseBuiltinImage { get; set; } = true;
    }
}
