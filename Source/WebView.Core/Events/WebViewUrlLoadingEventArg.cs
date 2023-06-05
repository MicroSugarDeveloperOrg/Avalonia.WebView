using WebViewCore.Enums;

namespace WebViewCore.Events;
public class WebViewUrlLoadingEventArg : EventArgs
{
    public Uri? Url { get; set; } 
}
