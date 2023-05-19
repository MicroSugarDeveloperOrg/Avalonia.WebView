namespace Avalonia.WebView.iOS;
internal class BlaozeWebViewHandlerProvider : IPlatformBlazorWebViewProvider
{
    public string Scheme => "app";

    public string GetBlazorStartupScript()
    {
        throw new NotImplementedException();
    }
}
