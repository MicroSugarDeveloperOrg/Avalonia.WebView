namespace Avalonia.WebView.iOS.Handlers;

internal sealed class WebViewScriptMessageHandler : NSObject, IWKScriptMessageHandler
{
    public WebViewScriptMessageHandler(Uri baseUri, Action<Uri, string> messageReceivedAction)
    {
        _baseUri = baseUri;
        _messageReceivedAction = messageReceivedAction ?? throw new ArgumentNullException(nameof(messageReceivedAction));
    }

    readonly Uri _baseUri;
    readonly Action<Uri, string> _messageReceivedAction;

    public void DidReceiveScriptMessage(WKUserContentController userContentController, WKScriptMessage message)
    {
        if (message is null) throw new ArgumentNullException(nameof(message));
        _messageReceivedAction(_baseUri, ((NSString)message.Body).ToString());
    }
}