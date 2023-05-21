namespace WebViewCore.Models;

public class WebResourceResponse
{
    public required int StatusCode { get; set; }
    public required string StatusMessage { get; set; }
    public required Stream Content { get; set; }
    public required IDictionary<string, string> Headers { get; set; }
}