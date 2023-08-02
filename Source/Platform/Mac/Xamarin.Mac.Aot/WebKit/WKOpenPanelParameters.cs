using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace WebKit;

[Register("WKOpenPanelParameters", true)]
public class WKOpenPanelParameters : NSObject
{
    private const string selAllowsDirectories = "allowsDirectories";

    private static readonly IntPtr selAllowsDirectoriesHandle = Selector.GetHandle("allowsDirectories");

    private const string selAllowsMultipleSelection = "allowsMultipleSelection";

    private static readonly IntPtr selAllowsMultipleSelectionHandle = Selector.GetHandle("allowsMultipleSelection");

    private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WKOpenPanelParameters");

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public WKOpenPanelParameters()
    : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKOpenPanelParameters(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKOpenPanelParameters(IntPtr handle)
        : base(handle)
    {
    }

    public virtual bool AllowsDirectories
    {
        [Export("allowsDirectories")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(base.Handle, selAllowsDirectoriesHandle);
            }
            return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsDirectoriesHandle);
        }
    }

    public virtual bool AllowsMultipleSelection
    {
        [Export("allowsMultipleSelection")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(base.Handle, selAllowsMultipleSelectionHandle);
            }
            return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsMultipleSelectionHandle);
        }
    }


}
