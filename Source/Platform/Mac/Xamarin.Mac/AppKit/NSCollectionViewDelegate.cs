using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionViewDelegate", true)]
[Model]
public class NSCollectionViewDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCollectionViewDelegate()
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
	public NSCollectionViewDelegate(NSCoder coder)
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
	public NSCollectionViewDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSCollectionViewDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("collectionView:canDragItemsAtIndexes:withEvent:")]
	public virtual bool CanDragItems(NSCollectionView collectionView, NSIndexSet indexes, NSEvent evt)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:writeItemsAtIndexes:toPasteboard:")]
	public virtual bool WriteItems(NSCollectionView collectionView, NSIndexSet indexes, NSPasteboard toPasteboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:namesOfPromisedFilesDroppedAtDestination:forDraggedItemsAtIndexes:")]
	public virtual string[] NamesOfPromisedFilesDroppedAtDestination(NSCollectionView collectionView, NSUrl dropUrl, NSIndexSet indexes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:validateDrop:proposedIndex:dropOperation:")]
	public virtual NSDragOperation ValidateDrop(NSCollectionView collectionView, NSDraggingInfo draggingInfo, ref long dropIndex, NSCollectionViewDropOperation dropOperation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:acceptDrop:index:dropOperation:")]
	public virtual bool AcceptDrop(NSCollectionView collectionView, NSDraggingInfo draggingInfo, long index, NSCollectionViewDropOperation dropOperation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
