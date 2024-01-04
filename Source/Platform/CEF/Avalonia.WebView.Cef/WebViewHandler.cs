using Avalonia.WebView.Core;

namespace Avalonia.WebView;
public partial class WebViewHandler : ViewHandlerTx<IVirtualWebView, CefWebViewCore>
{
    public WebViewHandler(IVirtualWebView virtualWebView, IVirtualWebViewControlCallBack callback, IVirtualBlazorWebViewProvider? provider, WebViewCreationProperties webViewCreationProperties)
        : base(webViewCreationProperties.KeepAlive)
    {
        CefWebViewCore webView = new(this, callback, provider, webViewCreationProperties);
        _viewHandlerControl = webView;
        PlatformWebView = webView;
        VirtualViewContext = virtualWebView;
        PlatformViewContext = webView;
    }

    IViewHandlerControl _viewHandlerControl;

    protected override void Disposing()
    {
        PlatformWebView.Dispose();
        PlatformWebView = default!;
        VirtualViewContext = default!;
    }

    public override void ApplyTemplate()
    {
        base.ApplyTemplate();
    }

    public override void Render(DrawingContext context)
    {
        base.Render(context);

        var bitmap = _viewHandlerControl.DrawingImage();
        if (bitmap is null)
            return;

        context.DrawImage(bitmap, new Rect(0, 0, Bounds.Width, Bounds.Height));
        //context.DrawImage(bitmap, new Rect(0, 0, bitmap.Size.Width, bitmap.Size.Height), new Rect(0, 0, Bounds.Width, Bounds.Height));
    }

}
