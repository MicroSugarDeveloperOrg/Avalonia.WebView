using WebView2Control = Microsoft.Web.WebView2.Wpf.WebView2;

namespace Microsoft.AspNetCore.Components.WebView;
public class BlazorWebViewInitializedEventArgs : EventArgs
{
    public WebView2Control? WebView { get; internal set; }

}