using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace WebKit;

[Register("WKNavigationResponse", true)]
public class WKNavigationResponse : NSObject
{
    private const string selCanShowMIMEType = "canShowMIMEType";
    private static readonly IntPtr selCanShowMIMETypeHandle = Selector.GetHandle("canShowMIMEType");

    private const string selIsForMainFrame = "isForMainFrame";
    private static readonly IntPtr selIsForMainFrameHandle = Selector.GetHandle("isForMainFrame");

    private const string selResponse = "response";
    private static readonly IntPtr selResponseHandle = Selector.GetHandle("response");

    private static readonly IntPtr class_ptr = Class.GetHandle("WKNavigationResponse");

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public WKNavigationResponse()
       : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKNavigationResponse(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKNavigationResponse(IntPtr handle)
        : base(handle)
    {
    }

    public virtual bool CanShowMimeType
    {
        [Export("canShowMIMEType")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(base.Handle, selCanShowMIMETypeHandle);
            }
            return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanShowMIMETypeHandle);
        }
    }

    public virtual bool IsForMainFrame
    {
        [Export("isForMainFrame")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(base.Handle, selIsForMainFrameHandle);
            }
            return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsForMainFrameHandle);
        }
    }

    public virtual NSUrlResponse Response
    {
        [Export("response", ArgumentSemantic.Copy)]
        get
        {
            if (base.IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<NSUrlResponse>(Messaging.IntPtr_objc_msgSend(base.Handle, selResponseHandle));
            }
            return Runtime.GetNSObjectTx<NSUrlResponse>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResponseHandle));
        }
    }
}