using Foundation;
using ObjCRuntime;

namespace WebKit;
internal sealed class WebPolicyDelegateWrapper : BaseWrapper, IWebPolicyDelegate, INativeObject, IDisposable
{
    [Preserve(Conditional = true)]
    public WebPolicyDelegateWrapper(IntPtr handle, bool owns)
        : base(handle, owns)
    {
    }

    [Preserve(Conditional = false)]
    public WebPolicyDelegateWrapper(IntPtr handle)
       : base(handle, false)
    {
    }
}
