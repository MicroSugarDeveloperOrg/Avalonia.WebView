namespace WebViewCore.Events;

public class WebViewMessageReceivedEventArgs : EventArgs
{
    public required Uri Source { get; set; }

    public required string Message { get; set; }

    public string? MessageAsJson { get; set; }

    public object? RawArgs { get; set; }
}