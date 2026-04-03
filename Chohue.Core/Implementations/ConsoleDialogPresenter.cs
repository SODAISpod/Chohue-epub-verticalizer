using Chohue.Core.Interfaces;

namespace Chohue.Core.Implementations;

/// <summary>
/// Console-based dialog presenter for CLI and test usage.
/// Will be replaced by AvaloniaDialogPresenter in the Desktop project (Phase 4).
/// </summary>
public class ConsoleDialogPresenter : IDialogPresenter
{
    public Task ShowErrorAsync(string message)
    {
        Console.Error.WriteLine($"[ERROR] {message}");
        return Task.CompletedTask;
    }

    public Task ShowInfoAsync(string message)
    {
        Console.WriteLine($"[INFO] {message}");
        return Task.CompletedTask;
    }

    public Task<bool> ConfirmAsync(string message)
    {
        Console.Write($"[CONFIRM] {message} (y/n): ");
        string? input = Console.ReadLine();
        return Task.FromResult(input?.Trim().Equals("y", StringComparison.OrdinalIgnoreCase) == true);
    }
}
