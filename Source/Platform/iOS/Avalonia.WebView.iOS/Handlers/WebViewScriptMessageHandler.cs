namespace Avalonia.WebView.iOS.Handlers;

sealed class WebViewScriptMessageHandler : NSObject, IWKScriptMessageHandler
{
    internal const string AppOrigin = "app://" + "0.0.0.0" + "/";
    internal static readonly Uri AppOriginUri = new(AppOrigin);

    private Action<Uri, string> _messageReceivedAction;

    public WebViewScriptMessageHandler(Action<Uri, string> messageReceivedAction)
    {
        _messageReceivedAction = messageReceivedAction ?? throw new ArgumentNullException(nameof(messageReceivedAction));
    }

    public void DidReceiveScriptMessage(WKUserContentController userContentController, WKScriptMessage message)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }
        _messageReceivedAction(AppOriginUri, ((NSString)message.Body).ToString());
    }
}