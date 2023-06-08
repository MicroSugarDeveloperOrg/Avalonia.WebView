using Avalonia.WebView.Desktop;

namespace Avalonia.WebView.DesktopX;
public static class AppBuilderExtensions
{
    public static AppBuilder UseDesktopWebView(this AppBuilder builder)
    {
#if __WINDOWS__
        builder.UseWindowWebView();
#elif __OSX__
        builder.UseMacCatalystWebView();
        //builder.UseOSXWebView();
#elif __LINUX__
        builder.UseLinuxWebView();
#endif

        return builder;
    }
}
