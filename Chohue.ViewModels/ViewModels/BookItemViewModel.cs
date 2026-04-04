using Chohue.Core.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Chohue.ViewModels.ViewModels;

/// <summary>
/// Represents a single book entry in the batch conversion list.
/// Replaces the string[] rows / DataGridView rows in the original Main.cs.
/// </summary>
public partial class BookItemViewModel : ObservableObject
{
    /// <summary>File path of the source EPUB/TXT.</summary>
    [ObservableProperty]
    private string _filePath = "";
    

    /// <summary>Displayed title, parsed from the EPUB or filename.</summary>
    [ObservableProperty]
    private string _title = "";

    /// <summary>Conversion status shown in the UI (e.g. Pending / Processing / Done / Failed).</summary>
    [ObservableProperty]
    private string _status = "Pending";

    /// <summary>Whether this book is currently selected in the list.</summary>
    [ObservableProperty]
    private bool _isSelected;

    /// <summary>Optional error message shown when conversion fails.</summary>
    [ObservableProperty]
    private string? _errorMessage;

    /// <summary>
    /// Path to the extracted (uncompressed) EPUB directory, set during LoadAsync().
    /// 解壓後的 EPUB 目錄路徑，在 LoadAsync() 階段設定。
    /// </summary>
    [ObservableProperty]
    private string? _uncompressedPath;

    /// <summary>
    /// Parsed EPUB manifest, set during LoadAsync(). Passed to ConvertAsync() later.
    /// 解析後的 EPUB manifest，在 LoadAsync() 階段設定，之後傳給 ConvertAsync()。
    /// </summary>
    [ObservableProperty]
    private EpubManifest? _manifest;

    /// <summary>
    /// Creates a BookItemViewModel from a file path.
    /// Uses the filename as a display title until the EPUB metadata is read.
    /// </summary>
    public static BookItemViewModel FromPath(string path) => new()
    {
        FilePath = path,
        Title = Path.GetFileNameWithoutExtension(path)
    };
 
}
