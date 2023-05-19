using Android.OS;
using AndroidNetUri = Android.Net.Uri;

namespace Avalonia.WebView.Android.Clients;
internal class AvaloniaWebChromeClient : WebChromeClient
{
    public override bool OnCreateWindow(AndroidWebView? view, bool isDialog, bool isUserGesture, Message? resultMsg)
    {
        if (view?.Context is not null)
        {
            // Intercept _blank target <a> tags to always open in device browser
            // regardless of UrlLoadingStrategy.OpenInWebview
            var requestUrl = view.GetHitTestResult().Extra;
            var intent = new Intent(Intent.ActionView, AndroidNetUri.Parse(requestUrl));
            view.Context.StartActivity(intent);
        }

        // We don't actually want to create a new WebView window so we just return false 
        return false;
    }
}
