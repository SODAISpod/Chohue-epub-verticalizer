using Chohue.Core.Models;

namespace Chohue.Core.Interfaces;

/// <summary>
/// Parses and writes EPUB OPF / container.xml metadata.
/// Maps to Container(), OpfReader(), OpfWriter(), PathEditor() in the original Book.cs.
/// 負責 EPUB 的 OPF / container.xml 解析與寫入。
/// 對應原始 Book.cs 的 Container(), OpfReader(), OpfWriter(), PathEditor()。
/// </summary>
public interface IEpubParser
{
    /// <summary>
    /// Reads the manifest (metadata, css, xhtml, images) from an extracted EPUB directory.
    /// 從解壓後的 EPUB 目錄讀取 manifest（metadata, css, xhtml, images）。
    /// </summary>
    EpubManifest ReadManifest(string uncompressedPath);

    /// <summary>
    /// Writes modified metadata back to the OPF file.
    /// 將修改後的 metadata 寫回 OPF 檔案。
    /// </summary>
    void WriteOpf(EpubManifest manifest, ConversionOptions options);
}
