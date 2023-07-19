namespace WebViewCore.Events;
public class WebViewCreatingEventArgs : EventArgs
{
    public bool Handled { get; set; }

    public object? RawArgs { get; set; }
}
