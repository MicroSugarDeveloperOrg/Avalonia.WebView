namespace Avalonia.WebView.Linux.Core;

partial class LinuxWebViewCore 
{
    static bool LoadedPropertyChanged()
    {
        SourceProperty.Changed.AddClassHandler<LinuxWebViewCore, string>(async (s, e) =>
        {
            var uri = e.OldValue.Value;
            var uri2 = e.NewValue.Value;


            if (s.WebView is not null)
            {
                if (uri != uri2 && !string.IsNullOrWhiteSpace(uri2))
                    s.WebView.LoadUri(uri2);
            }
            else
                await s.EnsureAndroidWebViewAsync();
        });

        HtmlContentProperty.Changed.AddClassHandler<LinuxWebViewCore, string>(async (s, e) =>
        {
            var content = e.OldValue.Value;
            var content2 = e.NewValue.Value;

            if (s.WebView is not null)
            {
                if (content != content2 && !string.IsNullOrWhiteSpace(content2))
                    s.WebView.LoadHtml(content2);
            }
            else
                await s.EnsureAndroidWebViewAsync(false);
        });

        return true;
    }

    public static readonly StyledProperty<string> SourceProperty =
           AvaloniaProperty.Register<LinuxWebViewCore, string>(nameof(Source), defaultValue: string.Empty, defaultBindingMode: BindingMode.TwoWay);

    [Category("Common")]
    public string Source
    {
        get => GetValue(SourceProperty);
        set => SetValue(SourceProperty, value);
    }

    public static readonly StyledProperty<string> HtmlContentProperty =
         AvaloniaProperty.Register<LinuxWebViewCore, string>(nameof(HtmlContent), defaultValue: string.Empty, defaultBindingMode: BindingMode.TwoWay);

    [Category("Common")]
    public string HtmlContent
    {
        get => GetValue(HtmlContentProperty);
        set => SetValue(HtmlContentProperty, value);
    }
}
