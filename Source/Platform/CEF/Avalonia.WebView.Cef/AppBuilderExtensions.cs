using Avalonia.Controls.ApplicationLifetimes;
using CefGlue.Adapter;
using CefGlue.Adapter.Browser;

namespace Avalonia.WebView;
public static class AppBuilderExtensions
{
    internal static CefBroswerManager __CefBroswerManager { get; } = new CefBroswerManager();

    public static AppBuilder UseCefWebView(this AppBuilder appBuilder, Action<CefInitializeSettings>? configDelegate)
    {
        CefInitializeSettings settings = new();
        configDelegate?.Invoke(settings);

        //CefRuntime.Load();
        CefRuntime.Load(settings.CefLibPath!);

        var args = Environment.GetCommandLineArgs();
        var mainArgs = new CefMainArgs(new string[] { });
        var cefApp = new CefAppAdapter(settings, null!);

        try
        {
            var exitCode = CefRuntime.ExecuteProcess(mainArgs, cefApp, IntPtr.Zero);
            if (exitCode == -1)
            {
                var cefSettings = new CefSettings
                {
                    //BrowserSubprocessPath = settings.BroswerSubProcessPath,
                    //ResourcesDirPath = settings.ResourcePath,
                    //LocalesDirPath = settings.LocalesPath,
                    //WindowlessRenderingEnabled = settings.WindowlessRenderingEnabled,
                    WindowlessRenderingEnabled = true,
                    MultiThreadedMessageLoop = settings.MultiThreadedMessageLoop,
                    LogSeverity = CefLogSeverity.Verbose,
                    LogFile = "cef.log",
                };

                CefRuntime.Initialize(mainArgs, cefSettings, cefApp, IntPtr.Zero);
            }
        }
        catch (Exception)
        {
            throw;
        }
        
        appBuilder.AfterSetup(app =>
        {
            if (Application.Current?.ApplicationLifetime is IControlledApplicationLifetime applicationLifetime)
                applicationLifetime.Exit += (s, e) => 
                {
                    CefRuntime.QuitMessageLoop();
                    __CefBroswerManager.StopHosts();    
                    Environment.Exit(0);
                    CefRuntime.Shutdown();//目前该函数调用会阻塞退出 所以直接使用Environment.Exit(0) 来退出程序
                };
        });

        return appBuilder.AfterPlatformServicesSetup(app =>
        {
            WebViewLocator.s_Registrator.RegisterSingleton<IViewHandlerProvider, ViewHandlerProvider>();
            WebViewLocator.s_Registrator.RegisterSingleton<IPlatformBlazorWebViewProvider, BlazorWebViewHandlerProvider>();
        });
    }
}
