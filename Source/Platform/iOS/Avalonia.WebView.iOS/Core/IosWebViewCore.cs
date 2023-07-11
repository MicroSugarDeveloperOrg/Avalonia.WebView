using CoreImage;

namespace Avalonia.WebView.iOS.Core;

public partial class IosWebViewCore: IPlatformWebView<IosWebViewCore>
{
    public IosWebViewCore(ViewHandler handler, IVirtualWebViewControlCallBack callback, IVirtualBlazorWebViewProvider? provider, WebViewCreationProperties webViewCreationProperties)
    {
        _provider = provider;
        _callBack = callback;
        _handler = handler;
        _creationProperties = webViewCreationProperties;

        _callBack.PlatformWebViewCreating(this, new WebViewCreatingEventArgs());
        _config = new WKWebViewConfiguration();
        _config.Preferences.SetValueForKey(NSObject.FromObject(_creationProperties.AreDevToolEnabled), new NSString("developerExtrasEnabled"));

        if (provider is not null)
        {
            if (provider.ResourceRequestedFilterProvider(this, out var filter))
            {
                _filter = filter;
                _config.UserContentController.AddScriptMessageHandler(new WebViewScriptMessageHandler(filter.BaseUri, MessageReceived), _filterKeyWord);
                _config.UserContentController.AddUserScript(new WKUserScript(new NSString(BlazorScriptHelper.BlazorStartingScript), WKUserScriptInjectionTime.AtDocumentEnd, true));
                _config.SetUrlSchemeHandler(new SchemeHandler(this, provider, filter), urlScheme: filter.Scheme);
            }

            _isBlazorWebView = true;
        }
        else
            _config.UserContentController.AddScriptMessageHandler(new WebViewScriptMessageHandler(default!, MessageReceived), _filterKeyWord);

        _webView = new WKWebView(CGRect.Empty, _config)
        {
            BackgroundColor = UIColor.Clear,
            AutosizesSubviews = true
        };

        NativeHandler = _webView.Handle.Handle;
        RegisterEvents();
    }

    ~IosWebViewCore()
    {
        Dispose(disposing: false);
    }

    WKWebView _webView;
    readonly WebScheme? _filter;
    readonly WKWebViewConfiguration _config;
    readonly IVirtualBlazorWebViewProvider? _provider;
    readonly IVirtualWebViewControlCallBack _callBack;
    readonly ViewHandler _handler;
    readonly WebViewCreationProperties _creationProperties;
    readonly string _filterKeyWord = "webwindowinterop";
    readonly string _dispatchMessageCallback = "__dispatchMessageCallback";

    bool _isBlazorWebView = false;

    bool _isInitialized = false;
    public bool IsInitialized
    {
        get => Volatile.Read(ref _isInitialized);
        private set => Volatile.Write(ref _isInitialized, value);
    }

    bool _isdisposed = false;
    public bool IsDisposed
    {
        get => Volatile.Read(ref _isdisposed);
        private set => Volatile.Write(ref _isdisposed, value);
    }


    public WKWebView WebView
    {
        get => _webView;
        private set => _webView = value;
    }
}

