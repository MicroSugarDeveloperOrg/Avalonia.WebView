namespace WebViewCore.Enums;

public enum UrlRequestStrategy
{
    /// <summary>
    /// Allows loading URLs using an app determined by the system.
    /// This is the default strategy for URLs with an external host.
    /// </summary>
    OpenExternally,

    /// <summary>
    /// Allows loading URLs within the Blazor WebView.
    /// This is the default strategy for URLs with a host matching the app origin.
    /// <para>
    /// This strategy should not be used for external links unless you can ensure they are fully trusted.
    /// </para>
    /// </summary>
    OpenInWebView,

    /// <summary>
    /// Allows loading URLs within the Blazor WebView.
    /// This is the default strategy for URLs with a host matching the app origin.
    /// <para>
    /// This strategy should not be used for external links unless you can ensure they are fully trusted.
    /// </para>
    /// </summary>
    OpenInNewWindow,

    /// <summary>
    /// Cancels the current URL loading attempt.
    /// </summary>
    CancelLoad
}