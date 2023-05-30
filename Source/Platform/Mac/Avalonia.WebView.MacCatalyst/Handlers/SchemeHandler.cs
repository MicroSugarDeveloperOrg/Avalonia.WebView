namespace Avalonia.WebView.MacCatalyst.Handlers;
internal class SchemeHandler : NSObject, IWKUrlSchemeHandler
{
    public SchemeHandler(MacCatalystWebViewCore webViewCore, IVirtualBlazorWebViewProvider provider, WebScheme webScheme)
    {
        _Scheme = webScheme;
        _webViewCore = webViewCore;
        _provider = provider;
    }

    readonly WebScheme _Scheme;
    readonly MacCatalystWebViewCore _webViewCore;
    readonly IVirtualBlazorWebViewProvider _provider;

    //[Export("webView:startURLSchemeTask:")]
    public void StartUrlSchemeTask(WKWebView webView, IWKUrlSchemeTask urlSchemeTask)
    {
        var responseBytes = GetResponseBytes(urlSchemeTask.Request.Url?.AbsoluteString ?? "", out var contentType, statusCode: out var statusCode);
        if (statusCode == 200)
        {
            using var dic = new NSMutableDictionary<NSString, NSString>();
            dic.Add((NSString)"Content-Length", (NSString)(responseBytes.Length.ToString(CultureInfo.InvariantCulture)));
            dic.Add((NSString)"Content-Type", (NSString)contentType);
            dic.Add((NSString)"Cache-Control", (NSString)"no-cache, max-age=0, must-revalidate, no-store");
            if (urlSchemeTask.Request.Url != null)
            {
                using var response = new NSHttpUrlResponse(urlSchemeTask.Request.Url, statusCode, "HTTP/1.1", dic);
                urlSchemeTask.DidReceiveResponse(response);
            }

            urlSchemeTask.DidReceiveData(NSData.FromArray(responseBytes));
            urlSchemeTask.DidFinish();
        }
    }

    private byte[] GetResponseBytes(string? url, out string contentType, out int statusCode)
    {
        var allowFallbackOnHostPage = _Scheme.BaseUri.IsBaseOfPage(url);
        var webRequest = new WebResourceRequest
        {
            RequestUri = url!,
            AllowFallbackOnHostPage = allowFallbackOnHostPage
        };

        var bRet = _provider.PlatformWebViewResourceRequested(_webViewCore, webRequest, out var webResponse);
        if (!bRet || webResponse is null)
        {
            statusCode = 404;
            contentType = string.Empty;
            return Array.Empty<byte>();
        }
        else
        {
            statusCode = 200;
            using var ms = new MemoryStream();
            webResponse.Content.CopyTo(ms);
            webResponse.Content.Dispose();

            contentType = webResponse.Headers[QueryStringHelper.ContentTypeKey];
            return ms.ToArray();
        }
    }

    //[Export("webView:stopURLSchemeTask:")]
    public void StopUrlSchemeTask(WKWebView webView, IWKUrlSchemeTask urlSchemeTask)
    {
    }
}