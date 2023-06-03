using Avalonia.Threading;

namespace AvaloniaWebView;

public sealed partial class  WebView : Control, IVirtualWebView<WebView>, IEmptyView, IWebViewEventHandler, IVirtualWebViewControlCallBack, IWebViewControl
{
    static WebView()
    {
        AffectsRender<WebView>(BackgroundProperty, BorderBrushProperty, BorderThicknessProperty, CornerRadiusProperty, BoxShadowProperty);
        AffectsMeasure<WebView>(ChildProperty, PaddingProperty, BorderThicknessProperty);
        LoadDependencyObjectsChanged();
        LoadHostDependencyObjectsChanged();
    }

    public WebView()
        : this(default)
    {

    }

    public WebView(IServiceProvider? serviceProvider = default)
    {
        var properties = AvaloniaLocator.Current.GetService<WebViewCreationProperties>();
        _creationProperties = properties ?? new WebViewCreationProperties();

        _viewHandlerProvider = AvaloniaLocator.Current.GetRequiredService<IViewHandlerProvider>();
        ClipToBounds = false;

        _partEmptyViewPresenter = new()
        {
            [!ContentPresenter.ContentProperty] = this[!EmptyViewerProperty],
            [!ContentPresenter.ContentTemplateProperty] = this[!EmptyViewerTemplateProperty],
        };

        _partInnerContainer = new()
        {
            Child = _partEmptyViewPresenter,
            ClipToBounds = true,
            [!Border.CornerRadiusProperty] = this[!CornerRadiusProperty]
        };
        //Child = _partInnerContainer;

        //Loaded += (s, e) =>
        //{
        //    Dispatcher.UIThread.InvokeAsync(() =>
        //    {
        //        _= Navigate(Url);
        //        _= NavigateToString(HtmlContent);
        //    });
        //};
    }

    readonly WebViewCreationProperties _creationProperties;
    readonly BorderRenderHelper _borderRenderHelper = new();
    readonly IViewHandlerProvider _viewHandlerProvider;

    readonly Border _partInnerContainer;
    readonly ContentPresenter _partEmptyViewPresenter;

    double _scale;
    Thickness? _layoutThickness;

    IPlatformWebView? _platformWebView;
    public IPlatformWebView? PlatformWebView => _platformWebView;
}
