namespace Avalonia.WebView.Mac.Delegates;

public class WebViewNavigationDelegate : WebPolicyDelegate
{
    public WebViewNavigationDelegate()
    {
    }

    public override void DecidePolicyForNavigation(MacosWebView webView, NSDictionary actionInformation, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
    {
        //webView.OnSendRequest(webView, decisionToken, request, new NSUrlResponse(), new WebDataSource());
        DecideUse(decisionToken);
        //base.DecidePolicyForNavigation(webView, actionInformation, request, frame, decisionToken);
    }

    public override void DecidePolicyForMimeType(MacosWebView webView, string mimeType, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
    {
        //base.DecidePolicyForMimeType(webView, mimeType, request, frame, decisionToken);
    }

    public override void DecidePolicyForNewWindow(MacosWebView webView, NSDictionary actionInformation, NSUrlRequest request, string newFrameName, NSObject decisionToken)
    {
        //base.DecidePolicyForNewWindow(webView, actionInformation, request, newFrameName, decisionToken);
    }

    public override void UnableToImplementPolicy(MacosWebView webView, NSError error, WebFrame frame)
    {
        //base.UnableToImplementPolicy(webView, error, frame);
    }
}

