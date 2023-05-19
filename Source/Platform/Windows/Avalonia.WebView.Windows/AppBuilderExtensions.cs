namespace Avalonia.WebView.Windows;
public static class AppBuilderExtensions
{
    public static AppBuilder UseWindowWebView(this AppBuilder appBuilder)
    {
        return appBuilder.AfterPlatformServicesSetup(app =>
        {
            AvaloniaLocator.CurrentMutable.BindToSelf<IViewHandlerProvider>(new ViewHandlerProvider());
        });
    }
}
