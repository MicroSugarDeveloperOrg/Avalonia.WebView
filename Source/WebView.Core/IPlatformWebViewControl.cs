namespace WebViewCore;
public interface IPlatformWebViewControl
{
    Task<bool> Initialize(IVirtualWebViewProvider? virtualProvider);

    bool IsInitialized { get; }

    bool IsCanGoForward { get; }
    bool IsCanGoBack { get; }

    bool Navigate(Uri? uri);
    bool NavigateToString(string htmlContent);

    bool GoBack();
    bool GoForward();
    bool Stop();
    bool Reload();

    Task<string?> ExecuteScriptAsync(string javaScript);

    bool PostWebMessageAsJson(string webMessageAsJson);
    bool PostWebMessageAsString(string webMessageAsString);

    bool OpenDevToolsWindow();
}
