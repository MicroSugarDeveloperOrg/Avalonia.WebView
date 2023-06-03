using Linux.WebView.Core;

namespace Avalonia.WebView.Linux;

public static class AppBuilderExtensions
{
    public static AppBuilder UseLinuxWebView(this AppBuilder builder)
    {
        return builder.AfterPlatformServicesSetup(app =>
        {
            AvaloniaLocator.CurrentMutable.BindToSelf<ILinuxApplication>(LinuxApplicationBuilder.Build());
            AvaloniaLocator.CurrentMutable.BindToSelf<IViewHandlerProvider>(new ViewHandlerProvider());
            AvaloniaLocator.CurrentMutable.BindToSelf<IPlatformBlazorWebViewProvider>(new BlazorWebViewHandlerProvider());
        });
    }
}
