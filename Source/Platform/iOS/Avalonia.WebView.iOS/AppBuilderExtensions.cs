namespace Avalonia.WebView.iOS;

public static class AppBuilderExtensions
{
    public static AppBuilder UseIosWebView(this AppBuilder builder)
    {
        return builder.AfterPlatformServicesSetup(app =>
        {
            AvaloniaLocator.CurrentMutable.BindToSelf<IPlatformWebViewProvider>(new WebViewHandlerProvider());
            AvaloniaLocator.CurrentMutable.BindToSelf<IPlatformBlazorWebViewProvider>(new BlaozeWebViewHandlerProvider());
        });
    }
}
