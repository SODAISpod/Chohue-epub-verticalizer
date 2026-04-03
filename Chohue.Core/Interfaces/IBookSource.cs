namespace Chohue.Core.Interfaces;

/// <summary>
/// Swappable book source (local files, cloud storage, HTTP, etc.).
/// 可抽換的書籍來源（本地檔案、雲端、HTTP 等）。
/// </summary>
public interface IBookSource
{
    Task<Stream> OpenAsync(string identifier);
    Task<IReadOnlyList<BookSourceItem>> ListAsync(string? filter = null);
    string DisplayName { get; }
}

public record BookSourceItem(string Identifier, string DisplayName, long? Size);
