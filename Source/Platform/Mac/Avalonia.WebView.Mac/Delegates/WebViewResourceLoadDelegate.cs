namespace Avalonia.WebView.Mac.Delegates;

public class WebViewResourceLoadDelegate : WebResourceLoadDelegate
{
    public WebViewResourceLoadDelegate()
    {
    }

    public override NSObject OnIdentifierForInitialRequest(MacosWebView sender, NSUrlRequest request, WebDataSource dataSource)
    {
        return base.OnIdentifierForInitialRequest(sender, request, dataSource);
    }

    public override NSUrlRequest OnSendRequest(MacosWebView sender, NSObject identifier, NSUrlRequest request, NSUrlResponse redirectResponse, WebDataSource dataSource)
    {
        return base.OnSendRequest(sender, identifier, request, redirectResponse, dataSource);
    }

    public override void OnReceivedAuthenticationChallenge(MacosWebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
    {
        base.OnReceivedAuthenticationChallenge(sender, identifier, challenge, dataSource);
    }

    public override void OnCancelledAuthenticationChallenge(MacosWebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
    {
        base.OnCancelledAuthenticationChallenge(sender, identifier, challenge, dataSource);
    }

    public override void OnReceivedResponse(MacosWebView sender, NSObject identifier, NSUrlResponse responseReceived, WebDataSource dataSource)
    {
        base.OnReceivedResponse(sender, identifier, responseReceived, dataSource);
    }

    public override void OnReceivedContentLength(MacosWebView sender, NSObject identifier, int length, WebDataSource dataSource)
    {
        base.OnReceivedContentLength(sender, identifier, length, dataSource);
    }

    public override void OnFinishedLoading(MacosWebView sender, NSObject identifier, WebDataSource dataSource)
    {
        base.OnFinishedLoading(sender, identifier, dataSource);
    }

    public override void OnFailedLoading(MacosWebView sender, NSObject identifier, NSError withError, WebDataSource dataSource)
    {
        base.OnFailedLoading(sender, identifier, withError, dataSource);
    }

    public override void OnPlugInFailed(MacosWebView sender, NSError error, WebDataSource dataSource)
    {
        base.OnPlugInFailed(sender, error, dataSource);
    }
}

