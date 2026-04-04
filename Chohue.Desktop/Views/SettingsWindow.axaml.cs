using Avalonia.Controls;
using Avalonia.Platform.Storage;
using Chohue.ViewModels.ViewModels;

namespace Chohue.Desktop.Views;

public partial class SettingsWindow : Window
{
    public SettingsWindow()
    {
        InitializeComponent();
    }

    private void OnCancelClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        => Close();

    private async void OnBrowsePandocClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var path = await PickExecutableAsync("Select Pandoc executable");
        if (path is not null && DataContext is SettingsViewModel vm)
            vm.PandocPath = path;
    }

    private async void OnBrowseCalibreClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var path = await PickExecutableAsync("Select Calibre ebook-convert executable");
        if (path is not null && DataContext is SettingsViewModel vm)
            vm.CalibrePath = path;
    }

    private async void OnBrowseKepubifyClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var path = await PickExecutableAsync("Select Kepubify executable");
        if (path is not null && DataContext is SettingsViewModel vm)
            vm.KepubifyPath = path;
    }

    private async void OnBrowseImageClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var files = await StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
        {
            AllowMultiple = false,
            FileTypeFilter =
            [
                new FilePickerFileType("Image files") { Patterns = ["*.png", "*.jpg", "*.jpeg", "*.gif"] }
            ]
        });

        if (files.Count > 0 && DataContext is SettingsViewModel vm)
            vm.CustomImagePath = files[0].Path.LocalPath;
    }

    private async Task<string?> PickExecutableAsync(string title)
    {
        var files = await StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
        {
            Title = title,
            AllowMultiple = false,
            FileTypeFilter =
            [
                new FilePickerFileType("Executable") { Patterns = ["*.exe", "*"] }
            ]
        });

        return files.Count > 0 ? files[0].Path.LocalPath : null;
    }
}
