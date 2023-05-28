using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSTableViewDataSource_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint GetRowCount(this INSTableViewDataSource This, NSTableView tableView)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		return Messaging.nint_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("numberOfRowsInTableView:"), tableView.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject GetObjectValue(this INSTableViewDataSource This, NSTableView tableView, NSTableColumn tableColumn, nint row)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("tableView:objectValueForTableColumn:row:"), tableView.Handle, tableColumn.Handle, row));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetObjectValue(this INSTableViewDataSource This, NSTableView tableView, NSObject theObject, NSTableColumn tableColumn, nint row)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (theObject == null)
		{
			throw new ArgumentNullException("theObject");
		}
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("tableView:setObjectValue:forTableColumn:row:"), tableView.Handle, theObject.Handle, tableColumn.Handle, row);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SortDescriptorsChanged(this INSTableViewDataSource This, NSTableView tableView, NSSortDescriptor[] oldDescriptors)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (oldDescriptors == null)
		{
			throw new ArgumentNullException("oldDescriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(oldDescriptors);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tableView:sortDescriptorsDidChange:"), tableView.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use the 'GetPasteboardWriterForRow' method instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WriteRows(this INSTableViewDataSource This, NSTableView tableView, NSIndexSet rowIndexes, NSPasteboard pboard)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (rowIndexes == null)
		{
			throw new ArgumentNullException("rowIndexes");
		}
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tableView:writeRowsWithIndexes:toPasteboard:"), tableView.Handle, rowIndexes.Handle, pboard.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDragOperation ValidateDrop(this INSTableViewDataSource This, NSTableView tableView, NSDraggingInfo info, nint row, NSTableViewDropOperation dropOperation)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSend_IntPtr_IntPtr_nint_UInt64(This.Handle, Selector.GetHandle("tableView:validateDrop:proposedRow:proposedDropOperation:"), tableView.Handle, info.Handle, row, (ulong)dropOperation);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool AcceptDrop(this INSTableViewDataSource This, NSTableView tableView, NSDraggingInfo info, nint row, NSTableViewDropOperation dropOperation)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_nint_UInt64(This.Handle, Selector.GetHandle("tableView:acceptDrop:row:dropOperation:"), tableView.Handle, info.Handle, row, (ulong)dropOperation);
	}

	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSFilePromiseReceiver' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] FilesDropped(this INSTableViewDataSource This, NSTableView tableView, NSUrl dropDestination, NSIndexSet indexSet)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (dropDestination == null)
		{
			throw new ArgumentNullException("dropDestination");
		}
		if (indexSet == null)
		{
			throw new ArgumentNullException("indexSet");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tableView:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:"), tableView.Handle, dropDestination.Handle, indexSet.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INSPasteboardWriting GetPasteboardWriterForRow(this INSTableViewDataSource This, NSTableView tableView, nint row)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		return Runtime.GetINativeObject<INSPasteboardWriting>(Messaging.IntPtr_objc_msgSend_IntPtr_nint(This.Handle, Selector.GetHandle("tableView:pasteboardWriterForRow:"), tableView.Handle, row), owns: false);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DraggingSessionWillBegin(this INSTableViewDataSource This, NSTableView tableView, NSDraggingSession draggingSession, CGPoint willBeginAtScreenPoint, NSIndexSet rowIndexes)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (draggingSession == null)
		{
			throw new ArgumentNullException("draggingSession");
		}
		if (rowIndexes == null)
		{
			throw new ArgumentNullException("rowIndexes");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_CGPoint_IntPtr(This.Handle, Selector.GetHandle("tableView:draggingSession:willBeginAtPoint:forRowIndexes:"), tableView.Handle, draggingSession.Handle, willBeginAtScreenPoint, rowIndexes.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DraggingSessionEnded(this INSTableViewDataSource This, NSTableView tableView, NSDraggingSession draggingSession, CGPoint endedAtScreenPoint, NSDragOperation operation)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (draggingSession == null)
		{
			throw new ArgumentNullException("draggingSession");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_CGPoint_UInt64(This.Handle, Selector.GetHandle("tableView:draggingSession:endedAtPoint:operation:"), tableView.Handle, draggingSession.Handle, endedAtScreenPoint, (ulong)operation);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UpdateDraggingItems(this INSTableViewDataSource This, NSTableView tableView, NSDraggingInfo draggingInfo)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (draggingInfo == null)
		{
			throw new ArgumentNullException("draggingInfo");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tableView:updateDraggingItemsForDrag:"), tableView.Handle, draggingInfo.Handle);
	}
}
