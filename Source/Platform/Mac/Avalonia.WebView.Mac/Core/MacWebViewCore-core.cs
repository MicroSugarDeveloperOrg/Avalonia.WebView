using Avalonia.WebView.Mac.Delegates;
using Avalonia.WebView.Mac.Helpers;
using System.Web;

namespace Avalonia.WebView.Mac.Core;
partial class MacWebViewCore  
{
    Task PrepareBlazorWebViewStarting(IVirtualBlazorWebViewProvider? provider)
    {
        if (provider is null )
            return Task.CompletedTask;

        if (!provider.ResourceRequestedFilterProvider(this, out var filter))
            return Task.CompletedTask;

        MacosWebView.RegisterUrlSchemeAsLocal(filter.Scheme);

        WebView.PolicyDelegate = new WebViewNavigationDelegate();
        WebView.ResourceLoadDelegate = new WebViewResourceLoadDelegate();
        WebView.FrameLoadDelegate = new WebViewFrameLoadDelegate(); 
        //WebView.UIDelegate = new WebViewUIDelegate();
        //NSHttpUrlResponse

        var messageJSStringLiteral = HttpUtility.JavaScriptStringEncode(BlazorScriptHelper.BlazorStartingScript);
        var result= WebView.StringByEvaluatingJavaScriptFromString(messageJSStringLiteral);
        //var result1 = WebView.StringByEvaluatingJavaScriptFromString(BlazorScriptHelper.BlazorStaredScript);

        _isBlazorWebView = true;
        return Task.CompletedTask;
    }

    void ClearBlazorWebViewCompleted()
    {
        _isBlazorWebView = false;
    }

    

}
