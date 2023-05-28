using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebHistory", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class WebHistory : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddItems_ = "addItems:";

	private static readonly IntPtr selAddItems_Handle = Selector.GetHandle("addItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHistoryAgeInDaysLimit = "historyAgeInDaysLimit";

	private static readonly IntPtr selHistoryAgeInDaysLimitHandle = Selector.GetHandle("historyAgeInDaysLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHistoryItemLimit = "historyItemLimit";

	private static readonly IntPtr selHistoryItemLimitHandle = Selector.GetHandle("historyItemLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemForURL_ = "itemForURL:";

	private static readonly IntPtr selItemForURL_Handle = Selector.GetHandle("itemForURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadFromURL_Error_ = "loadFromURL:error:";

	private static readonly IntPtr selLoadFromURL_Error_Handle = Selector.GetHandle("loadFromURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOptionalSharedHistory = "optionalSharedHistory";

	private static readonly IntPtr selOptionalSharedHistoryHandle = Selector.GetHandle("optionalSharedHistory");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrderedItemsLastVisitedOnDay_ = "orderedItemsLastVisitedOnDay:";

	private static readonly IntPtr selOrderedItemsLastVisitedOnDay_Handle = Selector.GetHandle("orderedItemsLastVisitedOnDay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrderedLastVisitedDays = "orderedLastVisitedDays";

	private static readonly IntPtr selOrderedLastVisitedDaysHandle = Selector.GetHandle("orderedLastVisitedDays");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllItems = "removeAllItems";

	private static readonly IntPtr selRemoveAllItemsHandle = Selector.GetHandle("removeAllItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveItems_ = "removeItems:";

	private static readonly IntPtr selRemoveItems_Handle = Selector.GetHandle("removeItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveToURL_Error_ = "saveToURL:error:";

	private static readonly IntPtr selSaveToURL_Error_Handle = Selector.GetHandle("saveToURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHistoryAgeInDaysLimit_ = "setHistoryAgeInDaysLimit:";

	private static readonly IntPtr selSetHistoryAgeInDaysLimit_Handle = Selector.GetHandle("setHistoryAgeInDaysLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHistoryItemLimit_ = "setHistoryItemLimit:";

	private static readonly IntPtr selSetHistoryItemLimit_Handle = Selector.GetHandle("setHistoryItemLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOptionalSharedHistory_ = "setOptionalSharedHistory:";

	private static readonly IntPtr selSetOptionalSharedHistory_Handle = Selector.GetHandle("setOptionalSharedHistory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WebHistory");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int HistoryAgeInDaysLimit
	{
		[Export("historyAgeInDaysLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selHistoryAgeInDaysLimitHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selHistoryAgeInDaysLimitHandle);
		}
		[Export("setHistoryAgeInDaysLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetHistoryAgeInDaysLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetHistoryAgeInDaysLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int HistoryItemLimit
	{
		[Export("historyItemLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selHistoryItemLimitHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selHistoryItemLimitHandle);
		}
		[Export("setHistoryItemLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetHistoryItemLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetHistoryItemLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static WebHistory OptionalSharedHistory
	{
		[Export("optionalSharedHistory")]
		get
		{
			return Runtime.GetNSObject<WebHistory>(Messaging.IntPtr_objc_msgSend(class_ptr, selOptionalSharedHistoryHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCalendarDate[] OrderedLastVisitedDays
	{
		[Export("orderedLastVisitedDays")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSCalendarDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selOrderedLastVisitedDaysHandle));
			}
			return NSArray.ArrayFromHandle<NSCalendarDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOrderedLastVisitedDaysHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebHistory()
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
	protected WebHistory(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WebHistory(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddItems(WebHistoryItem[] newItems)
	{
		if (newItems == null)
		{
			throw new ArgumentNullException("newItems");
		}
		NSArray nSArray = NSArray.FromNSObjects(newItems);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddItems_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddItems_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("itemForURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebHistoryItem GetHistoryItemForUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<WebHistoryItem>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selItemForURL_Handle, url.Handle));
		}
		return Runtime.GetNSObject<WebHistoryItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemForURL_Handle, url.Handle));
	}

	[Export("orderedItemsLastVisitedOnDay:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebHistoryItem[] GetOrderedItemsLastVisitedOnDay(NSCalendarDate calendarDate)
	{
		if (calendarDate == null)
		{
			throw new ArgumentNullException("calendarDate");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<WebHistoryItem>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selOrderedItemsLastVisitedOnDay_Handle, calendarDate.Handle));
		}
		return NSArray.ArrayFromHandle<WebHistoryItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderedItemsLastVisitedOnDay_Handle, calendarDate.Handle));
	}

	[Export("loadFromURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Load(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selLoadFromURL_Error_Handle, url.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selLoadFromURL_Error_Handle, url.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("removeAllItems")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllItems()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllItemsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllItemsHandle);
		}
	}

	[Export("removeItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveItems(WebHistoryItem[] items)
	{
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		NSArray nSArray = NSArray.FromNSObjects(items);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveItems_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveItems_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("saveToURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Save(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selSaveToURL_Error_Handle, url.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selSaveToURL_Error_Handle, url.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("setOptionalSharedHistory:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetOptionalSharedHistory(WebHistory? history)
	{
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetOptionalSharedHistory_Handle, history?.Handle ?? IntPtr.Zero);
	}
}
