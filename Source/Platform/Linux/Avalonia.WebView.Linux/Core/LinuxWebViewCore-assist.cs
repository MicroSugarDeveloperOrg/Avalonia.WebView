using System.Diagnostics;
using WebKit;
using WebViewCore.Helpers;

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

        //var navigationAction = policyDecision.NavigationAction;
#pragma warning disable CS0612 // Type or member is obsolete
        var navigationRequest = policyDecision.Request;
#pragma warning restore CS0612 // Type or member is obsolete
        
        if (navigationRequest is null)
            return false;

        var uriString = navigationRequest.Uri;
        var uri = new Uri(uriString);

        if (_webScheme?.BaseUri.IsBaseOf(uri) == true)
            return true;

        _callBack.PlatformWebViewNewWindowRequest(this, new WebViewNewWindowEventArgs());

        if (type == PolicyDecisionType.NewWindowAction)
            OpenUriHelper.OpenInProcess(uri);
        else
        {
            webView.LoadUri(uriString);
        }

        return false;
    }
}
