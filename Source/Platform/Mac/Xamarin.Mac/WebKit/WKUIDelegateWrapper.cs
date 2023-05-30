using Foundation;
using ObjCRuntime;

namespace WebKit;

internal sealed class WKUIDelegateWrapper : BaseWrapper, IWKUIDelegate 
{
    [Preserve(Conditional = true)]
    public WKUIDelegateWrapper(IntPtr handle, bool owns)
        : base(handle, owns)
    {
    }

    [Preserve(Conditional = false)]
    public WKUIDelegateWrapper(IntPtr handle)
        : base(handle, false)
    {
    }
}