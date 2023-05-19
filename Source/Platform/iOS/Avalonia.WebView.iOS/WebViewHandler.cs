namespace Avalonia.WebView.iOS;

public partial class WebViewHandler : ViewHandler<IVirtualView, WKWebView>
{
    static WebViewHandler()
    {
        LoadedPropertyChanged();
    }

    public WebViewHandler(IVirtualView virtualView) : base(virtualView)
    {
        _hwndTaskSource = new();
        _platformViewCall = () => WebView;
    }

    readonly TaskCompletionSource<WKWebView> _hwndTaskSource;
    Task? _initTask;

    [Browsable(false)]
    public WKWebView? WebView { get; set; } 
}
