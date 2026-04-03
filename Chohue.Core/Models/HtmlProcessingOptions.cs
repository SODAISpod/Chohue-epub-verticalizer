namespace Chohue.Core.Models;

/// <summary>
/// Options for the HtmlProcessor.
/// HtmlProcessor 的處理選項。
/// </summary>
public class HtmlProcessingOptions
{
    public bool ConvertChinese { get; set; }
    public bool ToTraditional { get; set; }
    public bool ReplacePunctuation { get; set; }
    public bool RemoveInlineStyles { get; set; }
    public bool DecodeBeforeParsing { get; set; }
}
