namespace Avalonia.WebView.Android.Core;

partial class AndroidWebViewCore
{
    internal TopLevel? GetTopLevel() => TopLevel.GetTopLevel(_handler);
}

