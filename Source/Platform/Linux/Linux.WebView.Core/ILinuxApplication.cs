namespace Linux.WebView.Core;

public interface ILinuxApplication : IDisposable
{
    bool IsRunning { get; }
    ILinuxDispatcher Dispatcher { get; }
    Task<bool> RunAsync(string? applicationName, string[]? args);
    Task<(GWindow, WebKitWebView, IntPtr hostHandle)> CreateWebView();
    Task StopAsync();
}
