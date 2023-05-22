namespace Avalonia.WebView.Android.Helpers;
internal class BlazorScriptHelper
{
    public const string BlazorStartedScript =
        """
            (function() { return typeof(window.__BlazorStarted); })();
        """;

    public const string UndefinedString =
        """
        "undefined"
        """;

    public const string BlazorMessageScript =
        """
            const channel = new MessageChannel();
        		var nativeJsPortOne = channel.port1;
        		var nativeJsPortTwo = channel.port2;
        		window.addEventListener('message', function (event) {
        			if (event.data != 'capturePort') {
        				nativeJsPortOne.postMessage(event.data)
        			}
        			else if (event.data == 'capturePort') {
        				if (event.ports[0] != null) {
        					nativeJsPortTwo = event.ports[0]
        				}
        			}
        		}, false);
        
        		nativeJsPortOne.addEventListener('message', function (event) {
        		}, false);
        
        		nativeJsPortTwo.addEventListener('message', function (event) {
        			// data from native code to JS
        			if (window.external.__callback) {
        				window.external.__callback(event.data);
        			}
        		}, false);
        		nativeJsPortOne.start();
        		nativeJsPortTwo.start();
        
        		window.external.sendMessage = function (message) {
        			// data from JS to native code
        			nativeJsPortTwo.postMessage(message);
        		};
        
        		window.external.receiveMessage = function (callback) {
        			window.external.__callback = callback;
        		}
        """;

    public const string BlazorStartingScript =
        """
            Blazor.start();
        	window.__BlazorStarted = true;
        """;

}
