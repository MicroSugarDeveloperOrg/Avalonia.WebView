using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSTableViewDelegate", false)]
[Model]
public class NSTableViewDelegate : NSObject, INSTableViewDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTableViewDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSTableViewDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTableViewDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
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

	[Export("tableView:rowViewForRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTableRowView CoreGetRowView(NSTableView tableView, nint row)
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

	[Export("tableView:dataCellForTableColumn:row:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCell GetDataCell(NSTableView tableView, NSTableColumn tableColumn, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:nextTypeSelectMatchFromRow:toRow:forString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetNextTypeSelectMatch(NSTableView tableView, nint startRow, nint endRow, string searchString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:heightOfRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetRowHeight(NSTableView tableView, nint row)
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

	[Export("tableView:toolTipForCell:rect:tableColumn:row:mouseLocation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString GetToolTip(NSTableView tableView, NSCell cell, ref CGRect rect, NSTableColumn? tableColumn, nint row, CGPoint mouseLocation)
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
	public virtual void MouseDownInHeaderOfTableColumn(NSTableView tableView, NSTableColumn tableColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:rowActionsForRow:edge:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTableViewRowAction[] RowActions(NSTableView tableView, nint row, NSTableRowActionEdge edge)
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

	[Export("tableView:willDisplayCell:forTableColumn:row:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillDisplayCell(NSTableView tableView, NSObject cell, NSTableColumn tableColumn, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
