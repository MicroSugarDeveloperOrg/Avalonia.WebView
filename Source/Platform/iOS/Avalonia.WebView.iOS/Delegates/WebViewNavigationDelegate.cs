namespace Avalonia.WebView.iOS.Delegates;

internal class WebViewNavigationDelegate : WKNavigationDelegate
{
    public WebViewNavigationDelegate(IosWebViewCore webViewCore, IVirtualWebViewControlCallBack callBack, WebScheme? webScheme)
    {
        _webViewCore = webViewCore;
        _webScheme = webScheme;
        _callBack = callBack;
        if (webScheme is null)
            _isBlazor = false;
    }
    readonly IosWebViewCore _webViewCore;
    readonly WebScheme? _webScheme;
    readonly IVirtualWebViewControlCallBack _callBack;
    readonly bool _isBlazor = true;

    WKNavigation? _navigation;
    Uri? _currentUri;

    public override void DidStartProvisionalNavigation(WKWebView webView, WKNavigation navigation)
    {
        _navigation = navigation;
    }

    public override void DecidePolicy(WKWebView webView, WKNavigationAction navigationAction, Action<WKNavigationActionPolicy> decisionHandler)
    {
        var requestUrl = navigationAction.Request.Url;
        var uri = new Uri(requestUrl.ToString());

        _callBack.PlatformWebViewNavigationStarting(_webViewCore, new WebViewUrlLoadingEventArg() { Url = uri });

        UrlRequestStrategy strategy;

        if (navigationAction.TargetFrame is null)
            strategy = UrlRequestStrategy.OpenExternally;
        else
        {
            if (_webScheme is not null)
                strategy = _webScheme.BaseUri.IsBaseOf(uri) ? UrlRequestStrategy.OpenInWebView : UrlRequestStrategy.OpenExternally;
            else
                strategy = UrlRequestStrategy.OpenInWebView;
        }

        var newWindowEventArgs = new WebViewNewWindowEventArgs()
        {
            Url = uri,
            UrlLoadingStrategy = UrlRequestStrategy.OpenInWebView
        };

        if (!_callBack.PlatformWebViewNewWindowRequest(_webViewCore, newWindowEventArgs))
        {
            decisionHandler(WKNavigationActionPolicy.Cancel);
            return;
        }

        if (strategy == UrlRequestStrategy.OpenExternally || strategy ==  UrlRequestStrategy.OpenInNewWindow)
        {
#pragma warning disable CA1422  // TODO: OpenUrl(...) has [UnsupportedOSPlatform("ios10.0")]
            UIApplication.SharedApplication.OpenUrl(requestUrl);
#pragma warning restore CA1422 // 
        }

        if (strategy != UrlRequestStrategy.OpenInWebView)
        {
            decisionHandler(WKNavigationActionPolicy.Cancel);
            return;
        }

        if (navigationAction.TargetFrame!.MainFrame)
            _currentUri = requestUrl;

        decisionHandler(WKNavigationActionPolicy.Allow);
    }

    public override void DidReceiveServerRedirectForProvisionalNavigation(WKWebView webView, WKNavigation navigation)
    {
        if (_currentUri?.Host == _webScheme?.AppAddress)
        {
            var uri = _currentUri;
            _currentUri = null;
            _navigation = null;
            if (uri is not null)
            {
                var request = new NSUrlRequest(new NSUrl(uri.AbsoluteUri));
                webView.LoadRequest(request);
            }
        }

        //else
        //base.DidReceiveServerRedirectForProvisionalNavigation(webView, navigation);
    }

    public override void DidFailNavigation(WKWebView webView, WKNavigation navigation, NSError error)
    {
        _currentUri = null;
        _navigation = null;
        //base.DidFailNavigation(webView, navigation, error);
    }

    public override void DidFailProvisionalNavigation(WKWebView webView, WKNavigation navigation, NSError error)
    {
        _currentUri = null;
        _navigation = null;
        //base.DidFailProvisionalNavigation(webView, navigation, error);
    }

    public override void DidCommitNavigation(WKWebView webView, WKNavigation navigation)
    {
        if (_currentUri != null && _navigation == navigation)
        {
            // TODO: Determine whether this is needed
            //_webView.HandleNavigationStarting(_currentUri);
        }
        //base.DidCommitNavigation(webView, navigation);
    }

    public override void DidFinishNavigation(WKWebView webView, WKNavigation navigation)
    {
        bool isSucceed = false;
        if (_currentUri != null && _navigation == navigation)
        {
            // TODO: Determine whether this is needed
            //_webView.HandleNavigationFinished(_currentUri);
            _currentUri = null;
            _navigation = null;
            isSucceed = true;
        }

        _callBack.PlatformWebViewNavigationCompleted(_webViewCore, new WebViewUrlLoadedEventArg() { IsSuccess = isSucceed, RawArgs = navigation });

        //base.DidFinishNavigation(webView, navigation);
    }
}
