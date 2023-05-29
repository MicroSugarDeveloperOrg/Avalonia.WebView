using Foundation;
using ObjCRuntime;

namespace WebKit;
internal sealed class WebDownloadDelegateWrapper : BaseWrapper, IWebDownloadDelegate
{
    [Preserve(Conditional = true)]
    public WebDownloadDelegateWrapper(IntPtr handle, bool owns)
        : base(handle, owns)
    {
    }
}
