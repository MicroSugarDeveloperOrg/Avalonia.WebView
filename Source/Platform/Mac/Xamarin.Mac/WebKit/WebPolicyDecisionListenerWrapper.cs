using Foundation;
using ObjCRuntime;

namespace WebKit;
internal sealed class WebPolicyDecisionListenerWrapper : BaseWrapper, IWebPolicyDecisionListener, INativeObject, IDisposable
{
    [Preserve(Conditional = true)]
    public WebPolicyDecisionListenerWrapper(IntPtr handle, bool owns)
        : base(handle, owns)
    {
    }
}
