namespace Avalonia.WebView.Android;

public static class AppBuilderExtensions
{
    public static AppBuilder UseAndroidWebView(this AppBuilder builder)
    {
        return builder.AfterPlatformServicesSetup(app =>
        {
            AvaloniaLocator.CurrentMutable.BindToSelf<IViewHandlerProvider>(new ViewHandlerProvider());
            AvaloniaLocator.CurrentMutable.BindToSelf<IPlatformBlazorWebViewProvider>(new BlaozeWebViewHandlerProvider());
        });
    }
}
