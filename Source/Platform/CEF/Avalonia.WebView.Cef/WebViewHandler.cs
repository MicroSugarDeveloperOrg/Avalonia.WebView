using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.WebView.Core;
using Avalonia.WebView.Extensions;

namespace Avalonia.WebView;
public partial class WebViewHandler : ViewHandlerTx<IVirtualWebView, CefWebViewCore>
{
    public WebViewHandler(IVirtualWebView virtualWebView, IVirtualWebViewControlCallBack callback, IVirtualBlazorWebViewProvider? provider, WebViewCreationProperties webViewCreationProperties)
        : base(webViewCreationProperties.KeepAlive)
    {
        Focusable = true;
        _popup = new AvaloniaPopup()
        {
            PlacementTarget = this,
            //Placement = PlacementMode.Re
        };

        CefWebViewCore webView = new(this, _popup, callback, provider, webViewCreationProperties);
        _popup.SetViewHandlerControl(webView);

        _viewHandlerControl = webView;
        PlatformWebView = webView;
        VirtualViewContext = virtualWebView;
        PlatformViewContext = webView;
    }

    readonly AvaloniaPopup _popup;
    //readonly ToolTip _toolTip;
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
