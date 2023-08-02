using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace WebKit;

[Register("WKWebsiteDataRecord", true)]
public class WKWebsiteDataRecord : NSObject
{
    private const string selDataTypes = "dataTypes";
    private static readonly IntPtr selDataTypesHandle = Selector.GetHandle("dataTypes");

    private const string selDisplayName = "displayName";
    private static readonly IntPtr selDisplayNameHandle = Selector.GetHandle("displayName");

    private static readonly IntPtr class_ptr = Class.GetHandle("WKWebsiteDataRecord");

    public override IntPtr ClassHandle => class_ptr;

    public virtual NSSet<NSString> DataTypes
    {
        [Export("dataTypes", ArgumentSemantic.Copy)]
        get
        {
            if (base.IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<NSSet<NSString>>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataTypesHandle));
            }
            return Runtime.GetNSObjectTx<NSSet<NSString>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataTypesHandle));
        }
    }

    public virtual string DisplayName
    {
        [Export("displayName")]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDisplayNameHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDisplayNameHandle));
        }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public WKWebsiteDataRecord()
        : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKWebsiteDataRecord(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKWebsiteDataRecord(IntPtr handle)
        : base(handle)
    {
    }
}
