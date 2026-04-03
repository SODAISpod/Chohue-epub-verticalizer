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
    Task<ConversionResult> ConvertAsync(string inputPath, ConversionOptions options);
}
