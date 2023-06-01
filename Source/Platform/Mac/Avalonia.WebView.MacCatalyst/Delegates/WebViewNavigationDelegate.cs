namespace Avalonia.WebView.MacCatalyst.Delegates;
internal class WebViewNavigationDelegate : NSObject, IWKNavigationDelegate
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

    public  void DidStartProvisionalNavigation(WKWebView webView, WKNavigation navigation)
    {
        //base.DidStartProvisionalNavigation(webView, navigation);
        _navigation = navigation;
    }

    public  void DecidePolicy(WKWebView webView, WKNavigationAction navigationAction, Action<WKNavigationActionPolicy> decisionHandler)
    {
        var action = Trampolines.NIDActionArity1V93.Create(Marshal.GetFunctionPointerForDelegate(decisionHandler));

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
            action?.Invoke(WKNavigationActionPolicy.Cancel);
            //decisionHandler(WKNavigationActionPolicy.Cancel);
            return;
        }

        if (navigationAction.TargetFrame!.MainFrame)
            _currentUri = requestUrl;

        action?.Invoke(WKNavigationActionPolicy.Allow);
        //decisionHandler(WKNavigationActionPolicy.Allow);
    }

    public  void DidReceiveServerRedirectForProvisionalNavigation(WKWebView webView, WKNavigation navigation)
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

    public  void DidFailNavigation(WKWebView webView, WKNavigation navigation, NSError error)
    {
        _currentUri = null;
        _navigation = null;
        //base.DidFailNavigation(webView, navigation, error);
    }

    public  void DidFailProvisionalNavigation(WKWebView webView, WKNavigation navigation, NSError error)
    {
        _currentUri = null;
        _navigation = null;
        //base.DidFailProvisionalNavigation(webView, navigation, error);
    }

    public  void DidCommitNavigation(WKWebView webView, WKNavigation navigation)
    {
        if (_currentUri != null && _navigation == navigation)
        {
            // TODO: Determine whether this is needed
            //_webView.HandleNavigationStarting(_currentUri);
        }
        //base.DidCommitNavigation(webView, navigation);
    }

    public  void DidFinishNavigation(WKWebView webView, WKNavigation navigation)
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
