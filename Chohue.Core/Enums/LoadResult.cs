namespace Chohue.Core.Enums;

/// <summary>
/// Status returned when loading a book.
/// 載入書本時回傳的狀態值。
/// </summary>
public enum LoadResult
{
    Success,
    Fail,
    FailPandocReturnError
}
