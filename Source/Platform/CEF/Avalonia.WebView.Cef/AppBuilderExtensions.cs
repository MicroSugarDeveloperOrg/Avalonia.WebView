using Avalonia.WebView.Browser;
using CefGlue;

namespace Avalonia.WebView;
public static class AppBuilderExtensions
{
    public static AppBuilder UseCefWebView(this AppBuilder appBuilder)
    {
        CefRuntime.Load();

        var args = Environment.GetCommandLineArgs();
        var mainArgs = new CefMainArgs(args);
        var cefApp = new AvaloniaCefApp();
        var exitCode = CefRuntime.ExecuteProcess(mainArgs, cefApp, IntPtr.Zero);
        if (exitCode == -1)
        {
            var cefSettings = new CefSettings
            {
                //BrowserSubprocessPath = browserSubprocessPath,
                WindowlessRenderingEnabled = true,
                MultiThreadedMessageLoop = true,
                LogSeverity = CefLogSeverity.Verbose,
                LogFile = "cef.log",
            };

            CefRuntime.Initialize(mainArgs, cefSettings, cefApp, IntPtr.Zero);
        }

      
         
        return appBuilder.AfterPlatformServicesSetup(app =>
        {
            WebViewLocator.s_Registrator.RegisterSingleton<IViewHandlerProvider, ViewHandlerProvider>();
            WebViewLocator.s_Registrator.RegisterSingleton<IPlatformBlazorWebViewProvider, BlazorWebViewHandlerProvider>();
        });
    }
}
