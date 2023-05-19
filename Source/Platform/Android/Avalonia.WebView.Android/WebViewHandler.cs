namespace Avalonia.WebView.Android;

[ToolboxItem(true)]
public partial class WebViewHandler : ViewHandler<IVirtualView, AndroidWebView>
{
    static WebViewHandler()
    {
        LoadedPropertyChanged();
    }

    public WebViewHandler(IVirtualView virtualView) : base(virtualView)
    {
        _hwndTaskSource = new();
        _platformViewCall = () => AndroidWebView;
        SizeChanged += WebViewHandler_SizeChanged;
    }

    readonly TaskCompletionSource<AndroidWebView> _hwndTaskSource;
    Task? _initTask;

    WebViewClient? _webViewClient;
    WebChromeClient? _webChromeClient;

    [Browsable(false)]
    public AndroidWebView? AndroidWebView { get; set; }
}
