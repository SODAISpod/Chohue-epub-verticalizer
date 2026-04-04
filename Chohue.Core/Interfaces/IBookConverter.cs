using Chohue.Core.Models;

namespace Chohue.Core.Interfaces;

/// <summary>
/// Orchestrates the full ebook conversion pipeline by composing other services.
/// Maps to the Load() + Convert() main flow in the original Book.cs.
/// 整合 pipeline：組合其他服務完成完整的電子書轉換流程。
/// 對應原始 Book.cs 的 Load() + Convert() 主流程。
/// </summary>
public interface IBookConverter
{
    /// <summary>
    /// Load phase: extract EPUB, parse manifest, upgrade EPUB 2→3 if needed.
    /// Called when a book is added to the list.
    /// 載入階段：解壓 EPUB、解析 manifest、必要時升級 EPUB 2→3。
    /// 在書籍加入清單時呼叫。
    /// </summary>
    Task<ConversionResult> LoadAsync(string inputPath);

    /// <summary>
    /// Convert phase using a pre-loaded manifest (from LoadAsync).
    /// Skips extract/parse — uses the manifest and uncompressedPath already prepared.
    /// 轉換階段，使用 LoadAsync() 預先載入的 manifest。
    /// 跳過解壓/解析步驟，直接使用已準備好的 manifest 和 uncompressedPath。
    /// </summary>
    Task<ConversionResult> ConvertAsync(EpubManifest manifest, ConversionOptions options);

    /// <summary>
    /// Full pipeline: load + convert in one call (convenience method).
    /// 完整管線：一次呼叫完成載入 + 轉換。
    /// </summary>
    Task<ConversionResult> ConvertAsync(string inputPath, ConversionOptions options);
}
