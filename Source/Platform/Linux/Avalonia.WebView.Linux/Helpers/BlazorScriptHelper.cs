namespace Avalonia.WebView.Linux.Helpers;
internal class BlazorScriptHelper
{
    public const string BlazorStartingScript =
        """
			window.__receiveMessageCallbacks = [];
		
		    window.__dispatchMessageCallback = function(message) {
		        window.__receiveMessageCallbacks.forEach(function(callback) { callback(message); });
		    };
		    
		    window.external = {
		        sendMessage: function(message) {
		            window.webkit.messageHandlers.webview.postMessage(message);
		        },
		        receiveMessage: function(callback) {
		            window.__receiveMessageCallbacks.push(callback);
		        }
		    };

		    Blazor.start();
		""";
}
