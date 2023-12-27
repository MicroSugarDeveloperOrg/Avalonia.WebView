using Avalonia.Controls.ApplicationLifetimes;
using CefGlue.Adapter;
using CefGlue.Adapter.Browser;

namespace Avalonia.WebView;
public static class AppBuilderExtensions
{
    public static AppBuilder UseCefWebView(this AppBuilder appBuilder, Action<CefInitializeSettings>? configDelegate)
    {
        CefInitializeSettings settings = new();
        configDelegate?.Invoke(settings);

        //CefRuntime.Load();
        CefRuntime.Load(settings.CefLibPath!);

        var args = Environment.GetCommandLineArgs();
        var mainArgs = new CefMainArgs(new string[] { });
        var cefApp = new CefAppAdapter(settings, null!);
        var exitCode = CefRuntime.ExecuteProcess(mainArgs, cefApp, IntPtr.Zero);
        if (exitCode == -1)
        {
            var cefSettings = new CefSettings
            {
                //BrowserSubprocessPath = settings.BroswerSubProcessPath,
                ResourcesDirPath = settings.ResourcePath,
                LocalesDirPath = settings.LocalesPath,
                WindowlessRenderingEnabled = settings.WindowlessRenderingEnabled,
                MultiThreadedMessageLoop = settings.MultiThreadedMessageLoop,
                //WindowlessRenderingEnabled = true,
                //MultiThreadedMessageLoop = true,
                LogSeverity = CefLogSeverity.Verbose,
                LogFile = "cef.log",
            };

            try
            {
                CefRuntime.Initialize(mainArgs, cefSettings, cefApp, IntPtr.Zero);
            }
            catch (Exception)
            {
                throw;
            }

        }

        appBuilder.AfterSetup(app =>
        {
            if (Application.Current?.ApplicationLifetime is IControlledApplicationLifetime applicationLifetime)
                applicationLifetime.Exit += (s, e) => CefRuntime.Shutdown();
        });


        return appBuilder.AfterPlatformServicesSetup(app =>
        {
            WebViewLocator.s_Registrator.RegisterSingleton<IViewHandlerProvider, ViewHandlerProvider>();
            WebViewLocator.s_Registrator.RegisterSingleton<IPlatformBlazorWebViewProvider, BlazorWebViewHandlerProvider>();
        });
    }
}
