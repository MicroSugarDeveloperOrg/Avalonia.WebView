using WebKit;

namespace Avalonia.WebView.Linux.Core;

partial class LinuxWebViewCore 
{
    private void WebView_UserMessageReceived(object o, UserMessageReceivedArgs args)
    {

    }


    private void WebView_PermissionRequest(object o, PermissionRequestArgs args)
    {
        args.Request.Allow();
    }

    private void WebView_DecidePolicy(object o, DecidePolicyArgs args)
    {

    }

    bool WebView_DecidePolicy(nint pWebView, nint pPolicyDecision, PolicyDecisionType type)
    {
        var webView = new WebKitWebView(pWebView);
        var policyDecision = new NavigationPolicyDecision(pPolicyDecision);



        return true;
    }
}
