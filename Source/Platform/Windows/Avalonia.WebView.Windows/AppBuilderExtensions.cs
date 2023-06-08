using Avalonia.WebView.Windows;

namespace Avalonia.WebView.Desktop;
public static class AppBuilderExtensions
{
    public static AppBuilder UseWindowWebView(this AppBuilder appBuilder)
    {
        return appBuilder.AfterPlatformServicesSetup(app =>
        {
            WebViewLocator.s_Registrator.RegisterSingleton<IViewHandlerProvider, ViewHandlerProvider>();
            WebViewLocator.s_Registrator.RegisterSingleton<IPlatformBlazorWebViewProvider, BlazorWebViewHandlerProvider>();
        });
    }
}
