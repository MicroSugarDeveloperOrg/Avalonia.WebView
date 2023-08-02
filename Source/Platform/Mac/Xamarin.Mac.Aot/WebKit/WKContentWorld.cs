using CoreFoundation;
using Foundation;
using ObjCRuntime;
using System.ComponentModel;
using Xamarin.Utiles;

namespace WebKit;

[Register("WKContentWorld", true)]
public class WKContentWorld : NSObject
{
    private static readonly IntPtr class_ptr = Class.GetHandle("WKContentWorld");

    public override IntPtr ClassHandle => class_ptr;

    public static WKContentWorld DefaultClient
    {
        [Export("defaultClientWorld")]
        get
        {
            return Runtime.GetNSObjectTx<WKContentWorld>(Messaging.IntPtr_objc_msgSend(class_ptr, Selector.GetHandle("defaultClientWorld")));
        }
    }

    public virtual string? Name
    {
        [Export("name")]
        get
        {
            if (IsDirectBinding)
            {
                return CFString.FromHandle(Messaging.IntPtr_objc_msgSend(Handle, Selector.GetHandle("name")));
            }
            return CFString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, Selector.GetHandle("name")));
        }
    }

    public static WKContentWorld Page
    {
        [Export("pageWorld")]
        get
        {
            return Runtime.GetNSObjectTx<WKContentWorld>(Messaging.IntPtr_objc_msgSend(class_ptr, Selector.GetHandle("pageWorld")));
        }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKContentWorld(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKContentWorld(IntPtr handle)
        : base(handle)
    {
    }

    [Export("worldWithName:")]
    public static WKContentWorld Create(string name)
    {
        if (name == null)
        {
            ThrowHelper.ThrowArgumentNullException("name");
        }
        NativeHandle arg = CFString.CreateNative(name);
        WKContentWorld? nSObject = Runtime.GetNSObjectTx<WKContentWorld>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, Selector.GetHandle("worldWithName:"), arg));
        CFString.ReleaseNative(arg);
        return nSObject;
    }
}
