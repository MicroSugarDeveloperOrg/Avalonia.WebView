using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.AspNetCore.Components.WebView.Wpf;
public interface IWpfBlazorWebViewBuilder
{
    /// <summary>
    /// Gets the builder service collection.
    /// </summary>
    IServiceCollection Services { get; }
}