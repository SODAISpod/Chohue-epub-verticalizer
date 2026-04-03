namespace Chohue.Core.Interfaces;

/// <summary>
/// Replaces images in the EPUB with placeholder images.
/// Maps to ImgReplace() in the original Book.cs.
/// 負責將 EPUB 內的圖片替換為佔位圖。
/// 對應原始 Book.cs 的 ImgReplace()。
/// </summary>
public interface IImageReplacer
{
    void ReplaceImages(Dictionary<string, List<string>> imageFiles);
}
