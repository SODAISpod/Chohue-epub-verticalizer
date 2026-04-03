namespace Chohue.Core.Models;

/// <summary>
/// Structured data parsed from EPUB's container.xml and OPF file.
/// Replaces the scattered css, xHtml, imgpath, title, author fields in the original Book class.
/// 從 EPUB 的 container.xml + OPF 解析出來的結構化資料。
/// 取代原本散落在 Book 中的 css, xHtml, imgpath, title, author 等欄位。
/// </summary>
public class EpubManifest
{
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public string OpfPath { get; set; } = "";
    public string BasePath { get; set; } = "";
    public string UncompressedPath { get; set; } = "";
    public string EpubVersion { get; set; } = "";
    public List<string> CssFiles { get; set; } = new();
    public List<string> XhtmlFiles { get; set; } = new();
    public Dictionary<string, List<string>> ImageFiles { get; set; } = new()
    {
        ["gif"] = new(),
        ["png"] = new(),
        ["jpeg"] = new()
    };
}
