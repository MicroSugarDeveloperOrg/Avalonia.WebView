using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.AspNetCore.Components.WebView.Wpf;
public static class BlazorWebViewServiceCollectionExtensions
{
    /// <summary>
    /// Configures <see cref="IServiceCollection"/> to add support for <see cref="BlazorWebView"/>.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/>.</param>
    /// <returns>The <see cref="IServiceCollection"/>.</returns>

    public static IWpfBlazorWebViewBuilder AddWpfBlazorWebView(this IServiceCollection services)



    {
        services.AddBlazorWebView();
        services.TryAddSingleton(new BlazorWebViewDeveloperTools { Enabled = false });

        services.TryAddSingleton<WpfBlazorMarkerService>();
        return new WpfBlazorWebViewBuilder(services);

    }

    /// <summary>
    /// Enables Developer tools on the underlying WebView controls.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/>.</param>
    /// <returns>The <see cref="IServiceCollection"/>.</returns>
    public static IServiceCollection AddBlazorWebViewDeveloperTools(this IServiceCollection services)
    {
        return services.AddSingleton<BlazorWebViewDeveloperTools>(new BlazorWebViewDeveloperTools { Enabled = true });
    }
}