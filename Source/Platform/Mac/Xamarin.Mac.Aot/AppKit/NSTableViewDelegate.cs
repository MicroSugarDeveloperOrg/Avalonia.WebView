using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTableViewDelegate", true)]
[Model]
public class NSTableViewDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTableViewDelegate()
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
	public NSTableViewDelegate(NSCoder coder)
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
	public NSTableViewDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTableViewDelegate(IntPtr handle)
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
	public virtual void MouseDownInHeaderOfTableColumn(NSTableView tableView, NSTableColumn tableColumn)
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
	public virtual NSCell GetDataCell(NSTableView tableView, NSTableColumn tableColumn, long row)
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

	[Export("tableView:viewForTableColumn:row:")]
	public virtual NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, long row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:rowViewForRow:")]
	public virtual NSTableRowView CoreGetRowView(NSTableView tableView, long row)
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
}
