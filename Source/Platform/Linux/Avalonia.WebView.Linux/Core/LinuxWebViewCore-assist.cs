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

        WebViewUrlLoadingEventArg args = new () 
        { 
            Url = uri, 
            RawArgs = policyDecision 
        };

        bool isSucceed = false;

        try
        {
            _callBack.PlatformWebViewNavigationStarting(this, args);
            if (args.Cancel)
            {
                policyDecision.Ignore();
                return false;
            }

            if (_webScheme?.BaseUri.IsBaseOf(uri) == true)
            {
                policyDecision.Use();
                isSucceed = true;
                return true;
            }

            var newWindowEventArgs = new WebViewNewWindowEventArgs()
            {
                Url = uri,
                UrlLoadingStrategy = type == PolicyDecisionType.NewWindowAction ? UrlRequestStrategy.OpenInWebView : UrlRequestStrategy.OpenExternally
            };

            if (!_callBack.PlatformWebViewNewWindowRequest(this, newWindowEventArgs))
            {
                policyDecision.Ignore();
                return false;
            }

            switch (newWindowEventArgs.UrlLoadingStrategy)
            {
                case UrlRequestStrategy.OpenExternally:
                case UrlRequestStrategy.OpenInNewWindow:
                    OpenUriHelper.OpenInProcess(uri);
                    policyDecision.Ignore();
                    isSucceed = true;
                    break;
                case UrlRequestStrategy.OpenInWebView:
                    policyDecision.Use();
                    isSucceed = true;
                    break;
                case UrlRequestStrategy.CancelLoad:
                default:
                    policyDecision.Ignore();
                    return false;
            }
        }
        catch (Exception)
        {
            isSucceed = false;
        }
        _callBack.PlatformWebViewNavigationCompleted(this, new WebViewUrlLoadedEventArg() { IsSuccess = isSucceed, RawArgs = policyDecision });
        return true;
    }
}
