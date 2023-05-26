using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSMatrix", true)]
public class NSMatrix : NSControl
{
	[Register]
	private sealed class _NSMatrixDelegate : NSMatrixDelegate
	{
		internal NSControlText textShouldBeginEditing;

		internal NSControlText textShouldEndEditing;

		internal NSControlTextError didFailToFormatString;

		internal EventHandler<NSControlTextErrorEventArgs> didFailToValidatePartialString;

		internal NSControlTextValidation isValidObject;

		internal NSControlCommand doCommandBySelector;

		internal NSControlTextCompletion getCompletions;

		[Preserve(Conditional = true)]
		public override bool TextShouldBeginEditing(NSControl control, NSText fieldEditor)
		{
			return textShouldBeginEditing?.Invoke(control, fieldEditor) ?? true;
		}

		[Preserve(Conditional = true)]
		public override bool TextShouldEndEditing(NSControl control, NSText fieldEditor)
		{
			return textShouldEndEditing?.Invoke(control, fieldEditor) ?? true;
		}

		[Preserve(Conditional = true)]
		public override bool DidFailToFormatString(NSControl control, string str, string error)
		{
			return didFailToFormatString?.Invoke(control, str, error) ?? true;
		}

		[Preserve(Conditional = true)]
		public override void DidFailToValidatePartialString(NSControl control, string str, string error)
		{
			EventHandler<NSControlTextErrorEventArgs> eventHandler = didFailToValidatePartialString;
			if (eventHandler != null)
			{
				NSControlTextErrorEventArgs e = new NSControlTextErrorEventArgs(str, error);
				eventHandler(control, e);
			}
		}

		[Preserve(Conditional = true)]
		public override bool IsValidObject(NSControl control, NSObject objectToValidate)
		{
			return isValidObject?.Invoke(control, objectToValidate) ?? true;
		}

		[Preserve(Conditional = true)]
		public override bool DoCommandBySelector(NSControl control, NSTextView textView, Selector commandSelector)
		{
			return doCommandBySelector?.Invoke(control, textView, commandSelector) ?? false;
		}

		[Preserve(Conditional = true)]
		public override string[] GetCompletions(NSControl control, NSTextView textView, string[] words, NSRange charRange, long index)
		{
			return getCompletions?.Invoke(control, textView, words, charRange, index);
		}
	}

	private static readonly IntPtr selCellsHandle = Selector.GetHandle("cells");

	private static readonly IntPtr selSelectedCellHandle = Selector.GetHandle("selectedCell");

	private static readonly IntPtr selSelectedCellsHandle = Selector.GetHandle("selectedCells");

	private static readonly IntPtr selSelectedRowHandle = Selector.GetHandle("selectedRow");

	private static readonly IntPtr selSelectedColumnHandle = Selector.GetHandle("selectedColumn");

	private static readonly IntPtr selNumberOfRowsHandle = Selector.GetHandle("numberOfRows");

	private static readonly IntPtr selNumberOfColumnsHandle = Selector.GetHandle("numberOfColumns");

	private static readonly IntPtr selCellClassHandle = Selector.GetHandle("cellClass");

	private static readonly IntPtr selSetCellClass_Handle = Selector.GetHandle("setCellClass:");

	private static readonly IntPtr selPrototypeHandle = Selector.GetHandle("prototype");

	private static readonly IntPtr selSetPrototype_Handle = Selector.GetHandle("setPrototype:");

	private static readonly IntPtr selModeHandle = Selector.GetHandle("mode");

	private static readonly IntPtr selSetMode_Handle = Selector.GetHandle("setMode:");

	private static readonly IntPtr selAllowsEmptySelectionHandle = Selector.GetHandle("allowsEmptySelection");

	private static readonly IntPtr selSetAllowsEmptySelection_Handle = Selector.GetHandle("setAllowsEmptySelection:");

	private static readonly IntPtr selIsSelectionByRectHandle = Selector.GetHandle("isSelectionByRect");

	private static readonly IntPtr selSetSelectionByRect_Handle = Selector.GetHandle("setSelectionByRect:");

	private static readonly IntPtr selCellSizeHandle = Selector.GetHandle("cellSize");

	private static readonly IntPtr selSetCellSize_Handle = Selector.GetHandle("setCellSize:");

	private static readonly IntPtr selIntercellSpacingHandle = Selector.GetHandle("intercellSpacing");

	private static readonly IntPtr selSetIntercellSpacing_Handle = Selector.GetHandle("setIntercellSpacing:");

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	private static readonly IntPtr selCellBackgroundColorHandle = Selector.GetHandle("cellBackgroundColor");

	private static readonly IntPtr selSetCellBackgroundColor_Handle = Selector.GetHandle("setCellBackgroundColor:");

	private static readonly IntPtr selDrawsCellBackgroundHandle = Selector.GetHandle("drawsCellBackground");

	private static readonly IntPtr selSetDrawsCellBackground_Handle = Selector.GetHandle("setDrawsCellBackground:");

	private static readonly IntPtr selDrawsBackgroundHandle = Selector.GetHandle("drawsBackground");

	private static readonly IntPtr selSetDrawsBackground_Handle = Selector.GetHandle("setDrawsBackground:");

	private static readonly IntPtr selDoubleActionHandle = Selector.GetHandle("doubleAction");

	private static readonly IntPtr selSetDoubleAction_Handle = Selector.GetHandle("setDoubleAction:");

	private static readonly IntPtr selAutosizesCellsHandle = Selector.GetHandle("autosizesCells");

	private static readonly IntPtr selSetAutosizesCells_Handle = Selector.GetHandle("setAutosizesCells:");

	private static readonly IntPtr selIsAutoscrollHandle = Selector.GetHandle("isAutoscroll");

	private static readonly IntPtr selSetAutoscroll_Handle = Selector.GetHandle("setAutoscroll:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selTabKeyTraversesCellsHandle = Selector.GetHandle("tabKeyTraversesCells");

	private static readonly IntPtr selSetTabKeyTraversesCells_Handle = Selector.GetHandle("setTabKeyTraversesCells:");

	private static readonly IntPtr selKeyCellHandle = Selector.GetHandle("keyCell");

	private static readonly IntPtr selSetKeyCell_Handle = Selector.GetHandle("setKeyCell:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selInitWithFrameModePrototypeNumberOfRowsNumberOfColumns_Handle = Selector.GetHandle("initWithFrame:mode:prototype:numberOfRows:numberOfColumns:");

	private static readonly IntPtr selInitWithFrameModeCellClassNumberOfRowsNumberOfColumns_Handle = Selector.GetHandle("initWithFrame:mode:cellClass:numberOfRows:numberOfColumns:");

	private static readonly IntPtr selMakeCellAtRowColumn_Handle = Selector.GetHandle("makeCellAtRow:column:");

	private static readonly IntPtr selSendActionToForAllCells_Handle = Selector.GetHandle("sendAction:to:forAllCells:");

	private static readonly IntPtr selSortUsingSelector_Handle = Selector.GetHandle("sortUsingSelector:");

	private static readonly IntPtr selSetSelectionFromToAnchorHighlight_Handle = Selector.GetHandle("setSelectionFrom:to:anchor:highlight:");

	private static readonly IntPtr selDeselectSelectedCellHandle = Selector.GetHandle("deselectSelectedCell");

	private static readonly IntPtr selDeselectAllCellsHandle = Selector.GetHandle("deselectAllCells");

	private static readonly IntPtr selSelectCellAtRowColumn_Handle = Selector.GetHandle("selectCellAtRow:column:");

	private static readonly IntPtr selSelectAll_Handle = Selector.GetHandle("selectAll:");

	private static readonly IntPtr selSelectCellWithTag_Handle = Selector.GetHandle("selectCellWithTag:");

	private static readonly IntPtr selSetScrollable_Handle = Selector.GetHandle("setScrollable:");

	private static readonly IntPtr selSetStateAtRowColumn_Handle = Selector.GetHandle("setState:atRow:column:");

	private static readonly IntPtr selGetNumberOfRowsColumns_Handle = Selector.GetHandle("getNumberOfRows:columns:");

	private static readonly IntPtr selCellAtRowColumn_Handle = Selector.GetHandle("cellAtRow:column:");

	private static readonly IntPtr selCellFrameAtRowColumn_Handle = Selector.GetHandle("cellFrameAtRow:column:");

	private static readonly IntPtr selGetRowColumnOfCell_Handle = Selector.GetHandle("getRow:column:ofCell:");

	private static readonly IntPtr selGetRowColumnForPoint_Handle = Selector.GetHandle("getRow:column:forPoint:");

	private static readonly IntPtr selRenewRowsColumns_Handle = Selector.GetHandle("renewRows:columns:");

	private static readonly IntPtr selPutCellAtRowColumn_Handle = Selector.GetHandle("putCell:atRow:column:");

	private static readonly IntPtr selAddRowHandle = Selector.GetHandle("addRow");

	private static readonly IntPtr selAddRowWithCells_Handle = Selector.GetHandle("addRowWithCells:");

	private static readonly IntPtr selInsertRow_Handle = Selector.GetHandle("insertRow:");

	private static readonly IntPtr selInsertRowWithCells_Handle = Selector.GetHandle("insertRow:withCells:");

	private static readonly IntPtr selRemoveRow_Handle = Selector.GetHandle("removeRow:");

	private static readonly IntPtr selAddColumnHandle = Selector.GetHandle("addColumn");

	private static readonly IntPtr selAddColumnWithCells_Handle = Selector.GetHandle("addColumnWithCells:");

	private static readonly IntPtr selInsertColumn_Handle = Selector.GetHandle("insertColumn:");

	private static readonly IntPtr selInsertColumnWithCells_Handle = Selector.GetHandle("insertColumn:withCells:");

	private static readonly IntPtr selRemoveColumn_Handle = Selector.GetHandle("removeColumn:");

	private static readonly IntPtr selCellWithTag_Handle = Selector.GetHandle("cellWithTag:");

	private static readonly IntPtr selSizeToCellsHandle = Selector.GetHandle("sizeToCells");

	private static readonly IntPtr selSetValidateSize_Handle = Selector.GetHandle("setValidateSize:");

	private static readonly IntPtr selDrawCellAtRowColumn_Handle = Selector.GetHandle("drawCellAtRow:column:");

	private static readonly IntPtr selHighlightCellAtRowColumn_Handle = Selector.GetHandle("highlightCell:atRow:column:");

	private static readonly IntPtr selScrollCellToVisibleAtRowColumn_Handle = Selector.GetHandle("scrollCellToVisibleAtRow:column:");

	private static readonly IntPtr selMouseDownFlagsHandle = Selector.GetHandle("mouseDownFlags");

	private static readonly IntPtr selMouseDown_Handle = Selector.GetHandle("mouseDown:");

	private static readonly IntPtr selPerformKeyEquivalent_Handle = Selector.GetHandle("performKeyEquivalent:");

	private static readonly IntPtr selSendActionHandle = Selector.GetHandle("sendAction");

	private static readonly IntPtr selSendDoubleActionHandle = Selector.GetHandle("sendDoubleAction");

	private static readonly IntPtr selTextShouldBeginEditing_Handle = Selector.GetHandle("textShouldBeginEditing:");

	private static readonly IntPtr selTextShouldEndEditing_Handle = Selector.GetHandle("textShouldEndEditing:");

	private static readonly IntPtr selTextDidBeginEditing_Handle = Selector.GetHandle("textDidBeginEditing:");

	private static readonly IntPtr selTextDidEndEditing_Handle = Selector.GetHandle("textDidEndEditing:");

	private static readonly IntPtr selTextDidChange_Handle = Selector.GetHandle("textDidChange:");

	private static readonly IntPtr selSelectText_Handle = Selector.GetHandle("selectText:");

	private static readonly IntPtr selSelectTextAtRowColumn_Handle = Selector.GetHandle("selectTextAtRow:column:");

	private static readonly IntPtr selAcceptsFirstMouse_Handle = Selector.GetHandle("acceptsFirstMouse:");

	private static readonly IntPtr selResetCursorRectsHandle = Selector.GetHandle("resetCursorRects");

	private static readonly IntPtr selSetToolTipForCell_Handle = Selector.GetHandle("setToolTip:forCell:");

	private static readonly IntPtr selToolTipForCell_Handle = Selector.GetHandle("toolTipForCell:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMatrix");

	private object __mt_Cells_var;

	private object __mt_SelectedCell_var;

	private object __mt_SelectedCells_var;

	private object __mt_Prototype_var;

	private object __mt_BackgroundColor_var;

	private object __mt_CellBackgroundColor_var;

	private object __mt_WeakDelegate_var;

	private object __mt_KeyCell_var;

	public NSCell this[int col, int row] => CellAtRowColumn(row, col);

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSCell[] Cells
	{
		[Export("cells")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCell[])(__mt_Cells_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSCell>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCellsHandle)) : NSArray.ArrayFromHandle<NSCell>(Messaging.IntPtr_objc_msgSend(base.Handle, selCellsHandle))));
		}
	}

	public new virtual NSCell SelectedCell
	{
		[Export("selectedCell")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCell)(__mt_SelectedCell_var = ((!IsDirectBinding) ? ((NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedCellHandle))) : ((NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedCellHandle)))));
		}
	}

	public virtual NSCell[] SelectedCells
	{
		[Export("selectedCells")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCell[])(__mt_SelectedCells_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSCell>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedCellsHandle)) : NSArray.ArrayFromHandle<NSCell>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedCellsHandle))));
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

	public virtual long SelectedColumn
	{
		[Export("selectedColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selSelectedColumnHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSelectedColumnHandle);
		}
	}

	public virtual long Rows
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

	public virtual long Columns
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

	public new virtual Class CellClass
	{
		[Export("cellClass")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return new Class(Messaging.IntPtr_objc_msgSend(base.Handle, selCellClassHandle));
			}
			return new Class(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCellClassHandle));
		}
		[Export("setCellClass:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCellClass_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCellClass_Handle, value.Handle);
			}
		}
	}

	public virtual NSCell Prototype
	{
		[Export("prototype")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCell)(__mt_Prototype_var = ((!IsDirectBinding) ? ((NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrototypeHandle))) : ((NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPrototypeHandle)))));
		}
		[Export("setPrototype:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPrototype_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPrototype_Handle, value.Handle);
			}
			__mt_Prototype_var = value;
		}
	}

	public virtual NSMatrixMode Mode
	{
		[Export("mode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSMatrixMode)Messaging.int_objc_msgSend(base.Handle, selModeHandle);
			}
			return (NSMatrixMode)Messaging.int_objc_msgSendSuper(base.SuperHandle, selModeHandle);
		}
		[Export("setMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetMode_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetMode_Handle, (int)value);
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

	public virtual bool SelectionByRect
	{
		[Export("isSelectionByRect")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSelectionByRectHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSelectionByRectHandle);
		}
		[Export("setSelectionByRect:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSelectionByRect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSelectionByRect_Handle, value);
			}
		}
	}

	public virtual CGSize CellSize
	{
		[Export("cellSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selCellSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selCellSizeHandle);
		}
		[Export("setCellSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetCellSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetCellSize_Handle, value);
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

	public virtual NSColor CellBackgroundColor
	{
		[Export("cellBackgroundColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_CellBackgroundColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCellBackgroundColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCellBackgroundColorHandle)))));
		}
		[Export("setCellBackgroundColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCellBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCellBackgroundColor_Handle, value.Handle);
			}
			__mt_CellBackgroundColor_var = value;
		}
	}

	public virtual bool DrawsCellBackground
	{
		[Export("drawsCellBackground")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDrawsCellBackgroundHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDrawsCellBackgroundHandle);
		}
		[Export("setDrawsCellBackground:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDrawsCellBackground_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDrawsCellBackground_Handle, value);
			}
		}
	}

	public virtual bool DrawsBackground
	{
		[Export("drawsBackground")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDrawsBackgroundHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDrawsBackgroundHandle);
		}
		[Export("setDrawsBackground:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDrawsBackground_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDrawsBackground_Handle, value);
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

	public virtual bool AutosizesCells
	{
		[Export("autosizesCells")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutosizesCellsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutosizesCellsHandle);
		}
		[Export("setAutosizesCells:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutosizesCells_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutosizesCells_Handle, value);
			}
		}
	}

	public new virtual bool Autoscroll
	{
		[Export("isAutoscroll")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutoscrollHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutoscrollHandle);
		}
		[Export("setAutoscroll:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoscroll_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoscroll_Handle, value);
			}
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

	public NSMatrixDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSMatrixDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual bool TabKeyTraversesCells
	{
		[Export("tabKeyTraversesCells")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTabKeyTraversesCellsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTabKeyTraversesCellsHandle);
		}
		[Export("setTabKeyTraversesCells:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTabKeyTraversesCells_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTabKeyTraversesCells_Handle, value);
			}
		}
	}

	public virtual NSObject KeyCell
	{
		[Export("keyCell")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_KeyCell_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyCellHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyCellHandle))));
		}
		[Export("setKeyCell:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetKeyCell_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetKeyCell_Handle, value.Handle);
			}
			__mt_KeyCell_var = value;
		}
	}

	public NSControlText TextShouldBeginEditing
	{
		get
		{
			return EnsureNSMatrixDelegate().textShouldBeginEditing;
		}
		set
		{
			EnsureNSMatrixDelegate().textShouldBeginEditing = value;
		}
	}

	public NSControlText TextShouldEndEditing
	{
		get
		{
			return EnsureNSMatrixDelegate().textShouldEndEditing;
		}
		set
		{
			EnsureNSMatrixDelegate().textShouldEndEditing = value;
		}
	}

	public NSControlTextError DidFailToFormatString
	{
		get
		{
			return EnsureNSMatrixDelegate().didFailToFormatString;
		}
		set
		{
			EnsureNSMatrixDelegate().didFailToFormatString = value;
		}
	}

	public NSControlTextValidation IsValidObject
	{
		get
		{
			return EnsureNSMatrixDelegate().isValidObject;
		}
		set
		{
			EnsureNSMatrixDelegate().isValidObject = value;
		}
	}

	public NSControlCommand DoCommandBySelector
	{
		get
		{
			return EnsureNSMatrixDelegate().doCommandBySelector;
		}
		set
		{
			EnsureNSMatrixDelegate().doCommandBySelector = value;
		}
	}

	public NSControlTextCompletion GetCompletions
	{
		get
		{
			return EnsureNSMatrixDelegate().getCompletions;
		}
		set
		{
			EnsureNSMatrixDelegate().getCompletions = value;
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

	public event EventHandler<NSControlTextErrorEventArgs> DidFailToValidatePartialString
	{
		add
		{
			_NSMatrixDelegate nSMatrixDelegate = EnsureNSMatrixDelegate();
			nSMatrixDelegate.didFailToValidatePartialString = (EventHandler<NSControlTextErrorEventArgs>)System.Delegate.Combine(nSMatrixDelegate.didFailToValidatePartialString, value);
		}
		remove
		{
			_NSMatrixDelegate nSMatrixDelegate = EnsureNSMatrixDelegate();
			nSMatrixDelegate.didFailToValidatePartialString = (EventHandler<NSControlTextErrorEventArgs>)System.Delegate.Remove(nSMatrixDelegate.didFailToValidatePartialString, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMatrix()
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
	public NSMatrix(NSCoder coder)
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
	public NSMatrix(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMatrix(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSMatrix(CGRect frameRect)
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

	[Export("initWithFrame:mode:prototype:numberOfRows:numberOfColumns:")]
	public NSMatrix(CGRect frameRect, NSMatrixMode aMode, NSCell aCell, long rowsHigh, long colsWide)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aCell == null)
		{
			throw new ArgumentNullException("aCell");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect_int_IntPtr_Int64_Int64(base.Handle, selInitWithFrameModePrototypeNumberOfRowsNumberOfColumns_Handle, frameRect, (int)aMode, aCell.Handle, rowsHigh, colsWide);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect_int_IntPtr_Int64_Int64(base.SuperHandle, selInitWithFrameModePrototypeNumberOfRowsNumberOfColumns_Handle, frameRect, (int)aMode, aCell.Handle, rowsHigh, colsWide);
		}
	}

	[Export("initWithFrame:mode:cellClass:numberOfRows:numberOfColumns:")]
	public NSMatrix(CGRect frameRect, NSMatrixMode aMode, Class factoryId, long rowsHigh, long colsWide)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (factoryId == null)
		{
			throw new ArgumentNullException("factoryId");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect_int_IntPtr_Int64_Int64(base.Handle, selInitWithFrameModeCellClassNumberOfRowsNumberOfColumns_Handle, frameRect, (int)aMode, factoryId.Handle, rowsHigh, colsWide);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect_int_IntPtr_Int64_Int64(base.SuperHandle, selInitWithFrameModeCellClassNumberOfRowsNumberOfColumns_Handle, frameRect, (int)aMode, factoryId.Handle, rowsHigh, colsWide);
		}
	}

	[Export("makeCellAtRow:column:")]
	public virtual NSCell MakeCell(long row, long col)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64_Int64(base.Handle, selMakeCellAtRowColumn_Handle, row, col));
		}
		return (NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selMakeCellAtRowColumn_Handle, row, col));
	}

	[Export("sendAction:to:forAllCells:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, selSendActionToForAllCells_Handle, aSelector.Handle, anObject.Handle, forAllCells);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool(base.SuperHandle, selSendActionToForAllCells_Handle, aSelector.Handle, anObject.Handle, forAllCells);
		}
	}

	[Export("sortUsingSelector:")]
	public virtual void Sort(Selector comparator)
	{
		NSApplication.EnsureUIThread();
		if (comparator == null)
		{
			throw new ArgumentNullException("comparator");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSortUsingSelector_Handle, comparator.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSortUsingSelector_Handle, comparator.Handle);
		}
	}

	[Export("setSelectionFrom:to:anchor:highlight:")]
	public virtual void SetSelection(long startPos, long endPos, long anchorPos, bool highlight)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_Int64_Int64_bool(base.Handle, selSetSelectionFromToAnchorHighlight_Handle, startPos, endPos, anchorPos, highlight);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_Int64_Int64_bool(base.SuperHandle, selSetSelectionFromToAnchorHighlight_Handle, startPos, endPos, anchorPos, highlight);
		}
	}

	[Export("deselectSelectedCell")]
	public virtual void DeselectSelectedCell()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDeselectSelectedCellHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDeselectSelectedCellHandle);
		}
	}

	[Export("deselectAllCells")]
	public virtual void DeselectAllCells()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDeselectAllCellsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDeselectAllCellsHandle);
		}
	}

	[Export("selectCellAtRow:column:")]
	public virtual void SelectCell(long row, long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_Int64(base.Handle, selSelectCellAtRowColumn_Handle, row, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selSelectCellAtRowColumn_Handle, row, column);
		}
	}

	[Export("selectAll:")]
	public virtual void SelectAll(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectAll_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectAll_Handle, sender.Handle);
		}
	}

	[Export("selectCellWithTag:")]
	public virtual bool SelectCellWithTag(long tag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selSelectCellWithTag_Handle, tag);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selSelectCellWithTag_Handle, tag);
	}

	[Export("setScrollable:")]
	public virtual void SetScrollable(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetScrollable_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetScrollable_Handle, flag);
		}
	}

	[Export("setState:atRow:column:")]
	public virtual void SetState(long state, long row, long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_Int64_Int64(base.Handle, selSetStateAtRowColumn_Handle, state, row, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_Int64_Int64(base.SuperHandle, selSetStateAtRowColumn_Handle, state, row, column);
		}
	}

	[Export("getNumberOfRows:columns:")]
	public virtual void GetRowsAndColumnsCount(out long rowCount, out long colCount)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_Int64_out_Int64(base.Handle, selGetNumberOfRowsColumns_Handle, out rowCount, out colCount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_Int64_out_Int64(base.SuperHandle, selGetNumberOfRowsColumns_Handle, out rowCount, out colCount);
		}
	}

	[Export("cellAtRow:column:")]
	internal virtual NSCell CellAtRowColumn(long row, long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64_Int64(base.Handle, selCellAtRowColumn_Handle, row, column));
		}
		return (NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selCellAtRowColumn_Handle, row, column));
	}

	[Export("cellFrameAtRow:column:")]
	public virtual CGRect CellFrameAtRowColumn(long row, long column)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_Int64_Int64(out retval, base.Handle, selCellFrameAtRowColumn_Handle, row, column);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_Int64_Int64(out retval, base.SuperHandle, selCellFrameAtRowColumn_Handle, row, column);
		}
		return retval;
	}

	[Export("getRow:column:ofCell:")]
	public virtual bool GetRowColumn(out long row, out long column, NSCell aCell)
	{
		NSApplication.EnsureUIThread();
		if (aCell == null)
		{
			throw new ArgumentNullException("aCell");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_out_Int64_out_Int64_IntPtr(base.Handle, selGetRowColumnOfCell_Handle, out row, out column, aCell.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_out_Int64_out_Int64_IntPtr(base.SuperHandle, selGetRowColumnOfCell_Handle, out row, out column, aCell.Handle);
	}

	[Export("getRow:column:forPoint:")]
	public virtual bool GetRowColumnForPoint(out long row, out long column, CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_out_Int64_out_Int64_CGPoint(base.Handle, selGetRowColumnForPoint_Handle, out row, out column, aPoint);
		}
		return Messaging.bool_objc_msgSendSuper_out_Int64_out_Int64_CGPoint(base.SuperHandle, selGetRowColumnForPoint_Handle, out row, out column, aPoint);
	}

	[Export("renewRows:columns:")]
	public virtual void RenewRowsColumns(long newRows, long newCols)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_Int64(base.Handle, selRenewRowsColumns_Handle, newRows, newCols);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selRenewRowsColumns_Handle, newRows, newCols);
		}
	}

	[Export("putCell:atRow:column:")]
	public virtual void PutCell(NSCell newCell, long row, long column)
	{
		NSApplication.EnsureUIThread();
		if (newCell == null)
		{
			throw new ArgumentNullException("newCell");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64_Int64(base.Handle, selPutCellAtRowColumn_Handle, newCell.Handle, row, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64_Int64(base.SuperHandle, selPutCellAtRowColumn_Handle, newCell.Handle, row, column);
		}
	}

	[Export("addRow")]
	public virtual void AddRow()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAddRowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAddRowHandle);
		}
	}

	[Export("addRowWithCells:")]
	public virtual void AddRowWithCells(NSCell[] newCells)
	{
		NSApplication.EnsureUIThread();
		if (newCells == null)
		{
			throw new ArgumentNullException("newCells");
		}
		NSArray nSArray = NSArray.FromNSObjects(newCells);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddRowWithCells_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddRowWithCells_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("insertRow:")]
	public virtual void InsertRow(long row)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selInsertRow_Handle, row);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selInsertRow_Handle, row);
		}
	}

	[Export("insertRow:withCells:")]
	public virtual void InsertRow(long row, NSCell[] newCells)
	{
		NSApplication.EnsureUIThread();
		if (newCells == null)
		{
			throw new ArgumentNullException("newCells");
		}
		NSArray nSArray = NSArray.FromNSObjects(newCells);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr(base.Handle, selInsertRowWithCells_Handle, row, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selInsertRowWithCells_Handle, row, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("removeRow:")]
	public virtual void RemoveRow(long row)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selRemoveRow_Handle, row);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selRemoveRow_Handle, row);
		}
	}

	[Export("addColumn")]
	public virtual void AddColumn()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAddColumnHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAddColumnHandle);
		}
	}

	[Export("addColumnWithCells:")]
	public virtual void AddColumnWithCells(NSCell[] newCells)
	{
		NSApplication.EnsureUIThread();
		if (newCells == null)
		{
			throw new ArgumentNullException("newCells");
		}
		NSArray nSArray = NSArray.FromNSObjects(newCells);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddColumnWithCells_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddColumnWithCells_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("insertColumn:")]
	public virtual void InsertColumn(long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selInsertColumn_Handle, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selInsertColumn_Handle, column);
		}
	}

	[Export("insertColumn:withCells:")]
	public virtual void InsertColumn(long column, NSCell[] newCells)
	{
		NSApplication.EnsureUIThread();
		if (newCells == null)
		{
			throw new ArgumentNullException("newCells");
		}
		NSArray nSArray = NSArray.FromNSObjects(newCells);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr(base.Handle, selInsertColumnWithCells_Handle, column, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selInsertColumnWithCells_Handle, column, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("removeColumn:")]
	public virtual void RemoveColumn(long col)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selRemoveColumn_Handle, col);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selRemoveColumn_Handle, col);
		}
	}

	[Export("cellWithTag:")]
	public virtual NSCell CellWithTag(long anInt)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selCellWithTag_Handle, anInt));
		}
		return (NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selCellWithTag_Handle, anInt));
	}

	[Export("sizeToCells")]
	public virtual void SizeToCells()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSizeToCellsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSizeToCellsHandle);
		}
	}

	[Export("setValidateSize:")]
	public virtual void SetValidateSize(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetValidateSize_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetValidateSize_Handle, flag);
		}
	}

	[Export("drawCellAtRow:column:")]
	public virtual void DrawCellAtRowColumn(long row, long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_Int64(base.Handle, selDrawCellAtRowColumn_Handle, row, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selDrawCellAtRowColumn_Handle, row, column);
		}
	}

	[Export("highlightCell:atRow:column:")]
	public virtual void HighlightCell(bool highlight, long row, long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_Int64_Int64(base.Handle, selHighlightCellAtRowColumn_Handle, highlight, row, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_Int64_Int64(base.SuperHandle, selHighlightCellAtRowColumn_Handle, highlight, row, column);
		}
	}

	[Export("scrollCellToVisibleAtRow:column:")]
	public virtual void ScrollCellToVisible(long row, long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_Int64(base.Handle, selScrollCellToVisibleAtRowColumn_Handle, row, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selScrollCellToVisibleAtRowColumn_Handle, row, column);
		}
	}

	[Export("mouseDownFlags")]
	public virtual long MouseDownFlags()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend(base.Handle, selMouseDownFlagsHandle);
		}
		return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMouseDownFlagsHandle);
	}

	[Export("mouseDown:")]
	public new virtual void MouseDown(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseDown_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseDown_Handle, theEvent.Handle);
		}
	}

	[Export("performKeyEquivalent:")]
	public new virtual bool PerformKeyEquivalent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPerformKeyEquivalent_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformKeyEquivalent_Handle, theEvent.Handle);
	}

	[Export("sendAction")]
	public virtual bool SendAction()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selSendActionHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSendActionHandle);
	}

	[Export("sendDoubleAction")]
	public virtual void SendDoubleAction()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSendDoubleActionHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSendDoubleActionHandle);
		}
	}

	[Export("textShouldBeginEditing:")]
	public virtual bool ShouldBeginEditing(NSText textObject)
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
	public virtual bool ShouldEndEditing(NSText textObject)
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
	public virtual void DidBeginEditing(NSNotification notification)
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
	public virtual void DidEndEditing(NSNotification notification)
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
	public virtual void Changed(NSNotification notification)
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

	[Export("selectText:")]
	public virtual void SelectText(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectText_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectText_Handle, sender.Handle);
		}
	}

	[Export("selectTextAtRow:column:")]
	public virtual NSObject SelectTextAtRowColumn(long row, long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64_Int64(base.Handle, selSelectTextAtRowColumn_Handle, row, column));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selSelectTextAtRowColumn_Handle, row, column));
	}

	[Export("acceptsFirstMouse:")]
	public new virtual bool AcceptsFirstMouse(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAcceptsFirstMouse_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAcceptsFirstMouse_Handle, theEvent.Handle);
	}

	[Export("resetCursorRects")]
	public new virtual void ResetCursorRects()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetCursorRectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetCursorRectsHandle);
		}
	}

	[Export("setToolTip:forCell:")]
	public virtual void SetToolTipForCell(string toolTipString, NSCell cell)
	{
		NSApplication.EnsureUIThread();
		if (toolTipString == null)
		{
			throw new ArgumentNullException("toolTipString");
		}
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		IntPtr arg = NSString.CreateNative(toolTipString);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetToolTipForCell_Handle, arg, cell.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetToolTipForCell_Handle, arg, cell.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("toolTipForCell:")]
	public virtual string ToolTipForCell(NSCell cell)
	{
		NSApplication.EnsureUIThread();
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selToolTipForCell_Handle, cell.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selToolTipForCell_Handle, cell.Handle));
	}

	private _NSMatrixDelegate EnsureNSMatrixDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _NSMatrixDelegate))
		{
			nSObject = (WeakDelegate = new _NSMatrixDelegate());
		}
		return (_NSMatrixDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Cells_var = null;
			__mt_SelectedCell_var = null;
			__mt_SelectedCells_var = null;
			__mt_Prototype_var = null;
			__mt_BackgroundColor_var = null;
			__mt_CellBackgroundColor_var = null;
			__mt_WeakDelegate_var = null;
			__mt_KeyCell_var = null;
		}
	}
}
