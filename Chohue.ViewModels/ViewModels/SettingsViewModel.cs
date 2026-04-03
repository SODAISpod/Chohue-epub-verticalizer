using Chohue.Core.Interfaces;
using Chohue.Core.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Chohue.ViewModels.ViewModels;

/// <summary>
/// ViewModel for the settings page.
/// Replaces Setting.cs form in the original WinForms app.
/// </summary>
public partial class SettingsViewModel : ObservableObject
{
    private readonly ISettingsProvider _settings;

    // --- External tool paths ---

    [ObservableProperty]
    private string _pandocPath = "";

    [ObservableProperty]
    private string _calibrePath = "";

    [ObservableProperty]
    private string _kepubifyPath = "";

    // --- Image replacement ---

    [ObservableProperty]
    private bool _useBuiltinImage = true;

    [ObservableProperty]
    private string _customImagePath = "";

    // --- Notification ---

    [ObservableProperty]
    private string _statusMessage = "";

    public SettingsViewModel(ISettingsProvider settings)
    {
        _settings = settings;
        Load();
    }

    private void Load()
    {
        PandocPath = _settings.GetToolPath("PandocPath") ?? "";
        CalibrePath = _settings.GetToolPath("CalibrePath") ?? "";
        KepubifyPath = _settings.GetToolPath("KepubifyPath") ?? "";
        UseBuiltinImage = _settings.UseBuiltinImage();
        CustomImagePath = _settings.GetCustomImagePath() ?? "";
    }

    [RelayCommand]
    private void Save()
    {
        _settings.SetToolPath("PandocPath", PandocPath);
        _settings.SetToolPath("CalibrePath", CalibrePath);
        _settings.SetToolPath("KepubifyPath", KepubifyPath);
        StatusMessage = "Settings saved.";
    }
}
