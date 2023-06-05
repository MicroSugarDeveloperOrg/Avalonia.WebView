namespace Avalonia.WebView.Windows.Core;

partial class WebView2Core
{

    void VerifyNotDisposed()
    {
        if (IsDisposed)
            throw new ObjectDisposedException(typeof(WebView2Core).FullName);
    }

    private void VerifyBrowserNotCrashed()
    {
        if (_browserCrashed)
            throw new InvalidOperationException("The WebView control is no longer valid because the browser process crashed.To work around this, please listen for the CoreWebView2.ProcessFailed event to explicitly manage the lifetime of the WebView2 control in the event of a browser failure.https://docs.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.core.corewebview2.processfailed");
    }

    private void VerifyCoreWebView2()
    {
        if (CoreWebView2 == null)
            throw new InvalidOperationException("Attempted to use WebView2 functionality which requires its CoreWebView2 prior to the CoreWebView2 being initialized.  Call EnsureCoreWebView2Async or set the Source property first.");
    }

    void ReparentController(CoreWebView2Controller coreWebView2Controller, IntPtr hwnd, bool sync = true)
    {
        if (coreWebView2Controller is null)
            return;

        if (hwnd == IntPtr.Zero)
        {
            coreWebView2Controller.IsVisible = false;
            coreWebView2Controller.ParentWindow = IntPtr.Zero;
            return;
        }

        coreWebView2Controller.ParentWindow = hwnd;

        if (sync)
            SyncControllerWithParentWindow(coreWebView2Controller);
    }

    void SyncControllerWithParentWindow(CoreWebView2Controller coreWebView2Controller)
    {
        if (coreWebView2Controller is null)
            return;

        _handler.TryUpdateNativeControlPosition();

        var focusElement = TopLevel.GetTopLevel(_handler)?.FocusManager?.GetFocusedElement();
        if (focusElement == _handler)
            coreWebView2Controller.MoveFocus(CoreWebView2MoveFocusReason.Programmatic);

        coreWebView2Controller.IsVisible = _handler.IsVisible;
    }

    void ResetWebViewSize(CoreWebView2Controller coreWebView2Controller)
    {
        if (coreWebView2Controller is null)
            return;

        double scale = 1;
        var topLevel = TopLevel.GetTopLevel(_handler);
        if (topLevel is not null)
            scale = topLevel.RenderScaling;

        coreWebView2Controller.Bounds = new Rectangle(0, 0, Convert.ToInt32(_handler.Bounds.Width * scale), Convert.ToInt32(_handler.Bounds.Height * scale));
        coreWebView2Controller.NotifyParentWindowPositionChanged();

        return;
    }

    void ApplyDefaultWebViewSettings(CoreWebView2 coreWebView2)
    {
        if (coreWebView2 is null)
            return;

        coreWebView2.Settings.AreDevToolsEnabled = _creationProperties.AreDevToolEnabled;
        coreWebView2.Settings.AreDefaultContextMenusEnabled = _creationProperties.AreDefaultContextMenusEnabled;
        coreWebView2.Settings.IsStatusBarEnabled = _creationProperties.IsStatusBarEnabled;
    }
 
}
