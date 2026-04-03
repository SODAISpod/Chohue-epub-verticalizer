namespace Chohue.Core.Interfaces;

/// <summary>
/// UI dialog abstraction, replacing direct MessageBox.Show() calls in business logic.
/// UI 對話框抽象，取代原本業務邏輯中直接呼叫的 MessageBox.Show()。
/// </summary>
public interface IDialogPresenter
{
    Task ShowErrorAsync(string message);
    Task ShowInfoAsync(string message);
    Task<bool> ConfirmAsync(string message);
}
