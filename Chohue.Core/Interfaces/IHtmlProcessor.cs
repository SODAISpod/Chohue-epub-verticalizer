using Chohue.Core.Models;

namespace Chohue.Core.Interfaces;

/// <summary>
/// Handles XHTML DOM manipulation: Chinese conversion, punctuation replacement, inline style removal, etc.
/// Maps to HtmlEdit(), RecursivelyReplaceText(), RemoveHtmlStyle() in the original Book.cs.
/// 負責 XHTML 檔案的 DOM 操作：繁簡轉換、標點替換、移除 inline style 等。
/// 對應原始 Book.cs 的 HtmlEdit(), RecursivelyReplaceText(), RemoveHtmlStyle()。
/// </summary>
public interface IHtmlProcessor
{
    void ProcessFile(string xhtmlPath, HtmlProcessingOptions options);
}
