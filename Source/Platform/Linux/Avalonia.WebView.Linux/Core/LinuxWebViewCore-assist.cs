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
        if (type == PolicyDecisionType.Response)
            return true;

        var policyDecision = new NavigationPolicyDecision(pPolicyDecision);

#pragma warning disable CS0612 // Type or member is obsolete
        var navigationRequest = policyDecision.Request;
#pragma warning restore CS0612 // Type or member is obsolete

        if (navigationRequest is null)
        {
            policyDecision.Ignore();
            return false;
        }

        var uriString = navigationRequest.Uri;
        var uri = new Uri(uriString);

        _callBack.PlatformWebViewNavigationStarting(this, new WebViewUrlLoadingEventArg() { Url = uri });

        if (_webScheme?.BaseUri.IsBaseOf(uri) == true)
        {
            policyDecision.Use();
            return true;
        }

        var newWindowEventArgs = new WebViewNewWindowEventArgs()
        {
            Url = uri,
            UrlLoadingStrategy = type == PolicyDecisionType.NewWindowAction ? UrlLoadingStrategy.OpenInWebView : UrlLoadingStrategy.OpenExternally
        };

        if (!_callBack.PlatformWebViewNewWindowRequest(this, newWindowEventArgs))
        {
            policyDecision.Ignore();
            return false;
        }

        switch (newWindowEventArgs.UrlLoadingStrategy)
        {
            case UrlLoadingStrategy.OpenExternally:
                OpenUriHelper.OpenInProcess(uri);
                policyDecision.Ignore();
                break;
            case UrlLoadingStrategy.OpenInWebView:
                policyDecision.Use();
                break;
            case UrlLoadingStrategy.CancelLoad:
            default:
                policyDecision.Ignore();
                return false;
        }
        return true;
    }
}
