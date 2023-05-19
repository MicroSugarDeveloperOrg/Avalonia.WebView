namespace Microsoft.AspNetCore.Components.WebView;
public class UrlLoadingEventArgs : EventArgs
{
    internal static UrlLoadingEventArgs CreateWithDefaultLoadingStrategy(Uri urlToLoad, Uri appOriginUri)
    {
        var strategy = appOriginUri.IsBaseOf(urlToLoad) ?
            UrlLoadingStrategy.OpenInWebView :
            UrlLoadingStrategy.OpenExternally;

        return new(urlToLoad, strategy);
    }

    private UrlLoadingEventArgs(Uri url, UrlLoadingStrategy urlLoadingStrategy)
    {
        Url = url;
        UrlLoadingStrategy = urlLoadingStrategy;
    }
 
    public Uri Url { get; }

 
    public UrlLoadingStrategy UrlLoadingStrategy { get; set; }
}