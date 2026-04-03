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
}
