using Chohue.Core.Enums;

namespace Chohue.Core.Interfaces;

/// <summary>
/// Invokes external tools (Pandoc, Calibre, KindleGen, Kepubify).
/// Maps to ExtensionProcess() and ExtensionChecker in the original Book.cs.
/// 負責呼叫外部工具（Pandoc, Calibre, KindleGen, Kepubify）。
/// 對應原始 Book.cs 的 ExtensionProcess() 與 ExtensionChecker。
/// </summary>
public interface IToolRunner
{
    Task<ToolResult> RunAsync(ExternalTool tool, string arguments);
    bool IsAvailable(ExternalTool tool);
}
