namespace Chohue.Core.Models;

/// <summary>
/// All conversion options, replacing the 15+ bool properties on the original Book class.
/// 所有轉換選項，取代原本 Book 上的 15+ bool 屬性。
/// </summary>
public class ConversionOptions
{
    public bool ConvertChinese { get; set; }
    public bool ToTraditional { get; set; }
    public bool ChangePageDirection { get; set; }
    public bool ConvertMobi { get; set; }
    public bool ConvertKepub { get; set; }
    public bool EmbedFont { get; set; }
    public bool ReplacePicture { get; set; }
    public bool ClearStylesheet { get; set; }
    public bool DoNotVerticalize { get; set; }
    public bool AddCustomCss { get; set; }
    public string? CustomCss { get; set; }
    public bool TruncateTitle { get; set; }
    public bool DecodeHtmlBeforeParsing { get; set; }
    public bool ReplacePunctuation { get; set; }
    public bool RemoveInlineStyles { get; set; }
}
