namespace WebViewCore.Events;

public class WebViewMessageReceivedEventArgs : EventArgs
{
    public required string Source { get; set; }

    public required string Message { get; set; }

    public string? MessageAsJson { get; set; }
}