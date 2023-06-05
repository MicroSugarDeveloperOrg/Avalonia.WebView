using WebViewCore.Enums;

namespace WebViewCore.Events;
public class WebViewNewWindowEventArgs : EventArgs
{
    public Uri? Url { get; set; }
    public required UrlLoadingStrategy UrlLoadingStrategy { get; set; }
}
