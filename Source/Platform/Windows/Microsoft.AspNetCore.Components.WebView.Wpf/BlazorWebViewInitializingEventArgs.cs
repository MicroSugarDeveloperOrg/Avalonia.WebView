using Microsoft.Web.WebView2.Core;

namespace Microsoft.AspNetCore.Components.WebView;
public class BlazorWebViewInitializingEventArgs : EventArgs
{
    public string? BrowserExecutableFolder { get; set; }

    public string? UserDataFolder { get; set; }

    public CoreWebView2EnvironmentOptions? EnvironmentOptions { get; set; }

}