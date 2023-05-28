using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebBackForwardList", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class WebBackForwardList : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddItem_ = "addItem:";

	private static readonly IntPtr selAddItem_Handle = Selector.GetHandle("addItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackItem = "backItem";

	private static readonly IntPtr selBackItemHandle = Selector.GetHandle("backItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackListCount = "backListCount";

	private static readonly IntPtr selBackListCountHandle = Selector.GetHandle("backListCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackListWithLimit_ = "backListWithLimit:";

	private static readonly IntPtr selBackListWithLimit_Handle = Selector.GetHandle("backListWithLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCapacity = "capacity";

	private static readonly IntPtr selCapacityHandle = Selector.GetHandle("capacity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainsItem_ = "containsItem:";

	private static readonly IntPtr selContainsItem_Handle = Selector.GetHandle("containsItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentItem = "currentItem";

	private static readonly IntPtr selCurrentItemHandle = Selector.GetHandle("currentItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selForwardItem = "forwardItem";

	private static readonly IntPtr selForwardItemHandle = Selector.GetHandle("forwardItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selForwardListCount = "forwardListCount";

	private static readonly IntPtr selForwardListCountHandle = Selector.GetHandle("forwardListCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selForwardListWithLimit_ = "forwardListWithLimit:";

	private static readonly IntPtr selForwardListWithLimit_Handle = Selector.GetHandle("forwardListWithLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoBack = "goBack";

	private static readonly IntPtr selGoBackHandle = Selector.GetHandle("goBack");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoForward = "goForward";

	private static readonly IntPtr selGoForwardHandle = Selector.GetHandle("goForward");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoToItem_ = "goToItem:";

	private static readonly IntPtr selGoToItem_Handle = Selector.GetHandle("goToItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemAtIndex_ = "itemAtIndex:";

	private static readonly IntPtr selItemAtIndex_Handle = Selector.GetHandle("itemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCapacity_ = "setCapacity:";

	private static readonly IntPtr selSetCapacity_Handle = Selector.GetHandle("setCapacity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WebBackForwardList");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int BackListCount
	{
		[Export("backListCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selBackListCountHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selBackListCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int Capacity
	{
		[Export("capacity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selCapacityHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selCapacityHandle);
		}
		[Export("setCapacity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetCapacity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetCapacity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int ForwardListCount
	{
		[Export("forwardListCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selForwardListCountHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selForwardListCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebBackForwardList()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected WebBackForwardList(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WebBackForwardList(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddItem(WebHistoryItem item)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddItem_Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddItem_Handle, item.Handle);
		}
	}

	[Export("backItem")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebHistoryItem BackItem()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<WebHistoryItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackItemHandle));
		}
		return Runtime.GetNSObject<WebHistoryItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackItemHandle));
	}

	[Export("backListWithLimit:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebHistoryItem[] BackListWithLimit(int limit)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<WebHistoryItem>(Messaging.IntPtr_objc_msgSend_int(base.Handle, selBackListWithLimit_Handle, limit));
		}
		return NSArray.ArrayFromHandle<WebHistoryItem>(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selBackListWithLimit_Handle, limit));
	}

	[Export("containsItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ContainsItem(WebHistoryItem item)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContainsItem_Handle, item.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selContainsItem_Handle, item.Handle);
	}

	[Export("currentItem")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebHistoryItem CurrentItem()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<WebHistoryItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentItemHandle));
		}
		return Runtime.GetNSObject<WebHistoryItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentItemHandle));
	}

	[Export("forwardItem")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebHistoryItem ForwardItem()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<WebHistoryItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selForwardItemHandle));
		}
		return Runtime.GetNSObject<WebHistoryItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selForwardItemHandle));
	}

	[Export("forwardListWithLimit:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebHistoryItem[] ForwardListWithLimit(int limit)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<WebHistoryItem>(Messaging.IntPtr_objc_msgSend_int(base.Handle, selForwardListWithLimit_Handle, limit));
		}
		return NSArray.ArrayFromHandle<WebHistoryItem>(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selForwardListWithLimit_Handle, limit));
	}

	[Export("goBack")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GoBack()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selGoBackHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selGoBackHandle);
		}
	}

	[Export("goForward")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GoForward()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selGoForwardHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selGoForwardHandle);
		}
	}

	[Export("goToItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GoToItem(WebHistoryItem item)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGoToItem_Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoToItem_Handle, item.Handle);
		}
	}

	[Export("itemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebHistoryItem ItemAtIndex(int index)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<WebHistoryItem>(Messaging.IntPtr_objc_msgSend_int(base.Handle, selItemAtIndex_Handle, index));
		}
		return Runtime.GetNSObject<WebHistoryItem>(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selItemAtIndex_Handle, index));
	}
}
