using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.AspNetCore.Components.WebView.Wpf;
internal class WpfBlazorWebViewBuilder : IWpfBlazorWebViewBuilder
{
    public IServiceCollection Services { get; }

    public WpfBlazorWebViewBuilder(IServiceCollection services)
    {
        Services = services;
    }
}