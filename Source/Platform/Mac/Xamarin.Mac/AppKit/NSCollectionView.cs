using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionView", true)]
public class NSCollectionView : NSView
{
	private static readonly IntPtr selIsFirstResponderHandle = Selector.GetHandle("isFirstResponder");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selContentHandle = Selector.GetHandle("content");

	private static readonly IntPtr selSetContent_Handle = Selector.GetHandle("setContent:");

	private static readonly IntPtr selIsSelectableHandle = Selector.GetHandle("isSelectable");

	private static readonly IntPtr selSetSelectable_Handle = Selector.GetHandle("setSelectable:");

	private static readonly IntPtr selAllowsMultipleSelectionHandle = Selector.GetHandle("allowsMultipleSelection");

	private static readonly IntPtr selSetAllowsMultipleSelection_Handle = Selector.GetHandle("setAllowsMultipleSelection:");

	private static readonly IntPtr selSelectionIndexesHandle = Selector.GetHandle("selectionIndexes");

	private static readonly IntPtr selSetSelectionIndexes_Handle = Selector.GetHandle("setSelectionIndexes:");

	private static readonly IntPtr selItemPrototypeHandle = Selector.GetHandle("itemPrototype");

	private static readonly IntPtr selSetItemPrototype_Handle = Selector.GetHandle("setItemPrototype:");

	private static readonly IntPtr selMaxNumberOfRowsHandle = Selector.GetHandle("maxNumberOfRows");

	private static readonly IntPtr selSetMaxNumberOfRows_Handle = Selector.GetHandle("setMaxNumberOfRows:");

	private static readonly IntPtr selMaxNumberOfColumnsHandle = Selector.GetHandle("maxNumberOfColumns");

	private static readonly IntPtr selSetMaxNumberOfColumns_Handle = Selector.GetHandle("setMaxNumberOfColumns:");

	private static readonly IntPtr selMinItemSizeHandle = Selector.GetHandle("minItemSize");

	private static readonly IntPtr selSetMinItemSize_Handle = Selector.GetHandle("setMinItemSize:");

	private static readonly IntPtr selMaxItemSizeHandle = Selector.GetHandle("maxItemSize");

	private static readonly IntPtr selSetMaxItemSize_Handle = Selector.GetHandle("setMaxItemSize:");

	private static readonly IntPtr selBackgroundColorsHandle = Selector.GetHandle("backgroundColors");

	private static readonly IntPtr selSetBackgroundColors_Handle = Selector.GetHandle("setBackgroundColors:");

	private static readonly IntPtr selWantsPeriodicDraggingUpdatesHandle = Selector.GetHandle("wantsPeriodicDraggingUpdates");

	private static readonly IntPtr selIgnoreModifierKeysWhileDraggingHandle = Selector.GetHandle("ignoreModifierKeysWhileDragging");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selNewItemForRepresentedObject_Handle = Selector.GetHandle("newItemForRepresentedObject:");

	private static readonly IntPtr selItemAtIndex_Handle = Selector.GetHandle("itemAtIndex:");

	private static readonly IntPtr selFrameForItemAtIndex_Handle = Selector.GetHandle("frameForItemAtIndex:");

	private static readonly IntPtr selSetDraggingSourceOperationMaskForLocal_Handle = Selector.GetHandle("setDraggingSourceOperationMask:forLocal:");

	private static readonly IntPtr selFrameForItemAtIndexWithNumberOfItems_Handle = Selector.GetHandle("frameForItemAtIndex:withNumberOfItems:");

	private static readonly IntPtr selDraggingEntered_Handle = Selector.GetHandle("draggingEntered:");

	private static readonly IntPtr selDraggingUpdated_Handle = Selector.GetHandle("draggingUpdated:");

	private static readonly IntPtr selDraggingExited_Handle = Selector.GetHandle("draggingExited:");

	private static readonly IntPtr selPrepareForDragOperation_Handle = Selector.GetHandle("prepareForDragOperation:");

	private static readonly IntPtr selPerformDragOperation_Handle = Selector.GetHandle("performDragOperation:");

	private static readonly IntPtr selConcludeDragOperation_Handle = Selector.GetHandle("concludeDragOperation:");

	private static readonly IntPtr selDraggingEnded_Handle = Selector.GetHandle("draggingEnded:");

	private static readonly IntPtr selDraggingSourceOperationMaskForLocal_Handle = Selector.GetHandle("draggingSourceOperationMaskForLocal:");

	private static readonly IntPtr selNamesOfPromisedFilesDroppedAtDestination_Handle = Selector.GetHandle("namesOfPromisedFilesDroppedAtDestination:");

	private static readonly IntPtr selDraggedImageBeganAt_Handle = Selector.GetHandle("draggedImage:beganAt:");

	private static readonly IntPtr selDraggedImageEndedAtOperation_Handle = Selector.GetHandle("draggedImage:endedAt:operation:");

	private static readonly IntPtr selDraggedImageMovedTo_Handle = Selector.GetHandle("draggedImage:movedTo:");

	private static readonly IntPtr selDraggedImageEndedAtDeposited_Handle = Selector.GetHandle("draggedImage:endedAt:deposited:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSCollectionView");

	private object __mt_WeakDelegate_var;

	private object __mt_Content_var;

	private object __mt_SelectionIndexes_var;

	private object __mt_ItemPrototype_var;

	private object __mt_BackgroundColors_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool IsFirstResponder
	{
		[Export("isFirstResponder")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFirstResponderHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFirstResponderHandle);
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public NSCollectionViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSCollectionViewDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual NSObject[] Content
	{
		[Export("content")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject[])(__mt_Content_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentHandle))));
		}
		[Export("setContent:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContent_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContent_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_Content_var = value;
		}
	}

	public virtual bool Selectable
	{
		[Export("isSelectable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSelectableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSelectableHandle);
		}
		[Export("setSelectable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSelectable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSelectable_Handle, value);
			}
		}
	}

	public virtual bool AllowsMultipleSelection
	{
		[Export("allowsMultipleSelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsMultipleSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsMultipleSelectionHandle);
		}
		[Export("setAllowsMultipleSelection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsMultipleSelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsMultipleSelection_Handle, value);
			}
		}
	}

	public virtual NSIndexSet SelectionIndexes
	{
		[Export("selectionIndexes")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSIndexSet)(__mt_SelectionIndexes_var = ((!IsDirectBinding) ? ((NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionIndexesHandle))) : ((NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionIndexesHandle)))));
		}
		[Export("setSelectionIndexes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelectionIndexes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectionIndexes_Handle, value.Handle);
			}
			__mt_SelectionIndexes_var = value;
		}
	}

	public virtual NSCollectionViewItem ItemPrototype
	{
		[Export("itemPrototype")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCollectionViewItem)(__mt_ItemPrototype_var = ((!IsDirectBinding) ? ((NSCollectionViewItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemPrototypeHandle))) : ((NSCollectionViewItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selItemPrototypeHandle)))));
		}
		[Export("setItemPrototype:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetItemPrototype_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetItemPrototype_Handle, value.Handle);
			}
			__mt_ItemPrototype_var = value;
		}
	}

	public virtual long MaxNumberOfRows
	{
		[Export("maxNumberOfRows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selMaxNumberOfRowsHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMaxNumberOfRowsHandle);
		}
		[Export("setMaxNumberOfRows:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMaxNumberOfRows_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMaxNumberOfRows_Handle, value);
			}
		}
	}

	public virtual long MaxNumberOfColumns
	{
		[Export("maxNumberOfColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selMaxNumberOfColumnsHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMaxNumberOfColumnsHandle);
		}
		[Export("setMaxNumberOfColumns:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMaxNumberOfColumns_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMaxNumberOfColumns_Handle, value);
			}
		}
	}

	public virtual CGSize MinItemSize
	{
		[Export("minItemSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMinItemSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMinItemSizeHandle);
		}
		[Export("setMinItemSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMinItemSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMinItemSize_Handle, value);
			}
		}
	}

	public virtual CGSize MaxItemSize
	{
		[Export("maxItemSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMaxItemSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMaxItemSizeHandle);
		}
		[Export("setMaxItemSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMaxItemSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMaxItemSize_Handle, value);
			}
		}
	}

	public virtual NSColor[] BackgroundColors
	{
		[Export("backgroundColors")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor[])(__mt_BackgroundColors_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorsHandle)) : NSArray.ArrayFromHandle<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorsHandle))));
		}
		[Export("setBackgroundColors:")]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColors_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColors_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
			__mt_BackgroundColors_var = value;
		}
	}

	public new virtual bool WantsPeriodicDraggingUpdates
	{
		[Export("wantsPeriodicDraggingUpdates")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWantsPeriodicDraggingUpdatesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWantsPeriodicDraggingUpdatesHandle);
		}
	}

	public virtual bool IgnoreModifierKeysWhileDragging
	{
		[Export("ignoreModifierKeysWhileDragging")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIgnoreModifierKeysWhileDraggingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIgnoreModifierKeysWhileDraggingHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCollectionView()
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
	public NSCollectionView(NSCoder coder)
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
	public NSCollectionView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSCollectionView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSCollectionView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect);
		}
	}

	[Export("newItemForRepresentedObject:")]
	public virtual NSCollectionViewItem NewItemForRepresentedObject(NSObject obj)
	{
		NSApplication.EnsureUIThread();
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (IsDirectBinding)
		{
			return (NSCollectionViewItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNewItemForRepresentedObject_Handle, obj.Handle));
		}
		return (NSCollectionViewItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNewItemForRepresentedObject_Handle, obj.Handle));
	}

	[Export("itemAtIndex:")]
	public virtual NSCollectionViewItem ItemAtIndex(long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSCollectionViewItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selItemAtIndex_Handle, index));
		}
		return (NSCollectionViewItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selItemAtIndex_Handle, index));
	}

	[Export("frameForItemAtIndex:")]
	public virtual CGRect FrameForItemAtIndex(long index)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_Int64(out retval, base.Handle, selFrameForItemAtIndex_Handle, index);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_Int64(out retval, base.SuperHandle, selFrameForItemAtIndex_Handle, index);
		}
		return retval;
	}

	[Export("setDraggingSourceOperationMask:forLocal:")]
	public virtual void SetDraggingSource(NSDragOperation dragOperationMask, bool localDestination)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_bool(base.Handle, selSetDraggingSourceOperationMaskForLocal_Handle, (ulong)dragOperationMask, localDestination);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_bool(base.SuperHandle, selSetDraggingSourceOperationMaskForLocal_Handle, (ulong)dragOperationMask, localDestination);
		}
	}

	[Export("frameForItemAtIndex:withNumberOfItems:")]
	public virtual CGRect FrameForItemAtIndex(long index, long numberOfItems)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_Int64_Int64(out retval, base.Handle, selFrameForItemAtIndexWithNumberOfItems_Handle, index, numberOfItems);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_Int64_Int64(out retval, base.SuperHandle, selFrameForItemAtIndexWithNumberOfItems_Handle, index, numberOfItems);
		}
		return retval;
	}

	[Export("draggingEntered:")]
	public new virtual NSDragOperation DraggingEntered(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			return (NSDragOperation)Messaging.UInt64_objc_msgSend_IntPtr(base.Handle, selDraggingEntered_Handle, sender.Handle);
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSendSuper_IntPtr(base.SuperHandle, selDraggingEntered_Handle, sender.Handle);
	}

	[Export("draggingUpdated:")]
	public new virtual NSDragOperation DraggingUpdated(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			return (NSDragOperation)Messaging.UInt64_objc_msgSend_IntPtr(base.Handle, selDraggingUpdated_Handle, sender.Handle);
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSendSuper_IntPtr(base.SuperHandle, selDraggingUpdated_Handle, sender.Handle);
	}

	[Export("draggingExited:")]
	public new virtual void DraggingExited(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDraggingExited_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDraggingExited_Handle, sender.Handle);
		}
	}

	[Export("prepareForDragOperation:")]
	public new virtual bool PrepareForDragOperation(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPrepareForDragOperation_Handle, sender.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrepareForDragOperation_Handle, sender.Handle);
	}

	[Export("performDragOperation:")]
	public new virtual bool PerformDragOperation(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPerformDragOperation_Handle, sender.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformDragOperation_Handle, sender.Handle);
	}

	[Export("concludeDragOperation:")]
	public new virtual void ConcludeDragOperation(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selConcludeDragOperation_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selConcludeDragOperation_Handle, sender.Handle);
		}
	}

	[Export("draggingEnded:")]
	public new virtual void DraggingEnded(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDraggingEnded_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDraggingEnded_Handle, sender.Handle);
		}
	}

	[Export("draggingSourceOperationMaskForLocal:")]
	public virtual NSDragOperation DraggingSourceOperationMaskForLocal(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSDragOperation)Messaging.UInt64_objc_msgSend_bool(base.Handle, selDraggingSourceOperationMaskForLocal_Handle, flag);
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSendSuper_bool(base.SuperHandle, selDraggingSourceOperationMaskForLocal_Handle, flag);
	}

	[Export("namesOfPromisedFilesDroppedAtDestination:")]
	public virtual string[] NamesOfPromisedFilesDroppedAtDestination(NSUrl dropDestination)
	{
		NSApplication.EnsureUIThread();
		if (dropDestination == null)
		{
			throw new ArgumentNullException("dropDestination");
		}
		if (IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNamesOfPromisedFilesDroppedAtDestination_Handle, dropDestination.Handle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNamesOfPromisedFilesDroppedAtDestination_Handle, dropDestination.Handle));
	}

	[Export("draggedImage:beganAt:")]
	public virtual void DraggedImageBeganAt(NSImage image, CGPoint screenPoint)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint(base.Handle, selDraggedImageBeganAt_Handle, image.Handle, screenPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selDraggedImageBeganAt_Handle, image.Handle, screenPoint);
		}
	}

	[Export("draggedImage:endedAt:operation:")]
	public virtual void DraggedImageEndedAtOperation(NSImage image, CGPoint screenPoint, NSDragOperation operation)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint_UInt64(base.Handle, selDraggedImageEndedAtOperation_Handle, image.Handle, screenPoint, (ulong)operation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint_UInt64(base.SuperHandle, selDraggedImageEndedAtOperation_Handle, image.Handle, screenPoint, (ulong)operation);
		}
	}

	[Export("draggedImage:movedTo:")]
	public virtual void DraggedImageMovedTo(NSImage image, CGPoint screenPoint)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint(base.Handle, selDraggedImageMovedTo_Handle, image.Handle, screenPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selDraggedImageMovedTo_Handle, image.Handle, screenPoint);
		}
	}

	[Export("draggedImage:endedAt:deposited:")]
	[Obsolete("On 10.1 and newer, use DraggedImageEndedAtOperation() instead", false)]
	public virtual void DraggedImageEndedAtDeposited(NSImage image, CGPoint screenPoint, bool deposited)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint_bool(base.Handle, selDraggedImageEndedAtDeposited_Handle, image.Handle, screenPoint, deposited);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint_bool(base.SuperHandle, selDraggedImageEndedAtDeposited_Handle, image.Handle, screenPoint, deposited);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
			__mt_Content_var = null;
			__mt_SelectionIndexes_var = null;
			__mt_ItemPrototype_var = null;
			__mt_BackgroundColors_var = null;
		}
	}
}
