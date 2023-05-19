namespace WebViewCore.Events;
public class WebViewCreatedEventArgs
{
    public required bool IsSucceed { get; set; }

    public string? Message { get; set; }
}
