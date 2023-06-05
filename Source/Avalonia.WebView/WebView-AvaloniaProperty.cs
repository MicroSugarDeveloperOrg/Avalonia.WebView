namespace AvaloniaWebView;

partial class WebView
{
    static bool LoadDependencyObjectsChanged()
    {
        ChildProperty.Changed.AddClassHandler<WebView, Control?>((x, e) => x.ChildChanged(e));

        EmptyViewerProperty.Changed.AddClassHandler<WebView, object?>((x, e) => x.HeaderChanged(e));

        return true;
    }

    private static readonly StyledProperty<Control?> ChildProperty =
            AvaloniaProperty.Register<WebView, Control?>(nameof(Child));

    public static readonly StyledProperty<Thickness> PaddingProperty =
           AvaloniaProperty.Register<WebView, Thickness>(nameof(Padding), defaultValue: new Thickness(0));

    public static readonly StyledProperty<IBrush?> BackgroundProperty =
           AvaloniaProperty.Register<WebView, IBrush?>(nameof(Background));

    public static readonly StyledProperty<IBrush?> BorderBrushProperty =
           AvaloniaProperty.Register<WebView, IBrush?>(nameof(BorderBrush));

    public static readonly StyledProperty<Thickness> BorderThicknessProperty =
           AvaloniaProperty.Register<WebView, Thickness>(nameof(BorderThickness));

    public static readonly StyledProperty<CornerRadius> CornerRadiusProperty =
           AvaloniaProperty.Register<WebView, CornerRadius>(nameof(CornerRadius));

    public static readonly StyledProperty<BoxShadows> BoxShadowProperty =
           AvaloniaProperty.Register<WebView, BoxShadows>(nameof(BoxShadow));

    public static readonly StyledProperty<object?> EmptyViewerProperty =
           AvaloniaProperty.Register<WebView, object?>(nameof(EmptyViewer));

    public static readonly StyledProperty<IDataTemplate?> EmptyViewerTemplateProperty =
           AvaloniaProperty.Register<WebView, IDataTemplate?>(nameof(EmptyViewerTemplate));

    [Content]
    private Control? Child
    {
        get => GetValue(ChildProperty);
        set => SetValue(ChildProperty, value);
    }

    private Thickness LayoutThickness
    {
        get
        {
            VerifyScale();

            if (_layoutThickness == null)
            {
                var borderThickness = BorderThickness;

                if (UseLayoutRounding)
                    borderThickness = LayoutHelper.RoundLayoutThickness(borderThickness, _scale, _scale);

                _layoutThickness = borderThickness;
            }

            return _layoutThickness.Value;
        }
    }

    public Thickness Padding
    {
        get => GetValue(PaddingProperty);
        set => SetValue(PaddingProperty, value);
    }

    public IBrush? Background
    {
        get => GetValue(BackgroundProperty);
        set => SetValue(BackgroundProperty, value);
    }

    public IBrush? BorderBrush
    {
        get => GetValue(BorderBrushProperty);
        set => SetValue(BorderBrushProperty, value);
    }

    public Thickness BorderThickness
    {
        get => GetValue(BorderThicknessProperty);
        set => SetValue(BorderThicknessProperty, value);
    }

    public CornerRadius CornerRadius
    {
        get => GetValue(CornerRadiusProperty);
        set => SetValue(CornerRadiusProperty, value);
    }

    public BoxShadows BoxShadow
    {
        get => GetValue(BoxShadowProperty);
        set => SetValue(BoxShadowProperty, value);
    }

    public object? EmptyViewer
    {
        get => GetValue(EmptyViewerProperty);
        set => SetValue(EmptyViewerProperty, value);
    }

    public IDataTemplate? EmptyViewerTemplate
    {
        get => GetValue(EmptyViewerTemplateProperty);
        set => SetValue(EmptyViewerTemplateProperty, value);
    }

    private void VerifyScale()
    {
        var currentScale = LayoutHelper.GetLayoutScale(this);
        if (MathUtilities.AreClose(currentScale, _scale))
            return;

        _scale = currentScale;
        _layoutThickness = null;
    }

    protected sealed override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        base.OnPropertyChanged(change);
        switch (change.Property.Name)
        {
            case nameof(UseLayoutRounding):
            case nameof(BorderThickness):
                _layoutThickness = null;
                break;
            //case nameof(CornerRadius):
            //    if (_borderVisual != null)
            //        _borderVisual.CornerRadius = CornerRadius;
            //    break;
        }
    }

    private void ChildChanged(AvaloniaPropertyChangedEventArgs e)
    {
        var oldChild = (Control?)e.OldValue;
        var newChild = (Control?)e.NewValue;

        if (oldChild != null)
        {
            ((ISetLogicalParent)oldChild).SetParent(null);
            LogicalChildren.Clear();
            VisualChildren.Remove(oldChild);
        }

        if (newChild != null)
        {
            ((ISetLogicalParent)newChild).SetParent(this);
            VisualChildren.Add(newChild);
            LogicalChildren.Add(newChild);
        }
    }

    private void HeaderChanged(AvaloniaPropertyChangedEventArgs e)
    {


    }
}
