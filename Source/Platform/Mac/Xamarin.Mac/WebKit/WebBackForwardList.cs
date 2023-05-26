using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebBackForwardList", true)]
public class WebBackForwardList : NSObject
{
	private static readonly IntPtr selBackListCountHandle = Selector.GetHandle("backListCount");

	private static readonly IntPtr selForwardListCountHandle = Selector.GetHandle("forwardListCount");

	private static readonly IntPtr selCapacityHandle = Selector.GetHandle("capacity");

	private static readonly IntPtr selSetCapacity_Handle = Selector.GetHandle("setCapacity:");

	private static readonly IntPtr selAddItem_Handle = Selector.GetHandle("addItem:");

	private static readonly IntPtr selGoBackHandle = Selector.GetHandle("goBack");

	private static readonly IntPtr selGoForwardHandle = Selector.GetHandle("goForward");

	private static readonly IntPtr selGoToItem_Handle = Selector.GetHandle("goToItem:");

	private static readonly IntPtr selBackItemHandle = Selector.GetHandle("backItem");

	private static readonly IntPtr selCurrentItemHandle = Selector.GetHandle("currentItem");

	private static readonly IntPtr selForwardItemHandle = Selector.GetHandle("forwardItem");

	private static readonly IntPtr selBackListWithLimit_Handle = Selector.GetHandle("backListWithLimit:");

	private static readonly IntPtr selForwardListWithLimit_Handle = Selector.GetHandle("forwardListWithLimit:");

	private static readonly IntPtr selContainsItem_Handle = Selector.GetHandle("containsItem:");

	private static readonly IntPtr selItemAtIndex_Handle = Selector.GetHandle("itemAtIndex:");

	private static readonly IntPtr class_ptr = Class.GetHandle("WebBackForwardList");

	public override IntPtr ClassHandle => class_ptr;

	public virtual int BackListCount
	{
		[Export("backListCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selBackListCountHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selBackListCountHandle);
		}
	}

	public virtual int ForwardListCount
	{
		[Export("forwardListCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selForwardListCountHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selForwardListCountHandle);
		}
	}

	public virtual int Capacity
	{
		[Export("capacity")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selCapacityHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selCapacityHandle);
		}
		[Export("setCapacity:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetCapacity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetCapacity_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebBackForwardList()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public WebBackForwardList(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebBackForwardList(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebBackForwardList(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addItem:")]
	public virtual void AddItem(WebHistoryItem item)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddItem_Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddItem_Handle, item.Handle);
		}
	}

	[Export("goBack")]
	public virtual void GoBack()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selGoBackHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selGoBackHandle);
		}
	}

	[Export("goForward")]
	public virtual void GoForward()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selGoForwardHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selGoForwardHandle);
		}
	}

	[Export("goToItem:")]
	public virtual void GoToItem(WebHistoryItem item)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGoToItem_Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoToItem_Handle, item.Handle);
		}
	}

	[Export("backItem")]
	public virtual WebHistoryItem BackItem()
	{
		if (IsDirectBinding)
		{
			return (WebHistoryItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBackItemHandle));
		}
		return (WebHistoryItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackItemHandle));
	}

	[Export("currentItem")]
	public virtual WebHistoryItem CurrentItem()
	{
		if (IsDirectBinding)
		{
			return (WebHistoryItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentItemHandle));
		}
		return (WebHistoryItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentItemHandle));
	}

	[Export("forwardItem")]
	public virtual WebHistoryItem ForwardItem()
	{
		if (IsDirectBinding)
		{
			return (WebHistoryItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selForwardItemHandle));
		}
		return (WebHistoryItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selForwardItemHandle));
	}

	[Export("backListWithLimit:")]
	public virtual WebHistoryItem[] BackListWithLimit(int limit)
	{
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<WebHistoryItem>(Messaging.IntPtr_objc_msgSend_int(base.Handle, selBackListWithLimit_Handle, limit));
		}
		return NSArray.ArrayFromHandle<WebHistoryItem>(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selBackListWithLimit_Handle, limit));
	}

	[Export("forwardListWithLimit:")]
	public virtual WebHistoryItem[] ForwardListWithLimit(int limit)
	{
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<WebHistoryItem>(Messaging.IntPtr_objc_msgSend_int(base.Handle, selForwardListWithLimit_Handle, limit));
		}
		return NSArray.ArrayFromHandle<WebHistoryItem>(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selForwardListWithLimit_Handle, limit));
	}

	[Export("containsItem:")]
	public virtual bool ContainsItem(WebHistoryItem item)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContainsItem_Handle, item.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selContainsItem_Handle, item.Handle);
	}

	[Export("itemAtIndex:")]
	public virtual WebHistoryItem ItemAtIndex(int index)
	{
		if (IsDirectBinding)
		{
			return (WebHistoryItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int(base.Handle, selItemAtIndex_Handle, index));
		}
		return (WebHistoryItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selItemAtIndex_Handle, index));
	}
}
