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
}