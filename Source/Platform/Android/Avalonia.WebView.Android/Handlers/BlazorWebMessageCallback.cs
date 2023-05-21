namespace Avalonia.WebView.Android.Handlers;

internal class BlazorWebMessageCallback : WebMessagePort.WebMessageCallback
{
    private readonly Action<string?> _onMessageReceived;

    public BlazorWebMessageCallback(Action<string?> onMessageReceived)
    {
        _onMessageReceived = onMessageReceived ?? throw new ArgumentNullException(nameof(onMessageReceived));
    }

    public override void OnMessage(WebMessagePort? port, WebMessage? message)
    {
        if (message is null)
            throw new ArgumentNullException(nameof(message));

        _onMessageReceived(message.Data);
    }
}