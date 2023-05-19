namespace Avalonia.WebView.Android;

public static class AppBuilderExtensions
{
    public static AppBuilder UseAndroidWebView(this AppBuilder builder)
    {
        return builder.AfterPlatformServicesSetup(app =>
        {
            AvaloniaLocator.CurrentMutable.BindToSelf<IPlatformWebViewProvider>(new WebViewHandlerProvider());
            AvaloniaLocator.CurrentMutable.BindToSelf<IPlatformBlazorWebViewProvider>(new BlaozeWebViewHandlerProvider());
        });
    }
}
