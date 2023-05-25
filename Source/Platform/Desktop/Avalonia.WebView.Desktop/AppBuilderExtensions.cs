#if __WINDOWS__
using Avalonia.WebView.Windows;
# elif __OSX__
using Avalonia.WebView.MacCatalyst;
# elif __LINUX__
using Avalonia.WebView.Linux;
#endif

namespace Avalonia.WebView.Desktop;

public static class AppBuilderExtensions
{
    public static AppBuilder UseDesktopWebView(this AppBuilder builder)
    {
#if __WINDOWS__
        builder.UseWindowWebView();
#elif __OSX__
        builder.UseMacCatalystWebView();
#elif __LINUX__
        builder.UseLinuxWebView();
#endif

        return builder; 
    }
}
