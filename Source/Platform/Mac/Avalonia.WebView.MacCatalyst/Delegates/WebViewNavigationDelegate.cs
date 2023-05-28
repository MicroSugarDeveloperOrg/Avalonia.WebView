namespace Avalonia.WebView.MacCatalyst.Delegates;
internal class WebViewNavigationDelegate : WKNavigationDelegate
{
    public WebViewNavigationDelegate(MacCatalystWebViewCore webViewCore, IVirtualWebViewControlCallBack callBack, WebScheme? webScheme)
    {
        _webViewCore = webViewCore;
        //_webView = _webViewCore.WebView;
        _webScheme = webScheme;
    }
    readonly MacCatalystWebViewCore _webViewCore;
    //readonly WKWebView _webView;
    readonly WebScheme? _webScheme;

    WKNavigation? _navigation;
    Uri? _currentUri;

    public override void DidStartProvisionalNavigation(WKWebView webView, WKNavigation navigation)
    {
        //base.DidStartProvisionalNavigation(webView, navigation);
        _navigation = navigation;
    }

    public override void DecidePolicy(WKWebView webView, WKNavigationAction navigationAction, Action<WKNavigationActionPolicy> decisionHandler)
    {
        //base.DecidePolicy(webView, navigationAction, decisionHandler);

        var requestUrl = navigationAction.Request.Url;
        var uri = new Uri(requestUrl.ToString());

        UrlLoadingStrategy strategy;

        if (navigationAction.TargetFrame is null)
            strategy = UrlLoadingStrategy.OpenExternally;
        else
        {
            if (_webScheme is not null)
                strategy = _webScheme.BaseUri.IsBaseOf(uri) ? UrlLoadingStrategy.OpenInWebView : UrlLoadingStrategy.OpenExternally;
            else
                strategy = UrlLoadingStrategy.OpenInWebView;
        }

        if (strategy == UrlLoadingStrategy.OpenExternally)
        {

            //Open use system  
        }

        if (strategy != UrlLoadingStrategy.OpenInWebView)
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
        if (_currentUri != null && _navigation == navigation)
        {
            // TODO: Determine whether this is needed
            //_webView.HandleNavigationFinished(_currentUri);
            _currentUri = null;
            _navigation = null;
        }
        //base.DidFinishNavigation(webView, navigation);
    }
}
