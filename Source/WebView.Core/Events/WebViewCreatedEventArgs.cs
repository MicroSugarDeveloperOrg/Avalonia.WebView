namespace WebViewCore.Events;
public class WebViewCreatedEventArgs : EventArgs
{
    public required bool IsSucceed { get; set; }

    public string? Message { get; set; }

    public object? RawArgs { get; set; }
}
