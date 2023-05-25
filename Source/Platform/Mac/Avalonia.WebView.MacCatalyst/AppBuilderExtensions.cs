namespace Avalonia.WebView.MacCatalyst;
public static class AppBuilderExtensions
{
    public static AppBuilder UseMacCatalystWebView(this AppBuilder builder)
    {
        return builder.AfterPlatformServicesSetup(app =>
        {
            AvaloniaLocator.CurrentMutable.BindToSelf<IViewHandlerProvider>(new ViewHandlerProvider());
            AvaloniaLocator.CurrentMutable.BindToSelf<IPlatformBlazorWebViewProvider>(new BlazorWebViewHandlerProvider());
        });
    }
}
