using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public static class NSOutlineViewDataSource_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject GetChild(this INSOutlineViewDataSource This, NSOutlineView outlineView, nint childIndex, NSObject? item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_nint_IntPtr(This.Handle, Selector.GetHandle("outlineView:child:ofItem:"), outlineView.Handle, childIndex, item?.Handle ?? IntPtr.Zero));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ItemExpandable(this INSOutlineViewDataSource This, NSOutlineView outlineView, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:isItemExpandable:"), outlineView.Handle, item.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint GetChildrenCount(this INSOutlineViewDataSource This, NSOutlineView outlineView, NSObject? item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		return Messaging.nint_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:numberOfChildrenOfItem:"), outlineView.Handle, item?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject GetObjectValue(this INSOutlineViewDataSource This, NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject? item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:objectValueForTableColumn:byItem:"), outlineView.Handle, tableColumn?.Handle ?? IntPtr.Zero, item?.Handle ?? IntPtr.Zero));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetObjectValue(this INSOutlineViewDataSource This, NSOutlineView outlineView, NSObject? theObject, NSTableColumn? tableColumn, NSObject? item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:setObjectValue:forTableColumn:byItem:"), outlineView.Handle, theObject?.Handle ?? IntPtr.Zero, tableColumn?.Handle ?? IntPtr.Zero, item?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject ItemForPersistentObject(this INSOutlineViewDataSource This, NSOutlineView outlineView, NSObject theObject)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (theObject == null)
		{
			throw new ArgumentNullException("theObject");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:itemForPersistentObject:"), outlineView.Handle, theObject.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject PersistentObjectForItem(this INSOutlineViewDataSource This, NSOutlineView outlineView, NSObject? item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:persistentObjectForItem:"), outlineView.Handle, item?.Handle ?? IntPtr.Zero));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SortDescriptorsChanged(this INSOutlineViewDataSource This, NSOutlineView outlineView, NSSortDescriptor[] oldDescriptors)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (oldDescriptors == null)
		{
			throw new ArgumentNullException("oldDescriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(oldDescriptors);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:sortDescriptorsDidChange:"), outlineView.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool OutlineViewwriteItemstoPasteboard(this INSOutlineViewDataSource This, NSOutlineView outlineView, NSArray items, NSPasteboard pboard)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:writeItems:toPasteboard:"), outlineView.Handle, items.Handle, pboard.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDragOperation ValidateDrop(this INSOutlineViewDataSource This, NSOutlineView outlineView, NSDraggingInfo info, NSObject? item, nint index)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSend_IntPtr_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("outlineView:validateDrop:proposedItem:proposedChildIndex:"), outlineView.Handle, info.Handle, item?.Handle ?? IntPtr.Zero, index);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool AcceptDrop(this INSOutlineViewDataSource This, NSOutlineView outlineView, NSDraggingInfo info, NSObject? item, nint index)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("outlineView:acceptDrop:item:childIndex:"), outlineView.Handle, info.Handle, item?.Handle ?? IntPtr.Zero, index);
	}

	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSFilePromiseReceiver' objects instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] FilesDropped(this INSOutlineViewDataSource This, NSOutlineView outlineView, NSUrl dropDestination, NSArray items)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (dropDestination == null)
		{
			throw new ArgumentNullException("dropDestination");
		}
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:namesOfPromisedFilesDroppedAtDestination:forDraggedItems:"), outlineView.Handle, dropDestination.Handle, items.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INSPasteboardWriting PasteboardWriterForItem(this INSOutlineViewDataSource This, NSOutlineView outlineView, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Runtime.GetINativeObject<INSPasteboardWriting>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:pasteboardWriterForItem:"), outlineView.Handle, item.Handle), owns: false);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DraggingSessionWillBegin(this INSOutlineViewDataSource This, NSOutlineView outlineView, NSDraggingSession session, CGPoint screenPoint, NSArray draggedItems)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (draggedItems == null)
		{
			throw new ArgumentNullException("draggedItems");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_CGPoint_IntPtr(This.Handle, Selector.GetHandle("outlineView:draggingSession:willBeginAtPoint:forItems:"), outlineView.Handle, session.Handle, screenPoint, draggedItems.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DraggingSessionEnded(this INSOutlineViewDataSource This, NSOutlineView outlineView, NSDraggingSession session, CGPoint screenPoint, NSDragOperation operation)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_CGPoint_UInt64(This.Handle, Selector.GetHandle("outlineView:draggingSession:endedAtPoint:operation:"), outlineView.Handle, session.Handle, screenPoint, (ulong)operation);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UpdateDraggingItemsForDrag(this INSOutlineViewDataSource This, NSOutlineView outlineView, NSDraggingInfo draggingInfo)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (draggingInfo == null)
		{
			throw new ArgumentNullException("draggingInfo");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:updateDraggingItemsForDrag:"), outlineView.Handle, draggingInfo.Handle);
	}
}
