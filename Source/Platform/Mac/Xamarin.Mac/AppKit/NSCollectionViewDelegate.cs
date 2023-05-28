using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol]
[Register("NSCollectionViewDelegate", false)]
[Model]
public class NSCollectionViewDelegate : NSObject, INSCollectionViewDelegate, INativeObject, IDisposable
{
	[Obsolete("Use 'ValidateDropOperation (NSCollectionView collectionView, NSDraggingInfo draggingInfo, ref NSIndexPath proposedDropIndexPath, ref NSCollectionViewDropOperation proposedDropOperation)' instead.")]
	[Mac(10, 11)]
	public virtual NSDragOperation ValidateDrop(NSCollectionView collectionView, NSDraggingInfo draggingInfo, out NSIndexPath proposedDropIndexPath, out NSCollectionViewDropOperation proposedDropOperation)
	{
		proposedDropIndexPath = null;
		proposedDropOperation = NSCollectionViewDropOperation.On;
		return ValidateDropOperation(collectionView, draggingInfo, ref proposedDropIndexPath, ref proposedDropOperation);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCollectionViewDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSCollectionViewDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionViewDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("collectionView:acceptDrop:index:dropOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AcceptDrop(NSCollectionView collectionView, NSDraggingInfo draggingInfo, nint index, NSCollectionViewDropOperation dropOperation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:acceptDrop:indexPath:dropOperation:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AcceptDrop(NSCollectionView collectionView, NSDraggingInfo draggingInfo, NSIndexPath indexPath, NSCollectionViewDropOperation dropOperation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:canDragItemsAtIndexes:withEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanDragItems(NSCollectionView collectionView, NSIndexSet indexes, NSEvent evt)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:canDragItemsAtIndexPaths:withEvent:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanDragItems(NSCollectionView collectionView, NSSet indexPaths, NSEvent theEvent)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:didEndDisplayingItem:forRepresentedObjectAtIndexPath:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisplayingItemEnded(NSCollectionView collectionView, NSCollectionViewItem item, NSIndexPath indexPath)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisplayingSupplementaryViewEnded(NSCollectionView collectionView, NSView view, string elementKind, NSIndexPath indexPath)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:draggingSession:endedAtPoint:dragOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggingSessionEnded(NSCollectionView collectionView, NSDraggingSession draggingSession, CGPoint screenPoint, NSDragOperation dragOperation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:draggingSession:willBeginAtPoint:forItemsAtIndexPaths:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggingSessionWillBegin(NSCollectionView collectionView, NSDraggingSession session, CGPoint screenPoint, NSSet indexPaths)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:draggingSession:willBeginAtPoint:forItemsAtIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggingSessionWillBegin(NSCollectionView collectionView, NSDraggingSession draggingSession, CGPoint screenPoint, NSIndexSet indexes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:draggingImageForItemsAtIndexPaths:withEvent:offset:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage GetDraggingImage(NSCollectionView collectionView, NSSet indexPaths, NSEvent theEvent, ref CGPoint dragImageOffset)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:namesOfPromisedFilesDroppedAtDestination:forDraggedItemsAtIndexPaths:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSFilePromiseReceiver' objects instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetNamesOfPromisedFiles(NSCollectionView collectionView, NSUrl dropURL, NSSet indexPaths)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:pasteboardWriterForItemAtIndexPath:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSPasteboardWriting? GetPasteboardWriter(NSCollectionView collectionView, NSIndexPath indexPath)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:didChangeItemsAtIndexPaths:toHighlightState:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ItemsChanged(NSCollectionView collectionView, NSSet indexPaths, NSCollectionViewItemHighlightState highlightState)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:didDeselectItemsAtIndexPaths:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ItemsDeselected(NSCollectionView collectionView, NSSet indexPaths)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:didSelectItemsAtIndexPaths:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ItemsSelected(NSCollectionView collectionView, NSSet indexPaths)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:namesOfPromisedFilesDroppedAtDestination:forDraggedItemsAtIndexes:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSFilePromiseReceiver' objects instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] NamesOfPromisedFilesDroppedAtDestination(NSCollectionView collectionView, NSUrl dropUrl, NSIndexSet indexes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:pasteboardWriterForItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSPasteboardWriting PasteboardWriterForItem(NSCollectionView collectionView, nuint index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:shouldChangeItemsAtIndexPaths:toHighlightState:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet ShouldChangeItems(NSCollectionView collectionView, NSSet indexPaths, NSCollectionViewItemHighlightState highlightState)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:shouldDeselectItemsAtIndexPaths:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet ShouldDeselectItems(NSCollectionView collectionView, NSSet indexPaths)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:shouldSelectItemsAtIndexPaths:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet ShouldSelectItems(NSCollectionView collectionView, NSSet indexPaths)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:transitionLayoutForOldLayout:newLayout:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewTransitionLayout TransitionLayout(NSCollectionView collectionView, NSCollectionViewLayout fromLayout, NSCollectionViewLayout toLayout)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:updateDraggingItemsForDrag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateDraggingItemsForDrag(NSCollectionView collectionView, NSDraggingInfo draggingInfo)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:validateDrop:proposedIndex:dropOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDragOperation ValidateDrop(NSCollectionView collectionView, NSDraggingInfo draggingInfo, ref nint dropIndex, ref NSCollectionViewDropOperation dropOperation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:validateDrop:proposedIndexPath:dropOperation:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDragOperation ValidateDropOperation(NSCollectionView collectionView, NSDraggingInfo draggingInfo, ref NSIndexPath proposedDropIndexPath, ref NSCollectionViewDropOperation proposedDropOperation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:willDisplayItem:forRepresentedObjectAtIndexPath:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillDisplayItem(NSCollectionView collectionView, NSCollectionViewItem item, NSIndexPath indexPath)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:willDisplaySupplementaryView:forElementKind:atIndexPath:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillDisplaySupplementaryView(NSCollectionView collectionView, NSView view, NSString elementKind, NSIndexPath indexPath)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:writeItemsAtIndexes:toPasteboard:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use the 'GetPasteboardWriter' method instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteItems(NSCollectionView collectionView, NSIndexSet indexes, NSPasteboard toPasteboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("collectionView:writeItemsAtIndexPaths:toPasteboard:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use the 'GetPasteboardWriter' method instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteItems(NSCollectionView collectionView, NSSet indexPaths, NSPasteboard pasteboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
