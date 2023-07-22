using Avalonia.Controls;

namespace SampleWebView.Views;
public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        //PART_Button.Click += PART_Button_Click;
        PART_WebView.WebViewNewWindowRequested += PART_WebView_WebViewNewWindowRequested;
    }

    private void PART_WebView_WebViewNewWindowRequested(object? sender, WebViewCore.Events.WebViewNewWindowEventArgs e)
    {
        e.UrlLoadingStrategy = WebViewCore.Enums.UrlRequestStrategy.OpenInWebView;
    }

    private void PART_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Window window = new()
        {
            Height = 600,
            Width = 600,
        };
        window.Show();
    }
}