namespace Avalonia.WebView.Android;
partial class WebViewHandler
{
    static bool LoadedPropertyChanged()
    {
        SourceProperty.Changed.AddClassHandler<WebViewHandler, string>(async (s, e) =>
        {
            var uri = e.OldValue.Value;
            var uri2 = e.NewValue.Value;

            if (s.AndroidWebView is not null)
            {
                if (!string.IsNullOrWhiteSpace(uri2) && uri != uri2)
                    s.AndroidWebView.LoadUrl(uri2);
            }
            else
                await s.EnsureAndroidWebViewAsync();
        });

        HtmlContentProperty.Changed.AddClassHandler<WebViewHandler, string>(async (s, e) =>
        {
            var content = e.OldValue.Value;
            var content2 = e.NewValue.Value;

            if (s.AndroidWebView is not null)
            {
                if (content != content2 && !string.IsNullOrWhiteSpace(content2))
                    s.AndroidWebView.LoadData(content2, default, default);
            }
            else
                await s.EnsureAndroidWebViewAsync(false);
        });

        return true;
    }

    public static readonly StyledProperty<string> SourceProperty =
           AvaloniaProperty.Register<WebViewHandler, string>(nameof(Source), defaultValue: string.Empty, defaultBindingMode: BindingMode.TwoWay);

    [Category("Common")]
    public string Source
    {
        get => GetValue(SourceProperty);
        set => SetValue(SourceProperty, value);
    }

    public static readonly StyledProperty<string> HtmlContentProperty =
          AvaloniaProperty.Register<WebViewHandler, string>(nameof(HtmlContent), defaultValue: string.Empty, defaultBindingMode: BindingMode.TwoWay);

    [Category("Common")]
    public string HtmlContent
    {
        get => GetValue(HtmlContentProperty);
        set => SetValue(HtmlContentProperty, value);
    }
}
