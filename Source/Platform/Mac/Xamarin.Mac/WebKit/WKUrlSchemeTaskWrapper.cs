using Foundation;
using ObjCRuntime;

namespace WebKit;

internal sealed class WKUrlSchemeTaskWrapper : BaseWrapper, IWKUrlSchemeTask
{
    [Preserve(Conditional = true)]
    public WKUrlSchemeTaskWrapper(IntPtr handle, bool owns)
        : base(handle, owns)
    {
    }

    [Preserve(Conditional = false)]
    public WKUrlSchemeTaskWrapper(IntPtr handle)
        : base(handle, false)
    {
    }

    public NSUrlRequest Request
    {
        [Export("request", ArgumentSemantic.Copy)]
        get
        {
            return Runtime.GetNSObjectTx<NSUrlRequest>(Messaging.IntPtr_objc_msgSend(Handle, Selector.GetHandle("request")));
        }
    }
  
    [Export("didReceiveResponse:")]
    public void DidReceiveResponse(NSUrlResponse response)
    {
        if (response == null)
            throw new ArgumentNullException("response");

        Messaging.void_objc_msgSend_IntPtr(Handle, Selector.GetHandle("didReceiveResponse:"), response.Handle);
    }

    [Export("didReceiveData:")]
    public void DidReceiveData(NSData data)
    {
        if (data == null)
            throw new ArgumentNullException("data");

        Messaging.void_objc_msgSend_IntPtr(Handle, Selector.GetHandle("didReceiveData:"), data.Handle);
    }

    [Export("didFinish")]
    public void DidFinish()
    {
        Messaging.void_objc_msgSend(Handle, Selector.GetHandle("didFinish"));
    }

    [Export("didFailWithError:")]
    public void DidFailWithError(NSError error)
    {
        if (error == null)
            throw new ArgumentNullException("error");

        Messaging.void_objc_msgSend_IntPtr(Handle, Selector.GetHandle("didFailWithError:"), error.Handle);
    }
}
