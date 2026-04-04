using Avalonia.Controls;
using Avalonia.Threading;
using Chohue.Core.Interfaces;

namespace Chohue.Desktop.Views;

/// <summary>
/// Avalonia implementation of IDialogPresenter.
/// Displays native message boxes on the UI thread.
/// Replaces ConsoleDialogPresenter when running as the Desktop application.
/// </summary>
public class AvaloniaDialogPresenter : IDialogPresenter
{
    /// <inheritdoc/>
    public Task ShowErrorAsync(string message)
        => ShowAsync("Error", message);

    /// <inheritdoc/>
    public Task ShowInfoAsync(string message)
        => ShowAsync("Information", message);

    /// <inheritdoc/>
    public Task<bool> ConfirmAsync(string message)
        => Dispatcher.UIThread.InvokeAsync(async () =>
        {
            var owner = GetMainWindow();
            if (owner is null) return false;

            // Use a simple dialog with Yes/No buttons
            var result = await MessageBoxWindow.ShowAsync(owner, "Confirm", message, isConfirm: true);
            return result;
        });

    private static Task ShowAsync(string title, string message)
        => Dispatcher.UIThread.InvokeAsync(async () =>
        {
            var owner = GetMainWindow();
            if (owner is null) return;
            await MessageBoxWindow.ShowAsync(owner, title, message, isConfirm: false);
        });

    private static Window? GetMainWindow()
    {
        if (Avalonia.Application.Current?.ApplicationLifetime
            is Avalonia.Controls.ApplicationLifetimes.IClassicDesktopStyleApplicationLifetime lifetime)
        {
            return lifetime.MainWindow;
        }
        return null;
    }
}
