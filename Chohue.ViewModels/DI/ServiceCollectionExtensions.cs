using Chohue.Core.Implementations;
using Chohue.Core.Interfaces;
using Chohue.ViewModels.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Chohue.ViewModels.DI;

/// <summary>
/// Extension methods for registering all Chohue services and ViewModels into the DI container.
/// Call this from the host application (Desktop, CLI) during startup.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registers all Core services (implementations) and ViewModels.
    /// </summary>
    public static IServiceCollection AddChohueServices(this IServiceCollection services)
    {
        // --- Core services ---
        services.AddSingleton<ISettingsProvider, JsonSettingsProvider>();
        services.AddTransient<IEpubPacker, ZipEpubPacker>();
        services.AddTransient<IEpubParser, EpubParser>();
        services.AddTransient<IChineseConverter, OpenCcConverter>();
        services.AddTransient<IHtmlProcessor, HtmlProcessor>();
        services.AddTransient<ICssVerticalizer, CssVerticalizer>();
        services.AddTransient<IImageReplacer, SkiaImageReplacer>();
        services.AddTransient<IToolRunner, PlatformAwareToolRunner>();
        services.AddTransient<IBookConverter, BookConverter>();

        // Default dialog presenter (Console). Desktop project overrides this with Avalonia version.
        services.AddTransient<IDialogPresenter, ConsoleDialogPresenter>();

        // --- ViewModels ---
        services.AddTransient<MainViewModel>();
        services.AddTransient<SettingsViewModel>();

        return services;
    }

    /// <summary>
    /// Registers all Core services with logging configured to write to the console.
    /// Useful for CLI and test scenarios.
    /// </summary>
    public static IServiceCollection AddChohueServicesWithConsoleLogging(this IServiceCollection services)
    {
        services.AddLogging(builder => builder.AddConsole());
        return services.AddChohueServices();
    }
}
