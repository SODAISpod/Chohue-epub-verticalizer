using Chohue.Core.Models;

namespace Chohue.Core.Interfaces;

/// <summary>
/// Injects vertical writing CSS (writing-mode: vertical-rl) and appends custom CSS.
/// Maps to CSSEdit() and the LagecyCssStyle class in the original Book.cs.
/// 負責 CSS 的直排注入（writing-mode: vertical-rl）與自訂 CSS 附加。
/// 對應原始 Book.cs 的 CSSEdit() 與 LagecyCssStyle 類別。
/// </summary>
public interface ICssVerticalizer
{
    void ProcessFile(string cssPath, CssProcessingOptions options);
}
