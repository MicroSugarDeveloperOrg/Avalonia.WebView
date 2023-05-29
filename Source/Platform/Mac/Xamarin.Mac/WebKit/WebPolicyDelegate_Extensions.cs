using Foundation;
using ObjCRuntime;

namespace WebKit;


public static class WebPolicyDelegate_Extensions
{
    public static void DecidePolicyForNavigation(this IWebPolicyDelegate This, WebView webView, NSDictionary actionInformation, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
    {
        if (webView == null)
        {
            throw new ArgumentNullException("webView");
        }
        if (actionInformation == null)
        {
            throw new ArgumentNullException("actionInformation");
        }
        if (request == null)
        {
            throw new ArgumentNullException("request");
        }
        if (frame == null)
        {
            throw new ArgumentNullException("frame");
        }
        if (decisionToken == null)
        {
            throw new ArgumentNullException("decisionToken");
        }
        Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:decidePolicyForNavigationAction:request:frame:decisionListener:"), webView.Handle, actionInformation.Handle, request.Handle, frame.Handle, decisionToken.Handle);
    }

    public static void DecidePolicyForNewWindow(this IWebPolicyDelegate This, WebView webView, NSDictionary actionInformation, NSUrlRequest request, string newFrameName, NSObject decisionToken)
    {
        if (webView == null)
        {
            throw new ArgumentNullException("webView");
        }
        if (actionInformation == null)
        {
            throw new ArgumentNullException("actionInformation");
        }
        if (request == null)
        {
            throw new ArgumentNullException("request");
        }
        if (newFrameName == null)
        {
            throw new ArgumentNullException("newFrameName");
        }
        if (decisionToken == null)
        {
            throw new ArgumentNullException("decisionToken");
        }
        IntPtr intPtr = NSString.CreateNative(newFrameName);
        Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:decidePolicyForNewWindowAction:request:newFrameName:decisionListener:"), webView.Handle, actionInformation.Handle, request.Handle, intPtr, decisionToken.Handle);
        NSString.ReleaseNative(intPtr);
    }

    public static void DecidePolicyForMimeType(this IWebPolicyDelegate This, WebView webView, string mimeType, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
    {
        if (webView == null)
        {
            throw new ArgumentNullException("webView");
        }
        if (mimeType == null)
        {
            throw new ArgumentNullException("mimeType");
        }
        if (request == null)
        {
            throw new ArgumentNullException("request");
        }
        if (frame == null)
        {
            throw new ArgumentNullException("frame");
        }
        if (decisionToken == null)
        {
            throw new ArgumentNullException("decisionToken");
        }
        IntPtr intPtr = NSString.CreateNative(mimeType);
        Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:decidePolicyForMIMEType:request:frame:decisionListener:"), webView.Handle, intPtr, request.Handle, frame.Handle, decisionToken.Handle);
        NSString.ReleaseNative(intPtr);
    }

    public static void UnableToImplementPolicy(this IWebPolicyDelegate This, WebView webView, NSError error, WebFrame frame)
    {
        if (webView == null)
        {
            throw new ArgumentNullException("webView");
        }
        if (error == null)
        {
            throw new ArgumentNullException("error");
        }
        if (frame == null)
        {
            throw new ArgumentNullException("frame");
        }
        Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:unableToImplementPolicyWithError:frame:"), webView.Handle, error.Handle, frame.Handle);
    }
}
