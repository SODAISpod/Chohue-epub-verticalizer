namespace Chohue.Core.Models;

/// <summary>
/// Options for the CssVerticalizer.
/// CssVerticalizer 的處理選項。
/// </summary>
public class CssProcessingOptions
{
    public bool EmbedFont { get; set; }
    public bool Verticalize { get; set; }
    public bool DoNotVerticalize { get; set; }
    public bool ClearStylesheet { get; set; }
    public bool AddCustomCss { get; set; }
    public string? CustomCss { get; set; }
}
