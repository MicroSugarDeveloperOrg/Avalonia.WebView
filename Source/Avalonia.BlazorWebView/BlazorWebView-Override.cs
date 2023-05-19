namespace AvaloniaBlazorWebView;

partial class BlazorWebView  
{
    protected override async void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnAttachedToVisualTree(e);
        var viewHandler = _viewHandlerProvider.CreatePlatformWebViewHandler(this, this, config =>
        {
            config.AreDevToolEnabled = _creationProperties.AreDevToolEnabled;
            config.AreDefaultContextMenusEnabled = _creationProperties.AreDefaultContextMenusEnabled;
            config.IsStatusBarEnabled = _creationProperties.IsStatusBarEnabled;
            config.BrowserExecutableFolder = _creationProperties.BrowserExecutableFolder;
            config.UserDataFolder = _creationProperties.UserDataFolder;
            config.Language = _creationProperties.Language;
            config.AdditionalBrowserArguments = _creationProperties.AdditionalBrowserArguments;
            config.ProfileName = _creationProperties.ProfileName;
            config.IsInPrivateModeEnabled = _creationProperties.IsInPrivateModeEnabled;
            config.DefaultWebViewBackgroundColor = _creationProperties.DefaultWebViewBackgroundColor;
        });

        if (viewHandler is null)
            throw new ArgumentNullException(nameof(viewHandler));

        var control = viewHandler.AttachableControl;
        if (control is null)
            return;

        Child = control;
        _platformWebView = viewHandler.PlatformWebView;
        await CreateWebViewManager(_platformWebView);
        if (_webviewManager is null)
            return;

        _webviewManager.Navigate(_startAddress);
    }

    protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnDetachedFromVisualTree(e);
        Child = null;
        _platformWebView?.Dispose();
        _platformWebView = null;
    }

}
