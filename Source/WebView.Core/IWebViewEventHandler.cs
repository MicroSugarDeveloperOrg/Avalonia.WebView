using WebViewCore.Events;

namespace WebViewCore;

public interface IWebViewEventHandler
{
    event EventHandler<WebViewCreatingEventArgs>? WebViewCreating;   
    event EventHandler<WebViewCreatedEventArgs>? WebViewCreated;

    event EventHandler<WebViewUrlLoadingEventArg>? NavigationStarting;
    event EventHandler<WebViewUrlLoadedEventArg>? NavigationCompleted;

    event EventHandler<WebViewMessageReceivedEventArgs>? WebMessageReceived;
    event EventHandler<WebViewNewWindowEventArgs>? WebViewNewWindowRequested;
}
