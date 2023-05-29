using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace WebKit;

[Protocol]
[Register("WKNavigationDelegate", false)]
[Model]
public class WKNavigationDelegate : NSObject, IWKNavigationDelegate
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public WKNavigationDelegate()
        : base(NSObjectFlag.Empty)
    {
        IsDirectBinding = false;
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKNavigationDelegate(NSObjectFlag t)
        : base(t)
    {
        IsDirectBinding = false;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKNavigationDelegate(IntPtr handle)
        : base(handle)
    {
        IsDirectBinding = false;
    }

    [Export("webViewWebContentProcessDidTerminate:")]
    public virtual void ContentProcessDidTerminate(WKWebView webView)
    {
        throw new You_Should_Not_Call_base_In_This_Method();
    }

    [Export("webView:decidePolicyForNavigationAction:decisionHandler:")]
    public virtual void DecidePolicy(WKWebView webView, WKNavigationAction navigationAction, Action<WKNavigationActionPolicy> decisionHandler)
    {
        throw new You_Should_Not_Call_base_In_This_Method();
    }

    [Export("webView:decidePolicyForNavigationResponse:decisionHandler:")]
    public virtual void DecidePolicy(WKWebView webView, WKNavigationResponse navigationResponse, Action<WKNavigationResponsePolicy> decisionHandler)
    {
        throw new You_Should_Not_Call_base_In_This_Method();
    }

    [Export("webView:decidePolicyForNavigationAction:preferences:decisionHandler:")]
    public virtual void DecidePolicy(WKWebView webView, WKNavigationAction navigationAction, WKWebpagePreferences preferences, Action<WKNavigationActionPolicy, WKWebpagePreferences> decisionHandler)
    {
        throw new You_Should_Not_Call_base_In_This_Method();
    }

    [Export("webView:didCommitNavigation:")]
    public virtual void DidCommitNavigation(WKWebView webView, WKNavigation navigation)
    {
        throw new You_Should_Not_Call_base_In_This_Method();
    }

    [Export("webView:didFailNavigation:withError:")]
    public virtual void DidFailNavigation(WKWebView webView, WKNavigation navigation, NSError error)
    {
        throw new You_Should_Not_Call_base_In_This_Method();
    }

    [Export("webView:didFailProvisionalNavigation:withError:")]
    public virtual void DidFailProvisionalNavigation(WKWebView webView, WKNavigation navigation, NSError error)
    {
        throw new You_Should_Not_Call_base_In_This_Method();
    }

    [Export("webView:didFinishNavigation:")]
    public virtual void DidFinishNavigation(WKWebView webView, WKNavigation navigation)
    {
        throw new You_Should_Not_Call_base_In_This_Method();
    }

    [Export("webView:didReceiveAuthenticationChallenge:completionHandler:")]
    public virtual void DidReceiveAuthenticationChallenge(WKWebView webView, NSUrlAuthenticationChallenge challenge, Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
    {
        throw new You_Should_Not_Call_base_In_This_Method();
    }

    [Export("webView:didReceiveServerRedirectForProvisionalNavigation:")]
    public virtual void DidReceiveServerRedirectForProvisionalNavigation(WKWebView webView, WKNavigation navigation)
    {
        throw new You_Should_Not_Call_base_In_This_Method();
    }

    [Export("webView:didStartProvisionalNavigation:")]
    public virtual void DidStartProvisionalNavigation(WKWebView webView, WKNavigation navigation)
    {
        throw new You_Should_Not_Call_base_In_This_Method();
    }
}
