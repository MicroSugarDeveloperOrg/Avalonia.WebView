using AvaloniaWebView.Shared;


namespace Avalonia.WebView.iOS;

public static class AppBuilderExtensions
{
    public static AppBuilder UseIosWebView(this AppBuilder builder)
    {
        return builder.AfterPlatformServicesSetup(app =>
        {
            AvaloniaLocator.CurrentMutable.BindToSelf<IViewHandlerProvider>(new ViewHandlerProvider());
            AvaloniaLocator.CurrentMutable.BindToSelf<IPlatformBlazorWebViewProvider>(new BlaozeWebViewHandlerProvider());
        });
    }
}
