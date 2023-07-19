namespace WebViewCore.Events;

public class WebViewUrlLoadedEventArg : EventArgs
{
    public bool IsSuccess { get; internal set; }
    public object? RawArgs { get; set; }
}
