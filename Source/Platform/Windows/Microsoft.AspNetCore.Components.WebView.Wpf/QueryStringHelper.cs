namespace Microsoft.AspNetCore.Components.WebView;
internal static class QueryStringHelper
{
    public static string RemovePossibleQueryString(string? url)
    {
        if (string.IsNullOrEmpty(url))
        {
            return string.Empty;
        }
        var indexOfQueryString = url.IndexOf('?', StringComparison.Ordinal);
        return (indexOfQueryString == -1)
            ? url
            : url.Substring(0, indexOfQueryString);
    }
}