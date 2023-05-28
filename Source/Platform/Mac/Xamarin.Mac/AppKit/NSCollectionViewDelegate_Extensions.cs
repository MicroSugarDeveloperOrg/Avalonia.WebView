using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public static class NSCollectionViewDelegate_Extensions
{
	[Obsolete("Use 'ValidateDropOperation (NSCollectionView collectionView, NSDraggingInfo draggingInfo, ref NSIndexPath proposedDropIndexPath, ref NSCollectionViewDropOperation proposedDropOperation)' instead.")]
	[Mac(10, 11)]
	public static NSDragOperation ValidateDrop(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSDraggingInfo draggingInfo, out NSIndexPath proposedDropIndexPath, out NSCollectionViewDropOperation proposedDropOperation)
	{
		proposedDropIndexPath = null;
		proposedDropOperation = NSCollectionViewDropOperation.On;
		return This.ValidateDropOperation(collectionView, draggingInfo, ref proposedDropIndexPath, ref proposedDropOperation);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CanDragItems(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSIndexSet indexes, NSEvent evt)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (evt == null)
		{
			throw new ArgumentNullException("evt");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("collectionView:canDragItemsAtIndexes:withEvent:"), collectionView.Handle, indexes.Handle, evt.Handle);
	}

	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use the 'GetPasteboardWriter' method instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WriteItems(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSIndexSet indexes, NSPasteboard toPasteboard)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (toPasteboard == null)
		{
			throw new ArgumentNullException("toPasteboard");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("collectionView:writeItemsAtIndexes:toPasteboard:"), collectionView.Handle, indexes.Handle, toPasteboard.Handle);
	}

	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSFilePromiseReceiver' objects instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] NamesOfPromisedFilesDroppedAtDestination(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSUrl dropUrl, NSIndexSet indexes)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (dropUrl == null)
		{
			throw new ArgumentNullException("dropUrl");
		}
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("collectionView:namesOfPromisedFilesDroppedAtDestination:forDraggedItemsAtIndexes:"), collectionView.Handle, dropUrl.Handle, indexes.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDragOperation ValidateDrop(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSDraggingInfo draggingInfo, ref nint dropIndex, ref NSCollectionViewDropOperation dropOperation)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (draggingInfo == null)
		{
			throw new ArgumentNullException("draggingInfo");
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSend_IntPtr_IntPtr_ref_nint_ref_NSCollectionViewDropOperation(This.Handle, Selector.GetHandle("collectionView:validateDrop:proposedIndex:dropOperation:"), collectionView.Handle, draggingInfo.Handle, ref dropIndex, ref dropOperation);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool AcceptDrop(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSDraggingInfo draggingInfo, nint index, NSCollectionViewDropOperation dropOperation)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (draggingInfo == null)
		{
			throw new ArgumentNullException("draggingInfo");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_nint_Int64(This.Handle, Selector.GetHandle("collectionView:acceptDrop:index:dropOperation:"), collectionView.Handle, draggingInfo.Handle, index, (long)dropOperation);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CanDragItems(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths, NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("collectionView:canDragItemsAtIndexPaths:withEvent:"), collectionView.Handle, indexPaths.Handle, theEvent.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use the 'GetPasteboardWriter' method instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WriteItems(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths, NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("collectionView:writeItemsAtIndexPaths:toPasteboard:"), collectionView.Handle, indexPaths.Handle, pasteboard.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSFilePromiseReceiver' objects instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] GetNamesOfPromisedFiles(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSUrl dropURL, NSSet indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (dropURL == null)
		{
			throw new ArgumentNullException("dropURL");
		}
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("collectionView:namesOfPromisedFilesDroppedAtDestination:forDraggedItemsAtIndexPaths:"), collectionView.Handle, dropURL.Handle, indexPaths.Handle));
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSImage GetDraggingImage(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths, NSEvent theEvent, ref CGPoint dragImageOffset)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_CGPoint(This.Handle, Selector.GetHandle("collectionView:draggingImageForItemsAtIndexPaths:withEvent:offset:"), collectionView.Handle, indexPaths.Handle, theEvent.Handle, ref dragImageOffset));
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDragOperation ValidateDropOperation(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSDraggingInfo draggingInfo, ref NSIndexPath proposedDropIndexPath, ref NSCollectionViewDropOperation proposedDropOperation)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (draggingInfo == null)
		{
			throw new ArgumentNullException("draggingInfo");
		}
		IntPtr arg = ((proposedDropIndexPath == null) ? IntPtr.Zero : proposedDropIndexPath.Handle);
		NSDragOperation result = (NSDragOperation)Messaging.UInt64_objc_msgSend_IntPtr_IntPtr_ref_IntPtr_ref_NSCollectionViewDropOperation(This.Handle, Selector.GetHandle("collectionView:validateDrop:proposedIndexPath:dropOperation:"), collectionView.Handle, draggingInfo.Handle, ref arg, ref proposedDropOperation);
		proposedDropIndexPath = Runtime.GetNSObject<NSIndexPath>(arg);
		return result;
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool AcceptDrop(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSDraggingInfo draggingInfo, NSIndexPath indexPath, NSCollectionViewDropOperation dropOperation)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (draggingInfo == null)
		{
			throw new ArgumentNullException("draggingInfo");
		}
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_Int64(This.Handle, Selector.GetHandle("collectionView:acceptDrop:indexPath:dropOperation:"), collectionView.Handle, draggingInfo.Handle, indexPath.Handle, (long)dropOperation);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INSPasteboardWriting? GetPasteboardWriter(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		return Runtime.GetINativeObject<INSPasteboardWriting>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("collectionView:pasteboardWriterForItemAtIndexPath:"), collectionView.Handle, indexPath.Handle), owns: false);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DraggingSessionWillBegin(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSDraggingSession session, CGPoint screenPoint, NSSet indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_CGPoint_IntPtr(This.Handle, Selector.GetHandle("collectionView:draggingSession:willBeginAtPoint:forItemsAtIndexPaths:"), collectionView.Handle, session.Handle, screenPoint, indexPaths.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSet ShouldChangeItems(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths, NSCollectionViewItemHighlightState highlightState)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Int64(This.Handle, Selector.GetHandle("collectionView:shouldChangeItemsAtIndexPaths:toHighlightState:"), collectionView.Handle, indexPaths.Handle, (long)highlightState));
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ItemsChanged(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths, NSCollectionViewItemHighlightState highlightState)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_Int64(This.Handle, Selector.GetHandle("collectionView:didChangeItemsAtIndexPaths:toHighlightState:"), collectionView.Handle, indexPaths.Handle, (long)highlightState);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSet ShouldSelectItems(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("collectionView:shouldSelectItemsAtIndexPaths:"), collectionView.Handle, indexPaths.Handle));
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSet ShouldDeselectItems(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("collectionView:shouldDeselectItemsAtIndexPaths:"), collectionView.Handle, indexPaths.Handle));
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ItemsSelected(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("collectionView:didSelectItemsAtIndexPaths:"), collectionView.Handle, indexPaths.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ItemsDeselected(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSSet indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("collectionView:didDeselectItemsAtIndexPaths:"), collectionView.Handle, indexPaths.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillDisplayItem(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSCollectionViewItem item, NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("collectionView:willDisplayItem:forRepresentedObjectAtIndexPath:"), collectionView.Handle, item.Handle, indexPath.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillDisplaySupplementaryView(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSView view, NSString elementKind, NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("collectionView:willDisplaySupplementaryView:forElementKind:atIndexPath:"), collectionView.Handle, view.Handle, elementKind.Handle, indexPath.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DisplayingItemEnded(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSCollectionViewItem item, NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("collectionView:didEndDisplayingItem:forRepresentedObjectAtIndexPath:"), collectionView.Handle, item.Handle, indexPath.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DisplayingSupplementaryViewEnded(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSView view, string elementKind, NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		IntPtr intPtr = NSString.CreateNative(elementKind);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:"), collectionView.Handle, view.Handle, intPtr, indexPath.Handle);
		NSString.ReleaseNative(intPtr);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionViewTransitionLayout TransitionLayout(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSCollectionViewLayout fromLayout, NSCollectionViewLayout toLayout)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (fromLayout == null)
		{
			throw new ArgumentNullException("fromLayout");
		}
		if (toLayout == null)
		{
			throw new ArgumentNullException("toLayout");
		}
		return Runtime.GetNSObject<NSCollectionViewTransitionLayout>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("collectionView:transitionLayoutForOldLayout:newLayout:"), collectionView.Handle, fromLayout.Handle, toLayout.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INSPasteboardWriting PasteboardWriterForItem(this INSCollectionViewDelegate This, NSCollectionView collectionView, nuint index)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		return Runtime.GetINativeObject<INSPasteboardWriting>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(This.Handle, Selector.GetHandle("collectionView:pasteboardWriterForItemAtIndex:"), collectionView.Handle, index), owns: false);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UpdateDraggingItemsForDrag(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSDraggingInfo draggingInfo)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (draggingInfo == null)
		{
			throw new ArgumentNullException("draggingInfo");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("collectionView:updateDraggingItemsForDrag:"), collectionView.Handle, draggingInfo.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DraggingSessionWillBegin(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSDraggingSession draggingSession, CGPoint screenPoint, NSIndexSet indexes)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (draggingSession == null)
		{
			throw new ArgumentNullException("draggingSession");
		}
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_CGPoint_IntPtr(This.Handle, Selector.GetHandle("collectionView:draggingSession:willBeginAtPoint:forItemsAtIndexes:"), collectionView.Handle, draggingSession.Handle, screenPoint, indexes.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DraggingSessionEnded(this INSCollectionViewDelegate This, NSCollectionView collectionView, NSDraggingSession draggingSession, CGPoint screenPoint, NSDragOperation dragOperation)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (draggingSession == null)
		{
			throw new ArgumentNullException("draggingSession");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_CGPoint_UInt64(This.Handle, Selector.GetHandle("collectionView:draggingSession:endedAtPoint:dragOperation:"), collectionView.Handle, draggingSession.Handle, screenPoint, (ulong)dragOperation);
	}
}
