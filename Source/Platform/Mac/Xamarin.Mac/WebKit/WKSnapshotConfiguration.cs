using CoreGraphics;
using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace WebKit;

[Register("WKSnapshotConfiguration", true)]
public class WKSnapshotConfiguration : NSObject, INativeObject, IDisposable
{
    private const string selAfterScreenUpdates = "afterScreenUpdates";
    private static readonly IntPtr selAfterScreenUpdatesHandle = Selector.GetHandle("afterScreenUpdates");

    private const string selCopyWithZone_ = "copyWithZone:";
    private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

    private const string selRect = "rect";
    private static readonly IntPtr selRectHandle = Selector.GetHandle("rect");

    private const string selSetAfterScreenUpdates_ = "setAfterScreenUpdates:";
    private static readonly IntPtr selSetAfterScreenUpdates_Handle = Selector.GetHandle("setAfterScreenUpdates:");

    private const string selSetRect_ = "setRect:";
    private static readonly IntPtr selSetRect_Handle = Selector.GetHandle("setRect:");

    private const string selSetSnapshotWidth_ = "setSnapshotWidth:";
    private static readonly IntPtr selSetSnapshotWidth_Handle = Selector.GetHandle("setSnapshotWidth:");

    private const string selSnapshotWidth = "snapshotWidth";
    private static readonly IntPtr selSnapshotWidthHandle = Selector.GetHandle("snapshotWidth");

    private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WKSnapshotConfiguration");

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public WKSnapshotConfiguration()
    : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKSnapshotConfiguration(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKSnapshotConfiguration(IntPtr handle)
        : base(handle)
    {
    }

    public virtual bool AfterScreenUpdates
    {
        [Export("afterScreenUpdates")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(base.Handle, selAfterScreenUpdatesHandle);
            }
            return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAfterScreenUpdatesHandle);
        }
        [Export("setAfterScreenUpdates:")]
        set
        {
            if (base.IsDirectBinding)
            {
                Messaging.void_objc_msgSend_bool(base.Handle, selSetAfterScreenUpdates_Handle, value);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAfterScreenUpdates_Handle, value);
            }
        }
    }

    public virtual CGRect Rect
    {
        [Export("rect")]
        get
        {
            CGRect retval;
            if (base.IsDirectBinding)
            {
                Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selRectHandle);
            }
            else
            {
                Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRectHandle);
            }
            return retval;
        }
        [Export("setRect:")]
        set
        {
            if (base.IsDirectBinding)
            {
                Messaging.void_objc_msgSend_CGRect(base.Handle, selSetRect_Handle, value);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetRect_Handle, value);
            }
        }
    }

    public virtual NSNumber SnapshotWidth
    {
        [Export("snapshotWidth")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selSnapshotWidthHandle));
            }
            return Runtime.GetNSObjectTx<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSnapshotWidthHandle));
        }
        [Export("setSnapshotWidth:")]
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            if (base.IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSnapshotWidth_Handle, value.Handle);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSnapshotWidth_Handle, value.Handle);
            }
        }
    }

    [Export("copyWithZone:")]
    public virtual NSObject Copy(NSZone? zone)
    {
        NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
        if (nSObject != null)
        {
            Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
        }
        return nSObject;
    }
}
