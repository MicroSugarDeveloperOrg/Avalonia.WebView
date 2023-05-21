namespace WebViewCore.Extensions;

public static class UriExtensions
{
    public static bool IsBaseOfPage(this Uri baseUri, string? uriString)
    {
        if (Path.HasExtension(uriString))
            return false;

        var uri = new Uri(uriString!);
        return baseUri.IsBaseOf(uri);
    }
}