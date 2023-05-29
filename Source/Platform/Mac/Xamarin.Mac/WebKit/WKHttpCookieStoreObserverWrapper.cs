using Foundation;
using ObjCRuntime;

namespace WebKit;
internal class WKHttpCookieStoreObserverWrapper : BaseWrapper, IWKHttpCookieStoreObserver
{
    [Preserve(Conditional = true)]
    public WKHttpCookieStoreObserverWrapper(IntPtr handle, bool owns)
    : base(handle, owns)
    {
    }
}
