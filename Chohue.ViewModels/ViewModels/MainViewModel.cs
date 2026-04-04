using Chohue.Core.Interfaces;
using Chohue.Core.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Chohue.ViewModels.ViewModels;

/// <summary>
/// ViewModel for the main application window.
/// Replaces the Form1 / Main.cs logic in the original WinForms app.
/// Handles: book list management, conversion options, batch conversion, status reporting.
/// </summary>
public partial class MainViewModel : ObservableObject
{
    private readonly IBookConverter _converter;
    private readonly ISettingsProvider _settings;

    // --- Book list ---

    /// <summary>
    /// The list of books queued for conversion.
    /// Replaces the DataGridView rows in Main.cs.
    /// </summary>
    public ObservableCollection<BookItemViewModel> Books { get; } = new();

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(RemoveSelectedCommand))]
    private BookItemViewModel? _selectedBook;

    // --- Conversion options (bound to checkboxes / dropdowns in the UI) ---

    [ObservableProperty]
    private ConversionOptions _options = new();

    // --- Status ---

    [ObservableProperty]
    private string _statusMessage = "";

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(ConvertAllCommand))]
    private bool _isProcessing;

    [ObservableProperty]
    private int _progress;

    [ObservableProperty]
    private int _progressMax = 1;

    // --- Log output ---

    [ObservableProperty]
    private string _logOutput = "";

    public MainViewModel(IBookConverter converter, ISettingsProvider settings)
    {
        _converter = converter;
        _settings = settings;

        // Load last-used options from settings
        Options = _settings.GetConversionOptions();
    }

    // --- Commands ---

    /// <summary>
    /// Add books to the list from file paths (e.g. drag-drop or file picker).
    /// Extracts each EPUB and parses its manifest immediately so the title
    /// and metadata are available before the user clicks "Forge".
    /// 新增書籍到清單，立即解壓並解析 manifest，讓標題和中繼資料在按「製作」之前就可用。
    /// </summary>
    [RelayCommand]
    private async Task AddBooksAsync(IEnumerable<string> paths)
    {
        IsProcessing = true;
        int loaded = 0;

        foreach (var path in paths)
        {
            // Avoid duplicates
            if (Books.Any(b => b.FilePath == path)) continue;

            var book = BookItemViewModel.FromPath(path);
            book.Status = "Loading...";
            Books.Add(book);

            // Load: extract + parse manifest
            var result = await _converter.LoadAsync(path);

            if (result.Success && result.Manifest is not null)
            {
                book.Manifest = result.Manifest;
                book.UncompressedPath = result.UncompressedPath;
                book.Title = result.Manifest.Title;
                book.Status = "Ready";
                AppendLog($"✓ Loaded: {result.Manifest.Title}");
                loaded++;
            }
            else
            {
                book.Status = "Load Failed";
                book.ErrorMessage = result.ErrorMessage;
                AppendLog($"✗ Failed to load: {path} — {result.ErrorMessage}");
            }
        }

        IsProcessing = false;
        StatusMessage = $"{loaded} book(s) loaded, {Books.Count} total.";
    }

    /// <summary>
    /// Remove the currently selected book from the list.
    /// </summary>
    [RelayCommand(CanExecute = nameof(CanRemoveSelected))]
    private void RemoveSelected()
    {
        if (SelectedBook is not null)
            Books.Remove(SelectedBook);
    }

    private bool CanRemoveSelected() => SelectedBook is not null;

    /// <summary>
    /// Clear all books from the list.
    /// </summary>
    [RelayCommand]
    private void ClearAll() => Books.Clear();

    /// <summary>
    /// Convert all books in the list that have a loaded manifest.
    /// Passes the pre-loaded manifest to ConvertAsync() — no re-extraction needed.
    /// 轉換清單中所有已載入 manifest 的書籍，直接傳入已準備好的 manifest。
    /// </summary>
    [RelayCommand(CanExecute = nameof(CanConvertAll))]
    private async Task ConvertAllAsync(CancellationToken ct)
    {
        if (Books.Count == 0) return;

        IsProcessing = true;
        Progress = 0;
        ProgressMax = Books.Count;

        // Persist current options
        _settings.SaveConversionOptions(Options);

        int done = 0, failed = 0;

        foreach (var book in Books)
        {
            if (ct.IsCancellationRequested) break;

            // Skip books that failed to load
            if (book.Manifest is null)
            {
                book.Status = "Skipped (not loaded)";
                AppendLog($"⏭ Skipped: {book.Title} (manifest not loaded)");
                failed++;
                Progress++;
                continue;
            }

            book.Status = "Processing...";
            StatusMessage = $"Converting: {book.Title}";
            AppendLog($"▶ {book.Title}");

            // Use the pre-loaded manifest — no re-extraction
            var result = await _converter.ConvertAsync(book.Manifest, Options);

            if (result.Success)
            {
                book.Status = "Done";
                AppendLog($"  ✓ {result.OutputPath}");
                done++;
            }
            else
            {
                book.Status = "Failed";
                book.ErrorMessage = result.ErrorMessage;
                AppendLog($"  ✗ {result.ErrorMessage}");
                failed++;
            }

            Progress++;
        }

        IsProcessing = false;
        StatusMessage = $"Completed: {done} succeeded, {failed} failed.";
        AppendLog($"─── Done ───");
    }

    private bool CanConvertAll() => !IsProcessing && Books.Count > 0;

    /// <summary>
    /// Open the output folder in the system file explorer.
    /// </summary>
    [RelayCommand]
    private void OpenOutputFolder()
    {
        string outputDir = Path.GetFullPath("output");
        if (!Directory.Exists(outputDir))
            Directory.CreateDirectory(outputDir);

        // Platform-aware: use open / xdg-open / explorer
        string command = System.Runtime.InteropServices.RuntimeInformation
            .IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Windows)
            ? "explorer"
            : System.Runtime.InteropServices.RuntimeInformation
                .IsOSPlatform(System.Runtime.InteropServices.OSPlatform.OSX)
            ? "open"
            : "xdg-open";

        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
        {
            FileName = command,
            Arguments = outputDir,
            UseShellExecute = true
        });
    }

    private void AppendLog(string line)
    {
        LogOutput += line + Environment.NewLine;
    }
}
