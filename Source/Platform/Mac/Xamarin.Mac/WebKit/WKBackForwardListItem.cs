using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace WebKit;

[Register("WKBackForwardListItem", true)]
public class WKBackForwardListItem : NSObject
{
    private const string selURL = "URL";
    private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

    private const string selInitialURL = "initialURL";
    private static readonly IntPtr selInitialURLHandle = Selector.GetHandle("initialURL");

    private const string selTitle = "title";
    private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

    private static readonly IntPtr class_ptr = Class.GetHandle("WKBackForwardListItem");

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKBackForwardListItem(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKBackForwardListItem(IntPtr handle)
        : base(handle)
    {
    }

    public virtual NSUrl InitialUrl
    {
        [Export("initialURL", ArgumentSemantic.Copy)]
        get
        {
            if (IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<NSUrl>(Messaging.IntPtr_objc_msgSend(Handle, selInitialURLHandle));
            }
            return Runtime.GetNSObjectTx<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selInitialURLHandle));
        }
    }

    public virtual string Title
    {
        [Export("title")]
        get
        {
            if (IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(Handle, selTitleHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selTitleHandle));
        }
    }

    public virtual NSUrl Url
    {
        [Export("URL", ArgumentSemantic.Copy)]
        get
        {
            if (IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<NSUrl>(Messaging.IntPtr_objc_msgSend(Handle, selURLHandle));
            }
            return Runtime.GetNSObjectTx<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selURLHandle));
        }
    }
}