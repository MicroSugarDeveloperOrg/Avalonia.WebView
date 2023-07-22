using Avalonia.WebView.Linux;
using Linux.WebView.Core;

namespace Avalonia.WebView.Desktop;

public static class AppBuilderExtensions
{
    public static AppBuilder UseLinuxWebView(this AppBuilder builder, bool isWslDevelop)
    {
        //GtkApi.SetAllowedBackends("x11");
        //Environment.SetEnvironmentVariable("WAYLAND_DISPLAY", "/proc/fake-display-to-prevent-wayland-initialization-by-gtk3");

        return builder.AfterPlatformServicesSetup(app =>
        {
            WebViewLocator.s_Registrator.RegisterSingleton<ILinuxApplication>(() => LinuxApplicationBuilder.Build(isWslDevelop));
            WebViewLocator.s_Registrator.RegisterSingleton<IViewHandlerProvider, ViewHandlerProvider>();
            WebViewLocator.s_Registrator.RegisterSingleton<IPlatformBlazorWebViewProvider, BlazorWebViewHandlerProvider>();
        });
    }
}
