using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSBrowser", true)]
public class NSBrowser : NSControl
{
	public new static class Notifications
	{
		public static NSObject ObserveColumnConfigurationChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ColumnConfigurationChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveColumnConfigurationChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ColumnConfigurationChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddColumn = "addColumn";

	private static readonly IntPtr selAddColumnHandle = Selector.GetHandle("addColumn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsBranchSelection = "allowsBranchSelection";

	private static readonly IntPtr selAllowsBranchSelectionHandle = Selector.GetHandle("allowsBranchSelection");

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
	private const string selAutohidesScroller = "autohidesScroller";

	private static readonly IntPtr selAutohidesScrollerHandle = Selector.GetHandle("autohidesScroller");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColor = "backgroundColor";

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanDragRowsWithIndexes_InColumn_WithEvent_ = "canDragRowsWithIndexes:inColumn:withEvent:";

	private static readonly IntPtr selCanDragRowsWithIndexes_InColumn_WithEvent_Handle = Selector.GetHandle("canDragRowsWithIndexes:inColumn:withEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellClass = "cellClass";

	private static readonly IntPtr selCellClassHandle = Selector.GetHandle("cellClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellPrototype = "cellPrototype";

	private static readonly IntPtr selCellPrototypeHandle = Selector.GetHandle("cellPrototype");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClickedColumn = "clickedColumn";

	private static readonly IntPtr selClickedColumnHandle = Selector.GetHandle("clickedColumn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClickedRow = "clickedRow";

	private static readonly IntPtr selClickedRowHandle = Selector.GetHandle("clickedRow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColumnContentWidthForColumnWidth_ = "columnContentWidthForColumnWidth:";

	private static readonly IntPtr selColumnContentWidthForColumnWidth_Handle = Selector.GetHandle("columnContentWidthForColumnWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColumnOfMatrix_ = "columnOfMatrix:";

	private static readonly IntPtr selColumnOfMatrix_Handle = Selector.GetHandle("columnOfMatrix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColumnResizingType = "columnResizingType";

	private static readonly IntPtr selColumnResizingTypeHandle = Selector.GetHandle("columnResizingType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColumnWidthForColumnContentWidth_ = "columnWidthForColumnContentWidth:";

	private static readonly IntPtr selColumnWidthForColumnContentWidth_Handle = Selector.GetHandle("columnWidthForColumnContentWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColumnsAutosaveName = "columnsAutosaveName";

	private static readonly IntPtr selColumnsAutosaveNameHandle = Selector.GetHandle("columnsAutosaveName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultColumnWidth = "defaultColumnWidth";

	private static readonly IntPtr selDefaultColumnWidthHandle = Selector.GetHandle("defaultColumnWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoClick_ = "doClick:";

	private static readonly IntPtr selDoClick_Handle = Selector.GetHandle("doClick:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoDoubleClick_ = "doDoubleClick:";

	private static readonly IntPtr selDoDoubleClick_Handle = Selector.GetHandle("doDoubleClick:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoubleAction = "doubleAction";

	private static readonly IntPtr selDoubleActionHandle = Selector.GetHandle("doubleAction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawTitleOfColumn_InRect_ = "drawTitleOfColumn:inRect:";

	private static readonly IntPtr selDrawTitleOfColumn_InRect_Handle = Selector.GetHandle("drawTitleOfColumn:inRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEditItemAtIndexPath_WithEvent_Select_ = "editItemAtIndexPath:withEvent:select:";

	private static readonly IntPtr selEditItemAtIndexPath_WithEvent_Select_Handle = Selector.GetHandle("editItemAtIndexPath:withEvent:select:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstVisibleColumn = "firstVisibleColumn";

	private static readonly IntPtr selFirstVisibleColumnHandle = Selector.GetHandle("firstVisibleColumn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameOfColumn_ = "frameOfColumn:";

	private static readonly IntPtr selFrameOfColumn_Handle = Selector.GetHandle("frameOfColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameOfInsideOfColumn_ = "frameOfInsideOfColumn:";

	private static readonly IntPtr selFrameOfInsideOfColumn_Handle = Selector.GetHandle("frameOfInsideOfColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameOfRow_InColumn_ = "frameOfRow:inColumn:";

	private static readonly IntPtr selFrameOfRow_InColumn_Handle = Selector.GetHandle("frameOfRow:inColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetRow_Column_ForPoint_ = "getRow:column:forPoint:";

	private static readonly IntPtr selGetRow_Column_ForPoint_Handle = Selector.GetHandle("getRow:column:forPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasHorizontalScroller = "hasHorizontalScroller";

	private static readonly IntPtr selHasHorizontalScrollerHandle = Selector.GetHandle("hasHorizontalScroller");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexPathForColumn_ = "indexPathForColumn:";

	private static readonly IntPtr selIndexPathForColumn_Handle = Selector.GetHandle("indexPathForColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLeafItem_ = "isLeafItem:";

	private static readonly IntPtr selIsLeafItem_Handle = Selector.GetHandle("isLeafItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLoaded = "isLoaded";

	private static readonly IntPtr selIsLoadedHandle = Selector.GetHandle("isLoaded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsTitled = "isTitled";

	private static readonly IntPtr selIsTitledHandle = Selector.GetHandle("isTitled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemAtIndexPath_ = "itemAtIndexPath:";

	private static readonly IntPtr selItemAtIndexPath_Handle = Selector.GetHandle("itemAtIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemAtRow_InColumn_ = "itemAtRow:inColumn:";

	private static readonly IntPtr selItemAtRow_InColumn_Handle = Selector.GetHandle("itemAtRow:inColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLastColumn = "lastColumn";

	private static readonly IntPtr selLastColumnHandle = Selector.GetHandle("lastColumn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLastVisibleColumn = "lastVisibleColumn";

	private static readonly IntPtr selLastVisibleColumnHandle = Selector.GetHandle("lastVisibleColumn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadColumnZero = "loadColumnZero";

	private static readonly IntPtr selLoadColumnZeroHandle = Selector.GetHandle("loadColumnZero");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadedCellAtRow_Column_ = "loadedCellAtRow:column:";

	private static readonly IntPtr selLoadedCellAtRow_Column_Handle = Selector.GetHandle("loadedCellAtRow:column:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatrixClass = "matrixClass";

	private static readonly IntPtr selMatrixClassHandle = Selector.GetHandle("matrixClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatrixInColumn_ = "matrixInColumn:";

	private static readonly IntPtr selMatrixInColumn_Handle = Selector.GetHandle("matrixInColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxVisibleColumns = "maxVisibleColumns";

	private static readonly IntPtr selMaxVisibleColumnsHandle = Selector.GetHandle("maxVisibleColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinColumnWidth = "minColumnWidth";

	private static readonly IntPtr selMinColumnWidthHandle = Selector.GetHandle("minColumnWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoteHeightOfRowsWithIndexesChanged_InColumn_ = "noteHeightOfRowsWithIndexesChanged:inColumn:";

	private static readonly IntPtr selNoteHeightOfRowsWithIndexesChanged_InColumn_Handle = Selector.GetHandle("noteHeightOfRowsWithIndexesChanged:inColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfVisibleColumns = "numberOfVisibleColumns";

	private static readonly IntPtr selNumberOfVisibleColumnsHandle = Selector.GetHandle("numberOfVisibleColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParentForItemsInColumn_ = "parentForItemsInColumn:";

	private static readonly IntPtr selParentForItemsInColumn_Handle = Selector.GetHandle("parentForItemsInColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPath = "path";

	private static readonly IntPtr selPathHandle = Selector.GetHandle("path");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathSeparator = "pathSeparator";

	private static readonly IntPtr selPathSeparatorHandle = Selector.GetHandle("pathSeparator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathToColumn_ = "pathToColumn:";

	private static readonly IntPtr selPathToColumn_Handle = Selector.GetHandle("pathToColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrefersAllColumnUserResizing = "prefersAllColumnUserResizing";

	private static readonly IntPtr selPrefersAllColumnUserResizingHandle = Selector.GetHandle("prefersAllColumnUserResizing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadColumn_ = "reloadColumn:";

	private static readonly IntPtr selReloadColumn_Handle = Selector.GetHandle("reloadColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadDataForRowIndexes_InColumn_ = "reloadDataForRowIndexes:inColumn:";

	private static readonly IntPtr selReloadDataForRowIndexes_InColumn_Handle = Selector.GetHandle("reloadDataForRowIndexes:inColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveSavedColumnsWithAutosaveName_ = "removeSavedColumnsWithAutosaveName:";

	private static readonly IntPtr selRemoveSavedColumnsWithAutosaveName_Handle = Selector.GetHandle("removeSavedColumnsWithAutosaveName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReusesColumns = "reusesColumns";

	private static readonly IntPtr selReusesColumnsHandle = Selector.GetHandle("reusesColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowHeight = "rowHeight";

	private static readonly IntPtr selRowHeightHandle = Selector.GetHandle("rowHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollColumnToVisible_ = "scrollColumnToVisible:";

	private static readonly IntPtr selScrollColumnToVisible_Handle = Selector.GetHandle("scrollColumnToVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollColumnsLeftBy_ = "scrollColumnsLeftBy:";

	private static readonly IntPtr selScrollColumnsLeftBy_Handle = Selector.GetHandle("scrollColumnsLeftBy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollColumnsRightBy_ = "scrollColumnsRightBy:";

	private static readonly IntPtr selScrollColumnsRightBy_Handle = Selector.GetHandle("scrollColumnsRightBy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollRowToVisible_InColumn_ = "scrollRowToVisible:inColumn:";

	private static readonly IntPtr selScrollRowToVisible_InColumn_Handle = Selector.GetHandle("scrollRowToVisible:inColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectAll_ = "selectAll:";

	private static readonly IntPtr selSelectAll_Handle = Selector.GetHandle("selectAll:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectRow_InColumn_ = "selectRow:inColumn:";

	private static readonly IntPtr selSelectRow_InColumn_Handle = Selector.GetHandle("selectRow:inColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectRowIndexes_InColumn_ = "selectRowIndexes:inColumn:";

	private static readonly IntPtr selSelectRowIndexes_InColumn_Handle = Selector.GetHandle("selectRowIndexes:inColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedCell = "selectedCell";

	private static readonly IntPtr selSelectedCellHandle = Selector.GetHandle("selectedCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedCellInColumn_ = "selectedCellInColumn:";

	private static readonly IntPtr selSelectedCellInColumn_Handle = Selector.GetHandle("selectedCellInColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedCells = "selectedCells";

	private static readonly IntPtr selSelectedCellsHandle = Selector.GetHandle("selectedCells");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedColumn = "selectedColumn";

	private static readonly IntPtr selSelectedColumnHandle = Selector.GetHandle("selectedColumn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedRowInColumn_ = "selectedRowInColumn:";

	private static readonly IntPtr selSelectedRowInColumn_Handle = Selector.GetHandle("selectedRowInColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedRowIndexesInColumn_ = "selectedRowIndexesInColumn:";

	private static readonly IntPtr selSelectedRowIndexesInColumn_Handle = Selector.GetHandle("selectedRowIndexesInColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionIndexPath = "selectionIndexPath";

	private static readonly IntPtr selSelectionIndexPathHandle = Selector.GetHandle("selectionIndexPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionIndexPaths = "selectionIndexPaths";

	private static readonly IntPtr selSelectionIndexPathsHandle = Selector.GetHandle("selectionIndexPaths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendAction = "sendAction";

	private static readonly IntPtr selSendActionHandle = Selector.GetHandle("sendAction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendsActionOnArrowKeys = "sendsActionOnArrowKeys";

	private static readonly IntPtr selSendsActionOnArrowKeysHandle = Selector.GetHandle("sendsActionOnArrowKeys");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeparatesColumns = "separatesColumns";

	private static readonly IntPtr selSeparatesColumnsHandle = Selector.GetHandle("separatesColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsBranchSelection_ = "setAllowsBranchSelection:";

	private static readonly IntPtr selSetAllowsBranchSelection_Handle = Selector.GetHandle("setAllowsBranchSelection:");

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
	private const string selSetAutohidesScroller_ = "setAutohidesScroller:";

	private static readonly IntPtr selSetAutohidesScroller_Handle = Selector.GetHandle("setAutohidesScroller:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCellClass_ = "setCellClass:";

	private static readonly IntPtr selSetCellClass_Handle = Selector.GetHandle("setCellClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCellPrototype_ = "setCellPrototype:";

	private static readonly IntPtr selSetCellPrototype_Handle = Selector.GetHandle("setCellPrototype:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColumnResizingType_ = "setColumnResizingType:";

	private static readonly IntPtr selSetColumnResizingType_Handle = Selector.GetHandle("setColumnResizingType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColumnsAutosaveName_ = "setColumnsAutosaveName:";

	private static readonly IntPtr selSetColumnsAutosaveName_Handle = Selector.GetHandle("setColumnsAutosaveName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultColumnWidth_ = "setDefaultColumnWidth:";

	private static readonly IntPtr selSetDefaultColumnWidth_Handle = Selector.GetHandle("setDefaultColumnWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDoubleAction_ = "setDoubleAction:";

	private static readonly IntPtr selSetDoubleAction_Handle = Selector.GetHandle("setDoubleAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDraggingSourceOperationMask_ForLocal_ = "setDraggingSourceOperationMask:forLocal:";

	private static readonly IntPtr selSetDraggingSourceOperationMask_ForLocal_Handle = Selector.GetHandle("setDraggingSourceOperationMask:forLocal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHasHorizontalScroller_ = "setHasHorizontalScroller:";

	private static readonly IntPtr selSetHasHorizontalScroller_Handle = Selector.GetHandle("setHasHorizontalScroller:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLastColumn_ = "setLastColumn:";

	private static readonly IntPtr selSetLastColumn_Handle = Selector.GetHandle("setLastColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMatrixClass_ = "setMatrixClass:";

	private static readonly IntPtr selSetMatrixClass_Handle = Selector.GetHandle("setMatrixClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxVisibleColumns_ = "setMaxVisibleColumns:";

	private static readonly IntPtr selSetMaxVisibleColumns_Handle = Selector.GetHandle("setMaxVisibleColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinColumnWidth_ = "setMinColumnWidth:";

	private static readonly IntPtr selSetMinColumnWidth_Handle = Selector.GetHandle("setMinColumnWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPath_ = "setPath:";

	private static readonly IntPtr selSetPath_Handle = Selector.GetHandle("setPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPathSeparator_ = "setPathSeparator:";

	private static readonly IntPtr selSetPathSeparator_Handle = Selector.GetHandle("setPathSeparator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrefersAllColumnUserResizing_ = "setPrefersAllColumnUserResizing:";

	private static readonly IntPtr selSetPrefersAllColumnUserResizing_Handle = Selector.GetHandle("setPrefersAllColumnUserResizing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReusesColumns_ = "setReusesColumns:";

	private static readonly IntPtr selSetReusesColumns_Handle = Selector.GetHandle("setReusesColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRowHeight_ = "setRowHeight:";

	private static readonly IntPtr selSetRowHeight_Handle = Selector.GetHandle("setRowHeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectionIndexPath_ = "setSelectionIndexPath:";

	private static readonly IntPtr selSetSelectionIndexPath_Handle = Selector.GetHandle("setSelectionIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectionIndexPaths_ = "setSelectionIndexPaths:";

	private static readonly IntPtr selSetSelectionIndexPaths_Handle = Selector.GetHandle("setSelectionIndexPaths:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSendsActionOnArrowKeys_ = "setSendsActionOnArrowKeys:";

	private static readonly IntPtr selSetSendsActionOnArrowKeys_Handle = Selector.GetHandle("setSendsActionOnArrowKeys:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSeparatesColumns_ = "setSeparatesColumns:";

	private static readonly IntPtr selSetSeparatesColumns_Handle = Selector.GetHandle("setSeparatesColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTakesTitleFromPreviousColumn_ = "setTakesTitleFromPreviousColumn:";

	private static readonly IntPtr selSetTakesTitleFromPreviousColumn_Handle = Selector.GetHandle("setTakesTitleFromPreviousColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitle_OfColumn_ = "setTitle:ofColumn:";

	private static readonly IntPtr selSetTitle_OfColumn_Handle = Selector.GetHandle("setTitle:ofColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitled_ = "setTitled:";

	private static readonly IntPtr selSetTitled_Handle = Selector.GetHandle("setTitled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWidth_OfColumn_ = "setWidth:ofColumn:";

	private static readonly IntPtr selSetWidth_OfColumn_Handle = Selector.GetHandle("setWidth:ofColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTakesTitleFromPreviousColumn = "takesTitleFromPreviousColumn";

	private static readonly IntPtr selTakesTitleFromPreviousColumnHandle = Selector.GetHandle("takesTitleFromPreviousColumn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTile = "tile";

	private static readonly IntPtr selTileHandle = Selector.GetHandle("tile");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitleFrameOfColumn_ = "titleFrameOfColumn:";

	private static readonly IntPtr selTitleFrameOfColumn_Handle = Selector.GetHandle("titleFrameOfColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitleHeight = "titleHeight";

	private static readonly IntPtr selTitleHeightHandle = Selector.GetHandle("titleHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitleOfColumn_ = "titleOfColumn:";

	private static readonly IntPtr selTitleOfColumn_Handle = Selector.GetHandle("titleOfColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateVisibleColumns = "validateVisibleColumns";

	private static readonly IntPtr selValidateVisibleColumnsHandle = Selector.GetHandle("validateVisibleColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWidthOfColumn_ = "widthOfColumn:";

	private static readonly IntPtr selWidthOfColumn_Handle = Selector.GetHandle("widthOfColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSBrowser");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColumnConfigurationChangedNotification;

	public string Path
	{
		get
		{
			return GetPath();
		}
		set
		{
			SetPath(value);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsBranchSelection
	{
		[Export("allowsBranchSelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsBranchSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsBranchSelectionHandle);
		}
		[Export("setAllowsBranchSelection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsBranchSelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsBranchSelection_Handle, value);
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
	public virtual bool AutohidesScroller
	{
		[Export("autohidesScroller")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutohidesScrollerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutohidesScrollerHandle);
		}
		[Export("setAutohidesScroller:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutohidesScroller_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutohidesScroller_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle));
		}
		[Export("setBackgroundColor:", ArgumentSemantic.Retain)]
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
	public new static Class CellClass
	{
		[Export("cellClass")]
		get
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = Messaging.IntPtr_objc_msgSend(class_ptr, selCellClassHandle);
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject CellPrototype
	{
		[Export("cellPrototype", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCellPrototypeHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCellPrototypeHandle));
		}
		[Export("setCellPrototype:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCellPrototype_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCellPrototype_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBrowserColumnResizingType ColumnResizingType
	{
		[Export("columnResizingType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSBrowserColumnResizingType)Messaging.UInt64_objc_msgSend(base.Handle, selColumnResizingTypeHandle);
			}
			return (NSBrowserColumnResizingType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selColumnResizingTypeHandle);
		}
		[Export("setColumnResizingType:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetColumnResizingType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetColumnResizingType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ColumnsAutosaveName
	{
		[Export("columnsAutosaveName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selColumnsAutosaveNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColumnsAutosaveNameHandle));
		}
		[Export("setColumnsAutosaveName:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColumnsAutosaveName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColumnsAutosaveName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat DefaultColumnWidth
	{
		[Export("defaultColumnWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selDefaultColumnWidthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selDefaultColumnWidthHandle);
		}
		[Export("setDefaultColumnWidth:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetDefaultColumnWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetDefaultColumnWidth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSBrowserDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSBrowserDelegate;
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
	public virtual nint FirstVisibleColumn
	{
		[Export("firstVisibleColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selFirstVisibleColumnHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selFirstVisibleColumnHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasHorizontalScroller
	{
		[Export("hasHorizontalScroller")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasHorizontalScrollerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasHorizontalScrollerHandle);
		}
		[Export("setHasHorizontalScroller:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasHorizontalScroller_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasHorizontalScroller_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint LastColumn
	{
		[Export("lastColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selLastColumnHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selLastColumnHandle);
		}
		[Export("setLastColumn:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetLastColumn_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetLastColumn_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint LastVisibleColumn
	{
		[Export("lastVisibleColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selLastVisibleColumnHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selLastVisibleColumnHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Loaded
	{
		[Export("isLoaded")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLoadedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLoadedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the item based NSBrowser instead.")]
	public virtual Class MatrixClass
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the item based NSBrowser instead.")]
		[Export("matrixClass")]
		get
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMatrixClassHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selMatrixClassHandle));
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the item based NSBrowser instead.")]
		[Export("setMatrixClass:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMatrixClass_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMatrixClass_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint MaxVisibleColumns
	{
		[Export("maxVisibleColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMaxVisibleColumnsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMaxVisibleColumnsHandle);
		}
		[Export("setMaxVisibleColumns:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetMaxVisibleColumns_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetMaxVisibleColumns_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MinColumnWidth
	{
		[Export("minColumnWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMinColumnWidthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMinColumnWidthHandle);
		}
		[Export("setMinColumnWidth:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMinColumnWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMinColumnWidth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PathSeparator
	{
		[Export("pathSeparator")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPathSeparatorHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathSeparatorHandle));
		}
		[Export("setPathSeparator:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPathSeparator_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPathSeparator_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PrefersAllColumnUserResizing
	{
		[Export("prefersAllColumnUserResizing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPrefersAllColumnUserResizingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPrefersAllColumnUserResizingHandle);
		}
		[Export("setPrefersAllColumnUserResizing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPrefersAllColumnUserResizing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPrefersAllColumnUserResizing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReusesColumns
	{
		[Export("reusesColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selReusesColumnsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selReusesColumnsHandle);
		}
		[Export("setReusesColumns:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetReusesColumns_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetReusesColumns_Handle, value);
			}
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
	public virtual NSIndexPath? SelectionIndexPath
	{
		[Export("selectionIndexPath", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionIndexPathHandle));
			}
			return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionIndexPathHandle));
		}
		[Export("setSelectionIndexPath:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelectionIndexPath_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectionIndexPath_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexPath[] SelectionIndexPaths
	{
		[Export("selectionIndexPaths", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSIndexPath>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionIndexPathsHandle));
			}
			return NSArray.ArrayFromHandle<NSIndexPath>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionIndexPathsHandle));
		}
		[Export("setSelectionIndexPaths:", ArgumentSemantic.Copy)]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelectionIndexPaths_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectionIndexPaths_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SendsActionOnArrowKeys
	{
		[Export("sendsActionOnArrowKeys")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSendsActionOnArrowKeysHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSendsActionOnArrowKeysHandle);
		}
		[Export("setSendsActionOnArrowKeys:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSendsActionOnArrowKeys_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSendsActionOnArrowKeys_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SeparatesColumns
	{
		[Export("separatesColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSeparatesColumnsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSeparatesColumnsHandle);
		}
		[Export("setSeparatesColumns:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSeparatesColumns_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSeparatesColumns_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TakesTitleFromPreviousColumn
	{
		[Export("takesTitleFromPreviousColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTakesTitleFromPreviousColumnHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTakesTitleFromPreviousColumnHandle);
		}
		[Export("setTakesTitleFromPreviousColumn:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTakesTitleFromPreviousColumn_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTakesTitleFromPreviousColumn_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat TitleHeight
	{
		[Export("titleHeight")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selTitleHeightHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selTitleHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Titled
	{
		[Export("isTitled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTitledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTitledHandle);
		}
		[Export("setTitled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTitled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTitled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint VisibleColumns
	{
		[Export("numberOfVisibleColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfVisibleColumnsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfVisibleColumnsHandle);
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

	[Field("NSBrowserColumnConfigurationDidChangeNotification", "AppKit")]
	[Advice("Use NSBrowser.Notifications.ObserveColumnConfigurationChanged helper method instead.")]
	public static NSString ColumnConfigurationChangedNotification
	{
		get
		{
			if (_ColumnConfigurationChangedNotification == null)
			{
				_ColumnConfigurationChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSBrowserColumnConfigurationDidChangeNotification");
			}
			return _ColumnConfigurationChangedNotification;
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSBrowser()
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
	public NSBrowser(NSCoder coder)
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
	protected NSBrowser(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSBrowser(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSBrowser(CGRect frameRect)
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

	[Export("addColumn")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddColumn()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAddColumnHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAddColumnHandle);
		}
	}

	[Export("canDragRowsWithIndexes:inColumn:withEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanDragRowsWithIndexes(NSIndexSet rowIndexes, nint column, NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (rowIndexes == null)
		{
			throw new ArgumentNullException("rowIndexes");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_nint_IntPtr(base.Handle, selCanDragRowsWithIndexes_InColumn_WithEvent_Handle, rowIndexes.Handle, column, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_nint_IntPtr(base.SuperHandle, selCanDragRowsWithIndexes_InColumn_WithEvent_Handle, rowIndexes.Handle, column, theEvent.Handle);
	}

	[Export("clickedColumn")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ClickedColumn()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend(base.Handle, selClickedColumnHandle);
		}
		return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selClickedColumnHandle);
	}

	[Export("clickedRow")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ClickedRow()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend(base.Handle, selClickedRowHandle);
		}
		return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selClickedRowHandle);
	}

	[Export("columnContentWidthForColumnWidth:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ColumnContentWidthForColumnWidth(nfloat columnWidth)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_nfloat(base.Handle, selColumnContentWidthForColumnWidth_Handle, columnWidth);
		}
		return Messaging.nfloat_objc_msgSendSuper_nfloat(base.SuperHandle, selColumnContentWidthForColumnWidth_Handle, columnWidth);
	}

	[Export("frameOfColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ColumnFrame(nint column)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nint(out retval, base.Handle, selFrameOfColumn_Handle, column);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nint(out retval, base.SuperHandle, selFrameOfColumn_Handle, column);
		}
		return retval;
	}

	[Export("frameOfInsideOfColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ColumnInsideFrame(nint column)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nint(out retval, base.Handle, selFrameOfInsideOfColumn_Handle, column);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nint(out retval, base.SuperHandle, selFrameOfInsideOfColumn_Handle, column);
		}
		return retval;
	}

	[Export("columnOfMatrix:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the item based NSBrowser instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ColumnOfMatrix(NSMatrix matrix)
	{
		NSApplication.EnsureUIThread();
		if (matrix == null)
		{
			throw new ArgumentNullException("matrix");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selColumnOfMatrix_Handle, matrix.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selColumnOfMatrix_Handle, matrix.Handle);
	}

	[Export("pathToColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ColumnPath(nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selPathToColumn_Handle, column));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selPathToColumn_Handle, column));
	}

	[Export("titleOfColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ColumnTitle(nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selTitleOfColumn_Handle, column));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selTitleOfColumn_Handle, column));
	}

	[Export("columnWidthForColumnContentWidth:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ColumnWidthForColumnContentWidth(nfloat columnContentWidth)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_nfloat(base.Handle, selColumnWidthForColumnContentWidth_Handle, columnContentWidth);
		}
		return Messaging.nfloat_objc_msgSendSuper_nfloat(base.SuperHandle, selColumnWidthForColumnContentWidth_Handle, columnContentWidth);
	}

	[Export("doClick:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DoClick(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDoClick_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDoClick_Handle, sender.Handle);
		}
	}

	[Export("doDoubleClick:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DoDoubleClick(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDoDoubleClick_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDoDoubleClick_Handle, sender.Handle);
		}
	}

	[Export("drawTitleOfColumn:inRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawTitle(nint column, CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_CGRect(base.Handle, selDrawTitleOfColumn_InRect_Handle, column, aRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_CGRect(base.SuperHandle, selDrawTitleOfColumn_InRect_Handle, column, aRect);
		}
	}

	[Export("editItemAtIndexPath:withEvent:select:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EditItemAtIndexPath(NSIndexPath indexPath, NSEvent theEvent, bool select)
	{
		NSApplication.EnsureUIThread();
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, selEditItemAtIndexPath_WithEvent_Select_Handle, indexPath.Handle, theEvent.Handle, select);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool(base.SuperHandle, selEditItemAtIndexPath_WithEvent_Select_Handle, indexPath.Handle, theEvent.Handle, select);
		}
	}

	[Export("widthOfColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetColumnWidth(nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_nint(base.Handle, selWidthOfColumn_Handle, column);
		}
		return Messaging.nfloat_objc_msgSendSuper_nint(base.SuperHandle, selWidthOfColumn_Handle, column);
	}

	[Export("itemAtRow:inColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetItem(nint row, nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nint_nint(base.Handle, selItemAtRow_InColumn_Handle, row, column));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_nint_nint(base.SuperHandle, selItemAtRow_InColumn_Handle, row, column));
	}

	[Export("path")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual string GetPath()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPathHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathHandle));
	}

	[Export("getRow:column:forPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetRowColumnForPoint(out nint row, out nint column, CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_out_nint_out_nint_CGPoint(base.Handle, selGetRow_Column_ForPoint_Handle, out row, out column, point);
		}
		return Messaging.bool_objc_msgSendSuper_out_nint_out_nint_CGPoint(base.SuperHandle, selGetRow_Column_ForPoint_Handle, out row, out column, point);
	}

	[Export("indexPathForColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexPath IndexPathForColumn(nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selIndexPathForColumn_Handle, column));
		}
		return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selIndexPathForColumn_Handle, column));
	}

	[Export("isLeafItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsLeafItem(NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsLeafItem_Handle, item.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsLeafItem_Handle, item.Handle);
	}

	[Export("itemAtIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ItemAtIndexPath(NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selItemAtIndexPath_Handle, indexPath.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemAtIndexPath_Handle, indexPath.Handle));
	}

	[Export("loadColumnZero")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LoadColumnZero()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLoadColumnZeroHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLoadColumnZeroHandle);
		}
	}

	[Export("loadedCellAtRow:column:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCell LoadedCell(nint row, nint col)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCell>(Messaging.IntPtr_objc_msgSend_nint_nint(base.Handle, selLoadedCellAtRow_Column_Handle, row, col));
		}
		return Runtime.GetNSObject<NSCell>(Messaging.IntPtr_objc_msgSendSuper_nint_nint(base.SuperHandle, selLoadedCellAtRow_Column_Handle, row, col));
	}

	[Export("matrixInColumn:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the item based NSBrowser instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMatrix MatrixInColumn(nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSMatrix>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selMatrixInColumn_Handle, column));
		}
		return Runtime.GetNSObject<NSMatrix>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selMatrixInColumn_Handle, column));
	}

	[Export("noteHeightOfRowsWithIndexesChanged:inColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NoteHeightOfRows(NSIndexSet indexSet, nint columnIndex)
	{
		NSApplication.EnsureUIThread();
		if (indexSet == null)
		{
			throw new ArgumentNullException("indexSet");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selNoteHeightOfRowsWithIndexesChanged_InColumn_Handle, indexSet.Handle, columnIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selNoteHeightOfRowsWithIndexesChanged_InColumn_Handle, indexSet.Handle, columnIndex);
		}
	}

	[Export("parentForItemsInColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ParentForItems(nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selParentForItemsInColumn_Handle, column));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selParentForItemsInColumn_Handle, column));
	}

	[Export("reloadColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadColumn(nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selReloadColumn_Handle, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selReloadColumn_Handle, column);
		}
	}

	[Export("reloadDataForRowIndexes:inColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadData(NSIndexSet rowIndexes, nint column)
	{
		NSApplication.EnsureUIThread();
		if (rowIndexes == null)
		{
			throw new ArgumentNullException("rowIndexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selReloadDataForRowIndexes_InColumn_Handle, rowIndexes.Handle, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selReloadDataForRowIndexes_InColumn_Handle, rowIndexes.Handle, column);
		}
	}

	[Export("removeSavedColumnsWithAutosaveName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RemoveSavedColumnsWithAutosaveName(string name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selRemoveSavedColumnsWithAutosaveName_Handle, arg);
		NSString.ReleaseNative(arg);
	}

	[Export("frameOfRow:inColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect RowFrame(nint row, nint column)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nint_nint(out retval, base.Handle, selFrameOfRow_InColumn_Handle, row, column);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nint_nint(out retval, base.SuperHandle, selFrameOfRow_InColumn_Handle, row, column);
		}
		return retval;
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

	[Export("scrollColumnsLeftBy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollColumnsLeftBy(nint shiftAmount)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selScrollColumnsLeftBy_Handle, shiftAmount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selScrollColumnsLeftBy_Handle, shiftAmount);
		}
	}

	[Export("scrollColumnsRightBy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollColumnsRightBy(nint shiftAmount)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selScrollColumnsRightBy_Handle, shiftAmount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selScrollColumnsRightBy_Handle, shiftAmount);
		}
	}

	[Export("scrollRowToVisible:inColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollRowToVisible(nint row, nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint(base.Handle, selScrollRowToVisible_InColumn_Handle, row, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint(base.SuperHandle, selScrollRowToVisible_InColumn_Handle, row, column);
		}
	}

	[Export("selectRow:inColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Select(nint row, nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint(base.Handle, selSelectRow_InColumn_Handle, row, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint(base.SuperHandle, selSelectRow_InColumn_Handle, row, column);
		}
	}

	[Export("selectAll:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectAll(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectAll_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectAll_Handle, sender.Handle);
		}
	}

	[Export("selectRowIndexes:inColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectRowIndexes(NSIndexSet indexes, nint column)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selSelectRowIndexes_InColumn_Handle, indexes.Handle, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selSelectRowIndexes_InColumn_Handle, indexes.Handle, column);
		}
	}

	[Export("selectedCell")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSObject SelectedCell()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedCellHandle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedCellHandle));
	}

	[Export("selectedCellInColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject SelectedCellInColumn(nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selSelectedCellInColumn_Handle, column));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selSelectedCellInColumn_Handle, column));
	}

	[Export("selectedCells")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCell[] SelectedCells()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSCell>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedCellsHandle));
		}
		return NSArray.ArrayFromHandle<NSCell>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedCellsHandle));
	}

	[Export("selectedColumn")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SelectedColumn()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend(base.Handle, selSelectedColumnHandle);
		}
		return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSelectedColumnHandle);
	}

	[Export("selectedRowInColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SelectedRow(nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nint(base.Handle, selSelectedRowInColumn_Handle, column);
		}
		return Messaging.nint_objc_msgSendSuper_nint(base.SuperHandle, selSelectedRowInColumn_Handle, column);
	}

	[Export("selectedRowIndexesInColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet SelectedRowIndexes(nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selSelectedRowIndexesInColumn_Handle, column));
		}
		return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selSelectedRowIndexesInColumn_Handle, column));
	}

	[Export("sendAction")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SendAction()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selSendActionHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSendActionHandle);
	}

	[Export("setCellClass:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCellClass(Class factoryId)
	{
		NSApplication.EnsureUIThread();
		if (factoryId == null)
		{
			throw new ArgumentNullException("factoryId");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCellClass_Handle, factoryId.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCellClass_Handle, factoryId.Handle);
		}
	}

	[Export("setWidth:ofColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetColumnWidth(nfloat columnWidth, nint columnIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_nint(base.Handle, selSetWidth_OfColumn_Handle, columnWidth, columnIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_nint(base.SuperHandle, selSetWidth_OfColumn_Handle, columnWidth, columnIndex);
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

	[Export("setPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual bool SetPath(string path)
	{
		NSApplication.EnsureUIThread();
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPath_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setTitle:ofColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTitle(string aString, nint column)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selSetTitle_OfColumn_Handle, arg, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selSetTitle_OfColumn_Handle, arg, column);
		}
		NSString.ReleaseNative(arg);
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

	[Export("titleFrameOfColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect TitleFrameOfColumn(nint column)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nint(out retval, base.Handle, selTitleFrameOfColumn_Handle, column);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nint(out retval, base.SuperHandle, selTitleFrameOfColumn_Handle, column);
		}
		return retval;
	}

	[Export("validateVisibleColumns")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ValidateVisibleColumns()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selValidateVisibleColumnsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selValidateVisibleColumnsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
