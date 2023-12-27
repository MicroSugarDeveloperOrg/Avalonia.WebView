namespace AvaloniaWebView;

partial class WebView
{
    protected override Size MeasureOverride(Size availableSize)
    {
        return LayoutHelper.MeasureChild(Child, availableSize, Padding, BorderThickness);
    }

    protected override Size ArrangeOverride(Size finalSize)
    {
        return LayoutHelper.ArrangeChild(Child, finalSize, Padding, BorderThickness);
    }

    public override void Render(DrawingContext context)
    {
        _borderRenderHelper.Render(context, Bounds.Size, LayoutThickness, CornerRadius, Background, BorderBrush, BoxShadow);
    }

    protected override async void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnAttachedToVisualTree(e);
        var viewHandler = _viewHandlerProvider.CreatePlatformWebViewHandler(this, this, default, config =>
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
        //Child = control;
        _partInnerContainer.Child = control;
        _platformWebView = viewHandler.PlatformWebView;

        await Navigate(Url);
        await NavigateToString(HtmlContent);
    }

    protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnDetachedFromVisualTree(e);
        //Child = null;
        _partInnerContainer.Child = null;
        _platformWebView?.Dispose();
        _platformWebView = null;
    }
}
