using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Platform.Storage;
using Chohue.ViewModels.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Chohue.Desktop.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        // Enable drag-drop for the whole window
        AddHandler(DragDrop.DropEvent, OnDrop);
        AddHandler(DragDrop.DragOverEvent, OnDragOver);
    }

    private static void OnDragOver(object? sender, DragEventArgs e)
    {
        e.DragEffects = e.Data.Contains(DataFormats.Files)
            ? DragDropEffects.Copy
            : DragDropEffects.None;
    }

    private void OnDrop(object? sender, DragEventArgs e)
    {
        if (DataContext is not MainViewModel vm) return;

        var files = e.Data.GetFiles();
        if (files is null) return;

        var paths = files
            .OfType<IStorageFile>()
            .Select(f => f.Path.LocalPath)
            .Where(p => p.EndsWith(".epub", StringComparison.OrdinalIgnoreCase)
                     || p.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (paths.Count > 0)
            vm.AddBooksCommand.Execute(paths);
    }

    private async void OnOpenFilesClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var files = await StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
        {
            AllowMultiple = true,
            FileTypeFilter =
            [
                new FilePickerFileType("EPUB / TXT") { Patterns = ["*.epub", "*.txt"] }
            ]
        });

        if (DataContext is not MainViewModel vm) return;

        var paths = files.Select(f => f.Path.LocalPath).ToList();
        if (paths.Count > 0)
            vm.AddBooksCommand.Execute(paths);
    }

    private void OnSettingsClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var vm = Program.Services.GetRequiredService<SettingsViewModel>();
        var win = new SettingsWindow { DataContext = vm };
        win.ShowDialog(this);
    }

    private void OnAboutClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        // Simple about dialog — can be expanded later
        var win = new Window
        {
            Title = "About",
            Width = 300,
            Height = 160,
            Content = new TextBlock
            {
                Text = "做伙直排 (Chohue Verticalizer)\n\n.NET 8 + Avalonia UI",
                Margin = new Avalonia.Thickness(16),
                TextWrapping = Avalonia.Media.TextWrapping.Wrap,
                VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
                HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center
            }
        };
        win.ShowDialog(this);
    }

    private void OnCustomizeCssClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (DataContext is not MainViewModel vm) return;

        var win = new CustomCssWindow { DataContext = vm.Options };
        win.ShowDialog(this);
    }
}
