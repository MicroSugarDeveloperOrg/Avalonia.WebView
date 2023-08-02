using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace WebKit;

[Register("WKContentRuleList", true)]
public class WKContentRuleList : NSObject
{
    private const string selIdentifier = "identifier";
    private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

    private static readonly IntPtr class_ptr = Class.GetHandle("WKContentRuleList");

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public WKContentRuleList()
    : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKContentRuleList(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKContentRuleList(IntPtr handle)
        : base(handle)
    {
    }

    public virtual string Identifier
    {
        [Export("identifier")]
        get
        {
            if (base.IsDirectBinding)
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));

            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
        }
    }
}