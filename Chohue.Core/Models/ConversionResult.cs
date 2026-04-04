namespace Chohue.Core.Models;

/// <summary>
/// Result returned after a book conversion completes.
/// 轉換完成後的結果。
/// </summary>
public class ConversionResult
{
    public bool Success { get; set; }
    public string OutputPath { get; set; } = "";
    public string? ErrorMessage { get; set; }

    /// <summary>
    /// Manifest parsed during LoadAsync(). Stored for later use in ConvertAsync().
    /// 在 LoadAsync() 階段解析的 Manifest，供後續 ConvertAsync() 使用。
    /// </summary>
    public EpubManifest? Manifest { get; set; }

    /// <summary>
    /// Path to the extracted (uncompressed) EPUB directory.
    /// 解壓後的 EPUB 目錄路徑。
    /// </summary>
    public string? UncompressedPath { get; set; }
}
