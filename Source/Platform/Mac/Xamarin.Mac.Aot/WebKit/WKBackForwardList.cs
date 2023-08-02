using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace WebKit;

[Register("WKBackForwardList", true)]
public class WKBackForwardList : NSObject
{
    private const string selBackItem = "backItem";
    private static readonly IntPtr selBackItemHandle = Selector.GetHandle("backItem");

    private const string selBackList = "backList";
    private static readonly IntPtr selBackListHandle = Selector.GetHandle("backList");

    private const string selCurrentItem = "currentItem";
    private static readonly IntPtr selCurrentItemHandle = Selector.GetHandle("currentItem");

    private const string selForwardItem = "forwardItem";
    private static readonly IntPtr selForwardItemHandle = Selector.GetHandle("forwardItem");

    private const string selForwardList = "forwardList";
    private static readonly IntPtr selForwardListHandle = Selector.GetHandle("forwardList");

    private const string selItemAtIndex_ = "itemAtIndex:";
    private static readonly IntPtr selItemAtIndex_Handle = Selector.GetHandle("itemAtIndex:");

    private static readonly IntPtr class_ptr = Class.GetHandle("WKBackForwardList");

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKBackForwardList(NSObjectFlag t)
       : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKBackForwardList(IntPtr handle)
        : base(handle)
    {
    }

    public virtual WKBackForwardListItem BackItem
    {
        [Export("backItem", ArgumentSemantic.Retain)]
        get
        {
            if (IsDirectBinding)
                return Runtime.GetNSObjectTx<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSend(Handle, selBackItemHandle));

            return Runtime.GetNSObjectTx<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selBackItemHandle));
        }
    }

    public virtual WKBackForwardListItem[] BackList
    {
        [Export("backList")]
        get
        {
            if (IsDirectBinding)
                return NSArray.ArrayFromHandle<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSend(Handle, selBackListHandle));

            return NSArray.ArrayFromHandle<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selBackListHandle));
        }
    }

    public virtual WKBackForwardListItem CurrentItem
    {
        [Export("currentItem", ArgumentSemantic.Retain)]
        get
        {
            if (IsDirectBinding)
                return Runtime.GetNSObjectTx<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSend(Handle, selCurrentItemHandle));

            return Runtime.GetNSObjectTx<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selCurrentItemHandle));
        }
    }

    public virtual WKBackForwardListItem ForwardItem
    {
        [Export("forwardItem", ArgumentSemantic.Retain)]
        get
        {
            if (IsDirectBinding)
                return Runtime.GetNSObjectTx<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSend(Handle, selForwardItemHandle));

            return Runtime.GetNSObjectTx<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selForwardItemHandle));
        }
    }

    public virtual WKBackForwardListItem[] ForwardList
    {
        [Export("forwardList")]
        get
        {
            if (IsDirectBinding)
                return NSArray.ArrayFromHandle<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSend(Handle, selForwardListHandle));

            return NSArray.ArrayFromHandle<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selForwardListHandle));
        }
    }

    [Export("itemAtIndex:")]
    public virtual WKBackForwardListItem ItemAtIndex(long index)
    {
        if (IsDirectBinding)
            return Runtime.GetNSObjectTx<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSend_long(Handle, selItemAtIndex_Handle, index));

        return Runtime.GetNSObjectTx<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSendSuper_long(SuperHandle, selItemAtIndex_Handle, index));
    }
}