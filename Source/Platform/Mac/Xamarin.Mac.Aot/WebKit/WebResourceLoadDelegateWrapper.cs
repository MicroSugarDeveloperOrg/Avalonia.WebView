using Foundation;
using ObjCRuntime;

namespace WebKit;
internal sealed class WebResourceLoadDelegateWrapper : BaseWrapper, IWebResourceLoadDelegate, INativeObject, IDisposable
{
    [Preserve(Conditional = true)]
    public WebResourceLoadDelegateWrapper(IntPtr handle, bool owns)
        : base(handle, owns)
    {
    }

    [Preserve(Conditional = false)]
    public WebResourceLoadDelegateWrapper(IntPtr handle)
    : base(handle, false)
    {
    }
}
