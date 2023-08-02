using Foundation;
using ObjCRuntime;
using System.ComponentModel;
using Xamarin.Utiles;

namespace WebKit;

[Register("WKFindConfiguration", true)]
public class WKFindConfiguration : NSObject, INativeObject, IDisposable
{
    private static readonly IntPtr class_ptr = Class.GetHandle("WKFindConfiguration");
    public override IntPtr ClassHandle => class_ptr;
    public virtual bool Backwards
    {
        [Export("backwards")]
        get
        {
            if (IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(Handle, Selector.GetHandle("backwards"));
            }
            return Messaging.bool_objc_msgSendSuper(SuperHandle, Selector.GetHandle("backwards"));
        }
        [Export("setBackwards:")]
        set
        {
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_bool(Handle, Selector.GetHandle("setBackwards:"), value);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_bool(SuperHandle, Selector.GetHandle("setBackwards:"), value);
            }
        }
    }

    public virtual bool CaseSensitive
    {
        [Export("caseSensitive")]
        get
        {
            if (IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(Handle, Selector.GetHandle("caseSensitive"));
            }
            return Messaging.bool_objc_msgSendSuper(SuperHandle, Selector.GetHandle("caseSensitive"));
        }
        [Export("setCaseSensitive:")]
        set
        {
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_bool(Handle, Selector.GetHandle("setCaseSensitive:"), value);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_bool(SuperHandle, Selector.GetHandle("setCaseSensitive:"), value);
            }
        }
    }

    public virtual bool Wraps
    {
        [Export("wraps")]
        get
        {
            if (IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(Handle, Selector.GetHandle("wraps"));
            }
            return Messaging.bool_objc_msgSendSuper(SuperHandle, Selector.GetHandle("wraps"));
        }
        [Export("setWraps:")]
        set
        {
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_bool(Handle, Selector.GetHandle("setWraps:"), value);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_bool(SuperHandle, Selector.GetHandle("setWraps:"), value);
            }
        }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public WKFindConfiguration()
        : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKFindConfiguration(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKFindConfiguration(IntPtr handle)
        : base(handle)
    {
    }

    [Export("copyWithZone:")]
    [return: Release]
    public virtual NSObject Copy(NSZone? zone)
    {
        IntPtr arg = zone.GetHandle();
        NSObject nSObject = !IsDirectBinding ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, Selector.GetHandle("copyWithZone:"), arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, Selector.GetHandle("copyWithZone:"), arg));
        if (nSObject != null)
        {
            Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
        }
        return nSObject;
    }
}
