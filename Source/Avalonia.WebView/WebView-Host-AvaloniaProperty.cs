namespace AvaloniaWebView;

partial class WebView
{
    static bool LoadHostDependencyObjectsChanged()
    {
        UrlProperty.Changed.AddClassHandler<WebView, Uri?>(async (s, e) =>
        {
            var oldValue = e.OldValue.Value;
            var newValue = e.NewValue.Value;
            await s.Navigate(newValue);
        });

        HtmlContentProperty.Changed.AddClassHandler<WebView, string?>(async (s, e) => 
        {
            var newValue = e.NewValue.Value;
            await s.NavigateToString(newValue);
        });

        return true;
    }

    public static readonly StyledProperty<Uri?> UrlProperty =
           AvaloniaProperty.Register<WebView, Uri?>(nameof(Url));

    public static readonly StyledProperty<string?> HtmlContentProperty =
           AvaloniaProperty.Register<WebView, string?>(nameof(HtmlContent));

    public Uri? Url
    {
        get => GetValue(UrlProperty);
        set => SetValue(UrlProperty, value);
    }

    public string? HtmlContent
    {
        get => GetValue(HtmlContentProperty);
        set => SetValue(HtmlContentProperty, value);
    }
  
}
