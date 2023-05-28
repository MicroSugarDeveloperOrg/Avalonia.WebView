using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVQueuePlayer", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVQueuePlayer : AVPlayer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdvanceToNextItem = "advanceToNextItem";

	private static readonly IntPtr selAdvanceToNextItemHandle = Selector.GetHandle("advanceToNextItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanInsertItem_AfterItem_ = "canInsertItem:afterItem:";

	private static readonly IntPtr selCanInsertItem_AfterItem_Handle = Selector.GetHandle("canInsertItem:afterItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithItems_ = "initWithItems:";

	private static readonly IntPtr selInitWithItems_Handle = Selector.GetHandle("initWithItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertItem_AfterItem_ = "insertItem:afterItem:";

	private static readonly IntPtr selInsertItem_AfterItem_Handle = Selector.GetHandle("insertItem:afterItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItems = "items";

	private static readonly IntPtr selItemsHandle = Selector.GetHandle("items");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQueuePlayerWithItems_ = "queuePlayerWithItems:";

	private static readonly IntPtr selQueuePlayerWithItems_Handle = Selector.GetHandle("queuePlayerWithItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllItems = "removeAllItems";

	private static readonly IntPtr selRemoveAllItemsHandle = Selector.GetHandle("removeAllItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveItem_ = "removeItem:";

	private static readonly IntPtr selRemoveItem_Handle = Selector.GetHandle("removeItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVQueuePlayer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVPlayerItem[] Items
	{
		[Export("items")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVPlayerItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selItemsHandle));
			}
			return NSArray.ArrayFromHandle<AVPlayerItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVQueuePlayer()
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
	protected AVQueuePlayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVQueuePlayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVQueuePlayer(AVPlayerItem[] items)
		: base(NSObjectFlag.Empty)
	{
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		NSArray nSArray = NSArray.FromNSObjects(items);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithItems_Handle, nSArray.Handle), "initWithItems:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithItems_Handle, nSArray.Handle), "initWithItems:");
		}
		nSArray.Dispose();
	}

	[Export("advanceToNextItem")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AdvanceToNextItem()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAdvanceToNextItemHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAdvanceToNextItemHandle);
		}
	}

	[Export("canInsertItem:afterItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanInsert(AVPlayerItem item, AVPlayerItem? afterItem)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selCanInsertItem_AfterItem_Handle, item.Handle, afterItem?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCanInsertItem_AfterItem_Handle, item.Handle, afterItem?.Handle ?? IntPtr.Zero);
	}

	[Export("queuePlayerWithItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVQueuePlayer FromItems(AVPlayerItem[] items)
	{
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		NSArray nSArray = NSArray.FromNSObjects(items);
		AVQueuePlayer nSObject = Runtime.GetNSObject<AVQueuePlayer>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selQueuePlayerWithItems_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("insertItem:afterItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertItem(AVPlayerItem item, AVPlayerItem? afterItem)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertItem_AfterItem_Handle, item.Handle, afterItem?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertItem_AfterItem_Handle, item.Handle, afterItem?.Handle ?? IntPtr.Zero);
		}
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

	[Export("removeItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveItem(AVPlayerItem item)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveItem_Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveItem_Handle, item.Handle);
		}
	}
}
