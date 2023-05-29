using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTableViewSource", true)]
[Model]
public class NSTableViewSource : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTableViewSource()
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
	public NSTableViewSource(NSCoder coder)
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
	public NSTableViewSource(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTableViewSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("tableView:willDisplayCell:forTableColumn:row:")]
	public virtual void WillDisplayCell(NSTableView tableView, NSObject cell, NSTableColumn tableColumn, long row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:shouldEditTableColumn:row:")]
	public virtual bool ShouldEditTableColumn(NSTableView tableView, NSTableColumn tableColumn, long row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("selectionShouldChangeInTableView:")]
	public virtual bool SelectionShouldChange(NSTableView tableView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:shouldSelectRow:")]
	public virtual bool ShouldSelectRow(NSTableView tableView, long row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:selectionIndexesForProposedSelection:")]
	public virtual NSIndexSet GetSelectionIndexes(NSTableView tableView, NSIndexSet proposedSelectionIndexes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:shouldSelectTableColumn:")]
	public virtual bool ShouldSelectTableColumn(NSTableView tableView, NSTableColumn tableColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:mouseDownInHeaderOfTableColumn:")]
	public virtual void MouseDown(NSTableView tableView, NSTableColumn tableColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:didClickTableColumn:")]
	public virtual void DidClickTableColumn(NSTableView tableView, NSTableColumn tableColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:didDragTableColumn:")]
	public virtual void DidDragTableColumn(NSTableView tableView, NSTableColumn tableColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:heightOfRow:")]
	public virtual double GetRowHeight(NSTableView tableView, long row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:typeSelectStringForTableColumn:row:")]
	public virtual string GetSelectString(NSTableView tableView, NSTableColumn tableColumn, long row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:nextTypeSelectMatchFromRow:toRow:forString:")]
	public virtual long GetNextTypeSelectMatch(NSTableView tableView, long startRow, long endRow, string searchString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:shouldTypeSelectForEvent:withCurrentSearchString:")]
	public virtual bool ShouldTypeSelect(NSTableView tableView, NSEvent theEvent, string searchString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:shouldShowCellExpansionForTableColumn:row:")]
	public virtual bool ShouldShowCellExpansion(NSTableView tableView, NSTableColumn tableColumn, long row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:shouldTrackCell:forTableColumn:row:")]
	public virtual bool ShouldTrackCell(NSTableView tableView, NSCell cell, NSTableColumn tableColumn, long row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:dataCellForTableColumn:row:")]
	public virtual NSCell GetCell(NSTableView tableView, NSTableColumn tableColumn, long row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:isGroupRow:")]
	public virtual bool IsGroupRow(NSTableView tableView, long row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:sizeToFitWidthOfColumn:")]
	public virtual double GetSizeToFitColumnWidth(NSTableView tableView, long column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:shouldReorderColumn:toColumn:")]
	public virtual bool ShouldReorder(NSTableView tableView, long columnIndex, long newColumnIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableViewSelectionDidChange:")]
	public virtual void SelectionDidChange(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableViewColumnDidMove:")]
	public virtual void ColumnDidMove(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableViewColumnDidResize:")]
	public virtual void ColumnDidResize(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableViewSelectionIsChanging:")]
	public virtual void SelectionIsChanging(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
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

	[Export("tableView:viewForTableColumn:row:")]
	public virtual NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, long row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:rowViewForRow:")]
	public virtual NSTableRowView GetRowView(NSTableView tableView, long row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:didAddRowView:forRow:")]
	public virtual void DidAddRowView(NSTableView tableView, NSTableRowView rowView, long row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:didRemoveRowView:forRow:")]
	public virtual void DidRemoveRowView(NSTableView tableView, NSTableRowView rowView, long row)
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
