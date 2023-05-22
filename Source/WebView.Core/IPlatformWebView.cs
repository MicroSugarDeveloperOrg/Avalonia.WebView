namespace WebViewCore;

public interface IPlatformWebView : IWebViewControl, IDisposable, IAsyncDisposable
{
    bool IsInitialized { get; }
    object? PlatformViewContext { get; }
    IntPtr NativeHandler { get;} 
    Task<bool> Initialize();
}
