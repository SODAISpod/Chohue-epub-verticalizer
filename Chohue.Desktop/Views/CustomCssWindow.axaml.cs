using Avalonia.Controls;

namespace Chohue.Desktop.Views;

public partial class CustomCssWindow : Window
{
    public CustomCssWindow()
    {
        InitializeComponent();
    }

    private void OnSaveClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        => Close();

    private void OnCancelClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        => Close();
}
