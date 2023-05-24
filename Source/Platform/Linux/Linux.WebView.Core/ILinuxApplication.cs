namespace Linux.WebView.Core;

public interface ILinuxApplication : IDisposable
{
    bool IsRunning { get; }
    ILinuxDispatcher Dispatcher { get; }
    Task<bool> RunAsync(string? applicationName, string[]? args);
    ILinuxWebView? CreateWebView();
    Task StopAsync();
}
