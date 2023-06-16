using Avalonia.WebView.MacCatalyst;

namespace Avalonia.WebView.Desktop;
public static class AppBuilderExtensions
{
    public static AppBuilder UseMacCatalystWebView(this AppBuilder builder)
    {
        return builder.AfterPlatformServicesSetup(app =>
        {
            WebViewLocator.s_Registrator.RegisterSingleton<IViewHandlerProvider, ViewHandlerProvider>();
            WebViewLocator.s_Registrator.RegisterSingleton<IPlatformBlazorWebViewProvider, BlazorWebViewHandlerProvider>();
        });
    }
}
