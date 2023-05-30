using Foundation;
using ObjCRuntime;
using System.ComponentModel;
using Xamarin.Utiles;

namespace WebKit;

[Register("WKFindResult", true)]
public class WKFindResult : NSObject, INativeObject, IDisposable
{
    private static readonly IntPtr class_ptr = Class.GetHandle("WKFindResult");
    public override IntPtr ClassHandle => class_ptr;

    public virtual bool MatchFound
    {
        [Export("matchFound")]
        get
        {
            if (IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(Handle, Selector.GetHandle("matchFound"));
            }
            return Messaging.bool_objc_msgSendSuper(SuperHandle, Selector.GetHandle("matchFound"));
        }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKFindResult(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKFindResult(IntPtr handle)
        : base(handle)
    {
    }

    [Export("copyWithZone:")]
    [return: Release]
    public virtual NSObject Copy(NSZone? zone)
    {
        IntPtr arg = zone.GetHandle();
        NSObject nSObject = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, Selector.GetHandle("copyWithZone:"), arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, Selector.GetHandle("copyWithZone:"), arg)));
        if (nSObject != null)
        {
            Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
        }
        return nSObject;
    }
}
