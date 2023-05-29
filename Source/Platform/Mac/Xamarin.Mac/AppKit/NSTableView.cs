using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTableView", true)]
public class NSTableView : NSControl
{
	[Register]
	private sealed class _NSTableViewDelegate : NSTableViewDelegate
	{
		internal EventHandler<NSTableViewCellEventArgs> willDisplayCell;

		internal NSTableViewColumnRowPredicate shouldEditTableColumn;

		internal NSTableViewPredicate selectionShouldChange;

		internal NSTableViewRowPredicate shouldSelectRow;

		internal NSTableViewIndexFilter getSelectionIndexes;

		internal NSTableViewColumnPredicate shouldSelectTableColumn;

		internal EventHandler<NSTableViewTableEventArgs> mouseDownInHeaderOfTableColumn;

		internal EventHandler<NSTableViewTableEventArgs> didClickTableColumn;

		internal EventHandler<NSTableViewTableEventArgs> didDragTableColumn;

		internal NSTableViewRowHeight getRowHeight;

		internal NSTableViewColumnRowString getSelectString;

		internal NSTableViewSearchString getNextTypeSelectMatch;

		internal NSTableViewEventString shouldTypeSelect;

		internal NSTableViewColumnRowPredicate shouldShowCellExpansion;

		internal NSTableViewCell shouldTrackCell;

		internal NSTableViewCellGetter getDataCell;

		internal NSTableViewRowPredicate isGroupRow;

		internal NSTableViewColumnWidth getSizeToFitColumnWidth;

		internal NSTableReorder shouldReorder;

		internal EventHandler selectionDidChange;

		internal EventHandler columnDidMove;

		internal EventHandler columnDidResize;

		internal EventHandler selectionIsChanging;

		internal NSTableViewViewGetter getViewForItem;

		internal NSTableViewRowGetter coreGetRowView;

		internal EventHandler<NSTableViewRowEventArgs> didAddRowView;

		internal EventHandler<NSTableViewRowEventArgs> didRemoveRowView;

		private static IntPtr selGetRowHeightHandle = Selector.GetHandle("tableView:heightOfRow:");

		private static IntPtr selGetDataCellHandle = Selector.GetHandle("tableView:dataCellForTableColumn:row:");

		private static IntPtr selGetViewForItemHandle = Selector.GetHandle("tableView:viewForTableColumn:row:");

		private static IntPtr selRespondsToSelector = Selector.GetHandle("respondsToSelector:");

		[Preserve(Conditional = true)]
		public override void WillDisplayCell(NSTableView tableView, NSObject cell, NSTableColumn tableColumn, long row)
		{
			EventHandler<NSTableViewCellEventArgs> eventHandler = willDisplayCell;
			if (eventHandler != null)
			{
				NSTableViewCellEventArgs e = new NSTableViewCellEventArgs(cell, tableColumn, row);
				eventHandler(tableView, e);
			}
		}

		[Preserve(Conditional = true)]
		public override bool ShouldEditTableColumn(NSTableView tableView, NSTableColumn tableColumn, long row)
		{
			return shouldEditTableColumn?.Invoke(tableView, tableColumn, row) ?? false;
		}

		[Preserve(Conditional = true)]
		public override bool SelectionShouldChange(NSTableView tableView)
		{
			return selectionShouldChange?.Invoke(tableView) ?? false;
		}

		[Preserve(Conditional = true)]
		public override bool ShouldSelectRow(NSTableView tableView, long row)
		{
			return shouldSelectRow?.Invoke(tableView, row) ?? true;
		}

		[Preserve(Conditional = true)]
		public override NSIndexSet GetSelectionIndexes(NSTableView tableView, NSIndexSet proposedSelectionIndexes)
		{
			NSTableViewIndexFilter nSTableViewIndexFilter = getSelectionIndexes;
			if (nSTableViewIndexFilter != null)
			{
				return nSTableViewIndexFilter(tableView, proposedSelectionIndexes);
			}
			return proposedSelectionIndexes;
		}

		[Preserve(Conditional = true)]
		public override bool ShouldSelectTableColumn(NSTableView tableView, NSTableColumn tableColumn)
		{
			return shouldSelectTableColumn?.Invoke(tableView, tableColumn) ?? true;
		}

		[Preserve(Conditional = true)]
		public override void MouseDownInHeaderOfTableColumn(NSTableView tableView, NSTableColumn tableColumn)
		{
			EventHandler<NSTableViewTableEventArgs> eventHandler = mouseDownInHeaderOfTableColumn;
			if (eventHandler != null)
			{
				NSTableViewTableEventArgs e = new NSTableViewTableEventArgs(tableColumn);
				eventHandler(tableView, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DidClickTableColumn(NSTableView tableView, NSTableColumn tableColumn)
		{
			EventHandler<NSTableViewTableEventArgs> eventHandler = didClickTableColumn;
			if (eventHandler != null)
			{
				NSTableViewTableEventArgs e = new NSTableViewTableEventArgs(tableColumn);
				eventHandler(tableView, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DidDragTableColumn(NSTableView tableView, NSTableColumn tableColumn)
		{
			EventHandler<NSTableViewTableEventArgs> eventHandler = didDragTableColumn;
			if (eventHandler != null)
			{
				NSTableViewTableEventArgs e = new NSTableViewTableEventArgs(tableColumn);
				eventHandler(tableView, e);
			}
		}

		[Preserve(Conditional = true)]
		public override double GetRowHeight(NSTableView tableView, long row)
		{
			NSTableViewRowHeight nSTableViewRowHeight = getRowHeight;
			if (nSTableViewRowHeight != null)
			{
				return nSTableViewRowHeight(tableView, row);
			}
			throw new You_Should_Not_Call_base_In_This_Method();
		}

		[Preserve(Conditional = true)]
		public override string GetSelectString(NSTableView tableView, NSTableColumn tableColumn, long row)
		{
			NSTableViewColumnRowString nSTableViewColumnRowString = getSelectString;
			if (nSTableViewColumnRowString != null)
			{
				return nSTableViewColumnRowString(tableView, tableColumn, row);
			}
			return string.Empty;
		}

		[Preserve(Conditional = true)]
		public override long GetNextTypeSelectMatch(NSTableView tableView, long startRow, long endRow, string searchString)
		{
			return getNextTypeSelectMatch?.Invoke(tableView, startRow, endRow, searchString) ?? (-1);
		}

		[Preserve(Conditional = true)]
		public override bool ShouldTypeSelect(NSTableView tableView, NSEvent theEvent, string searchString)
		{
			return shouldTypeSelect?.Invoke(tableView, theEvent, searchString) ?? false;
		}

		[Preserve(Conditional = true)]
		public override bool ShouldShowCellExpansion(NSTableView tableView, NSTableColumn tableColumn, long row)
		{
			return shouldShowCellExpansion?.Invoke(tableView, tableColumn, row) ?? false;
		}

		[Preserve(Conditional = true)]
		public override bool ShouldTrackCell(NSTableView tableView, NSCell cell, NSTableColumn tableColumn, long row)
		{
			return shouldTrackCell?.Invoke(tableView, cell, tableColumn, row) ?? false;
		}

		[Preserve(Conditional = true)]
		public override NSCell GetDataCell(NSTableView tableView, NSTableColumn tableColumn, long row)
		{
			NSTableViewCellGetter nSTableViewCellGetter = getDataCell;
			if (nSTableViewCellGetter != null)
			{
				return nSTableViewCellGetter(tableView, tableColumn, row);
			}
			throw new You_Should_Not_Call_base_In_This_Method();
		}

		[Preserve(Conditional = true)]
		public override bool IsGroupRow(NSTableView tableView, long row)
		{
			return isGroupRow?.Invoke(tableView, row) ?? false;
		}

		[Preserve(Conditional = true)]
		public override double GetSizeToFitColumnWidth(NSTableView tableView, long column)
		{
			return getSizeToFitColumnWidth?.Invoke(tableView, column) ?? 80.0;
		}

		[Preserve(Conditional = true)]
		public override bool ShouldReorder(NSTableView tableView, long columnIndex, long newColumnIndex)
		{
			return shouldReorder?.Invoke(tableView, columnIndex, newColumnIndex) ?? false;
		}

		[Preserve(Conditional = true)]
		public override void SelectionDidChange(NSNotification notification)
		{
			selectionDidChange?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void ColumnDidMove(NSNotification notification)
		{
			columnDidMove?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void ColumnDidResize(NSNotification notification)
		{
			columnDidResize?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void SelectionIsChanging(NSNotification notification)
		{
			selectionIsChanging?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, long row)
		{
			NSTableViewViewGetter nSTableViewViewGetter = getViewForItem;
			if (nSTableViewViewGetter != null)
			{
				return nSTableViewViewGetter(tableView, tableColumn, row);
			}
			throw new You_Should_Not_Call_base_In_This_Method();
		}

		[Preserve(Conditional = true)]
		public override NSTableRowView CoreGetRowView(NSTableView tableView, long row)
		{
			return coreGetRowView?.Invoke(tableView, row);
		}

		[Preserve(Conditional = true)]
		public override void DidAddRowView(NSTableView tableView, NSTableRowView rowView, long row)
		{
			EventHandler<NSTableViewRowEventArgs> eventHandler = didAddRowView;
			if (eventHandler != null)
			{
				NSTableViewRowEventArgs e = new NSTableViewRowEventArgs(rowView, row);
				eventHandler(tableView, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DidRemoveRowView(NSTableView tableView, NSTableRowView rowView, long row)
		{
			EventHandler<NSTableViewRowEventArgs> eventHandler = didRemoveRowView;
			if (eventHandler != null)
			{
				NSTableViewRowEventArgs e = new NSTableViewRowEventArgs(rowView, row);
				eventHandler(tableView, e);
			}
		}

		public override bool RespondsToSelector(Selector sel)
		{
			IntPtr arg = sel.Handle;
			if (arg.Equals((object?)(nint)selGetRowHeightHandle))
			{
				return getRowHeight != null;
			}
			if (arg.Equals((object?)(nint)selGetDataCellHandle))
			{
				return getDataCell != null;
			}
			if (arg.Equals((object?)(nint)selGetViewForItemHandle))
			{
				return getViewForItem != null;
			}
			return Messaging.bool_objc_msgSendSuper_intptr(base.SuperHandle, selRespondsToSelector, arg);
		}
	}

	private static readonly IntPtr selNumberOfColumnsHandle = Selector.GetHandle("numberOfColumns");

	private static readonly IntPtr selNumberOfRowsHandle = Selector.GetHandle("numberOfRows");

	private static readonly IntPtr selEditedColumnHandle = Selector.GetHandle("editedColumn");

	private static readonly IntPtr selEditedRowHandle = Selector.GetHandle("editedRow");

	private static readonly IntPtr selClickedColumnHandle = Selector.GetHandle("clickedColumn");

	private static readonly IntPtr selClickedRowHandle = Selector.GetHandle("clickedRow");

	private static readonly IntPtr selSelectedColumnIndexesHandle = Selector.GetHandle("selectedColumnIndexes");

	private static readonly IntPtr selSelectedRowIndexesHandle = Selector.GetHandle("selectedRowIndexes");

	private static readonly IntPtr selSelectedColumnHandle = Selector.GetHandle("selectedColumn");

	private static readonly IntPtr selSelectedRowHandle = Selector.GetHandle("selectedRow");

	private static readonly IntPtr selNumberOfSelectedColumnsHandle = Selector.GetHandle("numberOfSelectedColumns");

	private static readonly IntPtr selNumberOfSelectedRowsHandle = Selector.GetHandle("numberOfSelectedRows");

	private static readonly IntPtr selDataSourceHandle = Selector.GetHandle("dataSource");

	private static readonly IntPtr selSetDataSource_Handle = Selector.GetHandle("setDataSource:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selHeaderViewHandle = Selector.GetHandle("headerView");

	private static readonly IntPtr selSetHeaderView_Handle = Selector.GetHandle("setHeaderView:");

	private static readonly IntPtr selCornerViewHandle = Selector.GetHandle("cornerView");

	private static readonly IntPtr selSetCornerView_Handle = Selector.GetHandle("setCornerView:");

	private static readonly IntPtr selAllowsColumnReorderingHandle = Selector.GetHandle("allowsColumnReordering");

	private static readonly IntPtr selSetAllowsColumnReordering_Handle = Selector.GetHandle("setAllowsColumnReordering:");

	private static readonly IntPtr selAllowsColumnResizingHandle = Selector.GetHandle("allowsColumnResizing");

	private static readonly IntPtr selSetAllowsColumnResizing_Handle = Selector.GetHandle("setAllowsColumnResizing:");

	private static readonly IntPtr selColumnAutoresizingStyleHandle = Selector.GetHandle("columnAutoresizingStyle");

	private static readonly IntPtr selSetColumnAutoresizingStyle_Handle = Selector.GetHandle("setColumnAutoresizingStyle:");

	private static readonly IntPtr selGridStyleMaskHandle = Selector.GetHandle("gridStyleMask");

	private static readonly IntPtr selSetGridStyleMask_Handle = Selector.GetHandle("setGridStyleMask:");

	private static readonly IntPtr selIntercellSpacingHandle = Selector.GetHandle("intercellSpacing");

	private static readonly IntPtr selSetIntercellSpacing_Handle = Selector.GetHandle("setIntercellSpacing:");

	private static readonly IntPtr selUsesAlternatingRowBackgroundColorsHandle = Selector.GetHandle("usesAlternatingRowBackgroundColors");

	private static readonly IntPtr selSetUsesAlternatingRowBackgroundColors_Handle = Selector.GetHandle("setUsesAlternatingRowBackgroundColors:");

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	private static readonly IntPtr selGridColorHandle = Selector.GetHandle("gridColor");

	private static readonly IntPtr selSetGridColor_Handle = Selector.GetHandle("setGridColor:");

	private static readonly IntPtr selRowHeightHandle = Selector.GetHandle("rowHeight");

	private static readonly IntPtr selSetRowHeight_Handle = Selector.GetHandle("setRowHeight:");

	private static readonly IntPtr selDoubleActionHandle = Selector.GetHandle("doubleAction");

	private static readonly IntPtr selSetDoubleAction_Handle = Selector.GetHandle("setDoubleAction:");

	private static readonly IntPtr selSortDescriptorsHandle = Selector.GetHandle("sortDescriptors");

	private static readonly IntPtr selSetSortDescriptors_Handle = Selector.GetHandle("setSortDescriptors:");

	private static readonly IntPtr selHighlightedTableColumnHandle = Selector.GetHandle("highlightedTableColumn");

	private static readonly IntPtr selSetHighlightedTableColumn_Handle = Selector.GetHandle("setHighlightedTableColumn:");

	private static readonly IntPtr selVerticalMotionCanBeginDragHandle = Selector.GetHandle("verticalMotionCanBeginDrag");

	private static readonly IntPtr selSetVerticalMotionCanBeginDrag_Handle = Selector.GetHandle("setVerticalMotionCanBeginDrag:");

	private static readonly IntPtr selAllowsMultipleSelectionHandle = Selector.GetHandle("allowsMultipleSelection");

	private static readonly IntPtr selSetAllowsMultipleSelection_Handle = Selector.GetHandle("setAllowsMultipleSelection:");

	private static readonly IntPtr selAllowsEmptySelectionHandle = Selector.GetHandle("allowsEmptySelection");

	private static readonly IntPtr selSetAllowsEmptySelection_Handle = Selector.GetHandle("setAllowsEmptySelection:");

	private static readonly IntPtr selAllowsColumnSelectionHandle = Selector.GetHandle("allowsColumnSelection");

	private static readonly IntPtr selSetAllowsColumnSelection_Handle = Selector.GetHandle("setAllowsColumnSelection:");

	private static readonly IntPtr selAllowsTypeSelectHandle = Selector.GetHandle("allowsTypeSelect");

	private static readonly IntPtr selSetAllowsTypeSelect_Handle = Selector.GetHandle("setAllowsTypeSelect:");

	private static readonly IntPtr selSelectionHighlightStyleHandle = Selector.GetHandle("selectionHighlightStyle");

	private static readonly IntPtr selSetSelectionHighlightStyle_Handle = Selector.GetHandle("setSelectionHighlightStyle:");

	private static readonly IntPtr selDraggingDestinationFeedbackStyleHandle = Selector.GetHandle("draggingDestinationFeedbackStyle");

	private static readonly IntPtr selSetDraggingDestinationFeedbackStyle_Handle = Selector.GetHandle("setDraggingDestinationFeedbackStyle:");

	private static readonly IntPtr selAutosaveNameHandle = Selector.GetHandle("autosaveName");

	private static readonly IntPtr selSetAutosaveName_Handle = Selector.GetHandle("setAutosaveName:");

	private static readonly IntPtr selAutosaveTableColumnsHandle = Selector.GetHandle("autosaveTableColumns");

	private static readonly IntPtr selSetAutosaveTableColumns_Handle = Selector.GetHandle("setAutosaveTableColumns:");

	private static readonly IntPtr selFocusedColumnHandle = Selector.GetHandle("focusedColumn");

	private static readonly IntPtr selSetFocusedColumn_Handle = Selector.GetHandle("setFocusedColumn:");

	private static readonly IntPtr selEffectiveRowSizeStyleHandle = Selector.GetHandle("effectiveRowSizeStyle");

	private static readonly IntPtr selRowSizeStyleHandle = Selector.GetHandle("rowSizeStyle");

	private static readonly IntPtr selSetRowSizeStyle_Handle = Selector.GetHandle("setRowSizeStyle:");

	private static readonly IntPtr selFloatsGroupRowsHandle = Selector.GetHandle("floatsGroupRows");

	private static readonly IntPtr selSetFloatsGroupRows_Handle = Selector.GetHandle("setFloatsGroupRows:");

	private static readonly IntPtr selIgnoreModifierKeysWhileDraggingHandle = Selector.GetHandle("ignoreModifierKeysWhileDragging");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selNoteHeightOfRowsWithIndexesChanged_Handle = Selector.GetHandle("noteHeightOfRowsWithIndexesChanged:");

	private static readonly IntPtr selTableColumnsHandle = Selector.GetHandle("tableColumns");

	private static readonly IntPtr selAddTableColumn_Handle = Selector.GetHandle("addTableColumn:");

	private static readonly IntPtr selRemoveTableColumn_Handle = Selector.GetHandle("removeTableColumn:");

	private static readonly IntPtr selMoveColumnToColumn_Handle = Selector.GetHandle("moveColumn:toColumn:");

	private static readonly IntPtr selColumnWithIdentifier_Handle = Selector.GetHandle("columnWithIdentifier:");

	private static readonly IntPtr selTableColumnWithIdentifier_Handle = Selector.GetHandle("tableColumnWithIdentifier:");

	private static readonly IntPtr selTileHandle = Selector.GetHandle("tile");

	private static readonly IntPtr selSizeToFitHandle = Selector.GetHandle("sizeToFit");

	private static readonly IntPtr selSizeLastColumnToFitHandle = Selector.GetHandle("sizeLastColumnToFit");

	private static readonly IntPtr selScrollRowToVisible_Handle = Selector.GetHandle("scrollRowToVisible:");

	private static readonly IntPtr selScrollColumnToVisible_Handle = Selector.GetHandle("scrollColumnToVisible:");

	private static readonly IntPtr selReloadDataHandle = Selector.GetHandle("reloadData");

	private static readonly IntPtr selNoteNumberOfRowsChangedHandle = Selector.GetHandle("noteNumberOfRowsChanged");

	private static readonly IntPtr selReloadDataForRowIndexesColumnIndexes_Handle = Selector.GetHandle("reloadDataForRowIndexes:columnIndexes:");

	private static readonly IntPtr selSetIndicatorImageInTableColumn_Handle = Selector.GetHandle("setIndicatorImage:inTableColumn:");

	private static readonly IntPtr selIndicatorImageInTableColumn_Handle = Selector.GetHandle("indicatorImageInTableColumn:");

	private static readonly IntPtr selCanDragRowsWithIndexesAtPoint_Handle = Selector.GetHandle("canDragRowsWithIndexes:atPoint:");

	private static readonly IntPtr selSetDraggingSourceOperationMaskForLocal_Handle = Selector.GetHandle("setDraggingSourceOperationMask:forLocal:");

	private static readonly IntPtr selSetDropRowDropOperation_Handle = Selector.GetHandle("setDropRow:dropOperation:");

	private static readonly IntPtr selSelectAll_Handle = Selector.GetHandle("selectAll:");

	private static readonly IntPtr selDeselectAll_Handle = Selector.GetHandle("deselectAll:");

	private static readonly IntPtr selSelectColumnIndexesByExtendingSelection_Handle = Selector.GetHandle("selectColumnIndexes:byExtendingSelection:");

	private static readonly IntPtr selSelectRowIndexesByExtendingSelection_Handle = Selector.GetHandle("selectRowIndexes:byExtendingSelection:");

	private static readonly IntPtr selDeselectColumn_Handle = Selector.GetHandle("deselectColumn:");

	private static readonly IntPtr selDeselectRow_Handle = Selector.GetHandle("deselectRow:");

	private static readonly IntPtr selIsColumnSelected_Handle = Selector.GetHandle("isColumnSelected:");

	private static readonly IntPtr selIsRowSelected_Handle = Selector.GetHandle("isRowSelected:");

	private static readonly IntPtr selRectOfColumn_Handle = Selector.GetHandle("rectOfColumn:");

	private static readonly IntPtr selRectOfRow_Handle = Selector.GetHandle("rectOfRow:");

	private static readonly IntPtr selColumnIndexesInRect_Handle = Selector.GetHandle("columnIndexesInRect:");

	private static readonly IntPtr selRowsInRect_Handle = Selector.GetHandle("rowsInRect:");

	private static readonly IntPtr selColumnAtPoint_Handle = Selector.GetHandle("columnAtPoint:");

	private static readonly IntPtr selRowAtPoint_Handle = Selector.GetHandle("rowAtPoint:");

	private static readonly IntPtr selFrameOfCellAtColumnRow_Handle = Selector.GetHandle("frameOfCellAtColumn:row:");

	private static readonly IntPtr selPreparedCellAtColumnRow_Handle = Selector.GetHandle("preparedCellAtColumn:row:");

	private static readonly IntPtr selTextShouldBeginEditing_Handle = Selector.GetHandle("textShouldBeginEditing:");

	private static readonly IntPtr selTextShouldEndEditing_Handle = Selector.GetHandle("textShouldEndEditing:");

	private static readonly IntPtr selTextDidBeginEditing_Handle = Selector.GetHandle("textDidBeginEditing:");

	private static readonly IntPtr selTextDidEndEditing_Handle = Selector.GetHandle("textDidEndEditing:");

	private static readonly IntPtr selTextDidChange_Handle = Selector.GetHandle("textDidChange:");

	private static readonly IntPtr selShouldFocusCellAtColumnRow_Handle = Selector.GetHandle("shouldFocusCell:atColumn:row:");

	private static readonly IntPtr selPerformClickOnCellAtColumnRow_Handle = Selector.GetHandle("performClickOnCellAtColumn:row:");

	private static readonly IntPtr selEditColumnRowWithEventSelect_Handle = Selector.GetHandle("editColumn:row:withEvent:select:");

	private static readonly IntPtr selDrawRowClipRect_Handle = Selector.GetHandle("drawRow:clipRect:");

	private static readonly IntPtr selHighlightSelectionInClipRect_Handle = Selector.GetHandle("highlightSelectionInClipRect:");

	private static readonly IntPtr selDrawGridInClipRect_Handle = Selector.GetHandle("drawGridInClipRect:");

	private static readonly IntPtr selDrawBackgroundInClipRect_Handle = Selector.GetHandle("drawBackgroundInClipRect:");

	private static readonly IntPtr selViewAtColumnRowMakeIfNecessary_Handle = Selector.GetHandle("viewAtColumn:row:makeIfNecessary:");

	private static readonly IntPtr selRowViewAtRowMakeIfNecessary_Handle = Selector.GetHandle("rowViewAtRow:makeIfNecessary:");

	private static readonly IntPtr selRowForView_Handle = Selector.GetHandle("rowForView:");

	private static readonly IntPtr selColumnForView_Handle = Selector.GetHandle("columnForView:");

	private static readonly IntPtr selMakeViewWithIdentifierOwner_Handle = Selector.GetHandle("makeViewWithIdentifier:owner:");

	private static readonly IntPtr selEnumerateAvailableRowViewsUsingBlock_Handle = Selector.GetHandle("enumerateAvailableRowViewsUsingBlock:");

	private static readonly IntPtr selBeginUpdatesHandle = Selector.GetHandle("beginUpdates");

	private static readonly IntPtr selEndUpdatesHandle = Selector.GetHandle("endUpdates");

	private static readonly IntPtr selInsertRowsAtIndexesWithAnimation_Handle = Selector.GetHandle("insertRowsAtIndexes:withAnimation:");

	private static readonly IntPtr selRemoveRowsAtIndexesWithAnimation_Handle = Selector.GetHandle("removeRowsAtIndexes:withAnimation:");

	private static readonly IntPtr selMoveRowAtIndexToIndex_Handle = Selector.GetHandle("moveRowAtIndex:toIndex:");

	private static readonly IntPtr selDraggingSourceOperationMaskForLocal_Handle = Selector.GetHandle("draggingSourceOperationMaskForLocal:");

	private static readonly IntPtr selNamesOfPromisedFilesDroppedAtDestination_Handle = Selector.GetHandle("namesOfPromisedFilesDroppedAtDestination:");

	private static readonly IntPtr selDraggedImageBeganAt_Handle = Selector.GetHandle("draggedImage:beganAt:");

	private static readonly IntPtr selDraggedImageEndedAtOperation_Handle = Selector.GetHandle("draggedImage:endedAt:operation:");

	private static readonly IntPtr selDraggedImageMovedTo_Handle = Selector.GetHandle("draggedImage:movedTo:");

	private static readonly IntPtr selDraggedImageEndedAtDeposited_Handle = Selector.GetHandle("draggedImage:endedAt:deposited:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTableView");

	private object __mt_SelectedColumns_var;

	private object __mt_SelectedRows_var;

	private object __mt_WeakDataSource_var;

	private object __mt_WeakDelegate_var;

	private object __mt_HeaderView_var;

	private object __mt_CornerView_var;

	private object __mt_BackgroundColor_var;

	private object __mt_GridColor_var;

	private object __mt_SortDescriptors_var;

	private object __mt_HighlightedTableColumn_var;

	private static NSString _RowViewKey;

	public NSTableViewSource Source
	{
		get
		{
			if (WeakDelegate is NSTableViewSource result)
			{
				return result;
			}
			return null;
		}
		set
		{
			WeakDelegate = value;
			WeakDataSource = value;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public virtual long ColumnCount
	{
		[Export("numberOfColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNumberOfColumnsHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNumberOfColumnsHandle);
		}
	}

	public virtual long RowCount
	{
		[Export("numberOfRows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNumberOfRowsHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNumberOfRowsHandle);
		}
	}

	public virtual long EditedColumn
	{
		[Export("editedColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selEditedColumnHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selEditedColumnHandle);
		}
	}

	public virtual long EditedRow
	{
		[Export("editedRow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selEditedRowHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selEditedRowHandle);
		}
	}

	public virtual long ClickedColumn
	{
		[Export("clickedColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selClickedColumnHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selClickedColumnHandle);
		}
	}

	public virtual long ClickedRow
	{
		[Export("clickedRow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selClickedRowHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selClickedRowHandle);
		}
	}

	public virtual NSIndexSet SelectedColumns
	{
		[Export("selectedColumnIndexes")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSIndexSet)(__mt_SelectedColumns_var = ((!IsDirectBinding) ? ((NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedColumnIndexesHandle))) : ((NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedColumnIndexesHandle)))));
		}
	}

	public virtual NSIndexSet SelectedRows
	{
		[Export("selectedRowIndexes")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSIndexSet)(__mt_SelectedRows_var = ((!IsDirectBinding) ? ((NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedRowIndexesHandle))) : ((NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedRowIndexesHandle)))));
		}
	}

	public virtual int SelectedColumn
	{
		[Export("selectedColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selSelectedColumnHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selSelectedColumnHandle);
		}
	}

	public virtual long SelectedRow
	{
		[Export("selectedRow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selSelectedRowHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSelectedRowHandle);
		}
	}

	public virtual long SelectedColumnsCount
	{
		[Export("numberOfSelectedColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNumberOfSelectedColumnsHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNumberOfSelectedColumnsHandle);
		}
	}

	public virtual long SelectedRowCount
	{
		[Export("numberOfSelectedRows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNumberOfSelectedRowsHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNumberOfSelectedRowsHandle);
		}
	}

	public virtual NSObject WeakDataSource
	{
		[Export("dataSource")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDataSource_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataSourceHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataSourceHandle))));
		}
		[Export("setDataSource:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDataSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDataSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDataSource_var = value;
		}
	}

	public NSTableViewDataSource DataSource
	{
		get
		{
			return WeakDataSource as NSTableViewDataSource;
		}
		set
		{
			WeakDataSource = value;
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public NSTableViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSTableViewDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual NSTableHeaderView HeaderView
	{
		[Export("headerView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTableHeaderView)(__mt_HeaderView_var = ((!IsDirectBinding) ? ((NSTableHeaderView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHeaderViewHandle))) : ((NSTableHeaderView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selHeaderViewHandle)))));
		}
		[Export("setHeaderView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHeaderView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHeaderView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_HeaderView_var = value;
		}
	}

	public virtual NSView CornerView
	{
		[Export("cornerView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_CornerView_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCornerViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCornerViewHandle)))));
		}
		[Export("setCornerView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCornerView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCornerView_Handle, value.Handle);
			}
			__mt_CornerView_var = value;
		}
	}

	public virtual bool AllowsColumnReordering
	{
		[Export("allowsColumnReordering")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsColumnReorderingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsColumnReorderingHandle);
		}
		[Export("setAllowsColumnReordering:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsColumnReordering_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsColumnReordering_Handle, value);
			}
		}
	}

	public virtual bool AllowsColumnResizing
	{
		[Export("allowsColumnResizing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsColumnResizingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsColumnResizingHandle);
		}
		[Export("setAllowsColumnResizing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsColumnResizing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsColumnResizing_Handle, value);
			}
		}
	}

	public virtual NSTableViewColumnAutoresizingStyle ColumnAutoresizingStyle
	{
		[Export("columnAutoresizingStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTableViewColumnAutoresizingStyle)Messaging.UInt64_objc_msgSend(base.Handle, selColumnAutoresizingStyleHandle);
			}
			return (NSTableViewColumnAutoresizingStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selColumnAutoresizingStyleHandle);
		}
		[Export("setColumnAutoresizingStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetColumnAutoresizingStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetColumnAutoresizingStyle_Handle, (ulong)value);
			}
		}
	}

	public virtual NSTableViewGridStyle GridStyleMask
	{
		[Export("gridStyleMask")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTableViewGridStyle)Messaging.UInt64_objc_msgSend(base.Handle, selGridStyleMaskHandle);
			}
			return (NSTableViewGridStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selGridStyleMaskHandle);
		}
		[Export("setGridStyleMask:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetGridStyleMask_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetGridStyleMask_Handle, (ulong)value);
			}
		}
	}

	public virtual CGSize IntercellSpacing
	{
		[Export("intercellSpacing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selIntercellSpacingHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selIntercellSpacingHandle);
		}
		[Export("setIntercellSpacing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetIntercellSpacing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetIntercellSpacing_Handle, value);
			}
		}
	}

	public virtual bool UsesAlternatingRowBackgroundColors
	{
		[Export("usesAlternatingRowBackgroundColors")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesAlternatingRowBackgroundColorsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesAlternatingRowBackgroundColorsHandle);
		}
		[Export("setUsesAlternatingRowBackgroundColors:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesAlternatingRowBackgroundColors_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesAlternatingRowBackgroundColors_Handle, value);
			}
		}
	}

	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_BackgroundColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle)))));
		}
		[Export("setBackgroundColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
			__mt_BackgroundColor_var = value;
		}
	}

	public virtual NSColor GridColor
	{
		[Export("gridColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_GridColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGridColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selGridColorHandle)))));
		}
		[Export("setGridColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGridColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGridColor_Handle, value.Handle);
			}
			__mt_GridColor_var = value;
		}
	}

	public virtual double RowHeight
	{
		[Export("rowHeight")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selRowHeightHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selRowHeightHandle);
		}
		[Export("setRowHeight:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetRowHeight_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetRowHeight_Handle, value);
			}
		}
	}

	public virtual Selector DoubleAction
	{
		[Export("doubleAction")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDoubleActionHandle));
			}
			return Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDoubleActionHandle));
		}
		[Export("setDoubleAction:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDoubleAction_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDoubleAction_Handle, value.Handle);
			}
		}
	}

	public virtual NSSortDescriptor[] SortDescriptors
	{
		[Export("sortDescriptors")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSSortDescriptor[])(__mt_SortDescriptors_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSSortDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSortDescriptorsHandle)) : NSArray.ArrayFromHandle<NSSortDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selSortDescriptorsHandle))));
		}
		[Export("setSortDescriptors:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSortDescriptors_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSortDescriptors_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_SortDescriptors_var = value;
		}
	}

	public virtual NSTableColumn HighlightedTableColumn
	{
		[Export("highlightedTableColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTableColumn)(__mt_HighlightedTableColumn_var = ((!IsDirectBinding) ? ((NSTableColumn)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHighlightedTableColumnHandle))) : ((NSTableColumn)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selHighlightedTableColumnHandle)))));
		}
		[Export("setHighlightedTableColumn:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHighlightedTableColumn_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHighlightedTableColumn_Handle, value.Handle);
			}
			__mt_HighlightedTableColumn_var = value;
		}
	}

	public virtual bool VerticalMotionCanBeginDrag
	{
		[Export("verticalMotionCanBeginDrag")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selVerticalMotionCanBeginDragHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selVerticalMotionCanBeginDragHandle);
		}
		[Export("setVerticalMotionCanBeginDrag:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetVerticalMotionCanBeginDrag_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetVerticalMotionCanBeginDrag_Handle, value);
			}
		}
	}

	public virtual bool AllowsMultipleSelection
	{
		[Export("allowsMultipleSelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsMultipleSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsMultipleSelectionHandle);
		}
		[Export("setAllowsMultipleSelection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsMultipleSelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsMultipleSelection_Handle, value);
			}
		}
	}

	public virtual bool AllowsEmptySelection
	{
		[Export("allowsEmptySelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsEmptySelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsEmptySelectionHandle);
		}
		[Export("setAllowsEmptySelection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsEmptySelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsEmptySelection_Handle, value);
			}
		}
	}

	public virtual bool AllowsColumnSelection
	{
		[Export("allowsColumnSelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsColumnSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsColumnSelectionHandle);
		}
		[Export("setAllowsColumnSelection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsColumnSelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsColumnSelection_Handle, value);
			}
		}
	}

	public virtual bool AllowsTypeSelect
	{
		[Export("allowsTypeSelect")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsTypeSelectHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsTypeSelectHandle);
		}
		[Export("setAllowsTypeSelect:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsTypeSelect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsTypeSelect_Handle, value);
			}
		}
	}

	public virtual NSTableViewSelectionHighlightStyle SelectionHighlightStyle
	{
		[Export("selectionHighlightStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTableViewSelectionHighlightStyle)Messaging.Int64_objc_msgSend(base.Handle, selSelectionHighlightStyleHandle);
			}
			return (NSTableViewSelectionHighlightStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSelectionHighlightStyleHandle);
		}
		[Export("setSelectionHighlightStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetSelectionHighlightStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetSelectionHighlightStyle_Handle, (long)value);
			}
		}
	}

	public virtual NSTableViewDraggingDestinationFeedbackStyle DraggingDestinationFeedbackStyle
	{
		[Export("draggingDestinationFeedbackStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTableViewDraggingDestinationFeedbackStyle)Messaging.Int64_objc_msgSend(base.Handle, selDraggingDestinationFeedbackStyleHandle);
			}
			return (NSTableViewDraggingDestinationFeedbackStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDraggingDestinationFeedbackStyleHandle);
		}
		[Export("setDraggingDestinationFeedbackStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDraggingDestinationFeedbackStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDraggingDestinationFeedbackStyle_Handle, (long)value);
			}
		}
	}

	public virtual string AutosaveName
	{
		[Export("autosaveName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAutosaveNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAutosaveNameHandle));
		}
		[Export("setAutosaveName:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAutosaveName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAutosaveName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool AutosaveTableColumns
	{
		[Export("autosaveTableColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutosaveTableColumnsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutosaveTableColumnsHandle);
		}
		[Export("setAutosaveTableColumns:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutosaveTableColumns_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutosaveTableColumns_Handle, value);
			}
		}
	}

	public virtual long FocusedColumn
	{
		[Export("focusedColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selFocusedColumnHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFocusedColumnHandle);
		}
		[Export("setFocusedColumn:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetFocusedColumn_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetFocusedColumn_Handle, value);
			}
		}
	}

	public virtual NSTableViewRowSizeStyle EffectiveRowSizeStyle
	{
		[Export("effectiveRowSizeStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTableViewRowSizeStyle)Messaging.Int64_objc_msgSend(base.Handle, selEffectiveRowSizeStyleHandle);
			}
			return (NSTableViewRowSizeStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selEffectiveRowSizeStyleHandle);
		}
	}

	public virtual NSTableViewRowSizeStyle RowSizeStyle
	{
		[Export("rowSizeStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTableViewRowSizeStyle)Messaging.Int64_objc_msgSend(base.Handle, selRowSizeStyleHandle);
			}
			return (NSTableViewRowSizeStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRowSizeStyleHandle);
		}
		[Export("setRowSizeStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetRowSizeStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetRowSizeStyle_Handle, (long)value);
			}
		}
	}

	public virtual bool FloatsGroupRows
	{
		[Export("floatsGroupRows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selFloatsGroupRowsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFloatsGroupRowsHandle);
		}
		[Export("setFloatsGroupRows:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFloatsGroupRows_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFloatsGroupRows_Handle, value);
			}
		}
	}

	public virtual bool IgnoreModifierKeysWhileDragging
	{
		[Export("ignoreModifierKeysWhileDragging")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIgnoreModifierKeysWhileDraggingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIgnoreModifierKeysWhileDraggingHandle);
		}
	}

	[Field("NSTableViewRowViewKey", "AppKit")]
	public static NSString RowViewKey
	{
		get
		{
			if (_RowViewKey == null)
			{
				_RowViewKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTableViewRowViewKey");
			}
			return _RowViewKey;
		}
	}

	public NSTableViewColumnRowPredicate ShouldEditTableColumn
	{
		get
		{
			return EnsureNSTableViewDelegate().shouldEditTableColumn;
		}
		set
		{
			EnsureNSTableViewDelegate().shouldEditTableColumn = value;
		}
	}

	public NSTableViewPredicate SelectionShouldChange
	{
		get
		{
			return EnsureNSTableViewDelegate().selectionShouldChange;
		}
		set
		{
			EnsureNSTableViewDelegate().selectionShouldChange = value;
		}
	}

	public NSTableViewRowPredicate ShouldSelectRow
	{
		get
		{
			return EnsureNSTableViewDelegate().shouldSelectRow;
		}
		set
		{
			EnsureNSTableViewDelegate().shouldSelectRow = value;
		}
	}

	public NSTableViewIndexFilter GetSelectionIndexes
	{
		get
		{
			return EnsureNSTableViewDelegate().getSelectionIndexes;
		}
		set
		{
			EnsureNSTableViewDelegate().getSelectionIndexes = value;
		}
	}

	public NSTableViewColumnPredicate ShouldSelectTableColumn
	{
		get
		{
			return EnsureNSTableViewDelegate().shouldSelectTableColumn;
		}
		set
		{
			EnsureNSTableViewDelegate().shouldSelectTableColumn = value;
		}
	}

	public NSTableViewRowHeight GetRowHeight
	{
		get
		{
			return EnsureNSTableViewDelegate().getRowHeight;
		}
		set
		{
			EnsureNSTableViewDelegate().getRowHeight = value;
		}
	}

	public NSTableViewColumnRowString GetSelectString
	{
		get
		{
			return EnsureNSTableViewDelegate().getSelectString;
		}
		set
		{
			EnsureNSTableViewDelegate().getSelectString = value;
		}
	}

	public NSTableViewSearchString GetNextTypeSelectMatch
	{
		get
		{
			return EnsureNSTableViewDelegate().getNextTypeSelectMatch;
		}
		set
		{
			EnsureNSTableViewDelegate().getNextTypeSelectMatch = value;
		}
	}

	public NSTableViewEventString ShouldTypeSelect
	{
		get
		{
			return EnsureNSTableViewDelegate().shouldTypeSelect;
		}
		set
		{
			EnsureNSTableViewDelegate().shouldTypeSelect = value;
		}
	}

	public NSTableViewColumnRowPredicate ShouldShowCellExpansion
	{
		get
		{
			return EnsureNSTableViewDelegate().shouldShowCellExpansion;
		}
		set
		{
			EnsureNSTableViewDelegate().shouldShowCellExpansion = value;
		}
	}

	public NSTableViewCell ShouldTrackCell
	{
		get
		{
			return EnsureNSTableViewDelegate().shouldTrackCell;
		}
		set
		{
			EnsureNSTableViewDelegate().shouldTrackCell = value;
		}
	}

	public NSTableViewCellGetter GetDataCell
	{
		get
		{
			return EnsureNSTableViewDelegate().getDataCell;
		}
		set
		{
			EnsureNSTableViewDelegate().getDataCell = value;
		}
	}

	public NSTableViewRowPredicate IsGroupRow
	{
		get
		{
			return EnsureNSTableViewDelegate().isGroupRow;
		}
		set
		{
			EnsureNSTableViewDelegate().isGroupRow = value;
		}
	}

	public NSTableViewColumnWidth GetSizeToFitColumnWidth
	{
		get
		{
			return EnsureNSTableViewDelegate().getSizeToFitColumnWidth;
		}
		set
		{
			EnsureNSTableViewDelegate().getSizeToFitColumnWidth = value;
		}
	}

	public NSTableReorder ShouldReorder
	{
		get
		{
			return EnsureNSTableViewDelegate().shouldReorder;
		}
		set
		{
			EnsureNSTableViewDelegate().shouldReorder = value;
		}
	}

	public NSTableViewViewGetter GetViewForItem
	{
		get
		{
			return EnsureNSTableViewDelegate().getViewForItem;
		}
		set
		{
			EnsureNSTableViewDelegate().getViewForItem = value;
		}
	}

	public NSTableViewRowGetter CoreGetRowView
	{
		get
		{
			return EnsureNSTableViewDelegate().coreGetRowView;
		}
		set
		{
			EnsureNSTableViewDelegate().coreGetRowView = value;
		}
	}

	public event EventHandler DoubleClick
	{
		add
		{
			Target = ActionDispatcher.SetupDoubleAction(Target, value);
			DoubleAction = ActionDispatcher.DoubleAction;
		}
		remove
		{
			ActionDispatcher.RemoveDoubleAction(Target, value);
		}
	}

	public event EventHandler<NSTableViewCellEventArgs> WillDisplayCell
	{
		add
		{
			_NSTableViewDelegate nSTableViewDelegate = EnsureNSTableViewDelegate();
			nSTableViewDelegate.willDisplayCell = (EventHandler<NSTableViewCellEventArgs>)System.Delegate.Combine(nSTableViewDelegate.willDisplayCell, value);
		}
		remove
		{
			_NSTableViewDelegate nSTableViewDelegate = EnsureNSTableViewDelegate();
			nSTableViewDelegate.willDisplayCell = (EventHandler<NSTableViewCellEventArgs>)System.Delegate.Remove(nSTableViewDelegate.willDisplayCell, value);
		}
	}

	public event EventHandler<NSTableViewTableEventArgs> MouseDownInHeaderOfTableColumn
	{
		add
		{
			_NSTableViewDelegate nSTableViewDelegate = EnsureNSTableViewDelegate();
			nSTableViewDelegate.mouseDownInHeaderOfTableColumn = (EventHandler<NSTableViewTableEventArgs>)System.Delegate.Combine(nSTableViewDelegate.mouseDownInHeaderOfTableColumn, value);
		}
		remove
		{
			_NSTableViewDelegate nSTableViewDelegate = EnsureNSTableViewDelegate();
			nSTableViewDelegate.mouseDownInHeaderOfTableColumn = (EventHandler<NSTableViewTableEventArgs>)System.Delegate.Remove(nSTableViewDelegate.mouseDownInHeaderOfTableColumn, value);
		}
	}

	public event EventHandler<NSTableViewTableEventArgs> DidClickTableColumn
	{
		add
		{
			_NSTableViewDelegate nSTableViewDelegate = EnsureNSTableViewDelegate();
			nSTableViewDelegate.didClickTableColumn = (EventHandler<NSTableViewTableEventArgs>)System.Delegate.Combine(nSTableViewDelegate.didClickTableColumn, value);
		}
		remove
		{
			_NSTableViewDelegate nSTableViewDelegate = EnsureNSTableViewDelegate();
			nSTableViewDelegate.didClickTableColumn = (EventHandler<NSTableViewTableEventArgs>)System.Delegate.Remove(nSTableViewDelegate.didClickTableColumn, value);
		}
	}

	public event EventHandler<NSTableViewTableEventArgs> DidDragTableColumn
	{
		add
		{
			_NSTableViewDelegate nSTableViewDelegate = EnsureNSTableViewDelegate();
			nSTableViewDelegate.didDragTableColumn = (EventHandler<NSTableViewTableEventArgs>)System.Delegate.Combine(nSTableViewDelegate.didDragTableColumn, value);
		}
		remove
		{
			_NSTableViewDelegate nSTableViewDelegate = EnsureNSTableViewDelegate();
			nSTableViewDelegate.didDragTableColumn = (EventHandler<NSTableViewTableEventArgs>)System.Delegate.Remove(nSTableViewDelegate.didDragTableColumn, value);
		}
	}

	public event EventHandler SelectionDidChange
	{
		add
		{
			_NSTableViewDelegate nSTableViewDelegate = EnsureNSTableViewDelegate();
			nSTableViewDelegate.selectionDidChange = (EventHandler)System.Delegate.Combine(nSTableViewDelegate.selectionDidChange, value);
		}
		remove
		{
			_NSTableViewDelegate nSTableViewDelegate = EnsureNSTableViewDelegate();
			nSTableViewDelegate.selectionDidChange = (EventHandler)System.Delegate.Remove(nSTableViewDelegate.selectionDidChange, value);
		}
	}

	public event EventHandler ColumnDidMove
	{
		add
		{
			_NSTableViewDelegate nSTableViewDelegate = EnsureNSTableViewDelegate();
			nSTableViewDelegate.columnDidMove = (EventHandler)System.Delegate.Combine(nSTableViewDelegate.columnDidMove, value);
		}
		remove
		{
			_NSTableViewDelegate nSTableViewDelegate = EnsureNSTableViewDelegate();
			nSTableViewDelegate.columnDidMove = (EventHandler)System.Delegate.Remove(nSTableViewDelegate.columnDidMove, value);
		}
	}

	public event EventHandler ColumnDidResize
	{
		add
		{
			_NSTableViewDelegate nSTableViewDelegate = EnsureNSTableViewDelegate();
			nSTableViewDelegate.columnDidResize = (EventHandler)System.Delegate.Combine(nSTableViewDelegate.columnDidResize, value);
		}
		remove
		{
			_NSTableViewDelegate nSTableViewDelegate = EnsureNSTableViewDelegate();
			nSTableViewDelegate.columnDidResize = (EventHandler)System.Delegate.Remove(nSTableViewDelegate.columnDidResize, value);
		}
	}

	public event EventHandler SelectionIsChanging
	{
		add
		{
			_NSTableViewDelegate nSTableViewDelegate = EnsureNSTableViewDelegate();
			nSTableViewDelegate.selectionIsChanging = (EventHandler)System.Delegate.Combine(nSTableViewDelegate.selectionIsChanging, value);
		}
		remove
		{
			_NSTableViewDelegate nSTableViewDelegate = EnsureNSTableViewDelegate();
			nSTableViewDelegate.selectionIsChanging = (EventHandler)System.Delegate.Remove(nSTableViewDelegate.selectionIsChanging, value);
		}
	}

	public event EventHandler<NSTableViewRowEventArgs> DidAddRowView
	{
		add
		{
			_NSTableViewDelegate nSTableViewDelegate = EnsureNSTableViewDelegate();
			nSTableViewDelegate.didAddRowView = (EventHandler<NSTableViewRowEventArgs>)System.Delegate.Combine(nSTableViewDelegate.didAddRowView, value);
		}
		remove
		{
			_NSTableViewDelegate nSTableViewDelegate = EnsureNSTableViewDelegate();
			nSTableViewDelegate.didAddRowView = (EventHandler<NSTableViewRowEventArgs>)System.Delegate.Remove(nSTableViewDelegate.didAddRowView, value);
		}
	}

	public event EventHandler<NSTableViewRowEventArgs> DidRemoveRowView
	{
		add
		{
			_NSTableViewDelegate nSTableViewDelegate = EnsureNSTableViewDelegate();
			nSTableViewDelegate.didRemoveRowView = (EventHandler<NSTableViewRowEventArgs>)System.Delegate.Combine(nSTableViewDelegate.didRemoveRowView, value);
		}
		remove
		{
			_NSTableViewDelegate nSTableViewDelegate = EnsureNSTableViewDelegate();
			nSTableViewDelegate.didRemoveRowView = (EventHandler<NSTableViewRowEventArgs>)System.Delegate.Remove(nSTableViewDelegate.didRemoveRowView, value);
		}
	}

	public void SelectRow(ulong row, bool byExtendingSelection)
	{
		SelectRows(NSIndexSet.FromIndex(row), byExtendingSelection);
	}

	public void SelectColumn(ulong column, bool byExtendingSelection)
	{
		SelectColumns(NSIndexSet.FromIndex(column), byExtendingSelection);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTableView()
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
	public NSTableView(NSCoder coder)
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
	public NSTableView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTableView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSTableView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect);
		}
	}

	[Export("noteHeightOfRowsWithIndexesChanged:")]
	public virtual void NoteHeightOfRowsWithIndexesChanged(NSIndexSet indexSet)
	{
		NSApplication.EnsureUIThread();
		if (indexSet == null)
		{
			throw new ArgumentNullException("indexSet");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selNoteHeightOfRowsWithIndexesChanged_Handle, indexSet.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selNoteHeightOfRowsWithIndexesChanged_Handle, indexSet.Handle);
		}
	}

	[Export("tableColumns")]
	public virtual NSTableColumn[] TableColumns()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSTableColumn>(Messaging.IntPtr_objc_msgSend(base.Handle, selTableColumnsHandle));
		}
		return NSArray.ArrayFromHandle<NSTableColumn>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTableColumnsHandle));
	}

	[Export("addTableColumn:")]
	public virtual void AddColumn(NSTableColumn tableColumn)
	{
		NSApplication.EnsureUIThread();
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddTableColumn_Handle, tableColumn.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddTableColumn_Handle, tableColumn.Handle);
		}
	}

	[Export("removeTableColumn:")]
	public virtual void RemoveColumn(NSTableColumn tableColumn)
	{
		NSApplication.EnsureUIThread();
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveTableColumn_Handle, tableColumn.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveTableColumn_Handle, tableColumn.Handle);
		}
	}

	[Export("moveColumn:toColumn:")]
	public virtual void MoveColumn(long oldIndex, long newIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_Int64(base.Handle, selMoveColumnToColumn_Handle, oldIndex, newIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selMoveColumnToColumn_Handle, oldIndex, newIndex);
		}
	}

	[Export("columnWithIdentifier:")]
	public virtual long FindColumn(NSString identifier)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selColumnWithIdentifier_Handle, identifier.Handle);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selColumnWithIdentifier_Handle, identifier.Handle);
	}

	[Export("tableColumnWithIdentifier:")]
	public virtual NSTableColumn FindTableColumn(NSString identifier)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (IsDirectBinding)
		{
			return (NSTableColumn)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTableColumnWithIdentifier_Handle, identifier.Handle));
		}
		return (NSTableColumn)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTableColumnWithIdentifier_Handle, identifier.Handle));
	}

	[Export("tile")]
	public virtual void Tile()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selTileHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selTileHandle);
		}
	}

	[Export("sizeToFit")]
	public new virtual void SizeToFit()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSizeToFitHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSizeToFitHandle);
		}
	}

	[Export("sizeLastColumnToFit")]
	public virtual void SizeLastColumnToFit()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSizeLastColumnToFitHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSizeLastColumnToFitHandle);
		}
	}

	[Export("scrollRowToVisible:")]
	public virtual void ScrollRowToVisible(long row)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selScrollRowToVisible_Handle, row);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selScrollRowToVisible_Handle, row);
		}
	}

	[Export("scrollColumnToVisible:")]
	public virtual void ScrollColumnToVisible(long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selScrollColumnToVisible_Handle, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selScrollColumnToVisible_Handle, column);
		}
	}

	[Export("reloadData")]
	public virtual void ReloadData()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadDataHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadDataHandle);
		}
	}

	[Export("noteNumberOfRowsChanged")]
	public virtual void NoteNumberOfRowsChanged()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selNoteNumberOfRowsChangedHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selNoteNumberOfRowsChangedHandle);
		}
	}

	[Export("reloadDataForRowIndexes:columnIndexes:")]
	public virtual void ReloadData(NSIndexSet rowIndexes, NSIndexSet columnIndexes)
	{
		NSApplication.EnsureUIThread();
		if (rowIndexes == null)
		{
			throw new ArgumentNullException("rowIndexes");
		}
		if (columnIndexes == null)
		{
			throw new ArgumentNullException("columnIndexes");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selReloadDataForRowIndexesColumnIndexes_Handle, rowIndexes.Handle, columnIndexes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReloadDataForRowIndexesColumnIndexes_Handle, rowIndexes.Handle, columnIndexes.Handle);
		}
	}

	[Export("setIndicatorImage:inTableColumn:")]
	public virtual void SetIndicatorImage(NSImage anImage, NSTableColumn tableColumn)
	{
		NSApplication.EnsureUIThread();
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetIndicatorImageInTableColumn_Handle, anImage?.Handle ?? IntPtr.Zero, tableColumn.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetIndicatorImageInTableColumn_Handle, anImage?.Handle ?? IntPtr.Zero, tableColumn.Handle);
		}
	}

	[Export("indicatorImageInTableColumn:")]
	public virtual NSImage GetIndicatorImage(NSTableColumn tableColumn)
	{
		NSApplication.EnsureUIThread();
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		if (IsDirectBinding)
		{
			return (NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selIndicatorImageInTableColumn_Handle, tableColumn.Handle));
		}
		return (NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndicatorImageInTableColumn_Handle, tableColumn.Handle));
	}

	[Export("canDragRowsWithIndexes:atPoint:")]
	public virtual bool CanDragRows(NSIndexSet rowIndexes, CGPoint mouseDownPoint)
	{
		NSApplication.EnsureUIThread();
		if (rowIndexes == null)
		{
			throw new ArgumentNullException("rowIndexes");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_CGPoint(base.Handle, selCanDragRowsWithIndexesAtPoint_Handle, rowIndexes.Handle, mouseDownPoint);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selCanDragRowsWithIndexesAtPoint_Handle, rowIndexes.Handle, mouseDownPoint);
	}

	[Export("setDraggingSourceOperationMask:forLocal:")]
	public virtual void SetDraggingSourceOperationMask(NSDragOperation mask, bool isLocal)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_bool(base.Handle, selSetDraggingSourceOperationMaskForLocal_Handle, (ulong)mask, isLocal);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_bool(base.SuperHandle, selSetDraggingSourceOperationMaskForLocal_Handle, (ulong)mask, isLocal);
		}
	}

	[Export("setDropRow:dropOperation:")]
	public virtual void SetDropRowDropOperation(long row, NSTableViewDropOperation dropOperation)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_UInt64(base.Handle, selSetDropRowDropOperation_Handle, row, (ulong)dropOperation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_UInt64(base.SuperHandle, selSetDropRowDropOperation_Handle, row, (ulong)dropOperation);
		}
	}

	[Export("selectAll:")]
	public virtual void SelectAll(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectAll_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectAll_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("deselectAll:")]
	public virtual void DeselectAll(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeselectAll_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeselectAll_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("selectColumnIndexes:byExtendingSelection:")]
	public virtual void SelectColumns(NSIndexSet indexes, bool byExtendingSelection)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSelectColumnIndexesByExtendingSelection_Handle, indexes.Handle, byExtendingSelection);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSelectColumnIndexesByExtendingSelection_Handle, indexes.Handle, byExtendingSelection);
		}
	}

	[Export("selectRowIndexes:byExtendingSelection:")]
	public virtual void SelectRows(NSIndexSet indexes, bool byExtendingSelection)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSelectRowIndexesByExtendingSelection_Handle, indexes.Handle, byExtendingSelection);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSelectRowIndexesByExtendingSelection_Handle, indexes.Handle, byExtendingSelection);
		}
	}

	[Export("deselectColumn:")]
	public virtual void DeselectColumn(long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selDeselectColumn_Handle, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selDeselectColumn_Handle, column);
		}
	}

	[Export("deselectRow:")]
	public virtual void DeselectRow(long row)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selDeselectRow_Handle, row);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selDeselectRow_Handle, row);
		}
	}

	[Export("isColumnSelected:")]
	public virtual bool IsColumnSelected(long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selIsColumnSelected_Handle, column);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selIsColumnSelected_Handle, column);
	}

	[Export("isRowSelected:")]
	public virtual bool IsRowSelected(long row)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selIsRowSelected_Handle, row);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selIsRowSelected_Handle, row);
	}

	[Export("rectOfColumn:")]
	public virtual CGRect RectForColumn(long column)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_Int64(out retval, base.Handle, selRectOfColumn_Handle, column);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_Int64(out retval, base.SuperHandle, selRectOfColumn_Handle, column);
		}
		return retval;
	}

	[Export("rectOfRow:")]
	public virtual CGRect RectForRow(long row)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_Int64(out retval, base.Handle, selRectOfRow_Handle, row);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_Int64(out retval, base.SuperHandle, selRectOfRow_Handle, row);
		}
		return retval;
	}

	[Export("columnIndexesInRect:")]
	public virtual NSIndexSet GetColumnIndexesInRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selColumnIndexesInRect_Handle, rect));
		}
		return (NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selColumnIndexesInRect_Handle, rect));
	}

	[Export("rowsInRect:")]
	public virtual NSRange RowsInRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_CGRect(base.Handle, selRowsInRect_Handle, rect);
		}
		return Messaging.NSRange_objc_msgSendSuper_CGRect(base.SuperHandle, selRowsInRect_Handle, rect);
	}

	[Export("columnAtPoint:")]
	public virtual long GetColumn(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_CGPoint(base.Handle, selColumnAtPoint_Handle, point);
		}
		return Messaging.Int64_objc_msgSendSuper_CGPoint(base.SuperHandle, selColumnAtPoint_Handle, point);
	}

	[Export("rowAtPoint:")]
	public virtual long GetRow(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_CGPoint(base.Handle, selRowAtPoint_Handle, point);
		}
		return Messaging.Int64_objc_msgSendSuper_CGPoint(base.SuperHandle, selRowAtPoint_Handle, point);
	}

	[Export("frameOfCellAtColumn:row:")]
	public virtual CGRect GetCellFrame(long column, long row)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_Int64_Int64(out retval, base.Handle, selFrameOfCellAtColumnRow_Handle, column, row);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_Int64_Int64(out retval, base.SuperHandle, selFrameOfCellAtColumnRow_Handle, column, row);
		}
		return retval;
	}

	[Export("preparedCellAtColumn:row:")]
	public virtual NSCell GetCell(long column, long row)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64_Int64(base.Handle, selPreparedCellAtColumnRow_Handle, column, row));
		}
		return (NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selPreparedCellAtColumnRow_Handle, column, row));
	}

	[Export("textShouldBeginEditing:")]
	public virtual bool TextShouldBeginEditing(NSText textObject)
	{
		NSApplication.EnsureUIThread();
		if (textObject == null)
		{
			throw new ArgumentNullException("textObject");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selTextShouldBeginEditing_Handle, textObject.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextShouldBeginEditing_Handle, textObject.Handle);
	}

	[Export("textShouldEndEditing:")]
	public virtual bool TextShouldEndEditing(NSText textObject)
	{
		NSApplication.EnsureUIThread();
		if (textObject == null)
		{
			throw new ArgumentNullException("textObject");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selTextShouldEndEditing_Handle, textObject.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextShouldEndEditing_Handle, textObject.Handle);
	}

	[Export("textDidBeginEditing:")]
	public virtual void TextDidBeginEditing(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTextDidBeginEditing_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextDidBeginEditing_Handle, notification.Handle);
		}
	}

	[Export("textDidEndEditing:")]
	public virtual void TextDidEndEditing(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTextDidEndEditing_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextDidEndEditing_Handle, notification.Handle);
		}
	}

	[Export("textDidChange:")]
	public virtual void TextDidChange(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTextDidChange_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextDidChange_Handle, notification.Handle);
		}
	}

	[Export("shouldFocusCell:atColumn:row:")]
	public virtual bool ShouldFocusCell(NSCell cell, long column, long row)
	{
		NSApplication.EnsureUIThread();
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_Int64_Int64(base.Handle, selShouldFocusCellAtColumnRow_Handle, cell.Handle, column, row);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_Int64_Int64(base.SuperHandle, selShouldFocusCellAtColumnRow_Handle, cell.Handle, column, row);
	}

	[Export("performClickOnCellAtColumn:row:")]
	public virtual void PerformClick(long column, long row)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_Int64(base.Handle, selPerformClickOnCellAtColumnRow_Handle, column, row);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selPerformClickOnCellAtColumnRow_Handle, column, row);
		}
	}

	[Export("editColumn:row:withEvent:select:")]
	public virtual void EditColumn(long column, long row, NSEvent theEvent, bool select)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_Int64_IntPtr_bool(base.Handle, selEditColumnRowWithEventSelect_Handle, column, row, theEvent.Handle, select);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_Int64_IntPtr_bool(base.SuperHandle, selEditColumnRowWithEventSelect_Handle, column, row, theEvent.Handle, select);
		}
	}

	[Export("drawRow:clipRect:")]
	public virtual void DrawRow(long row, CGRect clipRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_CGRect(base.Handle, selDrawRowClipRect_Handle, row, clipRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_CGRect(base.SuperHandle, selDrawRowClipRect_Handle, row, clipRect);
		}
	}

	[Export("highlightSelectionInClipRect:")]
	public virtual void HighlightSelection(CGRect clipRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selHighlightSelectionInClipRect_Handle, clipRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selHighlightSelectionInClipRect_Handle, clipRect);
		}
	}

	[Export("drawGridInClipRect:")]
	public virtual void DrawGrid(CGRect clipRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawGridInClipRect_Handle, clipRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawGridInClipRect_Handle, clipRect);
		}
	}

	[Export("drawBackgroundInClipRect:")]
	public virtual void DrawBackground(CGRect clipRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawBackgroundInClipRect_Handle, clipRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawBackgroundInClipRect_Handle, clipRect);
		}
	}

	[Export("viewAtColumn:row:makeIfNecessary:")]
	public virtual NSView GetView(long column, long row, bool makeIfNecessary)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64_Int64_bool(base.Handle, selViewAtColumnRowMakeIfNecessary_Handle, column, row, makeIfNecessary));
		}
		return (NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64_Int64_bool(base.SuperHandle, selViewAtColumnRowMakeIfNecessary_Handle, column, row, makeIfNecessary));
	}

	[Export("rowViewAtRow:makeIfNecessary:")]
	public virtual NSTableRowView GetRowView(long row, bool makeIfNecessary)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSTableRowView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64_bool(base.Handle, selRowViewAtRowMakeIfNecessary_Handle, row, makeIfNecessary));
		}
		return (NSTableRowView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64_bool(base.SuperHandle, selRowViewAtRowMakeIfNecessary_Handle, row, makeIfNecessary));
	}

	[Export("rowForView:")]
	public virtual long RowForView(NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selRowForView_Handle, view.Handle);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selRowForView_Handle, view.Handle);
	}

	[Export("columnForView:")]
	public virtual long ColumnForView(NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selColumnForView_Handle, view.Handle);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selColumnForView_Handle, view.Handle);
	}

	[Export("makeViewWithIdentifier:owner:")]
	public virtual NSView MakeView(string identifier, NSObject owner)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (owner == null)
		{
			throw new ArgumentNullException("owner");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSView result = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMakeViewWithIdentifierOwner_Handle, arg, owner.Handle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selMakeViewWithIdentifierOwner_Handle, arg, owner.Handle))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("enumerateAvailableRowViewsUsingBlock:")]
	public unsafe virtual void EnumerateAvailableRowViews(NSTableViewRowHandler callback)
	{
		NSApplication.EnsureUIThread();
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSTableViewRowHandler.Handler, callback);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEnumerateAvailableRowViewsUsingBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEnumerateAvailableRowViewsUsingBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("beginUpdates")]
	public virtual void BeginUpdates()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selBeginUpdatesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selBeginUpdatesHandle);
		}
	}

	[Export("endUpdates")]
	public virtual void EndUpdates()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEndUpdatesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEndUpdatesHandle);
		}
	}

	[Export("insertRowsAtIndexes:withAnimation:")]
	public virtual void InsertRows(NSIndexSet indexes, NSTableViewAnimation animationOptions)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selInsertRowsAtIndexesWithAnimation_Handle, indexes.Handle, (ulong)animationOptions);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selInsertRowsAtIndexesWithAnimation_Handle, indexes.Handle, (ulong)animationOptions);
		}
	}

	[Export("removeRowsAtIndexes:withAnimation:")]
	public virtual void RemoveRows(NSIndexSet indexes, NSTableViewAnimation animationOptions)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selRemoveRowsAtIndexesWithAnimation_Handle, indexes.Handle, (ulong)animationOptions);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selRemoveRowsAtIndexesWithAnimation_Handle, indexes.Handle, (ulong)animationOptions);
		}
	}

	[Export("moveRowAtIndex:toIndex:")]
	public virtual void MoveRow(long oldIndex, long newIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_Int64(base.Handle, selMoveRowAtIndexToIndex_Handle, oldIndex, newIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selMoveRowAtIndexToIndex_Handle, oldIndex, newIndex);
		}
	}

	[Export("draggingSourceOperationMaskForLocal:")]
	public virtual NSDragOperation DraggingSourceOperationMaskForLocal(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSDragOperation)Messaging.UInt64_objc_msgSend_bool(base.Handle, selDraggingSourceOperationMaskForLocal_Handle, flag);
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSendSuper_bool(base.SuperHandle, selDraggingSourceOperationMaskForLocal_Handle, flag);
	}

	[Export("namesOfPromisedFilesDroppedAtDestination:")]
	public virtual string[] NamesOfPromisedFilesDroppedAtDestination(NSUrl dropDestination)
	{
		NSApplication.EnsureUIThread();
		if (dropDestination == null)
		{
			throw new ArgumentNullException("dropDestination");
		}
		if (IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNamesOfPromisedFilesDroppedAtDestination_Handle, dropDestination.Handle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNamesOfPromisedFilesDroppedAtDestination_Handle, dropDestination.Handle));
	}

	[Export("draggedImage:beganAt:")]
	public virtual void DraggedImageBeganAt(NSImage image, CGPoint screenPoint)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint(base.Handle, selDraggedImageBeganAt_Handle, image.Handle, screenPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selDraggedImageBeganAt_Handle, image.Handle, screenPoint);
		}
	}

	[Export("draggedImage:endedAt:operation:")]
	public virtual void DraggedImageEndedAtOperation(NSImage image, CGPoint screenPoint, NSDragOperation operation)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint_UInt64(base.Handle, selDraggedImageEndedAtOperation_Handle, image.Handle, screenPoint, (ulong)operation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint_UInt64(base.SuperHandle, selDraggedImageEndedAtOperation_Handle, image.Handle, screenPoint, (ulong)operation);
		}
	}

	[Export("draggedImage:movedTo:")]
	public virtual void DraggedImageMovedTo(NSImage image, CGPoint screenPoint)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint(base.Handle, selDraggedImageMovedTo_Handle, image.Handle, screenPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selDraggedImageMovedTo_Handle, image.Handle, screenPoint);
		}
	}

	[Export("draggedImage:endedAt:deposited:")]
	[Obsolete("On 10.1 and newer, use DraggedImageEndedAtOperation() instead", false)]
	public virtual void DraggedImageEndedAtDeposited(NSImage image, CGPoint screenPoint, bool deposited)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint_bool(base.Handle, selDraggedImageEndedAtDeposited_Handle, image.Handle, screenPoint, deposited);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint_bool(base.SuperHandle, selDraggedImageEndedAtDeposited_Handle, image.Handle, screenPoint, deposited);
		}
	}

	private _NSTableViewDelegate EnsureNSTableViewDelegate()
	{
		NSTableViewDelegate nSTableViewDelegate = Delegate;
		if (nSTableViewDelegate == null || !(nSTableViewDelegate is _NSTableViewDelegate))
		{
			nSTableViewDelegate = (Delegate = new _NSTableViewDelegate());
		}
		return (_NSTableViewDelegate)nSTableViewDelegate;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_SelectedColumns_var = null;
			__mt_SelectedRows_var = null;
			__mt_WeakDataSource_var = null;
			__mt_WeakDelegate_var = null;
			__mt_HeaderView_var = null;
			__mt_CornerView_var = null;
			__mt_BackgroundColor_var = null;
			__mt_GridColor_var = null;
			__mt_SortDescriptors_var = null;
			__mt_HighlightedTableColumn_var = null;
		}
	}
}
