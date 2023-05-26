using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVQueuePlayer", true)]
public class AVQueuePlayer : AVPlayer
{
	private static readonly IntPtr selItemsHandle = Selector.GetHandle("items");

	private static readonly IntPtr selQueuePlayerWithItems_Handle = Selector.GetHandle("queuePlayerWithItems:");

	private static readonly IntPtr selInitWithItems_Handle = Selector.GetHandle("initWithItems:");

	private static readonly IntPtr selAdvanceToNextItemHandle = Selector.GetHandle("advanceToNextItem");

	private static readonly IntPtr selCanInsertItemAfterItem_Handle = Selector.GetHandle("canInsertItem:afterItem:");

	private static readonly IntPtr selInsertItemAfterItem_Handle = Selector.GetHandle("insertItem:afterItem:");

	private static readonly IntPtr selRemoveItem_Handle = Selector.GetHandle("removeItem:");

	private static readonly IntPtr selRemoveAllItemsHandle = Selector.GetHandle("removeAllItems");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVQueuePlayer");

	private object __mt_Items_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual AVPlayerItem[] Items
	{
		[Export("items")]
		get
		{
			return (AVPlayerItem[])(__mt_Items_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVPlayerItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemsHandle)) : NSArray.ArrayFromHandle<AVPlayerItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selItemsHandle))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVQueuePlayer()
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
	public AVQueuePlayer(NSCoder coder)
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
	public AVQueuePlayer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVQueuePlayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("queuePlayerWithItems:")]
	public static AVQueuePlayer FromItems(AVPlayerItem[] items)
	{
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		NSArray nSArray = NSArray.FromNSObjects(items);
		AVQueuePlayer result = (AVQueuePlayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selQueuePlayerWithItems_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("initWithItems:")]
	public AVQueuePlayer(AVPlayerItem[] items)
		: base(NSObjectFlag.Empty)
	{
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		NSArray nSArray = NSArray.FromNSObjects(items);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithItems_Handle, nSArray.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithItems_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("advanceToNextItem")]
	public virtual void AdvanceToNextItem()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAdvanceToNextItemHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAdvanceToNextItemHandle);
		}
	}

	[Export("canInsertItem:afterItem:")]
	public virtual bool CanInsert(AVPlayerItem item, AVPlayerItem afterItem)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (afterItem == null)
		{
			throw new ArgumentNullException("afterItem");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selCanInsertItemAfterItem_Handle, item.Handle, afterItem.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCanInsertItemAfterItem_Handle, item.Handle, afterItem.Handle);
	}

	[Export("insertItem:afterItem:")]
	public virtual void InsertItem(AVPlayerItem item, AVPlayerItem afterItem)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (afterItem == null)
		{
			throw new ArgumentNullException("afterItem");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertItemAfterItem_Handle, item.Handle, afterItem.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertItemAfterItem_Handle, item.Handle, afterItem.Handle);
		}
	}

	[Export("removeItem:")]
	public virtual void RemoveItem(AVPlayerItem item)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveItem_Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveItem_Handle, item.Handle);
		}
	}

	[Export("removeAllItems")]
	public virtual void RemoveAllItems()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllItemsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllItemsHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Items_var = null;
		}
	}
}
