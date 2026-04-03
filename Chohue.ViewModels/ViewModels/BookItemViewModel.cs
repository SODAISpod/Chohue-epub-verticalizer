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
    /// Creates a BookItemViewModel from a file path.
    /// Uses the filename as a display title until the EPUB metadata is read.
    /// </summary>
    public static BookItemViewModel FromPath(string path) => new()
    {
        FilePath = path,
        Title = Path.GetFileNameWithoutExtension(path)
    };
}
