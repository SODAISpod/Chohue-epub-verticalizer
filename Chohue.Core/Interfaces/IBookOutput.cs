namespace Chohue.Core.Interfaces;

/// <summary>
/// Swappable output destination (local files, cloud storage, etc.).
/// 可抽換的輸出目的地（本地檔案、雲端等）。
/// </summary>
public interface IBookOutput
{
    Task SaveAsync(string identifier, Stream content);
    string ResolveOutputPath(string title, string extension);
    string DisplayName { get; }
}
