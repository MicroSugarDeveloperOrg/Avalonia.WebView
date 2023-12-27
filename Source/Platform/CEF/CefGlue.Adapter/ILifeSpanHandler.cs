namespace CefGlue.Adapter;
public interface ILifeSpanHandler
{
    void OnAfterCreated(CefBrowser browser);
    bool OnBeforePopup(CefBrowser browser, CefFrame frame, string targetUrl, string targetFrameName, CefWindowOpenDisposition targetDisposition, bool userGesture, CefPopupFeatures popupFeatures, CefWindowInfo windowInfo, ref CefClient client, CefBrowserSettings settings, ref CefDictionaryValue extraInfo, ref bool noJavascriptAccess);
    void OnBeforeClose(CefBrowser browser);
    
}
