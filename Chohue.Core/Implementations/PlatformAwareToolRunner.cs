using Chohue.Core.Enums;
using Chohue.Core.Interfaces;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Chohue.Core.Implementations;

/// <summary>
/// Runs external tools (Pandoc, Calibre, Kepubify) in a platform-aware manner.
/// Maps to ExtensionProcess() and ExtensionChecker in the original Book.cs.
/// Resolves the correct binary name based on the current OS.
/// </summary>
public class PlatformAwareToolRunner : IToolRunner
{
    private readonly ISettingsProvider _settings;
    private readonly ILogger<PlatformAwareToolRunner> _logger;

    public PlatformAwareToolRunner(ISettingsProvider settings, ILogger<PlatformAwareToolRunner> logger)
    {
        _settings = settings;
        _logger = logger;
    }

    /// <inheritdoc/>
    public bool IsAvailable(ExternalTool tool)
    {
        string? path = ResolvePath(tool);
        return !string.IsNullOrEmpty(path) && File.Exists(path);
    }

    /// <inheritdoc/>
    public async Task<ToolResult> RunAsync(ExternalTool tool, string arguments)
    {
        string? executablePath = ResolvePath(tool);

        if (string.IsNullOrEmpty(executablePath) || !File.Exists(executablePath))
        {
            _logger.LogError("Tool not found: {Tool} at {Path}", tool, executablePath);
            return ToolResult.Fail;
        }

        _logger.LogInformation("Running {Tool}: {Path} {Arguments}", tool, executablePath, arguments);

        var psi = new ProcessStartInfo
        {
            FileName = executablePath,
            Arguments = arguments,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            CreateNoWindow = true,
            StandardOutputEncoding = Encoding.UTF8
        };

        using var process = new Process { StartInfo = psi };
        var output = new StringBuilder();

        process.OutputDataReceived += (_, e) => { if (e.Data != null) output.AppendLine(e.Data); };
        process.ErrorDataReceived += (_, e) => { if (e.Data != null) output.AppendLine(e.Data); };

        process.Start();
        process.BeginOutputReadLine();
        process.BeginErrorReadLine();
        await process.WaitForExitAsync();

        int exitCode = process.ExitCode;
        _logger.LogDebug("Tool {Tool} exited with code {ExitCode}. Output:\n{Output}", tool, exitCode, output);

        return exitCode switch
        {
            0 => ToolResult.Success,
            2 when tool == ExternalTool.KindleGen => ToolResult.FailWithErrors,
            _ when exitCode != 0 => ToolResult.FailWithErrors,
            _ => ToolResult.Finished
        };
    }

    private string? ResolvePath(ExternalTool tool)
    {
        bool isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        string ext = isWindows ? ".exe" : "";

        return tool switch
        {
            ExternalTool.Pandoc or ExternalTool.PandocWithReload =>
                Path.Combine(_settings.GetToolPath("PandocPath") ?? "", $"pandoc{ext}"),

            ExternalTool.Calibre or ExternalTool.CalibreTxtToEpub =>
                Path.Combine(_settings.GetToolPath("CalibrePath") ?? "", $"ebook-convert{ext}"),

            ExternalTool.KindleGen =>
                Path.Combine(_settings.GetToolPath("KindlegenPath") ?? "", $"kindlegen{ext}"),

            ExternalTool.Kepubify =>
                ResolveKepubify(isWindows),

            _ => null
        };
    }

    private string ResolveKepubify(bool isWindows)
    {
        string? basePath = _settings.GetToolPath("KepubifyPath") ?? "";

        // Kepubify ships platform-specific binaries
        string binaryName = (isWindows, RuntimeInformation.OSArchitecture) switch
        {
            (true, _) => "kepubify-windows-64bit.exe",
            (false, Architecture.Arm64) => "kepubify-darwin-arm64",
            (false, Architecture.X64) when RuntimeInformation.IsOSPlatform(OSPlatform.OSX) => "kepubify-darwin-64bit",
            _ => "kepubify-linux-64bit"
        };

        return Path.Combine(basePath, binaryName);
    }
}
