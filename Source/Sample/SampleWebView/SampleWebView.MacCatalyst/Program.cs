using Avalonia;
using Avalonia.ReactiveUI;
using Avalonia.WebView.MacCatalyst;

namespace SampleWebView.MacCatalyst;

internal class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args)
    {
        UIApplication.Main(args);
        BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);
    }

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect() 
            .LogToTrace()
            .UseReactiveUI()
            .UseMacCatalystWebView();
}
