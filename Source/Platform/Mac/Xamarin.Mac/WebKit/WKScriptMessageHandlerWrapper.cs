using Foundation;
using ObjCRuntime;

namespace WebKit;

internal class WKScriptMessageHandlerWrapper : BaseWrapper, IWKScriptMessageHandler
{
    [Preserve(Conditional = true)]
    public WKScriptMessageHandlerWrapper(IntPtr handle, bool owns) 
        : base(handle, owns)
    {
    }

    [Preserve(Conditional = false)]
    public WKScriptMessageHandlerWrapper(IntPtr handle)
       : base(handle, false)
    {
    }

    [Export("userContentController:didReceiveScriptMessage:")]
    public void DidReceiveScriptMessage(WKUserContentController userContentController, WKScriptMessage message)
    {
        if (userContentController == null)
            throw new ArgumentNullException("userContentController");

        if (message == null)
            throw new ArgumentNullException("message");

        Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, Selector.GetHandle("userContentController:didReceiveScriptMessage:"), userContentController.Handle, message.Handle);
    }
}
