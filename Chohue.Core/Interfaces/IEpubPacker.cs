namespace Chohue.Core.Interfaces;

/// <summary>
/// Handles EPUB extraction and compression.
/// Maps to Uncompressing(), ZipUp(), Mimetype() in the original Book.cs.
/// 負責 EPUB 的解壓與壓縮。
/// 對應原始 Book.cs 的 Uncompressing(), ZipUp(), Mimetype()。
/// </summary>
public interface IEpubPacker
{
    /// <summary>
    /// Extracts an EPUB to a temporary directory and returns the extraction path.
    /// 將 EPUB 解壓到暫存目錄，回傳解壓路徑。
    /// </summary>
    string Extract(string epubPath);

    /// <summary>
    /// Packages the processed directory back into EPUB format.
    /// 將處理完的目錄壓縮回 EPUB 格式。
    /// </summary>
    string Package(string sourceDir, string title);
}
