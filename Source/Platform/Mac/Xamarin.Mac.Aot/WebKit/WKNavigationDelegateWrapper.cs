using Foundation;
using ObjCRuntime;

namespace WebKit;

internal sealed class WKNavigationDelegateWrapper : BaseWrapper, IWKNavigationDelegate
{
    [Preserve(Conditional = true)]
    public WKNavigationDelegateWrapper(IntPtr handle, bool owns)
        : base(handle, owns)
    {
    }

    [Preserve(Conditional = false)]
    public WKNavigationDelegateWrapper(IntPtr handle)
       : base(handle, false)
    {
    }
}
