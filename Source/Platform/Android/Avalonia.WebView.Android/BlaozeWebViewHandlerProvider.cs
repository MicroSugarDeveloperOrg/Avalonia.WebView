namespace Avalonia.WebView.Android;
internal class BlaozeWebViewHandlerProvider : IPlatformBlazorWebViewProvider
{
    public string Scheme => "https";

    public string GetBlazorStartupScript()
    {
        throw new NotImplementedException();
    }
}
