using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSTableView", true)]
public class NSTableView : NSControl, INSAccessibilityElementProtocol, INativeObject, IDisposable, INSAccessibilityGroup, INSAccessibilityTable, INSDraggingSource, INSUserInterfaceValidations
{
	[Register]
	internal class _NSTableViewDelegate : NSObject, INSTableViewDelegate, INativeObject, IDisposable
	{
		internal EventHandler? columnDidMove;

		internal EventHandler? columnDidResize;

		internal NSTableViewRowGetter? coreGetRowView;

		internal EventHandler<NSTableViewRowEventArgs>? didAddRowView;

		internal EventHandler<NSTableViewTableEventArgs>? didClickTableColumn;

		internal EventHandler<NSTableViewTableEventArgs>? didDragTableColumn;

		internal EventHandler<NSTableViewRowEventArgs>? didRemoveRowView;

		internal NSTableViewCellGetter? getDataCell;

		internal NSTableViewSearchString? getNextTypeSelectMatch;

		internal NSTableViewRowHeight? getRowHeight;

		internal NSTableViewColumnRowString? getSelectString;

		internal NSTableViewIndexFilter? getSelectionIndexes;

		internal NSTableViewColumnWidth? getSizeToFitColumnWidth;

		internal NSTableViewToolTip? getToolTip;

		internal NSTableViewViewGetter? getViewForItem;

		internal NSTableViewRowPredicate? isGroupRow;

		internal EventHandler<NSTableViewTableEventArgs>? mouseDownInHeaderOfTableColumn;

		internal NSTableViewRowActionsGetter? rowActions;

		internal EventHandler? selectionDidChange;

		internal EventHandler? selectionIsChanging;

		internal NSTableViewPredicate? selectionShouldChange;

		internal NSTableViewColumnRowPredicate? shouldEditTableColumn;

		internal NSTableReorder? shouldReorder;

		internal NSTableViewRowPredicate? shouldSelectRow;

		internal NSTableViewColumnPredicate? shouldSelectTableColumn;

		internal NSTableViewColumnRowPredicate? shouldShowCellExpansion;

		internal NSTableViewCell? shouldTrackCell;

		internal NSTableViewEventString? shouldTypeSelect;

		internal EventHandler<NSTableViewCellEventArgs>? willDisplayCell;

		private static IntPtr selGetDataCellHandle = Selector.GetHandle("tableView:dataCellForTableColumn:row:");

		private static IntPtr selGetRowHeightHandle = Selector.GetHandle("tableView:heightOfRow:");

		private static IntPtr selGetViewForItemHandle = Selector.GetHandle("tableView:viewForTableColumn:row:");

		private static IntPtr selRowActionsHandle = Selector.GetHandle("tableView:rowActionsForRow:edge:");

		private static IntPtr selRespondsToSelector = Selector.GetHandle("respondsToSelector:");

		public _NSTableViewDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("tableViewColumnDidMove:")]
		public void ColumnDidMove(NSNotification notification)
		{
			columnDidMove?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("tableViewColumnDidResize:")]
		public void ColumnDidResize(NSNotification notification)
		{
			columnDidResize?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("tableView:rowViewForRow:")]
		public NSTableRowView CoreGetRowView(NSTableView tableView, nint row)
		{
			return coreGetRowView?.Invoke(tableView, row);
		}

		[Preserve(Conditional = true)]
		[Export("tableView:didAddRowView:forRow:")]
		public void DidAddRowView(NSTableView tableView, NSTableRowView rowView, nint row)
		{
			EventHandler<NSTableViewRowEventArgs> eventHandler = didAddRowView;
			if (eventHandler != null)
			{
				NSTableViewRowEventArgs e = new NSTableViewRowEventArgs(rowView, row);
				eventHandler(tableView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("tableView:didClickTableColumn:")]
		public void DidClickTableColumn(NSTableView tableView, NSTableColumn tableColumn)
		{
			EventHandler<NSTableViewTableEventArgs> eventHandler = didClickTableColumn;
			if (eventHandler != null)
			{
				NSTableViewTableEventArgs e = new NSTableViewTableEventArgs(tableColumn);
				eventHandler(tableView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("tableView:didDragTableColumn:")]
		public void DidDragTableColumn(NSTableView tableView, NSTableColumn tableColumn)
		{
			EventHandler<NSTableViewTableEventArgs> eventHandler = didDragTableColumn;
			if (eventHandler != null)
			{
				NSTableViewTableEventArgs e = new NSTableViewTableEventArgs(tableColumn);
				eventHandler(tableView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("tableView:didRemoveRowView:forRow:")]
		public void DidRemoveRowView(NSTableView tableView, NSTableRowView rowView, nint row)
		{
			EventHandler<NSTableViewRowEventArgs> eventHandler = didRemoveRowView;
			if (eventHandler != null)
			{
				NSTableViewRowEventArgs e = new NSTableViewRowEventArgs(rowView, row);
				eventHandler(tableView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("tableView:dataCellForTableColumn:row:")]
		public NSCell GetDataCell(NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			NSTableViewCellGetter nSTableViewCellGetter = getDataCell;
			if (nSTableViewCellGetter != null)
			{
				return nSTableViewCellGetter(tableView, tableColumn, row);
			}
			throw new You_Should_Not_Call_base_In_This_Method();
		}

		[Preserve(Conditional = true)]
		[Export("tableView:nextTypeSelectMatchFromRow:toRow:forString:")]
		public nint GetNextTypeSelectMatch(NSTableView tableView, nint startRow, nint endRow, string searchString)
		{
			return getNextTypeSelectMatch?.Invoke(tableView, startRow, endRow, searchString) ?? ((nint)(-1));
		}

		[Preserve(Conditional = true)]
		[Export("tableView:heightOfRow:")]
		public nfloat GetRowHeight(NSTableView tableView, nint row)
		{
			NSTableViewRowHeight nSTableViewRowHeight = getRowHeight;
			if (nSTableViewRowHeight != null)
			{
				return nSTableViewRowHeight(tableView, row);
			}
			throw new You_Should_Not_Call_base_In_This_Method();
		}

		[Preserve(Conditional = true)]
		[Export("tableView:typeSelectStringForTableColumn:row:")]
		public string GetSelectString(NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			NSTableViewColumnRowString nSTableViewColumnRowString = getSelectString;
			if (nSTableViewColumnRowString != null)
			{
				return nSTableViewColumnRowString(tableView, tableColumn, row);
			}
			return string.Empty;
		}

		[Preserve(Conditional = true)]
		[Export("tableView:selectionIndexesForProposedSelection:")]
		public NSIndexSet GetSelectionIndexes(NSTableView tableView, NSIndexSet proposedSelectionIndexes)
		{
			NSTableViewIndexFilter nSTableViewIndexFilter = getSelectionIndexes;
			if (nSTableViewIndexFilter != null)
			{
				return nSTableViewIndexFilter(tableView, proposedSelectionIndexes);
			}
			return proposedSelectionIndexes;
		}

		[Preserve(Conditional = true)]
		[Export("tableView:sizeToFitWidthOfColumn:")]
		public nfloat GetSizeToFitColumnWidth(NSTableView tableView, nint column)
		{
			return getSizeToFitColumnWidth?.Invoke(tableView, column) ?? ((nfloat)80);
		}

		[Preserve(Conditional = true)]
		[Export("tableView:toolTipForCell:rect:tableColumn:row:mouseLocation:")]
		public NSString GetToolTip(NSTableView tableView, NSCell cell, ref CGRect rect, NSTableColumn? tableColumn, nint row, CGPoint mouseLocation)
		{
			return getToolTip?.Invoke(tableView, cell, ref rect, tableColumn, row, mouseLocation);
		}

		[Preserve(Conditional = true)]
		[Export("tableView:viewForTableColumn:row:")]
		public NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			NSTableViewViewGetter nSTableViewViewGetter = getViewForItem;
			if (nSTableViewViewGetter != null)
			{
				return nSTableViewViewGetter(tableView, tableColumn, row);
			}
			throw new You_Should_Not_Call_base_In_This_Method();
		}

		[Preserve(Conditional = true)]
		[Export("tableView:isGroupRow:")]
		public bool IsGroupRow(NSTableView tableView, nint row)
		{
			return isGroupRow?.Invoke(tableView, row) ?? false;
		}

		[Preserve(Conditional = true)]
		[Export("tableView:mouseDownInHeaderOfTableColumn:")]
		public void MouseDownInHeaderOfTableColumn(NSTableView tableView, NSTableColumn tableColumn)
		{
			EventHandler<NSTableViewTableEventArgs> eventHandler = mouseDownInHeaderOfTableColumn;
			if (eventHandler != null)
			{
				NSTableViewTableEventArgs e = new NSTableViewTableEventArgs(tableColumn);
				eventHandler(tableView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("tableView:rowActionsForRow:edge:")]
		public NSTableViewRowAction[] RowActions(NSTableView tableView, nint row, NSTableRowActionEdge edge)
		{
			NSTableViewRowActionsGetter nSTableViewRowActionsGetter = rowActions;
			if (nSTableViewRowActionsGetter != null)
			{
				return nSTableViewRowActionsGetter(tableView, row, edge);
			}
			throw new You_Should_Not_Call_base_In_This_Method();
		}

		[Preserve(Conditional = true)]
		[Export("tableViewSelectionDidChange:")]
		public void SelectionDidChange(NSNotification notification)
		{
			selectionDidChange?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("tableViewSelectionIsChanging:")]
		public void SelectionIsChanging(NSNotification notification)
		{
			selectionIsChanging?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("selectionShouldChangeInTableView:")]
		public bool SelectionShouldChange(NSTableView tableView)
		{
			return selectionShouldChange?.Invoke(tableView) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("tableView:shouldEditTableColumn:row:")]
		public bool ShouldEditTableColumn(NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			return shouldEditTableColumn?.Invoke(tableView, tableColumn, row) ?? false;
		}

		[Preserve(Conditional = true)]
		[Export("tableView:shouldReorderColumn:toColumn:")]
		public bool ShouldReorder(NSTableView tableView, nint columnIndex, nint newColumnIndex)
		{
			return shouldReorder?.Invoke(tableView, columnIndex, newColumnIndex) ?? false;
		}

		[Preserve(Conditional = true)]
		[Export("tableView:shouldSelectRow:")]
		public bool ShouldSelectRow(NSTableView tableView, nint row)
		{
			return shouldSelectRow?.Invoke(tableView, row) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("tableView:shouldSelectTableColumn:")]
		public bool ShouldSelectTableColumn(NSTableView tableView, NSTableColumn tableColumn)
		{
			return shouldSelectTableColumn?.Invoke(tableView, tableColumn) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("tableView:shouldShowCellExpansionForTableColumn:row:")]
		public bool ShouldShowCellExpansion(NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			return shouldShowCellExpansion?.Invoke(tableView, tableColumn, row) ?? false;
		}

		[Preserve(Conditional = true)]
		[Export("tableView:shouldTrackCell:forTableColumn:row:")]
		public bool ShouldTrackCell(NSTableView tableView, NSCell cell, NSTableColumn tableColumn, nint row)
		{
			return shouldTrackCell?.Invoke(tableView, cell, tableColumn, row) ?? false;
		}

		[Preserve(Conditional = true)]
		[Export("tableView:shouldTypeSelectForEvent:withCurrentSearchString:")]
		public bool ShouldTypeSelect(NSTableView tableView, NSEvent theEvent, string searchString)
		{
			return shouldTypeSelect?.Invoke(tableView, theEvent, searchString) ?? false;
		}

		[Preserve(Conditional = true)]
		[Export("tableView:willDisplayCell:forTableColumn:row:")]
		public void WillDisplayCell(NSTableView tableView, NSObject cell, NSTableColumn tableColumn, nint row)
		{
			EventHandler<NSTableViewCellEventArgs> eventHandler = willDisplayCell;
			if (eventHandler != null)
			{
				NSTableViewCellEventArgs e = new NSTableViewCellEventArgs(cell, tableColumn, row);
				eventHandler(tableView, e);
			}
		}

		[Preserve(Conditional = true)]
		public override bool RespondsToSelector(Selector? sel)
		{
			if (sel == null)
			{
				return false;
			}
			IntPtr arg = ((sel == null) ? IntPtr.Zero : sel.Handle);
			if (arg.Equals(selGetDataCellHandle))
			{
				return getDataCell != null;
			}
			if (arg.Equals(selGetRowHeightHandle))
			{
				return getRowHeight != null;
			}
			if (arg.Equals(selGetViewForItemHandle))
			{
				return getViewForItem != null;
			}
			if (arg.Equals(selRowActionsHandle))
			{
				return rowActions != null;
			}
			return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selRespondsToSelector, arg);
		}
	}

	public new static class Notifications
	{
		public static NSObject ObserveColumnDidMove(EventHandler<NSViewColumnMoveEventArgs> handler)
		{
			EventHandler<NSViewColumnMoveEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ColumnDidMoveNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSViewColumnMoveEventArgs(notification));
			});
		}

		public static NSObject ObserveColumnDidMove(NSObject objectToObserve, EventHandler<NSViewColumnMoveEventArgs> handler)
		{
			EventHandler<NSViewColumnMoveEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ColumnDidMoveNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSViewColumnMoveEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveColumnDidResize(EventHandler<NSViewColumnResizeEventArgs> handler)
		{
			EventHandler<NSViewColumnResizeEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ColumnDidResizeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSViewColumnResizeEventArgs(notification));
			});
		}

		public static NSObject ObserveColumnDidResize(NSObject objectToObserve, EventHandler<NSViewColumnResizeEventArgs> handler)
		{
			EventHandler<NSViewColumnResizeEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ColumnDidResizeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSViewColumnResizeEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSelectionDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectionDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectionDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectionDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSelectionIsChanging(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectionIsChangingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectionIsChanging(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectionIsChangingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityColumnHeaderUIElements = "accessibilityColumnHeaderUIElements";

	private static readonly IntPtr selAccessibilityColumnHeaderUIElementsHandle = Selector.GetHandle("accessibilityColumnHeaderUIElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityColumns = "accessibilityColumns";

	private static readonly IntPtr selAccessibilityColumnsHandle = Selector.GetHandle("accessibilityColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFrame = "accessibilityFrame";

	private static readonly IntPtr selAccessibilityFrameHandle = Selector.GetHandle("accessibilityFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityHeaderGroup = "accessibilityHeaderGroup";

	private static readonly IntPtr selAccessibilityHeaderGroupHandle = Selector.GetHandle("accessibilityHeaderGroup");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityIdentifier = "accessibilityIdentifier";

	private static readonly IntPtr selAccessibilityIdentifierHandle = Selector.GetHandle("accessibilityIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityLabel = "accessibilityLabel";

	private static readonly IntPtr selAccessibilityLabelHandle = Selector.GetHandle("accessibilityLabel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityParent = "accessibilityParent";

	private static readonly IntPtr selAccessibilityParentHandle = Selector.GetHandle("accessibilityParent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRowHeaderUIElements = "accessibilityRowHeaderUIElements";

	private static readonly IntPtr selAccessibilityRowHeaderUIElementsHandle = Selector.GetHandle("accessibilityRowHeaderUIElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRows = "accessibilityRows";

	private static readonly IntPtr selAccessibilityRowsHandle = Selector.GetHandle("accessibilityRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySelectedCells = "accessibilitySelectedCells";

	private static readonly IntPtr selAccessibilitySelectedCellsHandle = Selector.GetHandle("accessibilitySelectedCells");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySelectedColumns = "accessibilitySelectedColumns";

	private static readonly IntPtr selAccessibilitySelectedColumnsHandle = Selector.GetHandle("accessibilitySelectedColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySelectedRows = "accessibilitySelectedRows";

	private static readonly IntPtr selAccessibilitySelectedRowsHandle = Selector.GetHandle("accessibilitySelectedRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVisibleCells = "accessibilityVisibleCells";

	private static readonly IntPtr selAccessibilityVisibleCellsHandle = Selector.GetHandle("accessibilityVisibleCells");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVisibleColumns = "accessibilityVisibleColumns";

	private static readonly IntPtr selAccessibilityVisibleColumnsHandle = Selector.GetHandle("accessibilityVisibleColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVisibleRows = "accessibilityVisibleRows";

	private static readonly IntPtr selAccessibilityVisibleRowsHandle = Selector.GetHandle("accessibilityVisibleRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddTableColumn_ = "addTableColumn:";

	private static readonly IntPtr selAddTableColumn_Handle = Selector.GetHandle("addTableColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsColumnReordering = "allowsColumnReordering";

	private static readonly IntPtr selAllowsColumnReorderingHandle = Selector.GetHandle("allowsColumnReordering");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsColumnResizing = "allowsColumnResizing";

	private static readonly IntPtr selAllowsColumnResizingHandle = Selector.GetHandle("allowsColumnResizing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsColumnSelection = "allowsColumnSelection";

	private static readonly IntPtr selAllowsColumnSelectionHandle = Selector.GetHandle("allowsColumnSelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsEmptySelection = "allowsEmptySelection";

	private static readonly IntPtr selAllowsEmptySelectionHandle = Selector.GetHandle("allowsEmptySelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsMultipleSelection = "allowsMultipleSelection";

	private static readonly IntPtr selAllowsMultipleSelectionHandle = Selector.GetHandle("allowsMultipleSelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsTypeSelect = "allowsTypeSelect";

	private static readonly IntPtr selAllowsTypeSelectHandle = Selector.GetHandle("allowsTypeSelect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutosaveName = "autosaveName";

	private static readonly IntPtr selAutosaveNameHandle = Selector.GetHandle("autosaveName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutosaveTableColumns = "autosaveTableColumns";

	private static readonly IntPtr selAutosaveTableColumnsHandle = Selector.GetHandle("autosaveTableColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColor = "backgroundColor";

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginUpdates = "beginUpdates";

	private static readonly IntPtr selBeginUpdatesHandle = Selector.GetHandle("beginUpdates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanDragRowsWithIndexes_AtPoint_ = "canDragRowsWithIndexes:atPoint:";

	private static readonly IntPtr selCanDragRowsWithIndexes_AtPoint_Handle = Selector.GetHandle("canDragRowsWithIndexes:atPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClickedColumn = "clickedColumn";

	private static readonly IntPtr selClickedColumnHandle = Selector.GetHandle("clickedColumn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClickedRow = "clickedRow";

	private static readonly IntPtr selClickedRowHandle = Selector.GetHandle("clickedRow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColumnAtPoint_ = "columnAtPoint:";

	private static readonly IntPtr selColumnAtPoint_Handle = Selector.GetHandle("columnAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColumnAutoresizingStyle = "columnAutoresizingStyle";

	private static readonly IntPtr selColumnAutoresizingStyleHandle = Selector.GetHandle("columnAutoresizingStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColumnForView_ = "columnForView:";

	private static readonly IntPtr selColumnForView_Handle = Selector.GetHandle("columnForView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColumnIndexesInRect_ = "columnIndexesInRect:";

	private static readonly IntPtr selColumnIndexesInRect_Handle = Selector.GetHandle("columnIndexesInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColumnWithIdentifier_ = "columnWithIdentifier:";

	private static readonly IntPtr selColumnWithIdentifier_Handle = Selector.GetHandle("columnWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCornerView = "cornerView";

	private static readonly IntPtr selCornerViewHandle = Selector.GetHandle("cornerView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataSource = "dataSource";

	private static readonly IntPtr selDataSourceHandle = Selector.GetHandle("dataSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeselectAll_ = "deselectAll:";

	private static readonly IntPtr selDeselectAll_Handle = Selector.GetHandle("deselectAll:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeselectColumn_ = "deselectColumn:";

	private static readonly IntPtr selDeselectColumn_Handle = Selector.GetHandle("deselectColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeselectRow_ = "deselectRow:";

	private static readonly IntPtr selDeselectRow_Handle = Selector.GetHandle("deselectRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidAddRowView_ForRow_ = "didAddRowView:forRow:";

	private static readonly IntPtr selDidAddRowView_ForRow_Handle = Selector.GetHandle("didAddRowView:forRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidRemoveRowView_ForRow_ = "didRemoveRowView:forRow:";

	private static readonly IntPtr selDidRemoveRowView_ForRow_Handle = Selector.GetHandle("didRemoveRowView:forRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoubleAction = "doubleAction";

	private static readonly IntPtr selDoubleActionHandle = Selector.GetHandle("doubleAction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDragImageForRowsWithIndexes_TableColumns_Event_Offset_ = "dragImageForRowsWithIndexes:tableColumns:event:offset:";

	private static readonly IntPtr selDragImageForRowsWithIndexes_TableColumns_Event_Offset_Handle = Selector.GetHandle("dragImageForRowsWithIndexes:tableColumns:event:offset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggedImage_BeganAt_ = "draggedImage:beganAt:";

	private static readonly IntPtr selDraggedImage_BeganAt_Handle = Selector.GetHandle("draggedImage:beganAt:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggedImage_EndedAt_Deposited_ = "draggedImage:endedAt:deposited:";

	private static readonly IntPtr selDraggedImage_EndedAt_Deposited_Handle = Selector.GetHandle("draggedImage:endedAt:deposited:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggedImage_EndedAt_Operation_ = "draggedImage:endedAt:operation:";

	private static readonly IntPtr selDraggedImage_EndedAt_Operation_Handle = Selector.GetHandle("draggedImage:endedAt:operation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggedImage_MovedTo_ = "draggedImage:movedTo:";

	private static readonly IntPtr selDraggedImage_MovedTo_Handle = Selector.GetHandle("draggedImage:movedTo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingDestinationFeedbackStyle = "draggingDestinationFeedbackStyle";

	private static readonly IntPtr selDraggingDestinationFeedbackStyleHandle = Selector.GetHandle("draggingDestinationFeedbackStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingSourceOperationMaskForLocal_ = "draggingSourceOperationMaskForLocal:";

	private static readonly IntPtr selDraggingSourceOperationMaskForLocal_Handle = Selector.GetHandle("draggingSourceOperationMaskForLocal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawBackgroundInClipRect_ = "drawBackgroundInClipRect:";

	private static readonly IntPtr selDrawBackgroundInClipRect_Handle = Selector.GetHandle("drawBackgroundInClipRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawGridInClipRect_ = "drawGridInClipRect:";

	private static readonly IntPtr selDrawGridInClipRect_Handle = Selector.GetHandle("drawGridInClipRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawRow_ClipRect_ = "drawRow:clipRect:";

	private static readonly IntPtr selDrawRow_ClipRect_Handle = Selector.GetHandle("drawRow:clipRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEditColumn_Row_WithEvent_Select_ = "editColumn:row:withEvent:select:";

	private static readonly IntPtr selEditColumn_Row_WithEvent_Select_Handle = Selector.GetHandle("editColumn:row:withEvent:select:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEditedColumn = "editedColumn";

	private static readonly IntPtr selEditedColumnHandle = Selector.GetHandle("editedColumn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEditedRow = "editedRow";

	private static readonly IntPtr selEditedRowHandle = Selector.GetHandle("editedRow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEffectiveRowSizeStyle = "effectiveRowSizeStyle";

	private static readonly IntPtr selEffectiveRowSizeStyleHandle = Selector.GetHandle("effectiveRowSizeStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndUpdates = "endUpdates";

	private static readonly IntPtr selEndUpdatesHandle = Selector.GetHandle("endUpdates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateAvailableRowViewsUsingBlock_ = "enumerateAvailableRowViewsUsingBlock:";

	private static readonly IntPtr selEnumerateAvailableRowViewsUsingBlock_Handle = Selector.GetHandle("enumerateAvailableRowViewsUsingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloatsGroupRows = "floatsGroupRows";

	private static readonly IntPtr selFloatsGroupRowsHandle = Selector.GetHandle("floatsGroupRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFocusedColumn = "focusedColumn";

	private static readonly IntPtr selFocusedColumnHandle = Selector.GetHandle("focusedColumn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameOfCellAtColumn_Row_ = "frameOfCellAtColumn:row:";

	private static readonly IntPtr selFrameOfCellAtColumn_Row_Handle = Selector.GetHandle("frameOfCellAtColumn:row:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGridColor = "gridColor";

	private static readonly IntPtr selGridColorHandle = Selector.GetHandle("gridColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGridStyleMask = "gridStyleMask";

	private static readonly IntPtr selGridStyleMaskHandle = Selector.GetHandle("gridStyleMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeaderView = "headerView";

	private static readonly IntPtr selHeaderViewHandle = Selector.GetHandle("headerView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHiddenRowIndexes = "hiddenRowIndexes";

	private static readonly IntPtr selHiddenRowIndexesHandle = Selector.GetHandle("hiddenRowIndexes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHideRowsAtIndexes_WithAnimation_ = "hideRowsAtIndexes:withAnimation:";

	private static readonly IntPtr selHideRowsAtIndexes_WithAnimation_Handle = Selector.GetHandle("hideRowsAtIndexes:withAnimation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHighlightSelectionInClipRect_ = "highlightSelectionInClipRect:";

	private static readonly IntPtr selHighlightSelectionInClipRect_Handle = Selector.GetHandle("highlightSelectionInClipRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHighlightedTableColumn = "highlightedTableColumn";

	private static readonly IntPtr selHighlightedTableColumnHandle = Selector.GetHandle("highlightedTableColumn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIgnoreModifierKeysWhileDragging = "ignoreModifierKeysWhileDragging";

	private static readonly IntPtr selIgnoreModifierKeysWhileDraggingHandle = Selector.GetHandle("ignoreModifierKeysWhileDragging");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndicatorImageInTableColumn_ = "indicatorImageInTableColumn:";

	private static readonly IntPtr selIndicatorImageInTableColumn_Handle = Selector.GetHandle("indicatorImageInTableColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertRowsAtIndexes_WithAnimation_ = "insertRowsAtIndexes:withAnimation:";

	private static readonly IntPtr selInsertRowsAtIndexes_WithAnimation_Handle = Selector.GetHandle("insertRowsAtIndexes:withAnimation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntercellSpacing = "intercellSpacing";

	private static readonly IntPtr selIntercellSpacingHandle = Selector.GetHandle("intercellSpacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityFocused = "isAccessibilityFocused";

	private static readonly IntPtr selIsAccessibilityFocusedHandle = Selector.GetHandle("isAccessibilityFocused");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsColumnSelected_ = "isColumnSelected:";

	private static readonly IntPtr selIsColumnSelected_Handle = Selector.GetHandle("isColumnSelected:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRowSelected_ = "isRowSelected:";

	private static readonly IntPtr selIsRowSelected_Handle = Selector.GetHandle("isRowSelected:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeViewWithIdentifier_Owner_ = "makeViewWithIdentifier:owner:";

	private static readonly IntPtr selMakeViewWithIdentifier_Owner_Handle = Selector.GetHandle("makeViewWithIdentifier:owner:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveColumn_ToColumn_ = "moveColumn:toColumn:";

	private static readonly IntPtr selMoveColumn_ToColumn_Handle = Selector.GetHandle("moveColumn:toColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveRowAtIndex_ToIndex_ = "moveRowAtIndex:toIndex:";

	private static readonly IntPtr selMoveRowAtIndex_ToIndex_Handle = Selector.GetHandle("moveRowAtIndex:toIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNamesOfPromisedFilesDroppedAtDestination_ = "namesOfPromisedFilesDroppedAtDestination:";

	private static readonly IntPtr selNamesOfPromisedFilesDroppedAtDestination_Handle = Selector.GetHandle("namesOfPromisedFilesDroppedAtDestination:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoteHeightOfRowsWithIndexesChanged_ = "noteHeightOfRowsWithIndexesChanged:";

	private static readonly IntPtr selNoteHeightOfRowsWithIndexesChanged_Handle = Selector.GetHandle("noteHeightOfRowsWithIndexesChanged:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoteNumberOfRowsChanged = "noteNumberOfRowsChanged";

	private static readonly IntPtr selNoteNumberOfRowsChangedHandle = Selector.GetHandle("noteNumberOfRowsChanged");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfColumns = "numberOfColumns";

	private static readonly IntPtr selNumberOfColumnsHandle = Selector.GetHandle("numberOfColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfRows = "numberOfRows";

	private static readonly IntPtr selNumberOfRowsHandle = Selector.GetHandle("numberOfRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfSelectedColumns = "numberOfSelectedColumns";

	private static readonly IntPtr selNumberOfSelectedColumnsHandle = Selector.GetHandle("numberOfSelectedColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfSelectedRows = "numberOfSelectedRows";

	private static readonly IntPtr selNumberOfSelectedRowsHandle = Selector.GetHandle("numberOfSelectedRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformClickOnCellAtColumn_Row_ = "performClickOnCellAtColumn:row:";

	private static readonly IntPtr selPerformClickOnCellAtColumn_Row_Handle = Selector.GetHandle("performClickOnCellAtColumn:row:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreparedCellAtColumn_Row_ = "preparedCellAtColumn:row:";

	private static readonly IntPtr selPreparedCellAtColumn_Row_Handle = Selector.GetHandle("preparedCellAtColumn:row:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectOfColumn_ = "rectOfColumn:";

	private static readonly IntPtr selRectOfColumn_Handle = Selector.GetHandle("rectOfColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectOfRow_ = "rectOfRow:";

	private static readonly IntPtr selRectOfRow_Handle = Selector.GetHandle("rectOfRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterNib_ForIdentifier_ = "registerNib:forIdentifier:";

	private static readonly IntPtr selRegisterNib_ForIdentifier_Handle = Selector.GetHandle("registerNib:forIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisteredNibsByIdentifier = "registeredNibsByIdentifier";

	private static readonly IntPtr selRegisteredNibsByIdentifierHandle = Selector.GetHandle("registeredNibsByIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadData = "reloadData";

	private static readonly IntPtr selReloadDataHandle = Selector.GetHandle("reloadData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadDataForRowIndexes_ColumnIndexes_ = "reloadDataForRowIndexes:columnIndexes:";

	private static readonly IntPtr selReloadDataForRowIndexes_ColumnIndexes_Handle = Selector.GetHandle("reloadDataForRowIndexes:columnIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveRowsAtIndexes_WithAnimation_ = "removeRowsAtIndexes:withAnimation:";

	private static readonly IntPtr selRemoveRowsAtIndexes_WithAnimation_Handle = Selector.GetHandle("removeRowsAtIndexes:withAnimation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTableColumn_ = "removeTableColumn:";

	private static readonly IntPtr selRemoveTableColumn_Handle = Selector.GetHandle("removeTableColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowActionsVisible = "rowActionsVisible";

	private static readonly IntPtr selRowActionsVisibleHandle = Selector.GetHandle("rowActionsVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowAtPoint_ = "rowAtPoint:";

	private static readonly IntPtr selRowAtPoint_Handle = Selector.GetHandle("rowAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowForView_ = "rowForView:";

	private static readonly IntPtr selRowForView_Handle = Selector.GetHandle("rowForView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowHeight = "rowHeight";

	private static readonly IntPtr selRowHeightHandle = Selector.GetHandle("rowHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowSizeStyle = "rowSizeStyle";

	private static readonly IntPtr selRowSizeStyleHandle = Selector.GetHandle("rowSizeStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowViewAtRow_MakeIfNecessary_ = "rowViewAtRow:makeIfNecessary:";

	private static readonly IntPtr selRowViewAtRow_MakeIfNecessary_Handle = Selector.GetHandle("rowViewAtRow:makeIfNecessary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowsInRect_ = "rowsInRect:";

	private static readonly IntPtr selRowsInRect_Handle = Selector.GetHandle("rowsInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollColumnToVisible_ = "scrollColumnToVisible:";

	private static readonly IntPtr selScrollColumnToVisible_Handle = Selector.GetHandle("scrollColumnToVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollRowToVisible_ = "scrollRowToVisible:";

	private static readonly IntPtr selScrollRowToVisible_Handle = Selector.GetHandle("scrollRowToVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectAll_ = "selectAll:";

	private static readonly IntPtr selSelectAll_Handle = Selector.GetHandle("selectAll:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectColumnIndexes_ByExtendingSelection_ = "selectColumnIndexes:byExtendingSelection:";

	private static readonly IntPtr selSelectColumnIndexes_ByExtendingSelection_Handle = Selector.GetHandle("selectColumnIndexes:byExtendingSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectRowIndexes_ByExtendingSelection_ = "selectRowIndexes:byExtendingSelection:";

	private static readonly IntPtr selSelectRowIndexes_ByExtendingSelection_Handle = Selector.GetHandle("selectRowIndexes:byExtendingSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedColumn = "selectedColumn";

	private static readonly IntPtr selSelectedColumnHandle = Selector.GetHandle("selectedColumn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedColumnIndexes = "selectedColumnIndexes";

	private static readonly IntPtr selSelectedColumnIndexesHandle = Selector.GetHandle("selectedColumnIndexes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedRow = "selectedRow";

	private static readonly IntPtr selSelectedRowHandle = Selector.GetHandle("selectedRow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedRowIndexes = "selectedRowIndexes";

	private static readonly IntPtr selSelectedRowIndexesHandle = Selector.GetHandle("selectedRowIndexes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionHighlightStyle = "selectionHighlightStyle";

	private static readonly IntPtr selSelectionHighlightStyleHandle = Selector.GetHandle("selectionHighlightStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySelectedRows_ = "setAccessibilitySelectedRows:";

	private static readonly IntPtr selSetAccessibilitySelectedRows_Handle = Selector.GetHandle("setAccessibilitySelectedRows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsColumnReordering_ = "setAllowsColumnReordering:";

	private static readonly IntPtr selSetAllowsColumnReordering_Handle = Selector.GetHandle("setAllowsColumnReordering:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsColumnResizing_ = "setAllowsColumnResizing:";

	private static readonly IntPtr selSetAllowsColumnResizing_Handle = Selector.GetHandle("setAllowsColumnResizing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsColumnSelection_ = "setAllowsColumnSelection:";

	private static readonly IntPtr selSetAllowsColumnSelection_Handle = Selector.GetHandle("setAllowsColumnSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsEmptySelection_ = "setAllowsEmptySelection:";

	private static readonly IntPtr selSetAllowsEmptySelection_Handle = Selector.GetHandle("setAllowsEmptySelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsMultipleSelection_ = "setAllowsMultipleSelection:";

	private static readonly IntPtr selSetAllowsMultipleSelection_Handle = Selector.GetHandle("setAllowsMultipleSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsTypeSelect_ = "setAllowsTypeSelect:";

	private static readonly IntPtr selSetAllowsTypeSelect_Handle = Selector.GetHandle("setAllowsTypeSelect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutosaveName_ = "setAutosaveName:";

	private static readonly IntPtr selSetAutosaveName_Handle = Selector.GetHandle("setAutosaveName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutosaveTableColumns_ = "setAutosaveTableColumns:";

	private static readonly IntPtr selSetAutosaveTableColumns_Handle = Selector.GetHandle("setAutosaveTableColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColumnAutoresizingStyle_ = "setColumnAutoresizingStyle:";

	private static readonly IntPtr selSetColumnAutoresizingStyle_Handle = Selector.GetHandle("setColumnAutoresizingStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCornerView_ = "setCornerView:";

	private static readonly IntPtr selSetCornerView_Handle = Selector.GetHandle("setCornerView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDataSource_ = "setDataSource:";

	private static readonly IntPtr selSetDataSource_Handle = Selector.GetHandle("setDataSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDoubleAction_ = "setDoubleAction:";

	private static readonly IntPtr selSetDoubleAction_Handle = Selector.GetHandle("setDoubleAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDraggingDestinationFeedbackStyle_ = "setDraggingDestinationFeedbackStyle:";

	private static readonly IntPtr selSetDraggingDestinationFeedbackStyle_Handle = Selector.GetHandle("setDraggingDestinationFeedbackStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDraggingSourceOperationMask_ForLocal_ = "setDraggingSourceOperationMask:forLocal:";

	private static readonly IntPtr selSetDraggingSourceOperationMask_ForLocal_Handle = Selector.GetHandle("setDraggingSourceOperationMask:forLocal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDropRow_DropOperation_ = "setDropRow:dropOperation:";

	private static readonly IntPtr selSetDropRow_DropOperation_Handle = Selector.GetHandle("setDropRow:dropOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloatsGroupRows_ = "setFloatsGroupRows:";

	private static readonly IntPtr selSetFloatsGroupRows_Handle = Selector.GetHandle("setFloatsGroupRows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFocusedColumn_ = "setFocusedColumn:";

	private static readonly IntPtr selSetFocusedColumn_Handle = Selector.GetHandle("setFocusedColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGridColor_ = "setGridColor:";

	private static readonly IntPtr selSetGridColor_Handle = Selector.GetHandle("setGridColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGridStyleMask_ = "setGridStyleMask:";

	private static readonly IntPtr selSetGridStyleMask_Handle = Selector.GetHandle("setGridStyleMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHeaderView_ = "setHeaderView:";

	private static readonly IntPtr selSetHeaderView_Handle = Selector.GetHandle("setHeaderView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHighlightedTableColumn_ = "setHighlightedTableColumn:";

	private static readonly IntPtr selSetHighlightedTableColumn_Handle = Selector.GetHandle("setHighlightedTableColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIndicatorImage_InTableColumn_ = "setIndicatorImage:inTableColumn:";

	private static readonly IntPtr selSetIndicatorImage_InTableColumn_Handle = Selector.GetHandle("setIndicatorImage:inTableColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIntercellSpacing_ = "setIntercellSpacing:";

	private static readonly IntPtr selSetIntercellSpacing_Handle = Selector.GetHandle("setIntercellSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRowActionsVisible_ = "setRowActionsVisible:";

	private static readonly IntPtr selSetRowActionsVisible_Handle = Selector.GetHandle("setRowActionsVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRowHeight_ = "setRowHeight:";

	private static readonly IntPtr selSetRowHeight_Handle = Selector.GetHandle("setRowHeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRowSizeStyle_ = "setRowSizeStyle:";

	private static readonly IntPtr selSetRowSizeStyle_Handle = Selector.GetHandle("setRowSizeStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectionHighlightStyle_ = "setSelectionHighlightStyle:";

	private static readonly IntPtr selSetSelectionHighlightStyle_Handle = Selector.GetHandle("setSelectionHighlightStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSortDescriptors_ = "setSortDescriptors:";

	private static readonly IntPtr selSetSortDescriptors_Handle = Selector.GetHandle("setSortDescriptors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserInterfaceLayoutDirection_ = "setUserInterfaceLayoutDirection:";

	private static readonly IntPtr selSetUserInterfaceLayoutDirection_Handle = Selector.GetHandle("setUserInterfaceLayoutDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesAlternatingRowBackgroundColors_ = "setUsesAlternatingRowBackgroundColors:";

	private static readonly IntPtr selSetUsesAlternatingRowBackgroundColors_Handle = Selector.GetHandle("setUsesAlternatingRowBackgroundColors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesAutomaticRowHeights_ = "setUsesAutomaticRowHeights:";

	private static readonly IntPtr selSetUsesAutomaticRowHeights_Handle = Selector.GetHandle("setUsesAutomaticRowHeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesStaticContents_ = "setUsesStaticContents:";

	private static readonly IntPtr selSetUsesStaticContents_Handle = Selector.GetHandle("setUsesStaticContents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVerticalMotionCanBeginDrag_ = "setVerticalMotionCanBeginDrag:";

	private static readonly IntPtr selSetVerticalMotionCanBeginDrag_Handle = Selector.GetHandle("setVerticalMotionCanBeginDrag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldFocusCell_AtColumn_Row_ = "shouldFocusCell:atColumn:row:";

	private static readonly IntPtr selShouldFocusCell_AtColumn_Row_Handle = Selector.GetHandle("shouldFocusCell:atColumn:row:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSizeLastColumnToFit = "sizeLastColumnToFit";

	private static readonly IntPtr selSizeLastColumnToFitHandle = Selector.GetHandle("sizeLastColumnToFit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSizeToFit = "sizeToFit";

	private static readonly IntPtr selSizeToFitHandle = Selector.GetHandle("sizeToFit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortDescriptors = "sortDescriptors";

	private static readonly IntPtr selSortDescriptorsHandle = Selector.GetHandle("sortDescriptors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTableColumnWithIdentifier_ = "tableColumnWithIdentifier:";

	private static readonly IntPtr selTableColumnWithIdentifier_Handle = Selector.GetHandle("tableColumnWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTableColumns = "tableColumns";

	private static readonly IntPtr selTableColumnsHandle = Selector.GetHandle("tableColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextDidBeginEditing_ = "textDidBeginEditing:";

	private static readonly IntPtr selTextDidBeginEditing_Handle = Selector.GetHandle("textDidBeginEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextDidChange_ = "textDidChange:";

	private static readonly IntPtr selTextDidChange_Handle = Selector.GetHandle("textDidChange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextDidEndEditing_ = "textDidEndEditing:";

	private static readonly IntPtr selTextDidEndEditing_Handle = Selector.GetHandle("textDidEndEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextShouldBeginEditing_ = "textShouldBeginEditing:";

	private static readonly IntPtr selTextShouldBeginEditing_Handle = Selector.GetHandle("textShouldBeginEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextShouldEndEditing_ = "textShouldEndEditing:";

	private static readonly IntPtr selTextShouldEndEditing_Handle = Selector.GetHandle("textShouldEndEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTile = "tile";

	private static readonly IntPtr selTileHandle = Selector.GetHandle("tile");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnhideRowsAtIndexes_WithAnimation_ = "unhideRowsAtIndexes:withAnimation:";

	private static readonly IntPtr selUnhideRowsAtIndexes_WithAnimation_Handle = Selector.GetHandle("unhideRowsAtIndexes:withAnimation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserInterfaceLayoutDirection = "userInterfaceLayoutDirection";

	private static readonly IntPtr selUserInterfaceLayoutDirectionHandle = Selector.GetHandle("userInterfaceLayoutDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesAlternatingRowBackgroundColors = "usesAlternatingRowBackgroundColors";

	private static readonly IntPtr selUsesAlternatingRowBackgroundColorsHandle = Selector.GetHandle("usesAlternatingRowBackgroundColors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesAutomaticRowHeights = "usesAutomaticRowHeights";

	private static readonly IntPtr selUsesAutomaticRowHeightsHandle = Selector.GetHandle("usesAutomaticRowHeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesStaticContents = "usesStaticContents";

	private static readonly IntPtr selUsesStaticContentsHandle = Selector.GetHandle("usesStaticContents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateUserInterfaceItem_ = "validateUserInterfaceItem:";

	private static readonly IntPtr selValidateUserInterfaceItem_Handle = Selector.GetHandle("validateUserInterfaceItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVerticalMotionCanBeginDrag = "verticalMotionCanBeginDrag";

	private static readonly IntPtr selVerticalMotionCanBeginDragHandle = Selector.GetHandle("verticalMotionCanBeginDrag");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewAtColumn_Row_MakeIfNecessary_ = "viewAtColumn:row:makeIfNecessary:";

	private static readonly IntPtr selViewAtColumn_Row_MakeIfNecessary_Handle = Selector.GetHandle("viewAtColumn:row:makeIfNecessary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTableView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDataSource_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColumnDidMoveNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColumnDidResizeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RowViewKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectionDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectionIsChangingNotification;

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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject[] AccessibilityColumnHeaderUIElements
	{
		[Export("accessibilityColumnHeaderUIElements")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityColumnHeaderUIElementsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityColumnHeaderUIElementsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject[] AccessibilityColumns
	{
		[Export("accessibilityColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityColumnsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityColumnsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual bool AccessibilityFocused
	{
		[Export("isAccessibilityFocused")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityFocusedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityFocusedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual CGRect AccessibilityFrame
	{
		[Export("accessibilityFrame")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selAccessibilityFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAccessibilityFrameHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'AccessibilityHeader' instead.")]
	public virtual string AccessibilityHeaderGroup
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'AccessibilityHeader' instead.")]
		[Export("accessibilityHeaderGroup")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityHeaderGroupHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityHeaderGroupHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual string AccessibilityIdentifier
	{
		[Export("accessibilityIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual string? AccessibilityLabel
	{
		[Export("accessibilityLabel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityLabelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject? AccessibilityParent
	{
		[Export("accessibilityParent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityParentHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityParentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject[] AccessibilityRowHeaderUIElements
	{
		[Export("accessibilityRowHeaderUIElements")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityRowHeaderUIElementsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityRowHeaderUIElementsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual INSAccessibilityRow[]? AccessibilityRows
	{
		[Export("accessibilityRows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<INSAccessibilityRow>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityRowsHandle));
			}
			return NSArray.ArrayFromHandle<INSAccessibilityRow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityRowsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject[] AccessibilitySelectedCells
	{
		[Export("accessibilitySelectedCells")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySelectedCellsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySelectedCellsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject[] AccessibilitySelectedColumns
	{
		[Export("accessibilitySelectedColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySelectedColumnsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySelectedColumnsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual INSAccessibilityRow[]? AccessibilitySelectedRows
	{
		[Export("accessibilitySelectedRows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<INSAccessibilityRow>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySelectedRowsHandle));
			}
			return NSArray.ArrayFromHandle<INSAccessibilityRow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySelectedRowsHandle));
		}
		[Export("setAccessibilitySelectedRows:")]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySelectedRows_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySelectedRows_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject[] AccessibilityVisibleCells
	{
		[Export("accessibilityVisibleCells")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityVisibleCellsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityVisibleCellsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject[] AccessibilityVisibleColumns
	{
		[Export("accessibilityVisibleColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityVisibleColumnsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityVisibleColumnsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual INSAccessibilityRow[] AccessibilityVisibleRows
	{
		[Export("accessibilityVisibleRows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<INSAccessibilityRow>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityVisibleRowsHandle));
			}
			return NSArray.ArrayFromHandle<INSAccessibilityRow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityVisibleRowsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsColumnReordering
	{
		[Export("allowsColumnReordering")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsColumnReorderingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsColumnReorderingHandle);
		}
		[Export("setAllowsColumnReordering:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsColumnReordering_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsColumnReordering_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsColumnResizing
	{
		[Export("allowsColumnResizing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsColumnResizingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsColumnResizingHandle);
		}
		[Export("setAllowsColumnResizing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsColumnResizing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsColumnResizing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsColumnSelection
	{
		[Export("allowsColumnSelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsColumnSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsColumnSelectionHandle);
		}
		[Export("setAllowsColumnSelection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsColumnSelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsColumnSelection_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsEmptySelection
	{
		[Export("allowsEmptySelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsEmptySelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsEmptySelectionHandle);
		}
		[Export("setAllowsEmptySelection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsEmptySelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsEmptySelection_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsMultipleSelection
	{
		[Export("allowsMultipleSelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsMultipleSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsMultipleSelectionHandle);
		}
		[Export("setAllowsMultipleSelection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsMultipleSelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsMultipleSelection_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsTypeSelect
	{
		[Export("allowsTypeSelect")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsTypeSelectHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsTypeSelectHandle);
		}
		[Export("setAllowsTypeSelect:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsTypeSelect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsTypeSelect_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string AutosaveName
	{
		[Export("autosaveName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutosaveTableColumns
	{
		[Export("autosaveTableColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutosaveTableColumnsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutosaveTableColumnsHandle);
		}
		[Export("setAutosaveTableColumns:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutosaveTableColumns_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutosaveTableColumns_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle));
		}
		[Export("setBackgroundColor:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ClickedColumn
	{
		[Export("clickedColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selClickedColumnHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selClickedColumnHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ClickedRow
	{
		[Export("clickedRow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selClickedRowHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selClickedRowHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTableViewColumnAutoresizingStyle ColumnAutoresizingStyle
	{
		[Export("columnAutoresizingStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTableViewColumnAutoresizingStyle)Messaging.UInt64_objc_msgSend(base.Handle, selColumnAutoresizingStyleHandle);
			}
			return (NSTableViewColumnAutoresizingStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selColumnAutoresizingStyleHandle);
		}
		[Export("setColumnAutoresizingStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetColumnAutoresizingStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetColumnAutoresizingStyle_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ColumnCount
	{
		[Export("numberOfColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfColumnsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfColumnsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView CornerView
	{
		[Export("cornerView", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selCornerViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCornerViewHandle));
		}
		[Export("setCornerView:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCornerView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCornerView_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSTableViewDataSource? DataSource
	{
		get
		{
			return WeakDataSource as INSTableViewDataSource;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDataSource = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSTableViewDelegate? Delegate
	{
		get
		{
			return WeakDelegate as INSTableViewDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Selector DoubleAction
	{
		[Export("doubleAction")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDoubleAction_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDoubleAction_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTableViewDraggingDestinationFeedbackStyle DraggingDestinationFeedbackStyle
	{
		[Export("draggingDestinationFeedbackStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTableViewDraggingDestinationFeedbackStyle)Messaging.Int64_objc_msgSend(base.Handle, selDraggingDestinationFeedbackStyleHandle);
			}
			return (NSTableViewDraggingDestinationFeedbackStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDraggingDestinationFeedbackStyleHandle);
		}
		[Export("setDraggingDestinationFeedbackStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDraggingDestinationFeedbackStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDraggingDestinationFeedbackStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint EditedColumn
	{
		[Export("editedColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selEditedColumnHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selEditedColumnHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint EditedRow
	{
		[Export("editedRow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selEditedRowHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selEditedRowHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTableViewRowSizeStyle EffectiveRowSizeStyle
	{
		[Export("effectiveRowSizeStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTableViewRowSizeStyle)Messaging.Int64_objc_msgSend(base.Handle, selEffectiveRowSizeStyleHandle);
			}
			return (NSTableViewRowSizeStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selEffectiveRowSizeStyleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FloatsGroupRows
	{
		[Export("floatsGroupRows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selFloatsGroupRowsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFloatsGroupRowsHandle);
		}
		[Export("setFloatsGroupRows:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFloatsGroupRows_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFloatsGroupRows_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use a View Based TableView; observe the window’s firstResponder.")]
	public virtual nint FocusedColumn
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use a View Based TableView; observe the window’s firstResponder.")]
		[Export("focusedColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selFocusedColumnHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selFocusedColumnHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use a View Based TableView; observe the window’s firstResponder.")]
		[Export("setFocusedColumn:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetFocusedColumn_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetFocusedColumn_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor GridColor
	{
		[Export("gridColor", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selGridColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGridColorHandle));
		}
		[Export("setGridColor:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGridColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGridColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTableViewGridStyle GridStyleMask
	{
		[Export("gridStyleMask")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTableViewGridStyle)Messaging.UInt64_objc_msgSend(base.Handle, selGridStyleMaskHandle);
			}
			return (NSTableViewGridStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selGridStyleMaskHandle);
		}
		[Export("setGridStyleMask:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetGridStyleMask_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetGridStyleMask_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTableHeaderView? HeaderView
	{
		[Export("headerView", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTableHeaderView>(Messaging.IntPtr_objc_msgSend(base.Handle, selHeaderViewHandle));
			}
			return Runtime.GetNSObject<NSTableHeaderView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHeaderViewHandle));
		}
		[Export("setHeaderView:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHeaderView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHeaderView_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSIndexSet HiddenRowIndexes
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("hiddenRowIndexes", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selHiddenRowIndexesHandle));
			}
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHiddenRowIndexesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTableColumn HighlightedTableColumn
	{
		[Export("highlightedTableColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTableColumn>(Messaging.IntPtr_objc_msgSend(base.Handle, selHighlightedTableColumnHandle));
			}
			return Runtime.GetNSObject<NSTableColumn>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHighlightedTableColumnHandle));
		}
		[Export("setHighlightedTableColumn:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHighlightedTableColumn_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHighlightedTableColumn_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IgnoreModifierKeysWhileDragging
	{
		[Export("ignoreModifierKeysWhileDragging")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIgnoreModifierKeysWhileDraggingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIgnoreModifierKeysWhileDraggingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize IntercellSpacing
	{
		[Export("intercellSpacing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selIntercellSpacingHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selIntercellSpacingHandle);
		}
		[Export("setIntercellSpacing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetIntercellSpacing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetIntercellSpacing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary RegisteredNibsByIdentifier
	{
		[Export("registeredNibsByIdentifier", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selRegisteredNibsByIdentifierHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRegisteredNibsByIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool RowActionsVisible
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("rowActionsVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRowActionsVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRowActionsVisibleHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setRowActionsVisible:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRowActionsVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRowActionsVisible_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint RowCount
	{
		[Export("numberOfRows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfRowsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfRowsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat RowHeight
	{
		[Export("rowHeight")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selRowHeightHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selRowHeightHandle);
		}
		[Export("setRowHeight:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetRowHeight_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetRowHeight_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTableViewRowSizeStyle RowSizeStyle
	{
		[Export("rowSizeStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTableViewRowSizeStyle)Messaging.Int64_objc_msgSend(base.Handle, selRowSizeStyleHandle);
			}
			return (NSTableViewRowSizeStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRowSizeStyleHandle);
		}
		[Export("setRowSizeStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetRowSizeStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetRowSizeStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SelectedColumn
	{
		[Export("selectedColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSelectedColumnHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSelectedColumnHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet SelectedColumns
	{
		[Export("selectedColumnIndexes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedColumnIndexesHandle));
			}
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedColumnIndexesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SelectedColumnsCount
	{
		[Export("numberOfSelectedColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfSelectedColumnsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfSelectedColumnsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SelectedRow
	{
		[Export("selectedRow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSelectedRowHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSelectedRowHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SelectedRowCount
	{
		[Export("numberOfSelectedRows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfSelectedRowsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfSelectedRowsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet SelectedRows
	{
		[Export("selectedRowIndexes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedRowIndexesHandle));
			}
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedRowIndexesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTableViewSelectionHighlightStyle SelectionHighlightStyle
	{
		[Export("selectionHighlightStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTableViewSelectionHighlightStyle)Messaging.Int64_objc_msgSend(base.Handle, selSelectionHighlightStyleHandle);
			}
			return (NSTableViewSelectionHighlightStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSelectionHighlightStyleHandle);
		}
		[Export("setSelectionHighlightStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetSelectionHighlightStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetSelectionHighlightStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSortDescriptor[] SortDescriptors
	{
		[Export("sortDescriptors", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSSortDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selSortDescriptorsHandle));
			}
			return NSArray.ArrayFromHandle<NSSortDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSortDescriptorsHandle));
		}
		[Export("setSortDescriptors:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSortDescriptors_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSortDescriptors_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public new virtual NSUserInterfaceLayoutDirection UserInterfaceLayoutDirection
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("userInterfaceLayoutDirection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSUserInterfaceLayoutDirection)Messaging.Int64_objc_msgSend(base.Handle, selUserInterfaceLayoutDirectionHandle);
			}
			return (NSUserInterfaceLayoutDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selUserInterfaceLayoutDirectionHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setUserInterfaceLayoutDirection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetUserInterfaceLayoutDirection_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetUserInterfaceLayoutDirection_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UsesAlternatingRowBackgroundColors
	{
		[Export("usesAlternatingRowBackgroundColors")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesAlternatingRowBackgroundColorsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesAlternatingRowBackgroundColorsHandle);
		}
		[Export("setUsesAlternatingRowBackgroundColors:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesAlternatingRowBackgroundColors_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesAlternatingRowBackgroundColors_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual bool UsesAutomaticRowHeights
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("usesAutomaticRowHeights")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesAutomaticRowHeightsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesAutomaticRowHeightsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setUsesAutomaticRowHeights:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesAutomaticRowHeights_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesAutomaticRowHeights_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool UsesStaticContents
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("usesStaticContents")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesStaticContentsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesStaticContentsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setUsesStaticContents:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesStaticContents_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesStaticContents_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool VerticalMotionCanBeginDrag
	{
		[Export("verticalMotionCanBeginDrag")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selVerticalMotionCanBeginDragHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selVerticalMotionCanBeginDragHandle);
		}
		[Export("setVerticalMotionCanBeginDrag:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetVerticalMotionCanBeginDrag_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetVerticalMotionCanBeginDrag_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDataSource
	{
		[Export("dataSource", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataSourceHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataSourceHandle)));
			MarkDirty();
			__mt_WeakDataSource_var = nSObject;
			return nSObject;
		}
		[Export("setDataSource:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDataSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDataSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDataSource_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[Field("NSTableViewColumnDidMoveNotification", "AppKit")]
	[Advice("Use NSTableView.Notifications.ObserveColumnDidMove helper method instead.")]
	public static NSString ColumnDidMoveNotification
	{
		get
		{
			if (_ColumnDidMoveNotification == null)
			{
				_ColumnDidMoveNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTableViewColumnDidMoveNotification");
			}
			return _ColumnDidMoveNotification;
		}
	}

	[Field("NSTableViewColumnDidResizeNotification", "AppKit")]
	[Advice("Use NSTableView.Notifications.ObserveColumnDidResize helper method instead.")]
	public static NSString ColumnDidResizeNotification
	{
		get
		{
			if (_ColumnDidResizeNotification == null)
			{
				_ColumnDidResizeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTableViewColumnDidResizeNotification");
			}
			return _ColumnDidResizeNotification;
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

	[Field("NSTableViewSelectionDidChangeNotification", "AppKit")]
	[Advice("Use NSTableView.Notifications.ObserveSelectionDidChange helper method instead.")]
	public static NSString SelectionDidChangeNotification
	{
		get
		{
			if (_SelectionDidChangeNotification == null)
			{
				_SelectionDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTableViewSelectionDidChangeNotification");
			}
			return _SelectionDidChangeNotification;
		}
	}

	[Field("NSTableViewSelectionIsChangingNotification", "AppKit")]
	[Advice("Use NSTableView.Notifications.ObserveSelectionIsChanging helper method instead.")]
	public static NSString SelectionIsChangingNotification
	{
		get
		{
			if (_SelectionIsChangingNotification == null)
			{
				_SelectionIsChangingNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTableViewSelectionIsChangingNotification");
			}
			return _SelectionIsChangingNotification;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_NSTableViewDelegate);

	public NSTableViewRowGetter? CoreGetRowView
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

	public NSTableViewCellGetter? GetDataCell
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

	public NSTableViewSearchString? GetNextTypeSelectMatch
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

	public NSTableViewRowHeight? GetRowHeight
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

	public NSTableViewColumnRowString? GetSelectString
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

	public NSTableViewIndexFilter? GetSelectionIndexes
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

	public NSTableViewColumnWidth? GetSizeToFitColumnWidth
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

	public NSTableViewToolTip? GetToolTip
	{
		get
		{
			return EnsureNSTableViewDelegate().getToolTip;
		}
		set
		{
			EnsureNSTableViewDelegate().getToolTip = value;
		}
	}

	public NSTableViewViewGetter? GetViewForItem
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

	public NSTableViewRowPredicate? IsGroupRow
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

	public NSTableViewRowActionsGetter? RowActions
	{
		get
		{
			return EnsureNSTableViewDelegate().rowActions;
		}
		set
		{
			EnsureNSTableViewDelegate().rowActions = value;
		}
	}

	public NSTableViewPredicate? SelectionShouldChange
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

	public NSTableViewColumnRowPredicate? ShouldEditTableColumn
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

	public NSTableReorder? ShouldReorder
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

	public NSTableViewRowPredicate? ShouldSelectRow
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

	public NSTableViewColumnPredicate? ShouldSelectTableColumn
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

	public NSTableViewColumnRowPredicate? ShouldShowCellExpansion
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

	public NSTableViewCell? ShouldTrackCell
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

	public NSTableViewEventString? ShouldTypeSelect
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

	public void SelectRow(nint row, bool byExtendingSelection)
	{
		SelectRows(NSIndexSet.FromIndex(row), byExtendingSelection);
	}

	public void SelectColumn(nint column, bool byExtendingSelection)
	{
		SelectColumns(NSIndexSet.FromIndex(column), byExtendingSelection);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTableView()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSTableView(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSTableView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTableView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTableView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
	}

	[Export("addTableColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddColumn(NSTableColumn tableColumn)
	{
		NSApplication.EnsureUIThread();
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddTableColumn_Handle, tableColumn.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddTableColumn_Handle, tableColumn.Handle);
		}
	}

	[Export("beginUpdates")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginUpdates()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selBeginUpdatesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selBeginUpdatesHandle);
		}
	}

	[Export("canDragRowsWithIndexes:atPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanDragRows(NSIndexSet rowIndexes, CGPoint mouseDownPoint)
	{
		NSApplication.EnsureUIThread();
		if (rowIndexes == null)
		{
			throw new ArgumentNullException("rowIndexes");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_CGPoint(base.Handle, selCanDragRowsWithIndexes_AtPoint_Handle, rowIndexes.Handle, mouseDownPoint);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selCanDragRowsWithIndexes_AtPoint_Handle, rowIndexes.Handle, mouseDownPoint);
	}

	[Export("columnForView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ColumnForView(NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selColumnForView_Handle, view.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selColumnForView_Handle, view.Handle);
	}

	[Export("deselectAll:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeselectAll(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeselectAll_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeselectAll_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("deselectColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeselectColumn(nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selDeselectColumn_Handle, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selDeselectColumn_Handle, column);
		}
	}

	[Export("deselectRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeselectRow(nint row)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selDeselectRow_Handle, row);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selDeselectRow_Handle, row);
		}
	}

	[Export("dragImageForRowsWithIndexes:tableColumns:event:offset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage DragImageForRowsWithIndexestableColumnseventoffset(NSIndexSet dragRows, NSTableColumn[] tableColumns, NSEvent dragEvent, ref CGPoint dragImageOffset)
	{
		NSApplication.EnsureUIThread();
		if (dragRows == null)
		{
			throw new ArgumentNullException("dragRows");
		}
		if (tableColumns == null)
		{
			throw new ArgumentNullException("tableColumns");
		}
		if (dragEvent == null)
		{
			throw new ArgumentNullException("dragEvent");
		}
		NSArray nSArray = NSArray.FromNSObjects(tableColumns);
		NSImage result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_CGPoint(base.SuperHandle, selDragImageForRowsWithIndexes_TableColumns_Event_Offset_Handle, dragRows.Handle, nSArray.Handle, dragEvent.Handle, ref dragImageOffset)) : Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_CGPoint(base.Handle, selDragImageForRowsWithIndexes_TableColumns_Event_Offset_Handle, dragRows.Handle, nSArray.Handle, dragEvent.Handle, ref dragImageOffset)));
		nSArray.Dispose();
		return result;
	}

	[Export("draggedImage:beganAt:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggedImageBeganAt(NSImage image, CGPoint screenPoint)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint(base.Handle, selDraggedImage_BeganAt_Handle, image.Handle, screenPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selDraggedImage_BeganAt_Handle, image.Handle, screenPoint);
		}
	}

	[Export("draggedImage:endedAt:deposited:")]
	[Deprecated(PlatformName.MacOSX, 10, 1, PlatformArchitecture.All, "Use DraggedImageEndedAtOperation instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggedImageEndedAtDeposited(NSImage image, CGPoint screenPoint, bool deposited)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint_bool(base.Handle, selDraggedImage_EndedAt_Deposited_Handle, image.Handle, screenPoint, deposited);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint_bool(base.SuperHandle, selDraggedImage_EndedAt_Deposited_Handle, image.Handle, screenPoint, deposited);
		}
	}

	[Export("draggedImage:endedAt:operation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggedImageEndedAtOperation(NSImage image, CGPoint screenPoint, NSDragOperation operation)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint_UInt64(base.Handle, selDraggedImage_EndedAt_Operation_Handle, image.Handle, screenPoint, (ulong)operation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint_UInt64(base.SuperHandle, selDraggedImage_EndedAt_Operation_Handle, image.Handle, screenPoint, (ulong)operation);
		}
	}

	[Export("draggedImage:movedTo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggedImageMovedTo(NSImage image, CGPoint screenPoint)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint(base.Handle, selDraggedImage_MovedTo_Handle, image.Handle, screenPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selDraggedImage_MovedTo_Handle, image.Handle, screenPoint);
		}
	}

	[Export("draggingSourceOperationMaskForLocal:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDragOperation DraggingSourceOperationMaskForLocal(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return (NSDragOperation)Messaging.UInt64_objc_msgSend_bool(base.Handle, selDraggingSourceOperationMaskForLocal_Handle, flag);
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSendSuper_bool(base.SuperHandle, selDraggingSourceOperationMaskForLocal_Handle, flag);
	}

	[Export("drawBackgroundInClipRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawBackground(CGRect clipRect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawBackgroundInClipRect_Handle, clipRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawBackgroundInClipRect_Handle, clipRect);
		}
	}

	[Export("drawGridInClipRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawGrid(CGRect clipRect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawGridInClipRect_Handle, clipRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawGridInClipRect_Handle, clipRect);
		}
	}

	[Export("drawRow:clipRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawRow(nint row, CGRect clipRect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_CGRect(base.Handle, selDrawRow_ClipRect_Handle, row, clipRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_CGRect(base.SuperHandle, selDrawRow_ClipRect_Handle, row, clipRect);
		}
	}

	[Export("editColumn:row:withEvent:select:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EditColumn(nint column, nint row, NSEvent? theEvent, bool select)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint_IntPtr_bool(base.Handle, selEditColumn_Row_WithEvent_Select_Handle, column, row, theEvent?.Handle ?? IntPtr.Zero, select);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint_IntPtr_bool(base.SuperHandle, selEditColumn_Row_WithEvent_Select_Handle, column, row, theEvent?.Handle ?? IntPtr.Zero, select);
		}
	}

	[Export("endUpdates")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndUpdates()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEndUpdatesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEndUpdatesHandle);
		}
	}

	[Export("enumerateAvailableRowViewsUsingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateAvailableRowViews([BlockProxy(typeof(Trampolines.NIDNSTableViewRowHandler))] NSTableViewRowHandler callback)
	{
		NSApplication.EnsureUIThread();
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSTableViewRowHandler.Handler, callback);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEnumerateAvailableRowViewsUsingBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEnumerateAvailableRowViewsUsingBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("columnWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint FindColumn(NSString identifier)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selColumnWithIdentifier_Handle, identifier.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selColumnWithIdentifier_Handle, identifier.Handle);
	}

	[Export("tableColumnWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTableColumn FindTableColumn(NSString identifier)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSTableColumn>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTableColumnWithIdentifier_Handle, identifier.Handle));
		}
		return Runtime.GetNSObject<NSTableColumn>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTableColumnWithIdentifier_Handle, identifier.Handle));
	}

	[Export("preparedCellAtColumn:row:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use View Based TableView and GetView.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCell GetCell(nint column, nint row)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCell>(Messaging.IntPtr_objc_msgSend_nint_nint(base.Handle, selPreparedCellAtColumn_Row_Handle, column, row));
		}
		return Runtime.GetNSObject<NSCell>(Messaging.IntPtr_objc_msgSendSuper_nint_nint(base.SuperHandle, selPreparedCellAtColumn_Row_Handle, column, row));
	}

	[Export("frameOfCellAtColumn:row:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetCellFrame(nint column, nint row)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nint_nint(out retval, base.Handle, selFrameOfCellAtColumn_Row_Handle, column, row);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nint_nint(out retval, base.SuperHandle, selFrameOfCellAtColumn_Row_Handle, column, row);
		}
		return retval;
	}

	[Export("columnAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetColumn(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_CGPoint(base.Handle, selColumnAtPoint_Handle, point);
		}
		return Messaging.nint_objc_msgSendSuper_CGPoint(base.SuperHandle, selColumnAtPoint_Handle, point);
	}

	[Export("columnIndexesInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet GetColumnIndexesInRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selColumnIndexesInRect_Handle, rect));
		}
		return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selColumnIndexesInRect_Handle, rect));
	}

	[Export("indicatorImageInTableColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage GetIndicatorImage(NSTableColumn tableColumn)
	{
		NSApplication.EnsureUIThread();
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selIndicatorImageInTableColumn_Handle, tableColumn.Handle));
		}
		return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndicatorImageInTableColumn_Handle, tableColumn.Handle));
	}

	[Export("rowAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetRow(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_CGPoint(base.Handle, selRowAtPoint_Handle, point);
		}
		return Messaging.nint_objc_msgSendSuper_CGPoint(base.SuperHandle, selRowAtPoint_Handle, point);
	}

	[Export("rowViewAtRow:makeIfNecessary:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTableRowView GetRowView(nint row, bool makeIfNecessary)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSTableRowView>(Messaging.IntPtr_objc_msgSend_nint_bool(base.Handle, selRowViewAtRow_MakeIfNecessary_Handle, row, makeIfNecessary));
		}
		return Runtime.GetNSObject<NSTableRowView>(Messaging.IntPtr_objc_msgSendSuper_nint_bool(base.SuperHandle, selRowViewAtRow_MakeIfNecessary_Handle, row, makeIfNecessary));
	}

	[Export("viewAtColumn:row:makeIfNecessary:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView GetView(nint column, nint row, bool makeIfNecessary)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend_nint_nint_bool(base.Handle, selViewAtColumn_Row_MakeIfNecessary_Handle, column, row, makeIfNecessary));
		}
		return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper_nint_nint_bool(base.SuperHandle, selViewAtColumn_Row_MakeIfNecessary_Handle, column, row, makeIfNecessary));
	}

	[Export("hideRowsAtIndexes:withAnimation:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void HideRows(NSIndexSet indexes, NSTableViewAnimation rowAnimation)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selHideRowsAtIndexes_WithAnimation_Handle, indexes.Handle, (ulong)rowAnimation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selHideRowsAtIndexes_WithAnimation_Handle, indexes.Handle, (ulong)rowAnimation);
		}
	}

	[Export("highlightSelectionInClipRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void HighlightSelection(CGRect clipRect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selHighlightSelectionInClipRect_Handle, clipRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selHighlightSelectionInClipRect_Handle, clipRect);
		}
	}

	[Export("insertRowsAtIndexes:withAnimation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertRows(NSIndexSet indexes, NSTableViewAnimation animationOptions)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selInsertRowsAtIndexes_WithAnimation_Handle, indexes.Handle, (ulong)animationOptions);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selInsertRowsAtIndexes_WithAnimation_Handle, indexes.Handle, (ulong)animationOptions);
		}
	}

	[Export("isColumnSelected:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsColumnSelected(nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nint(base.Handle, selIsColumnSelected_Handle, column);
		}
		return Messaging.bool_objc_msgSendSuper_nint(base.SuperHandle, selIsColumnSelected_Handle, column);
	}

	[Export("isRowSelected:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsRowSelected(nint row)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nint(base.Handle, selIsRowSelected_Handle, row);
		}
		return Messaging.bool_objc_msgSendSuper_nint(base.SuperHandle, selIsRowSelected_Handle, row);
	}

	[Export("makeViewWithIdentifier:owner:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView MakeView(string? identifier, NSObject? owner)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(identifier);
		NSView result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMakeViewWithIdentifier_Owner_Handle, arg, owner?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selMakeViewWithIdentifier_Owner_Handle, arg, owner?.Handle ?? IntPtr.Zero)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("moveColumn:toColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveColumn(nint oldIndex, nint newIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint(base.Handle, selMoveColumn_ToColumn_Handle, oldIndex, newIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint(base.SuperHandle, selMoveColumn_ToColumn_Handle, oldIndex, newIndex);
		}
	}

	[Export("moveRowAtIndex:toIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveRow(nint oldIndex, nint newIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint(base.Handle, selMoveRowAtIndex_ToIndex_Handle, oldIndex, newIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint(base.SuperHandle, selMoveRowAtIndex_ToIndex_Handle, oldIndex, newIndex);
		}
	}

	[Export("namesOfPromisedFilesDroppedAtDestination:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use NSFilePromiseProvider objects instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] NamesOfPromisedFilesDroppedAtDestination(NSUrl dropDestination)
	{
		NSApplication.EnsureUIThread();
		if (dropDestination == null)
		{
			throw new ArgumentNullException("dropDestination");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNamesOfPromisedFilesDroppedAtDestination_Handle, dropDestination.Handle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNamesOfPromisedFilesDroppedAtDestination_Handle, dropDestination.Handle));
	}

	[Export("noteHeightOfRowsWithIndexesChanged:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NoteHeightOfRowsWithIndexesChanged(NSIndexSet indexSet)
	{
		NSApplication.EnsureUIThread();
		if (indexSet == null)
		{
			throw new ArgumentNullException("indexSet");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selNoteHeightOfRowsWithIndexesChanged_Handle, indexSet.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selNoteHeightOfRowsWithIndexesChanged_Handle, indexSet.Handle);
		}
	}

	[Export("noteNumberOfRowsChanged")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NoteNumberOfRowsChanged()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selNoteNumberOfRowsChangedHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selNoteNumberOfRowsChangedHandle);
		}
	}

	[Export("performClickOnCellAtColumn:row:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use a View Based TableView; directly interact with a particular view as required and call PerformClick on it, if necessary.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformClick(nint column, nint row)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint(base.Handle, selPerformClickOnCellAtColumn_Row_Handle, column, row);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint(base.SuperHandle, selPerformClickOnCellAtColumn_Row_Handle, column, row);
		}
	}

	[Export("rectOfColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect RectForColumn(nint column)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nint(out retval, base.Handle, selRectOfColumn_Handle, column);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nint(out retval, base.SuperHandle, selRectOfColumn_Handle, column);
		}
		return retval;
	}

	[Export("rectOfRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect RectForRow(nint row)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nint(out retval, base.Handle, selRectOfRow_Handle, row);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nint(out retval, base.SuperHandle, selRectOfRow_Handle, row);
		}
		return retval;
	}

	[Export("registerNib:forIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegisterNib(NSNib? nib, string identifier)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRegisterNib_ForIdentifier_Handle, nib?.Handle ?? IntPtr.Zero, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRegisterNib_ForIdentifier_Handle, nib?.Handle ?? IntPtr.Zero, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("reloadData")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadData()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadDataHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadDataHandle);
		}
	}

	[Export("reloadDataForRowIndexes:columnIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selReloadDataForRowIndexes_ColumnIndexes_Handle, rowIndexes.Handle, columnIndexes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReloadDataForRowIndexes_ColumnIndexes_Handle, rowIndexes.Handle, columnIndexes.Handle);
		}
	}

	[Export("removeTableColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveColumn(NSTableColumn tableColumn)
	{
		NSApplication.EnsureUIThread();
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveTableColumn_Handle, tableColumn.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveTableColumn_Handle, tableColumn.Handle);
		}
	}

	[Export("removeRowsAtIndexes:withAnimation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveRows(NSIndexSet indexes, NSTableViewAnimation animationOptions)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selRemoveRowsAtIndexes_WithAnimation_Handle, indexes.Handle, (ulong)animationOptions);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selRemoveRowsAtIndexes_WithAnimation_Handle, indexes.Handle, (ulong)animationOptions);
		}
	}

	[Export("rowForView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint RowForView(NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selRowForView_Handle, view.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selRowForView_Handle, view.Handle);
	}

	[Export("didAddRowView:forRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RowViewAdded(NSTableRowView rowView, nint row)
	{
		NSApplication.EnsureUIThread();
		if (rowView == null)
		{
			throw new ArgumentNullException("rowView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selDidAddRowView_ForRow_Handle, rowView.Handle, row);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selDidAddRowView_ForRow_Handle, rowView.Handle, row);
		}
	}

	[Export("didRemoveRowView:forRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RowViewRemoved(NSTableRowView rowView, nint row)
	{
		NSApplication.EnsureUIThread();
		if (rowView == null)
		{
			throw new ArgumentNullException("rowView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selDidRemoveRowView_ForRow_Handle, rowView.Handle, row);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selDidRemoveRowView_ForRow_Handle, rowView.Handle, row);
		}
	}

	[Export("rowsInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange RowsInRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_CGRect(base.Handle, selRowsInRect_Handle, rect);
		}
		return Messaging.NSRange_objc_msgSendSuper_CGRect(base.SuperHandle, selRowsInRect_Handle, rect);
	}

	[Export("scrollColumnToVisible:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollColumnToVisible(nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selScrollColumnToVisible_Handle, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selScrollColumnToVisible_Handle, column);
		}
	}

	[Export("scrollRowToVisible:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollRowToVisible(nint row)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selScrollRowToVisible_Handle, row);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selScrollRowToVisible_Handle, row);
		}
	}

	[Export("selectAll:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectAll(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectAll_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectAll_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("selectColumnIndexes:byExtendingSelection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectColumns(NSIndexSet indexes, bool byExtendingSelection)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSelectColumnIndexes_ByExtendingSelection_Handle, indexes.Handle, byExtendingSelection);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSelectColumnIndexes_ByExtendingSelection_Handle, indexes.Handle, byExtendingSelection);
		}
	}

	[Export("selectRowIndexes:byExtendingSelection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectRows(NSIndexSet indexes, bool byExtendingSelection)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSelectRowIndexes_ByExtendingSelection_Handle, indexes.Handle, byExtendingSelection);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSelectRowIndexes_ByExtendingSelection_Handle, indexes.Handle, byExtendingSelection);
		}
	}

	[Export("setDraggingSourceOperationMask:forLocal:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDraggingSourceOperationMask(NSDragOperation mask, bool isLocal)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_bool(base.Handle, selSetDraggingSourceOperationMask_ForLocal_Handle, (ulong)mask, isLocal);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_bool(base.SuperHandle, selSetDraggingSourceOperationMask_ForLocal_Handle, (ulong)mask, isLocal);
		}
	}

	[Export("setDropRow:dropOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDropRowDropOperation(nint row, NSTableViewDropOperation dropOperation)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_UInt64(base.Handle, selSetDropRow_DropOperation_Handle, row, (ulong)dropOperation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_UInt64(base.SuperHandle, selSetDropRow_DropOperation_Handle, row, (ulong)dropOperation);
		}
	}

	[Export("setIndicatorImage:inTableColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetIndicatorImage(NSImage? anImage, NSTableColumn tableColumn)
	{
		NSApplication.EnsureUIThread();
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetIndicatorImage_InTableColumn_Handle, anImage?.Handle ?? IntPtr.Zero, tableColumn.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetIndicatorImage_InTableColumn_Handle, anImage?.Handle ?? IntPtr.Zero, tableColumn.Handle);
		}
	}

	[Export("shouldFocusCell:atColumn:row:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use a View Based TableView; observe the window’s firstResponder for focus change notifications.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldFocusCell(NSCell cell, nint column, nint row)
	{
		NSApplication.EnsureUIThread();
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_nint_nint(base.Handle, selShouldFocusCell_AtColumn_Row_Handle, cell.Handle, column, row);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_nint_nint(base.SuperHandle, selShouldFocusCell_AtColumn_Row_Handle, cell.Handle, column, row);
	}

	[Export("sizeLastColumnToFit")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SizeLastColumnToFit()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSizeLastColumnToFitHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSizeLastColumnToFitHandle);
		}
	}

	[Export("sizeToFit")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void SizeToFit()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSizeToFitHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSizeToFitHandle);
		}
	}

	[Export("tableColumns")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTableColumn[] TableColumns()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSTableColumn>(Messaging.IntPtr_objc_msgSend(base.Handle, selTableColumnsHandle));
		}
		return NSArray.ArrayFromHandle<NSTableColumn>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTableColumnsHandle));
	}

	[Export("textDidBeginEditing:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use a View Based TableView with an NSTextField.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TextDidBeginEditing(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTextDidBeginEditing_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextDidBeginEditing_Handle, notification.Handle);
		}
	}

	[Export("textDidChange:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use a View Based TableView with an NSTextField.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TextDidChange(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTextDidChange_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextDidChange_Handle, notification.Handle);
		}
	}

	[Export("textDidEndEditing:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use a View Based TableView with an NSTextField.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TextDidEndEditing(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTextDidEndEditing_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextDidEndEditing_Handle, notification.Handle);
		}
	}

	[Export("textShouldBeginEditing:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use a View Based TableView with an NSTextField.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TextShouldBeginEditing(NSText textObject)
	{
		NSApplication.EnsureUIThread();
		if (textObject == null)
		{
			throw new ArgumentNullException("textObject");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selTextShouldBeginEditing_Handle, textObject.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextShouldBeginEditing_Handle, textObject.Handle);
	}

	[Export("textShouldEndEditing:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use a View Based TableView with an NSTextField.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TextShouldEndEditing(NSText textObject)
	{
		NSApplication.EnsureUIThread();
		if (textObject == null)
		{
			throw new ArgumentNullException("textObject");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selTextShouldEndEditing_Handle, textObject.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextShouldEndEditing_Handle, textObject.Handle);
	}

	[Export("tile")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Tile()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selTileHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selTileHandle);
		}
	}

	[Export("unhideRowsAtIndexes:withAnimation:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnhideRows(NSIndexSet indexes, NSTableViewAnimation rowAnimation)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selUnhideRowsAtIndexes_WithAnimation_Handle, indexes.Handle, (ulong)rowAnimation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selUnhideRowsAtIndexes_WithAnimation_Handle, indexes.Handle, (ulong)rowAnimation);
		}
	}

	[Export("validateUserInterfaceItem:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateUserInterfaceItem(INSValidatedUserInterfaceItem item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selValidateUserInterfaceItem_Handle, item.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selValidateUserInterfaceItem_Handle, item.Handle);
	}

	internal virtual _NSTableViewDelegate CreateInternalEventDelegateType()
	{
		return new _NSTableViewDelegate();
	}

	internal _NSTableViewDelegate EnsureNSTableViewDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSTableViewDelegate nSTableViewDelegate = Delegate as _NSTableViewDelegate;
		if (nSTableViewDelegate == null)
		{
			nSTableViewDelegate = (_NSTableViewDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSTableViewDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDataSource_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
