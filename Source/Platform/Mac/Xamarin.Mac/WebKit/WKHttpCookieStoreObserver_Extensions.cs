using ObjCRuntime;

namespace WebKit;

public static class WKHttpCookieStoreObserver_Extensions
{
    public static void CookiesDidChangeInCookieStore(this IWKHttpCookieStoreObserver This, WKHttpCookieStore cookieStore)
    {
        if (cookieStore == null)
            throw new ArgumentNullException("cookieStore");

        Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("cookiesDidChangeInCookieStore:"), cookieStore.Handle);
    }
}
