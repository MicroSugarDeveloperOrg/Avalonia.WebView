using Foundation;
using ObjCRuntime;

namespace WebKit;
internal sealed class WebFrameLoadDelegateWrapper : BaseWrapper, IWebFrameLoadDelegate, INativeObject, IDisposable
{
    [Preserve(Conditional = true)]
    public WebFrameLoadDelegateWrapper(IntPtr handle, bool owns)
        : base(handle, owns)
    {
    }

    [Preserve(Conditional = false)]
    public WebFrameLoadDelegateWrapper(IntPtr handle)
       : base(handle, false)
    {
    }
}