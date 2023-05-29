using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace WebKit;

[Register("WKWebpagePreferences", true)]
public class WKWebpagePreferences : NSObject
{
    private const string selPreferredContentMode = "preferredContentMode";
    private static readonly IntPtr selPreferredContentModeHandle = Selector.GetHandle("preferredContentMode");

    private const string selSetPreferredContentMode_ = "setPreferredContentMode:";
    private static readonly IntPtr selSetPreferredContentMode_Handle = Selector.GetHandle("setPreferredContentMode:");

    private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WKWebpagePreferences");

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public WKWebpagePreferences()
       : base(NSObjectFlag.Empty)
    {

        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKWebpagePreferences(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKWebpagePreferences(IntPtr handle)
        : base(handle)
    {
    }

    public virtual WKContentMode PreferredContentMode
    {
        [Export("preferredContentMode", ArgumentSemantic.Assign)]
        get
        {
            if (IsDirectBinding)
            {
                return (WKContentMode)Messaging.Int64_objc_msgSend(Handle, selPreferredContentModeHandle);
            }
            return (WKContentMode)Messaging.Int64_objc_msgSendSuper(SuperHandle, selPreferredContentModeHandle);
        }
        [Export("setPreferredContentMode:", ArgumentSemantic.Assign)]
        set
        {
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_Int64(Handle, selSetPreferredContentMode_Handle, (long)value);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_Int64(SuperHandle, selSetPreferredContentMode_Handle, (long)value);
            }
        }
    }


}