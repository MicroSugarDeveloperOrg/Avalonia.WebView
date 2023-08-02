using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace WebKit;

[Register("WKNavigation", true)]
public class WKNavigation : NSObject
{
    private const string selEffectiveContentMode = "effectiveContentMode";

    private static readonly IntPtr selEffectiveContentModeHandle = Selector.GetHandle("effectiveContentMode");

    private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WKNavigation");

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public WKNavigation()
        : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKNavigation(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKNavigation(IntPtr handle)
        : base(handle)
    {
    }

    public virtual WKContentMode EffectiveContentMode
    {
        [Export("effectiveContentMode")]
        get
        {
            if (base.IsDirectBinding)
            {
                return (WKContentMode)Messaging.Int64_objc_msgSend(base.Handle, selEffectiveContentModeHandle);
            }
            return (WKContentMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selEffectiveContentModeHandle);
        }
    }

}