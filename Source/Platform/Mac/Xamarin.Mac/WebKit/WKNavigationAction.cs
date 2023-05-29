using AppKit;
using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace WebKit;

[Register("WKNavigationAction", true)]
public class WKNavigationAction : NSObject
{
    private const string selButtonNumber = "buttonNumber";

    private static readonly IntPtr selButtonNumberHandle = Selector.GetHandle("buttonNumber");

    private const string selModifierFlags = "modifierFlags";

    private static readonly IntPtr selModifierFlagsHandle = Selector.GetHandle("modifierFlags");

    private const string selNavigationType = "navigationType";

    private static readonly IntPtr selNavigationTypeHandle = Selector.GetHandle("navigationType");

    private const string selRequest = "request";

    private static readonly IntPtr selRequestHandle = Selector.GetHandle("request");

    private const string selSourceFrame = "sourceFrame";

    private static readonly IntPtr selSourceFrameHandle = Selector.GetHandle("sourceFrame");

    private const string selTargetFrame = "targetFrame";

    private static readonly IntPtr selTargetFrameHandle = Selector.GetHandle("targetFrame");

    private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WKNavigationAction");

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public WKNavigationAction()
       : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKNavigationAction(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKNavigationAction(IntPtr handle)
        : base(handle)
    {
    }

    public virtual long ButtonNumber
    {
        [Export("buttonNumber")]
        get
        {
            if (IsDirectBinding)
                return Messaging.long_objc_msgSend(Handle, selButtonNumberHandle);

            return Messaging.long_objc_msgSendSuper(SuperHandle, selButtonNumberHandle);
        }
    }

    public virtual NSEventModifierMask ModifierFlags
    {
        [Export("modifierFlags")]
        get
        {
            if (IsDirectBinding)
                return (NSEventModifierMask)Messaging.UInt64_objc_msgSend(Handle, selModifierFlagsHandle);

            return (NSEventModifierMask)Messaging.UInt64_objc_msgSendSuper(SuperHandle, selModifierFlagsHandle);
        }
    }

    public virtual WKNavigationType NavigationType
    {
        [Export("navigationType")]
        get
        {
            if (IsDirectBinding)
                return (WKNavigationType)Messaging.Int64_objc_msgSend(Handle, selNavigationTypeHandle);

            return (WKNavigationType)Messaging.Int64_objc_msgSendSuper(SuperHandle, selNavigationTypeHandle);
        }
    }

    public virtual NSUrlRequest Request
    {
        [Export("request", ArgumentSemantic.Copy)]
        get
        {
            if (IsDirectBinding)
                return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSend(Handle, selRequestHandle));

            return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selRequestHandle));
        }
    }

    public virtual WKFrameInfo SourceFrame
    {
        [Export("sourceFrame", ArgumentSemantic.Copy)]
        get
        {
            if (IsDirectBinding)
                return Runtime.GetNSObject<WKFrameInfo>(Messaging.IntPtr_objc_msgSend(Handle, selSourceFrameHandle));

            return Runtime.GetNSObject<WKFrameInfo>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selSourceFrameHandle));
        }
    }

    public virtual WKFrameInfo TargetFrame
    {
        [Export("targetFrame", ArgumentSemantic.Copy)]
        get
        {
            if (IsDirectBinding)
                return Runtime.GetNSObject<WKFrameInfo>(Messaging.IntPtr_objc_msgSend(Handle, selTargetFrameHandle));

            return Runtime.GetNSObject<WKFrameInfo>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selTargetFrameHandle));
        }
    }

   
}
