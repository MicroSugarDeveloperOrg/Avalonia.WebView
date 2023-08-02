using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTableViewDataSource", true)]
[Model]
public class NSTableViewDataSource : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTableViewDataSource()
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
	public NSTableViewDataSource(NSCoder coder)
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
	public NSTableViewDataSource(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTableViewDataSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("numberOfRowsInTableView:")]
	public virtual long GetRowCount(NSTableView tableView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:objectValueForTableColumn:row:")]
	public virtual NSObject GetObjectValue(NSTableView tableView, NSTableColumn tableColumn, long row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:setObjectValue:forTableColumn:row:")]
	public virtual void SetObjectValue(NSTableView tableView, NSObject theObject, NSTableColumn tableColumn, long row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:sortDescriptorsDidChange:")]
	public virtual void SortDescriptorsChanged(NSTableView tableView, NSSortDescriptor[] oldDescriptors)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:writeRowsWithIndexes:toPasteboard:")]
	public virtual bool WriteRows(NSTableView tableView, NSIndexSet rowIndexes, NSPasteboard pboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:validateDrop:proposedRow:proposedDropOperation:")]
	public virtual NSDragOperation ValidateDrop(NSTableView tableView, NSDraggingInfo info, long row, NSTableViewDropOperation dropOperation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:acceptDrop:row:dropOperation:")]
	public virtual bool AcceptDrop(NSTableView tableView, NSDraggingInfo info, long row, NSTableViewDropOperation dropOperation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:")]
	public virtual string[] FilesDropped(NSTableView tableView, NSUrl dropDestination, NSIndexSet indexSet)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:pasteboardWriterForRow:")]
	public virtual NSPasteboardWriting GetPasteboardWriterForRow(NSTableView tableView, long row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:draggingSession:willBeginAtPoint:forRowIndexes:")]
	public virtual void DraggingSessionWillBegin(NSTableView tableView, NSDraggingSession draggingSession, CGPoint willBeginAtScreenPoint, NSIndexSet rowIndexes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:draggingSession:endedAtPoint:operation:")]
	public virtual void DraggingSessionEnded(NSTableView tableView, NSDraggingSession draggingSession, CGPoint endedAtScreenPoint, NSDragOperation operation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:updateDraggingItemsForDrag:")]
	public virtual void UpdateDraggingItems(NSTableView tableView, NSDraggingInfo draggingInfo)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
