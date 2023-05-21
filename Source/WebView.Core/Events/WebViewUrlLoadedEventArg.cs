using WebViewCore.Enums;

namespace WebViewCore.Events;

public class WebViewUrlLoadedEventArg : EventArgs
{
    public UrlLoadingStrategy UrlLoadingStrategy { get; set; }
}
