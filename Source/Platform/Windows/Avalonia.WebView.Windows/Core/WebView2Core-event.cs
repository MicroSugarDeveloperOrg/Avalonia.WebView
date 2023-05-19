using System.Runtime.InteropServices;

namespace Avalonia.WebView.Windows.Core;

partial class WebView2Core
{
    void RegisterEvents()
    {
        _handler.SizeChanged += HostControl_SizeChanged;
        _handler.PlatformHandlerChanged += Handler_PlatformHandlerChanged;
    }

    void UnregisterEvents()
    {
        _handler.SizeChanged -= HostControl_SizeChanged;
        _handler.PlatformHandlerChanged -= Handler_PlatformHandlerChanged;
    }

    void RegisterWebViewEvents(CoreWebView2Controller coreWebView2Controller)
    {
        if (coreWebView2Controller is null)
            return;

        if (!_browserHitTransparent)
            coreWebView2Controller.AcceleratorKeyPressed += CoreWebView2Controller_AcceleratorKeyPressed; ;

        coreWebView2Controller.GotFocus += CoreWebView2Controller_GotFocus;
        coreWebView2Controller.LostFocus += CoreWebView2Controller_LostFocus;
        coreWebView2Controller.MoveFocusRequested += CoreWebView2Controller_MoveFocusRequested;
        coreWebView2Controller.ZoomFactorChanged += CoreWebView2Controller_ZoomFactorChanged;

        var corewebview2 = coreWebView2Controller.CoreWebView2;
        if (corewebview2 is null)
            return;

        corewebview2.NewWindowRequested += CoreWebView2_NewWindowRequested;
        corewebview2.ContentLoading += CoreWebView2_ContentLoading;
        corewebview2.HistoryChanged += CoreWebView2_HistoryChanged;
        corewebview2.NavigationCompleted += CoreWebView2_NavigationCompleted;
        corewebview2.NavigationStarting += CoreWebView2_NavigationStarting;
        corewebview2.ProcessFailed += CoreWebView2_ProcessFailed;
        corewebview2.SourceChanged += CoreWebView2_SourceChanged;
        corewebview2.WebMessageReceived += CoreWebView2_WebMessageReceived;
        corewebview2.WebResourceRequested += CoreWebView2_WebResourceRequested;
        corewebview2.DOMContentLoaded += CoreWebView2_DOMContentLoaded;
        corewebview2.Profile.Deleted += Profile_Deleted;
    }

    void UnregisterWebViewEvents(CoreWebView2Controller coreWebView2Controller, bool browserCrashed = false)
    {
        if (coreWebView2Controller is null)
            return;

        var corewebview2 = coreWebView2Controller.CoreWebView2;

        if (!_browserHitTransparent)
            coreWebView2Controller.AcceleratorKeyPressed -= CoreWebView2Controller_AcceleratorKeyPressed; ;

        coreWebView2Controller.GotFocus -= CoreWebView2Controller_GotFocus;
        coreWebView2Controller.LostFocus -= CoreWebView2Controller_LostFocus;
        coreWebView2Controller.MoveFocusRequested -= CoreWebView2Controller_MoveFocusRequested;
        coreWebView2Controller.ZoomFactorChanged -= CoreWebView2Controller_ZoomFactorChanged;
        coreWebView2Controller.Close();

        if (corewebview2 is null)
            return;

        corewebview2.NewWindowRequested -= CoreWebView2_NewWindowRequested;
        corewebview2.ContentLoading -= CoreWebView2_ContentLoading;
        corewebview2.HistoryChanged -= CoreWebView2_HistoryChanged;
        corewebview2.NavigationCompleted -= CoreWebView2_NavigationCompleted;
        corewebview2.NavigationStarting -= CoreWebView2_NavigationStarting;
        corewebview2.ProcessFailed -= CoreWebView2_ProcessFailed;
        corewebview2.SourceChanged -= CoreWebView2_SourceChanged;
        corewebview2.WebMessageReceived -= CoreWebView2_WebMessageReceived;
        corewebview2.WebResourceRequested -= CoreWebView2_WebResourceRequested;
        corewebview2.DOMContentLoaded -= CoreWebView2_DOMContentLoaded;
        corewebview2.Profile.Deleted -= Profile_Deleted;
    }

    private void HostControl_SizeChanged(object sender, SizeChangedEventArgs e)
    {
        if (_coreWebView2Controller is null)
            return;

        double scale = 1;
        var topLevel = TopLevel.GetTopLevel(_handler);
        if (topLevel is not null)
            scale = topLevel.RenderScaling;

        _coreWebView2Controller.Bounds = new Rectangle(0, 0, Convert.ToInt32(e.NewSize.Width * scale), Convert.ToInt32(e.NewSize.Height * scale));
        _coreWebView2Controller.NotifyParentWindowPositionChanged();
    }

    private void Handler_PlatformHandlerChanged(object sender, EventArgs e)
    {
        if (_handler.RefHandler.Handle != IntPtr.Zero)
        {
            NativeHandler = _handler.RefHandler.Handle;
            _hwndTaskSource.SetResult(_handler.RefHandler.Handle);
        }
    }


}
