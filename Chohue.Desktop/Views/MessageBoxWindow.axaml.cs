using Avalonia.Controls;

namespace Chohue.Desktop.Views;

public partial class MessageBoxWindow : Window
{
    private bool _result;

    public MessageBoxWindow()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Shows a message box as a dialog.
    /// Returns true if the user clicked OK/Yes, false otherwise.
    /// </summary>
    public static async Task<bool> ShowAsync(Window owner, string title, string message, bool isConfirm)
    {
        var win = new MessageBoxWindow();
        win.Title = title;
        win.MessageText.Text = message;
        win.CancelButton.IsVisible = isConfirm;
        if (isConfirm)
            win.OkButton.Content = "Yes";

        await win.ShowDialog(owner);
        return win._result;
    }

    private void OnOkClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        _result = true;
        Close();
    }

    private void OnCancelClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        _result = false;
        Close();
    }
}
