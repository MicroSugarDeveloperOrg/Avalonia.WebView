using Foundation;
using ObjCRuntime;
using System.ComponentModel;
using Xamarin.Utiles;

namespace WebKit;

[Protocol]
[Register("WKUIDelegate", false)]
[Model]
public class WKUIDelegate : NSObject, IWKUIDelegate, INativeObject, IDisposable
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public WKUIDelegate()
        : base(NSObjectFlag.Empty)
    {
        IsDirectBinding = false;
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKUIDelegate(NSObjectFlag t)
        : base(t)
    {
        IsDirectBinding = false;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKUIDelegate(IntPtr handle)
        : base(handle)
    {
        IsDirectBinding = false;
    }

    [Export("webView:createWebViewWithConfiguration:forNavigationAction:windowFeatures:")]
    public virtual WKWebView CreateWebView(WKWebView webView, WKWebViewConfiguration configuration, WKNavigationAction navigationAction, WKWindowFeatures windowFeatures)
    {
        throw new You_Should_Not_Call_base_In_This_Method();
    }

    [Export("webViewDidClose:")]
    public virtual void DidClose(WKWebView webView)
    {
        throw new You_Should_Not_Call_base_In_This_Method();
    }

    [Export("webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:completionHandler:")]
    public virtual void RunJavaScriptAlertPanel(WKWebView webView, string message, WKFrameInfo frame, [BlockProxy(typeof(Trampolines.NIDAction))] Action completionHandler)
    {
        throw new You_Should_Not_Call_base_In_This_Method();
    }

    [Export("webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:completionHandler:")]
    public virtual void RunJavaScriptConfirmPanel(WKWebView webView, string message, WKFrameInfo frame, [BlockProxy(typeof(Trampolines.NIDActionArity1V2))] Action<bool> completionHandler)
    {
        throw new You_Should_Not_Call_base_In_This_Method();
    }

    [Export("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:completionHandler:")]
    public virtual void RunJavaScriptTextInputPanel(WKWebView webView, string prompt, string? defaultText, WKFrameInfo frame, [BlockProxy(typeof(Trampolines.NIDActionArity1V44))] Action<string> completionHandler)
    {
        throw new You_Should_Not_Call_base_In_This_Method();
    }

    [Export("webView:runOpenPanelWithParameters:initiatedByFrame:completionHandler:")]
    public virtual void RunOpenPanel(WKWebView webView, WKOpenPanelParameters parameters, WKFrameInfo frame, [BlockProxy(typeof(Trampolines.NIDActionArity1V95))] Action<NSUrl[]> completionHandler)
    {
        throw new You_Should_Not_Call_base_In_This_Method();
    }
}
