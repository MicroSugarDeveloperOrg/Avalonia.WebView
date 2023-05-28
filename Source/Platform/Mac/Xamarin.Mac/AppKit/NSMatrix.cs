using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSMatrix", true)]
public class NSMatrix : NSControl, INSUserInterfaceValidations, INativeObject, IDisposable, INSViewToolTipOwner
{
	[Register]
	internal class _NSMatrixDelegate : NSObject, INSMatrixDelegate, INativeObject, IDisposable, INSControlTextEditingDelegate
	{
		public _NSMatrixDelegate()
		{
			base.IsDirectBinding = false;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptsFirstMouse_ = "acceptsFirstMouse:";

	private static readonly IntPtr selAcceptsFirstMouse_Handle = Selector.GetHandle("acceptsFirstMouse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddColumn = "addColumn";

	private static readonly IntPtr selAddColumnHandle = Selector.GetHandle("addColumn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddColumnWithCells_ = "addColumnWithCells:";

	private static readonly IntPtr selAddColumnWithCells_Handle = Selector.GetHandle("addColumnWithCells:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRow = "addRow";

	private static readonly IntPtr selAddRowHandle = Selector.GetHandle("addRow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRowWithCells_ = "addRowWithCells:";

	private static readonly IntPtr selAddRowWithCells_Handle = Selector.GetHandle("addRowWithCells:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsEmptySelection = "allowsEmptySelection";

	private static readonly IntPtr selAllowsEmptySelectionHandle = Selector.GetHandle("allowsEmptySelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutorecalculatesCellSize = "autorecalculatesCellSize";

	private static readonly IntPtr selAutorecalculatesCellSizeHandle = Selector.GetHandle("autorecalculatesCellSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutosizesCells = "autosizesCells";

	private static readonly IntPtr selAutosizesCellsHandle = Selector.GetHandle("autosizesCells");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColor = "backgroundColor";

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellAtRow_Column_ = "cellAtRow:column:";

	private static readonly IntPtr selCellAtRow_Column_Handle = Selector.GetHandle("cellAtRow:column:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellBackgroundColor = "cellBackgroundColor";

	private static readonly IntPtr selCellBackgroundColorHandle = Selector.GetHandle("cellBackgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellClass = "cellClass";

	private static readonly IntPtr selCellClassHandle = Selector.GetHandle("cellClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellFrameAtRow_Column_ = "cellFrameAtRow:column:";

	private static readonly IntPtr selCellFrameAtRow_Column_Handle = Selector.GetHandle("cellFrameAtRow:column:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellSize = "cellSize";

	private static readonly IntPtr selCellSizeHandle = Selector.GetHandle("cellSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellWithTag_ = "cellWithTag:";

	private static readonly IntPtr selCellWithTag_Handle = Selector.GetHandle("cellWithTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCells = "cells";

	private static readonly IntPtr selCellsHandle = Selector.GetHandle("cells");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeselectAllCells = "deselectAllCells";

	private static readonly IntPtr selDeselectAllCellsHandle = Selector.GetHandle("deselectAllCells");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeselectSelectedCell = "deselectSelectedCell";

	private static readonly IntPtr selDeselectSelectedCellHandle = Selector.GetHandle("deselectSelectedCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoubleAction = "doubleAction";

	private static readonly IntPtr selDoubleActionHandle = Selector.GetHandle("doubleAction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawCellAtRow_Column_ = "drawCellAtRow:column:";

	private static readonly IntPtr selDrawCellAtRow_Column_Handle = Selector.GetHandle("drawCellAtRow:column:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawsBackground = "drawsBackground";

	private static readonly IntPtr selDrawsBackgroundHandle = Selector.GetHandle("drawsBackground");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawsCellBackground = "drawsCellBackground";

	private static readonly IntPtr selDrawsCellBackgroundHandle = Selector.GetHandle("drawsCellBackground");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetNumberOfRows_Columns_ = "getNumberOfRows:columns:";

	private static readonly IntPtr selGetNumberOfRows_Columns_Handle = Selector.GetHandle("getNumberOfRows:columns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetRow_Column_ForPoint_ = "getRow:column:forPoint:";

	private static readonly IntPtr selGetRow_Column_ForPoint_Handle = Selector.GetHandle("getRow:column:forPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetRow_Column_OfCell_ = "getRow:column:ofCell:";

	private static readonly IntPtr selGetRow_Column_OfCell_Handle = Selector.GetHandle("getRow:column:ofCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHighlightCell_AtRow_Column_ = "highlightCell:atRow:column:";

	private static readonly IntPtr selHighlightCell_AtRow_Column_Handle = Selector.GetHandle("highlightCell:atRow:column:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_Mode_CellClass_NumberOfRows_NumberOfColumns_ = "initWithFrame:mode:cellClass:numberOfRows:numberOfColumns:";

	private static readonly IntPtr selInitWithFrame_Mode_CellClass_NumberOfRows_NumberOfColumns_Handle = Selector.GetHandle("initWithFrame:mode:cellClass:numberOfRows:numberOfColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_Mode_Prototype_NumberOfRows_NumberOfColumns_ = "initWithFrame:mode:prototype:numberOfRows:numberOfColumns:";

	private static readonly IntPtr selInitWithFrame_Mode_Prototype_NumberOfRows_NumberOfColumns_Handle = Selector.GetHandle("initWithFrame:mode:prototype:numberOfRows:numberOfColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertColumn_ = "insertColumn:";

	private static readonly IntPtr selInsertColumn_Handle = Selector.GetHandle("insertColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertColumn_WithCells_ = "insertColumn:withCells:";

	private static readonly IntPtr selInsertColumn_WithCells_Handle = Selector.GetHandle("insertColumn:withCells:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertRow_ = "insertRow:";

	private static readonly IntPtr selInsertRow_Handle = Selector.GetHandle("insertRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertRow_WithCells_ = "insertRow:withCells:";

	private static readonly IntPtr selInsertRow_WithCells_Handle = Selector.GetHandle("insertRow:withCells:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntercellSpacing = "intercellSpacing";

	private static readonly IntPtr selIntercellSpacingHandle = Selector.GetHandle("intercellSpacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutoscroll = "isAutoscroll";

	private static readonly IntPtr selIsAutoscrollHandle = Selector.GetHandle("isAutoscroll");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSelectionByRect = "isSelectionByRect";

	private static readonly IntPtr selIsSelectionByRectHandle = Selector.GetHandle("isSelectionByRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyCell = "keyCell";

	private static readonly IntPtr selKeyCellHandle = Selector.GetHandle("keyCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeCellAtRow_Column_ = "makeCellAtRow:column:";

	private static readonly IntPtr selMakeCellAtRow_Column_Handle = Selector.GetHandle("makeCellAtRow:column:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMode = "mode";

	private static readonly IntPtr selModeHandle = Selector.GetHandle("mode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseDown_ = "mouseDown:";

	private static readonly IntPtr selMouseDown_Handle = Selector.GetHandle("mouseDown:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseDownFlags = "mouseDownFlags";

	private static readonly IntPtr selMouseDownFlagsHandle = Selector.GetHandle("mouseDownFlags");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfColumns = "numberOfColumns";

	private static readonly IntPtr selNumberOfColumnsHandle = Selector.GetHandle("numberOfColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfRows = "numberOfRows";

	private static readonly IntPtr selNumberOfRowsHandle = Selector.GetHandle("numberOfRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformKeyEquivalent_ = "performKeyEquivalent:";

	private static readonly IntPtr selPerformKeyEquivalent_Handle = Selector.GetHandle("performKeyEquivalent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrototype = "prototype";

	private static readonly IntPtr selPrototypeHandle = Selector.GetHandle("prototype");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPutCell_AtRow_Column_ = "putCell:atRow:column:";

	private static readonly IntPtr selPutCell_AtRow_Column_Handle = Selector.GetHandle("putCell:atRow:column:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveColumn_ = "removeColumn:";

	private static readonly IntPtr selRemoveColumn_Handle = Selector.GetHandle("removeColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveRow_ = "removeRow:";

	private static readonly IntPtr selRemoveRow_Handle = Selector.GetHandle("removeRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenewRows_Columns_ = "renewRows:columns:";

	private static readonly IntPtr selRenewRows_Columns_Handle = Selector.GetHandle("renewRows:columns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetCursorRects = "resetCursorRects";

	private static readonly IntPtr selResetCursorRectsHandle = Selector.GetHandle("resetCursorRects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollCellToVisibleAtRow_Column_ = "scrollCellToVisibleAtRow:column:";

	private static readonly IntPtr selScrollCellToVisibleAtRow_Column_Handle = Selector.GetHandle("scrollCellToVisibleAtRow:column:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectAll_ = "selectAll:";

	private static readonly IntPtr selSelectAll_Handle = Selector.GetHandle("selectAll:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectCellAtRow_Column_ = "selectCellAtRow:column:";

	private static readonly IntPtr selSelectCellAtRow_Column_Handle = Selector.GetHandle("selectCellAtRow:column:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectCellWithTag_ = "selectCellWithTag:";

	private static readonly IntPtr selSelectCellWithTag_Handle = Selector.GetHandle("selectCellWithTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectText_ = "selectText:";

	private static readonly IntPtr selSelectText_Handle = Selector.GetHandle("selectText:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectTextAtRow_Column_ = "selectTextAtRow:column:";

	private static readonly IntPtr selSelectTextAtRow_Column_Handle = Selector.GetHandle("selectTextAtRow:column:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedCell = "selectedCell";

	private static readonly IntPtr selSelectedCellHandle = Selector.GetHandle("selectedCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedCells = "selectedCells";

	private static readonly IntPtr selSelectedCellsHandle = Selector.GetHandle("selectedCells");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedColumn = "selectedColumn";

	private static readonly IntPtr selSelectedColumnHandle = Selector.GetHandle("selectedColumn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedRow = "selectedRow";

	private static readonly IntPtr selSelectedRowHandle = Selector.GetHandle("selectedRow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendAction = "sendAction";

	private static readonly IntPtr selSendActionHandle = Selector.GetHandle("sendAction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendAction_To_ForAllCells_ = "sendAction:to:forAllCells:";

	private static readonly IntPtr selSendAction_To_ForAllCells_Handle = Selector.GetHandle("sendAction:to:forAllCells:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendDoubleAction = "sendDoubleAction";

	private static readonly IntPtr selSendDoubleActionHandle = Selector.GetHandle("sendDoubleAction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsEmptySelection_ = "setAllowsEmptySelection:";

	private static readonly IntPtr selSetAllowsEmptySelection_Handle = Selector.GetHandle("setAllowsEmptySelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutorecalculatesCellSize_ = "setAutorecalculatesCellSize:";

	private static readonly IntPtr selSetAutorecalculatesCellSize_Handle = Selector.GetHandle("setAutorecalculatesCellSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutoscroll_ = "setAutoscroll:";

	private static readonly IntPtr selSetAutoscroll_Handle = Selector.GetHandle("setAutoscroll:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutosizesCells_ = "setAutosizesCells:";

	private static readonly IntPtr selSetAutosizesCells_Handle = Selector.GetHandle("setAutosizesCells:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCellBackgroundColor_ = "setCellBackgroundColor:";

	private static readonly IntPtr selSetCellBackgroundColor_Handle = Selector.GetHandle("setCellBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCellClass_ = "setCellClass:";

	private static readonly IntPtr selSetCellClass_Handle = Selector.GetHandle("setCellClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCellSize_ = "setCellSize:";

	private static readonly IntPtr selSetCellSize_Handle = Selector.GetHandle("setCellSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDoubleAction_ = "setDoubleAction:";

	private static readonly IntPtr selSetDoubleAction_Handle = Selector.GetHandle("setDoubleAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDrawsBackground_ = "setDrawsBackground:";

	private static readonly IntPtr selSetDrawsBackground_Handle = Selector.GetHandle("setDrawsBackground:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDrawsCellBackground_ = "setDrawsCellBackground:";

	private static readonly IntPtr selSetDrawsCellBackground_Handle = Selector.GetHandle("setDrawsCellBackground:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIntercellSpacing_ = "setIntercellSpacing:";

	private static readonly IntPtr selSetIntercellSpacing_Handle = Selector.GetHandle("setIntercellSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKeyCell_ = "setKeyCell:";

	private static readonly IntPtr selSetKeyCell_Handle = Selector.GetHandle("setKeyCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMode_ = "setMode:";

	private static readonly IntPtr selSetMode_Handle = Selector.GetHandle("setMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrototype_ = "setPrototype:";

	private static readonly IntPtr selSetPrototype_Handle = Selector.GetHandle("setPrototype:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScrollable_ = "setScrollable:";

	private static readonly IntPtr selSetScrollable_Handle = Selector.GetHandle("setScrollable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectionByRect_ = "setSelectionByRect:";

	private static readonly IntPtr selSetSelectionByRect_Handle = Selector.GetHandle("setSelectionByRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectionFrom_To_Anchor_Highlight_ = "setSelectionFrom:to:anchor:highlight:";

	private static readonly IntPtr selSetSelectionFrom_To_Anchor_Highlight_Handle = Selector.GetHandle("setSelectionFrom:to:anchor:highlight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetState_AtRow_Column_ = "setState:atRow:column:";

	private static readonly IntPtr selSetState_AtRow_Column_Handle = Selector.GetHandle("setState:atRow:column:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTabKeyTraversesCells_ = "setTabKeyTraversesCells:";

	private static readonly IntPtr selSetTabKeyTraversesCells_Handle = Selector.GetHandle("setTabKeyTraversesCells:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetToolTip_ForCell_ = "setToolTip:forCell:";

	private static readonly IntPtr selSetToolTip_ForCell_Handle = Selector.GetHandle("setToolTip:forCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValidateSize_ = "setValidateSize:";

	private static readonly IntPtr selSetValidateSize_Handle = Selector.GetHandle("setValidateSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSizeToCells = "sizeToCells";

	private static readonly IntPtr selSizeToCellsHandle = Selector.GetHandle("sizeToCells");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortUsingSelector_ = "sortUsingSelector:";

	private static readonly IntPtr selSortUsingSelector_Handle = Selector.GetHandle("sortUsingSelector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabKeyTraversesCells = "tabKeyTraversesCells";

	private static readonly IntPtr selTabKeyTraversesCellsHandle = Selector.GetHandle("tabKeyTraversesCells");

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
	private const string selToolTipForCell_ = "toolTipForCell:";

	private static readonly IntPtr selToolTipForCell_Handle = Selector.GetHandle("toolTipForCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateUserInterfaceItem_ = "validateUserInterfaceItem:";

	private static readonly IntPtr selValidateUserInterfaceItem_Handle = Selector.GetHandle("validateUserInterfaceItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selView_StringForToolTip_Point_UserData_ = "view:stringForToolTip:point:userData:";

	private static readonly IntPtr selView_StringForToolTip_Point_UserData_Handle = Selector.GetHandle("view:stringForToolTip:point:userData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMatrix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public NSCell this[nint col, nint row] => CellAtRowColumn(row, col);

	public override IntPtr ClassHandle => class_ptr;

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
	public virtual bool AutoRecalculatesCellSize
	{
		[Export("autorecalculatesCellSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutorecalculatesCellSizeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutorecalculatesCellSizeHandle);
		}
		[Export("setAutorecalculatesCellSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutorecalculatesCellSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutorecalculatesCellSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool Autoscroll
	{
		[Export("isAutoscroll")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutoscrollHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutoscrollHandle);
		}
		[Export("setAutoscroll:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoscroll_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoscroll_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutosizesCells
	{
		[Export("autosizesCells")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutosizesCellsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutosizesCellsHandle);
		}
		[Export("setAutosizesCells:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutosizesCells_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutosizesCells_Handle, value);
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
	public virtual NSColor CellBackgroundColor
	{
		[Export("cellBackgroundColor", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selCellBackgroundColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCellBackgroundColorHandle));
		}
		[Export("setCellBackgroundColor:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCellBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCellBackgroundColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual Class CellClass
	{
		[Export("cellClass")]
		get
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCellClassHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selCellClassHandle));
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
		[Export("setCellClass:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCellClass_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCellClass_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize CellSize
	{
		[Export("cellSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selCellSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selCellSizeHandle);
		}
		[Export("setCellSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetCellSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetCellSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCell[] Cells
	{
		[Export("cells")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSCell>(Messaging.IntPtr_objc_msgSend(base.Handle, selCellsHandle));
			}
			return NSArray.ArrayFromHandle<NSCell>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCellsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Columns
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
	public INSMatrixDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSMatrixDelegate;
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
	public virtual bool DrawsBackground
	{
		[Export("drawsBackground")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDrawsBackgroundHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDrawsBackgroundHandle);
		}
		[Export("setDrawsBackground:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDrawsBackground_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDrawsBackground_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DrawsCellBackground
	{
		[Export("drawsCellBackground")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDrawsCellBackgroundHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDrawsCellBackgroundHandle);
		}
		[Export("setDrawsCellBackground:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDrawsCellBackground_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDrawsCellBackground_Handle, value);
			}
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
	public virtual NSObject KeyCell
	{
		[Export("keyCell")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyCellHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyCellHandle));
		}
		[Export("setKeyCell:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetKeyCell_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetKeyCell_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMatrixMode Mode
	{
		[Export("mode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSMatrixMode)Messaging.UInt64_objc_msgSend(base.Handle, selModeHandle);
			}
			return (NSMatrixMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selModeHandle);
		}
		[Export("setMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCell Prototype
	{
		[Export("prototype", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCell>(Messaging.IntPtr_objc_msgSend(base.Handle, selPrototypeHandle));
			}
			return Runtime.GetNSObject<NSCell>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrototypeHandle));
		}
		[Export("setPrototype:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPrototype_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPrototype_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Rows
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
	public new virtual NSCell SelectedCell
	{
		[Export("selectedCell")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCell>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedCellHandle));
			}
			return Runtime.GetNSObject<NSCell>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedCellHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCell[] SelectedCells
	{
		[Export("selectedCells")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSCell>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedCellsHandle));
			}
			return NSArray.ArrayFromHandle<NSCell>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedCellsHandle));
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
	public virtual bool SelectionByRect
	{
		[Export("isSelectionByRect")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSelectionByRectHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSelectionByRectHandle);
		}
		[Export("setSelectionByRect:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSelectionByRect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSelectionByRect_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TabKeyTraversesCells
	{
		[Export("tabKeyTraversesCells")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTabKeyTraversesCellsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTabKeyTraversesCellsHandle);
		}
		[Export("setTabKeyTraversesCells:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTabKeyTraversesCells_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTabKeyTraversesCells_Handle, value);
			}
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

	internal virtual Type GetInternalEventDelegateType => typeof(_NSMatrixDelegate);

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
	public NSMatrix()
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
	public NSMatrix(NSCoder coder)
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
	protected NSMatrix(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMatrix(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMatrix(CGRect frameRect)
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

	[Export("initWithFrame:mode:prototype:numberOfRows:numberOfColumns:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMatrix(CGRect frameRect, NSMatrixMode aMode, NSCell aCell, nint rowsHigh, nint colsWide)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aCell == null)
		{
			throw new ArgumentNullException("aCell");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect_UInt64_IntPtr_nint_nint(base.Handle, selInitWithFrame_Mode_Prototype_NumberOfRows_NumberOfColumns_Handle, frameRect, (ulong)aMode, aCell.Handle, rowsHigh, colsWide), "initWithFrame:mode:prototype:numberOfRows:numberOfColumns:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect_UInt64_IntPtr_nint_nint(base.SuperHandle, selInitWithFrame_Mode_Prototype_NumberOfRows_NumberOfColumns_Handle, frameRect, (ulong)aMode, aCell.Handle, rowsHigh, colsWide), "initWithFrame:mode:prototype:numberOfRows:numberOfColumns:");
		}
	}

	[Export("initWithFrame:mode:cellClass:numberOfRows:numberOfColumns:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMatrix(CGRect frameRect, NSMatrixMode aMode, Class factoryId, nint rowsHigh, nint colsWide)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (factoryId == null)
		{
			throw new ArgumentNullException("factoryId");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect_UInt64_IntPtr_nint_nint(base.Handle, selInitWithFrame_Mode_CellClass_NumberOfRows_NumberOfColumns_Handle, frameRect, (ulong)aMode, factoryId.Handle, rowsHigh, colsWide), "initWithFrame:mode:cellClass:numberOfRows:numberOfColumns:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect_UInt64_IntPtr_nint_nint(base.SuperHandle, selInitWithFrame_Mode_CellClass_NumberOfRows_NumberOfColumns_Handle, frameRect, (ulong)aMode, factoryId.Handle, rowsHigh, colsWide), "initWithFrame:mode:cellClass:numberOfRows:numberOfColumns:");
		}
	}

	[Export("acceptsFirstMouse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool AcceptsFirstMouse(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAcceptsFirstMouse_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAcceptsFirstMouse_Handle, theEvent.Handle);
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

	[Export("addColumnWithCells:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddColumnWithCells(NSCell[] newCells)
	{
		NSApplication.EnsureUIThread();
		if (newCells == null)
		{
			throw new ArgumentNullException("newCells");
		}
		NSArray nSArray = NSArray.FromNSObjects(newCells);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddColumnWithCells_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddColumnWithCells_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("addRow")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddRow()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAddRowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAddRowHandle);
		}
	}

	[Export("addRowWithCells:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddRowWithCells(NSCell[] newCells)
	{
		NSApplication.EnsureUIThread();
		if (newCells == null)
		{
			throw new ArgumentNullException("newCells");
		}
		NSArray nSArray = NSArray.FromNSObjects(newCells);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddRowWithCells_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddRowWithCells_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("cellAtRow:column:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSCell CellAtRowColumn(nint row, nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCell>(Messaging.IntPtr_objc_msgSend_nint_nint(base.Handle, selCellAtRow_Column_Handle, row, column));
		}
		return Runtime.GetNSObject<NSCell>(Messaging.IntPtr_objc_msgSendSuper_nint_nint(base.SuperHandle, selCellAtRow_Column_Handle, row, column));
	}

	[Export("cellFrameAtRow:column:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect CellFrameAtRowColumn(nint row, nint column)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nint_nint(out retval, base.Handle, selCellFrameAtRow_Column_Handle, row, column);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nint_nint(out retval, base.SuperHandle, selCellFrameAtRow_Column_Handle, row, column);
		}
		return retval;
	}

	[Export("cellWithTag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCell CellWithTag(nint anInt)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCell>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selCellWithTag_Handle, anInt));
		}
		return Runtime.GetNSObject<NSCell>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selCellWithTag_Handle, anInt));
	}

	[Export("textDidChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Changed(NSNotification notification)
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

	[Export("deselectAllCells")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeselectAllCells()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDeselectAllCellsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDeselectAllCellsHandle);
		}
	}

	[Export("deselectSelectedCell")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeselectSelectedCell()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDeselectSelectedCellHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDeselectSelectedCellHandle);
		}
	}

	[Export("textDidBeginEditing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidBeginEditing(NSNotification notification)
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

	[Export("textDidEndEditing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidEndEditing(NSNotification notification)
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

	[Export("drawCellAtRow:column:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawCellAtRowColumn(nint row, nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint(base.Handle, selDrawCellAtRow_Column_Handle, row, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint(base.SuperHandle, selDrawCellAtRow_Column_Handle, row, column);
		}
	}

	[Export("getRow:column:ofCell:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetRowColumn(out nint row, out nint column, NSCell aCell)
	{
		NSApplication.EnsureUIThread();
		if (aCell == null)
		{
			throw new ArgumentNullException("aCell");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_out_nint_out_nint_IntPtr(base.Handle, selGetRow_Column_OfCell_Handle, out row, out column, aCell.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_out_nint_out_nint_IntPtr(base.SuperHandle, selGetRow_Column_OfCell_Handle, out row, out column, aCell.Handle);
	}

	[Export("getRow:column:forPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetRowColumnForPoint(out nint row, out nint column, CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_out_nint_out_nint_CGPoint(base.Handle, selGetRow_Column_ForPoint_Handle, out row, out column, aPoint);
		}
		return Messaging.bool_objc_msgSendSuper_out_nint_out_nint_CGPoint(base.SuperHandle, selGetRow_Column_ForPoint_Handle, out row, out column, aPoint);
	}

	[Export("getNumberOfRows:columns:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetRowsAndColumnsCount(out nint rowCount, out nint colCount)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_nint_out_nint(base.Handle, selGetNumberOfRows_Columns_Handle, out rowCount, out colCount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_nint_out_nint(base.SuperHandle, selGetNumberOfRows_Columns_Handle, out rowCount, out colCount);
		}
	}

	[Export("view:stringForToolTip:point:userData:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetStringForToolTip(NSView view, nint tag, CGPoint point, IntPtr data)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nint_CGPoint_IntPtr(base.Handle, selView_StringForToolTip_Point_UserData_Handle, view.Handle, tag, point, data));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint_CGPoint_IntPtr(base.SuperHandle, selView_StringForToolTip_Point_UserData_Handle, view.Handle, tag, point, data));
	}

	[Export("highlightCell:atRow:column:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void HighlightCell(bool highlight, nint row, nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_nint_nint(base.Handle, selHighlightCell_AtRow_Column_Handle, highlight, row, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_nint_nint(base.SuperHandle, selHighlightCell_AtRow_Column_Handle, highlight, row, column);
		}
	}

	[Export("insertColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertColumn(nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selInsertColumn_Handle, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selInsertColumn_Handle, column);
		}
	}

	[Export("insertColumn:withCells:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertColumn(nint column, NSCell[] newCells)
	{
		NSApplication.EnsureUIThread();
		if (newCells == null)
		{
			throw new ArgumentNullException("newCells");
		}
		NSArray nSArray = NSArray.FromNSObjects(newCells);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_IntPtr(base.Handle, selInsertColumn_WithCells_Handle, column, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_IntPtr(base.SuperHandle, selInsertColumn_WithCells_Handle, column, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("insertRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertRow(nint row)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selInsertRow_Handle, row);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selInsertRow_Handle, row);
		}
	}

	[Export("insertRow:withCells:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertRow(nint row, NSCell[] newCells)
	{
		NSApplication.EnsureUIThread();
		if (newCells == null)
		{
			throw new ArgumentNullException("newCells");
		}
		NSArray nSArray = NSArray.FromNSObjects(newCells);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_IntPtr(base.Handle, selInsertRow_WithCells_Handle, row, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_IntPtr(base.SuperHandle, selInsertRow_WithCells_Handle, row, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("makeCellAtRow:column:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCell MakeCell(nint row, nint col)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCell>(Messaging.IntPtr_objc_msgSend_nint_nint(base.Handle, selMakeCellAtRow_Column_Handle, row, col));
		}
		return Runtime.GetNSObject<NSCell>(Messaging.IntPtr_objc_msgSendSuper_nint_nint(base.SuperHandle, selMakeCellAtRow_Column_Handle, row, col));
	}

	[Export("mouseDown:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void MouseDown(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseDown_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseDown_Handle, theEvent.Handle);
		}
	}

	[Export("mouseDownFlags")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint MouseDownFlags()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend(base.Handle, selMouseDownFlagsHandle);
		}
		return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMouseDownFlagsHandle);
	}

	[Export("performKeyEquivalent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool PerformKeyEquivalent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPerformKeyEquivalent_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformKeyEquivalent_Handle, theEvent.Handle);
	}

	[Export("putCell:atRow:column:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PutCell(NSCell newCell, nint row, nint column)
	{
		NSApplication.EnsureUIThread();
		if (newCell == null)
		{
			throw new ArgumentNullException("newCell");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint_nint(base.Handle, selPutCell_AtRow_Column_Handle, newCell.Handle, row, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint_nint(base.SuperHandle, selPutCell_AtRow_Column_Handle, newCell.Handle, row, column);
		}
	}

	[Export("removeColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveColumn(nint col)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selRemoveColumn_Handle, col);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selRemoveColumn_Handle, col);
		}
	}

	[Export("removeRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveRow(nint row)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selRemoveRow_Handle, row);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selRemoveRow_Handle, row);
		}
	}

	[Export("renewRows:columns:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RenewRowsColumns(nint newRows, nint newCols)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint(base.Handle, selRenewRows_Columns_Handle, newRows, newCols);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint(base.SuperHandle, selRenewRows_Columns_Handle, newRows, newCols);
		}
	}

	[Export("resetCursorRects")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void ResetCursorRects()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetCursorRectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetCursorRectsHandle);
		}
	}

	[Export("scrollCellToVisibleAtRow:column:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollCellToVisible(nint row, nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint(base.Handle, selScrollCellToVisibleAtRow_Column_Handle, row, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint(base.SuperHandle, selScrollCellToVisibleAtRow_Column_Handle, row, column);
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

	[Export("selectCellAtRow:column:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectCell(nint row, nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint(base.Handle, selSelectCellAtRow_Column_Handle, row, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint(base.SuperHandle, selSelectCellAtRow_Column_Handle, row, column);
		}
	}

	[Export("selectCellWithTag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SelectCellWithTag(nint tag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nint(base.Handle, selSelectCellWithTag_Handle, tag);
		}
		return Messaging.bool_objc_msgSendSuper_nint(base.SuperHandle, selSelectCellWithTag_Handle, tag);
	}

	[Export("selectText:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectText(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectText_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectText_Handle, sender.Handle);
		}
	}

	[Export("selectTextAtRow:column:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject SelectTextAtRowColumn(nint row, nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nint_nint(base.Handle, selSelectTextAtRow_Column_Handle, row, column));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_nint_nint(base.SuperHandle, selSelectTextAtRow_Column_Handle, row, column));
	}

	[Export("sendAction:to:forAllCells:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SendAction(Selector aSelector, NSObject anObject, bool forAllCells)
	{
		NSApplication.EnsureUIThread();
		if (aSelector == null)
		{
			throw new ArgumentNullException("aSelector");
		}
		if (anObject == null)
		{
			throw new ArgumentNullException("anObject");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, selSendAction_To_ForAllCells_Handle, aSelector.Handle, anObject.Handle, forAllCells);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool(base.SuperHandle, selSendAction_To_ForAllCells_Handle, aSelector.Handle, anObject.Handle, forAllCells);
		}
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

	[Export("sendDoubleAction")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SendDoubleAction()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSendDoubleActionHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSendDoubleActionHandle);
		}
	}

	[Export("setScrollable:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetScrollable(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetScrollable_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetScrollable_Handle, flag);
		}
	}

	[Export("setSelectionFrom:to:anchor:highlight:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSelection(nint startPos, nint endPos, nint anchorPos, bool highlight)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint_nint_bool(base.Handle, selSetSelectionFrom_To_Anchor_Highlight_Handle, startPos, endPos, anchorPos, highlight);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint_nint_bool(base.SuperHandle, selSetSelectionFrom_To_Anchor_Highlight_Handle, startPos, endPos, anchorPos, highlight);
		}
	}

	[Export("setState:atRow:column:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetState(nint state, nint row, nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint_nint(base.Handle, selSetState_AtRow_Column_Handle, state, row, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint_nint(base.SuperHandle, selSetState_AtRow_Column_Handle, state, row, column);
		}
	}

	[Export("setToolTip:forCell:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetToolTipForCell(string? toolTipString, NSCell cell)
	{
		NSApplication.EnsureUIThread();
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		IntPtr arg = NSString.CreateNative(toolTipString);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetToolTip_ForCell_Handle, arg, cell.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetToolTip_ForCell_Handle, arg, cell.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setValidateSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValidateSize(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetValidateSize_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetValidateSize_Handle, flag);
		}
	}

	[Export("textShouldBeginEditing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldBeginEditing(NSText textObject)
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
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldEndEditing(NSText textObject)
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

	[Export("sizeToCells")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SizeToCells()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSizeToCellsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSizeToCellsHandle);
		}
	}

	[Export("sortUsingSelector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Sort(Selector comparator)
	{
		NSApplication.EnsureUIThread();
		if (comparator == null)
		{
			throw new ArgumentNullException("comparator");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSortUsingSelector_Handle, comparator.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSortUsingSelector_Handle, comparator.Handle);
		}
	}

	[Export("toolTipForCell:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? ToolTipForCell(NSCell cell)
	{
		NSApplication.EnsureUIThread();
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selToolTipForCell_Handle, cell.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selToolTipForCell_Handle, cell.Handle));
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

	internal virtual _NSMatrixDelegate CreateInternalEventDelegateType()
	{
		return new _NSMatrixDelegate();
	}

	internal _NSMatrixDelegate EnsureNSMatrixDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSMatrixDelegate nSMatrixDelegate = Delegate as _NSMatrixDelegate;
		if (nSMatrixDelegate == null)
		{
			nSMatrixDelegate = (_NSMatrixDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSMatrixDelegate;
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
