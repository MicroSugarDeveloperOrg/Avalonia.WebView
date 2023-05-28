using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTableViewSource", false)]
[Model]
public class NSTableViewSource : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTableViewSource()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSTableViewSource(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTableViewSource(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("tableView:acceptDrop:row:dropOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AcceptDrop(NSTableView tableView, NSDraggingInfo info, nint row, NSTableViewDropOperation dropOperation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableViewColumnDidMove:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ColumnDidMove(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableViewColumnDidResize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ColumnDidResize(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:didAddRowView:forRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidAddRowView(NSTableView tableView, NSTableRowView rowView, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:didClickTableColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidClickTableColumn(NSTableView tableView, NSTableColumn tableColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:didDragTableColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidDragTableColumn(NSTableView tableView, NSTableColumn tableColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:didRemoveRowView:forRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidRemoveRowView(NSTableView tableView, NSTableRowView rowView, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:draggingSession:endedAtPoint:operation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggingSessionEnded(NSTableView tableView, NSDraggingSession draggingSession, CGPoint endedAtScreenPoint, NSDragOperation operation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:draggingSession:willBeginAtPoint:forRowIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggingSessionWillBegin(NSTableView tableView, NSDraggingSession draggingSession, CGPoint willBeginAtScreenPoint, NSIndexSet rowIndexes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSFilePromiseReceiver' objects instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] FilesDropped(NSTableView tableView, NSUrl dropDestination, NSIndexSet indexSet)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:dataCellForTableColumn:row:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCell GetCell(NSTableView tableView, NSTableColumn tableColumn, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:nextTypeSelectMatchFromRow:toRow:forString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetNextTypeSelectMatch(NSTableView tableView, nint startRow, nint endRow, string searchString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:objectValueForTableColumn:row:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetObjectValue(NSTableView tableView, NSTableColumn tableColumn, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:pasteboardWriterForRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSPasteboardWriting GetPasteboardWriterForRow(NSTableView tableView, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("numberOfRowsInTableView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetRowCount(NSTableView tableView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:heightOfRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetRowHeight(NSTableView tableView, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:rowViewForRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTableRowView GetRowView(NSTableView tableView, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:typeSelectStringForTableColumn:row:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetSelectString(NSTableView tableView, NSTableColumn tableColumn, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:selectionIndexesForProposedSelection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet GetSelectionIndexes(NSTableView tableView, NSIndexSet proposedSelectionIndexes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:sizeToFitWidthOfColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetSizeToFitColumnWidth(NSTableView tableView, nint column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:viewForTableColumn:row:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:isGroupRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsGroupRow(NSTableView tableView, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:mouseDownInHeaderOfTableColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MouseDown(NSTableView tableView, NSTableColumn tableColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableViewSelectionDidChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectionDidChange(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableViewSelectionIsChanging:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectionIsChanging(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("selectionShouldChangeInTableView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SelectionShouldChange(NSTableView tableView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:setObjectValue:forTableColumn:row:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetObjectValue(NSTableView tableView, NSObject theObject, NSTableColumn tableColumn, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:shouldEditTableColumn:row:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldEditTableColumn(NSTableView tableView, NSTableColumn tableColumn, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:shouldReorderColumn:toColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldReorder(NSTableView tableView, nint columnIndex, nint newColumnIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:shouldSelectRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldSelectRow(NSTableView tableView, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:shouldSelectTableColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldSelectTableColumn(NSTableView tableView, NSTableColumn tableColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:shouldShowCellExpansionForTableColumn:row:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldShowCellExpansion(NSTableView tableView, NSTableColumn tableColumn, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:shouldTrackCell:forTableColumn:row:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldTrackCell(NSTableView tableView, NSCell cell, NSTableColumn tableColumn, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:shouldTypeSelectForEvent:withCurrentSearchString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldTypeSelect(NSTableView tableView, NSEvent theEvent, string searchString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:sortDescriptorsDidChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SortDescriptorsChanged(NSTableView tableView, NSSortDescriptor[] oldDescriptors)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:updateDraggingItemsForDrag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateDraggingItems(NSTableView tableView, NSDraggingInfo draggingInfo)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:validateDrop:proposedRow:proposedDropOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDragOperation ValidateDrop(NSTableView tableView, NSDraggingInfo info, nint row, NSTableViewDropOperation dropOperation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:willDisplayCell:forTableColumn:row:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillDisplayCell(NSTableView tableView, NSObject cell, NSTableColumn tableColumn, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:writeRowsWithIndexes:toPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteRows(NSTableView tableView, NSIndexSet rowIndexes, NSPasteboard pboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
