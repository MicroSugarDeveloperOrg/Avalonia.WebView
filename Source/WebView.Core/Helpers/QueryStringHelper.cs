namespace WebViewCore.Helpers;

public class QueryStringHelper
{
    public static string ContentTypeKey = "Content-Type";

    public static string RemovePossibleQueryString(string? url)
    {
        if (string.IsNullOrEmpty(url))
            return string.Empty;

        var indexOfQueryString = url!.IndexOf("?", 0, url.Length, StringComparison.Ordinal);
        return (indexOfQueryString == -1) ? url : url.Substring(0, indexOfQueryString);
    }
}