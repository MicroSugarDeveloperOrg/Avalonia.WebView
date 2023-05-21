namespace WebViewCore;

public interface IPlatformWebView : IWebViewControl, IDisposable, IAsyncDisposable
{
    IntPtr NativeHandler { get;}

    Task<bool> Initialize(IVirtualBlazorWebViewProvider? virtualProvider);
    bool IsInitialized { get; }

    object? PlatformViewContext { get; }
}
