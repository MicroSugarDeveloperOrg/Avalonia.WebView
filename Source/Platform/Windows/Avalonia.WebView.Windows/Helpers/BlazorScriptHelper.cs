namespace Avalonia.WebView.Windows.Helpers;
internal static class BlazorScriptHelper
{
    public const string BlazorStartingScript = 
            """
				window.external = {
					sendMessage: message => {
						window.chrome.webview.postMessage(message);
					},
					receiveMessage: callback => {
						window.chrome.webview.addEventListener('message', e => callback(e.data));
					}
				};
			""";

    public const string BlazorStaredScript =
        """
            Blazor.start();
        """;
}
