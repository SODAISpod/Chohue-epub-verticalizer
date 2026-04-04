using Chohue.Desktop.Views;
using Chohue.ViewModels.DI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Chohue.Desktop.DI;

/// <summary>
/// Registers all services needed by the Desktop application.
/// Adds Avalonia-specific implementations on top of the shared Core registrations.
/// </summary>
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddChohueDesktopServices(this IServiceCollection services)
    {
        // Logging — writes to Debug output (visible in VS / Rider output window)
        services.AddLogging(builder => builder
            .AddDebug()
            .SetMinimumLevel(LogLevel.Debug));

        // Core + ViewModel registrations (from Chohue.ViewModels)
        services.AddChohueServices();

        // Override the default ConsoleDialogPresenter with the Avalonia dialog presenter
        // (registered last wins for Transient registrations)
        services.AddTransient<Chohue.Core.Interfaces.IDialogPresenter, AvaloniaDialogPresenter>();

        return services;
    }
}
