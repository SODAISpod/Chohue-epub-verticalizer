using Chohue.Core.Enums;

namespace Chohue.Core.Interfaces;

/// <summary>
/// Handles Traditional/Simplified Chinese text conversion.
/// Maps to the Microsoft.International ChineseConverter calls in the original Book.cs.
/// 負責繁體/簡體中文轉換。
/// 對應原始 Book.cs 中對 Microsoft.International ChineseConverter 的呼叫。
/// </summary>
public interface IChineseConverter
{
    string Convert(string text, ChineseConversionDirection direction);
}
