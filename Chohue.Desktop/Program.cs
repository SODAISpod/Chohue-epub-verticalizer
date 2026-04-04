using Avalonia;
using Chohue.Desktop;
using Chohue.Desktop.DI;
using Microsoft.Extensions.DependencyInjection;

// Build DI container before Avalonia starts so App.axaml.cs can resolve services.
Program.Services = new ServiceCollection()
    .AddChohueDesktopServices()
    .BuildServiceProvider();

AppBuilder.Configure<App>()
    .UsePlatformDetect()
    .WithInterFont()
    .LogToTrace()
    .StartWithClassicDesktopLifetime(args);

/// <summary>
/// Entry point. Exposes the DI service provider for use throughout the application.
/// </summary>
public partial class Program
{
    public static IServiceProvider Services { get; set; } = null!;
}
