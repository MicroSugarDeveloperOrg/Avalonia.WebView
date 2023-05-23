namespace Avalonia.WebView.Mac.Delegates;
public class WebViewFrameLoadDelegate : WebFrameLoadDelegate
{
    public override void StartedProvisionalLoad(MacosWebView sender, WebFrame forFrame)
    {
        base.StartedProvisionalLoad(sender, forFrame);
    }

    public override void ReceivedServerRedirectForProvisionalLoad(MacosWebView sender, WebFrame forFrame)
    {
        base.ReceivedServerRedirectForProvisionalLoad(sender, forFrame);
    }

    public override void ClearedWindowObject(MacosWebView webView, WebScriptObject windowObject, WebFrame forFrame)
    {
        base.ClearedWindowObject(webView, windowObject, forFrame);
    }

    public override void WindowScriptObjectAvailable(MacosWebView webView, WebScriptObject windowScriptObject)
    {
        base.WindowScriptObjectAvailable(webView, windowScriptObject);
    }
}
