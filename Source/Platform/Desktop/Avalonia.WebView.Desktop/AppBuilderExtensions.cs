using Avalonia.WebView.Linux;
using Avalonia.WebView.MacCatalyst;
using Avalonia.WebView.Windows;
using Toolkit.Shared;

namespace Avalonia.WebView.Desktop;

public static class AppBuilderExtensions
{
    public static AppBuilder UseDesktopWebView(this AppBuilder builder)
    {
        if (OperatingSystemEx.IsWindows())
            builder.UseWindowWebView();
        else if (OperatingSystemEx.IsMacOS())
            builder.UseMacCatalystWebView();
        else if (OperatingSystemEx.IsLinux())
            builder.UseLinuxWebView();

        return builder;
    }
}
