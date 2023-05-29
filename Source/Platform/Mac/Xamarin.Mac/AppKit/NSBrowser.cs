using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSBrowser", true)]
public class NSBrowser : NSControl
{
	private static readonly IntPtr selIsLoadedHandle = Selector.GetHandle("isLoaded");

	private static readonly IntPtr selAutohidesScrollerHandle = Selector.GetHandle("autohidesScroller");

	private static readonly IntPtr selSetAutohidesScroller_Handle = Selector.GetHandle("setAutohidesScroller:");

	private static readonly IntPtr selSelectionIndexPathHandle = Selector.GetHandle("selectionIndexPath");

	private static readonly IntPtr selSetSelectionIndexPath_Handle = Selector.GetHandle("setSelectionIndexPath:");

	private static readonly IntPtr selSelectionIndexPathsHandle = Selector.GetHandle("selectionIndexPaths");

	private static readonly IntPtr selSetSelectionIndexPaths_Handle = Selector.GetHandle("setSelectionIndexPaths:");

	private static readonly IntPtr selNumberOfVisibleColumnsHandle = Selector.GetHandle("numberOfVisibleColumns");

	private static readonly IntPtr selFirstVisibleColumnHandle = Selector.GetHandle("firstVisibleColumn");

	private static readonly IntPtr selLastVisibleColumnHandle = Selector.GetHandle("lastVisibleColumn");

	private static readonly IntPtr selTitleHeightHandle = Selector.GetHandle("titleHeight");

	private static readonly IntPtr selColumnResizingTypeHandle = Selector.GetHandle("columnResizingType");

	private static readonly IntPtr selSetColumnResizingType_Handle = Selector.GetHandle("setColumnResizingType:");

	private static readonly IntPtr selPrefersAllColumnUserResizingHandle = Selector.GetHandle("prefersAllColumnUserResizing");

	private static readonly IntPtr selSetPrefersAllColumnUserResizing_Handle = Selector.GetHandle("setPrefersAllColumnUserResizing:");

	private static readonly IntPtr selRowHeightHandle = Selector.GetHandle("rowHeight");

	private static readonly IntPtr selSetRowHeight_Handle = Selector.GetHandle("setRowHeight:");

	private static readonly IntPtr selDefaultColumnWidthHandle = Selector.GetHandle("defaultColumnWidth");

	private static readonly IntPtr selSetDefaultColumnWidth_Handle = Selector.GetHandle("setDefaultColumnWidth:");

	private static readonly IntPtr selColumnsAutosaveNameHandle = Selector.GetHandle("columnsAutosaveName");

	private static readonly IntPtr selSetColumnsAutosaveName_Handle = Selector.GetHandle("setColumnsAutosaveName:");

	private static readonly IntPtr selAllowsTypeSelectHandle = Selector.GetHandle("allowsTypeSelect");

	private static readonly IntPtr selSetAllowsTypeSelect_Handle = Selector.GetHandle("setAllowsTypeSelect:");

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	private static readonly IntPtr selDoubleActionHandle = Selector.GetHandle("doubleAction");

	private static readonly IntPtr selSetDoubleAction_Handle = Selector.GetHandle("setDoubleAction:");

	private static readonly IntPtr selMatrixClassHandle = Selector.GetHandle("matrixClass");

	private static readonly IntPtr selSetMatrixClass_Handle = Selector.GetHandle("setMatrixClass:");

	private static readonly IntPtr selCellClassHandle = Selector.GetHandle("cellClass");

	private static readonly IntPtr selCellPrototypeHandle = Selector.GetHandle("cellPrototype");

	private static readonly IntPtr selSetCellPrototype_Handle = Selector.GetHandle("setCellPrototype:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selReusesColumnsHandle = Selector.GetHandle("reusesColumns");

	private static readonly IntPtr selSetReusesColumns_Handle = Selector.GetHandle("setReusesColumns:");

	private static readonly IntPtr selHasHorizontalScrollerHandle = Selector.GetHandle("hasHorizontalScroller");

	private static readonly IntPtr selSetHasHorizontalScroller_Handle = Selector.GetHandle("setHasHorizontalScroller:");

	private static readonly IntPtr selSeparatesColumnsHandle = Selector.GetHandle("separatesColumns");

	private static readonly IntPtr selSetSeparatesColumns_Handle = Selector.GetHandle("setSeparatesColumns:");

	private static readonly IntPtr selIsTitledHandle = Selector.GetHandle("isTitled");

	private static readonly IntPtr selSetTitled_Handle = Selector.GetHandle("setTitled:");

	private static readonly IntPtr selMinColumnWidthHandle = Selector.GetHandle("minColumnWidth");

	private static readonly IntPtr selSetMinColumnWidth_Handle = Selector.GetHandle("setMinColumnWidth:");

	private static readonly IntPtr selMaxVisibleColumnsHandle = Selector.GetHandle("maxVisibleColumns");

	private static readonly IntPtr selSetMaxVisibleColumns_Handle = Selector.GetHandle("setMaxVisibleColumns:");

	private static readonly IntPtr selAllowsMultipleSelectionHandle = Selector.GetHandle("allowsMultipleSelection");

	private static readonly IntPtr selSetAllowsMultipleSelection_Handle = Selector.GetHandle("setAllowsMultipleSelection:");

	private static readonly IntPtr selAllowsBranchSelectionHandle = Selector.GetHandle("allowsBranchSelection");

	private static readonly IntPtr selSetAllowsBranchSelection_Handle = Selector.GetHandle("setAllowsBranchSelection:");

	private static readonly IntPtr selAllowsEmptySelectionHandle = Selector.GetHandle("allowsEmptySelection");

	private static readonly IntPtr selSetAllowsEmptySelection_Handle = Selector.GetHandle("setAllowsEmptySelection:");

	private static readonly IntPtr selTakesTitleFromPreviousColumnHandle = Selector.GetHandle("takesTitleFromPreviousColumn");

	private static readonly IntPtr selSetTakesTitleFromPreviousColumn_Handle = Selector.GetHandle("setTakesTitleFromPreviousColumn:");

	private static readonly IntPtr selSendsActionOnArrowKeysHandle = Selector.GetHandle("sendsActionOnArrowKeys");

	private static readonly IntPtr selSetSendsActionOnArrowKeys_Handle = Selector.GetHandle("setSendsActionOnArrowKeys:");

	private static readonly IntPtr selPathSeparatorHandle = Selector.GetHandle("pathSeparator");

	private static readonly IntPtr selSetPathSeparator_Handle = Selector.GetHandle("setPathSeparator:");

	private static readonly IntPtr selLastColumnHandle = Selector.GetHandle("lastColumn");

	private static readonly IntPtr selSetLastColumn_Handle = Selector.GetHandle("setLastColumn:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selLoadColumnZeroHandle = Selector.GetHandle("loadColumnZero");

	private static readonly IntPtr selItemAtIndexPath_Handle = Selector.GetHandle("itemAtIndexPath:");

	private static readonly IntPtr selItemAtRowInColumn_Handle = Selector.GetHandle("itemAtRow:inColumn:");

	private static readonly IntPtr selIndexPathForColumn_Handle = Selector.GetHandle("indexPathForColumn:");

	private static readonly IntPtr selIsLeafItem_Handle = Selector.GetHandle("isLeafItem:");

	private static readonly IntPtr selReloadDataForRowIndexesInColumn_Handle = Selector.GetHandle("reloadDataForRowIndexes:inColumn:");

	private static readonly IntPtr selParentForItemsInColumn_Handle = Selector.GetHandle("parentForItemsInColumn:");

	private static readonly IntPtr selScrollRowToVisibleInColumn_Handle = Selector.GetHandle("scrollRowToVisible:inColumn:");

	private static readonly IntPtr selSetTitleOfColumn_Handle = Selector.GetHandle("setTitle:ofColumn:");

	private static readonly IntPtr selTitleOfColumn_Handle = Selector.GetHandle("titleOfColumn:");

	private static readonly IntPtr selPathToColumn_Handle = Selector.GetHandle("pathToColumn:");

	private static readonly IntPtr selClickedColumnHandle = Selector.GetHandle("clickedColumn");

	private static readonly IntPtr selClickedRowHandle = Selector.GetHandle("clickedRow");

	private static readonly IntPtr selSelectedColumnHandle = Selector.GetHandle("selectedColumn");

	private static readonly IntPtr selSelectedCellHandle = Selector.GetHandle("selectedCell");

	private static readonly IntPtr selSelectedCellInColumn_Handle = Selector.GetHandle("selectedCellInColumn:");

	private static readonly IntPtr selSelectedCellsHandle = Selector.GetHandle("selectedCells");

	private static readonly IntPtr selSelectRowInColumn_Handle = Selector.GetHandle("selectRow:inColumn:");

	private static readonly IntPtr selSelectedRowInColumn_Handle = Selector.GetHandle("selectedRowInColumn:");

	private static readonly IntPtr selSelectRowIndexesInColumn_Handle = Selector.GetHandle("selectRowIndexes:inColumn:");

	private static readonly IntPtr selSelectedRowIndexesInColumn_Handle = Selector.GetHandle("selectedRowIndexesInColumn:");

	private static readonly IntPtr selReloadColumn_Handle = Selector.GetHandle("reloadColumn:");

	private static readonly IntPtr selValidateVisibleColumnsHandle = Selector.GetHandle("validateVisibleColumns");

	private static readonly IntPtr selScrollColumnsRightBy_Handle = Selector.GetHandle("scrollColumnsRightBy:");

	private static readonly IntPtr selScrollColumnsLeftBy_Handle = Selector.GetHandle("scrollColumnsLeftBy:");

	private static readonly IntPtr selScrollColumnToVisible_Handle = Selector.GetHandle("scrollColumnToVisible:");

	private static readonly IntPtr selAddColumnHandle = Selector.GetHandle("addColumn");

	private static readonly IntPtr selColumnOfMatrix_Handle = Selector.GetHandle("columnOfMatrix:");

	private static readonly IntPtr selMatrixInColumn_Handle = Selector.GetHandle("matrixInColumn:");

	private static readonly IntPtr selLoadedCellAtRowColumn_Handle = Selector.GetHandle("loadedCellAtRow:column:");

	private static readonly IntPtr selSelectAll_Handle = Selector.GetHandle("selectAll:");

	private static readonly IntPtr selTileHandle = Selector.GetHandle("tile");

	private static readonly IntPtr selDoClick_Handle = Selector.GetHandle("doClick:");

	private static readonly IntPtr selDoDoubleClick_Handle = Selector.GetHandle("doDoubleClick:");

	private static readonly IntPtr selSendActionHandle = Selector.GetHandle("sendAction");

	private static readonly IntPtr selTitleFrameOfColumn_Handle = Selector.GetHandle("titleFrameOfColumn:");

	private static readonly IntPtr selDrawTitleOfColumnInRect_Handle = Selector.GetHandle("drawTitleOfColumn:inRect:");

	private static readonly IntPtr selFrameOfColumn_Handle = Selector.GetHandle("frameOfColumn:");

	private static readonly IntPtr selFrameOfInsideOfColumn_Handle = Selector.GetHandle("frameOfInsideOfColumn:");

	private static readonly IntPtr selFrameOfRowInColumn_Handle = Selector.GetHandle("frameOfRow:inColumn:");

	private static readonly IntPtr selGetRowColumnForPoint_Handle = Selector.GetHandle("getRow:column:forPoint:");

	private static readonly IntPtr selColumnWidthForColumnContentWidth_Handle = Selector.GetHandle("columnWidthForColumnContentWidth:");

	private static readonly IntPtr selColumnContentWidthForColumnWidth_Handle = Selector.GetHandle("columnContentWidthForColumnWidth:");

	private static readonly IntPtr selSetWidthOfColumn_Handle = Selector.GetHandle("setWidth:ofColumn:");

	private static readonly IntPtr selWidthOfColumn_Handle = Selector.GetHandle("widthOfColumn:");

	private static readonly IntPtr selNoteHeightOfRowsWithIndexesChangedInColumn_Handle = Selector.GetHandle("noteHeightOfRowsWithIndexesChanged:inColumn:");

	private static readonly IntPtr selRemoveSavedColumnsWithAutosaveName_Handle = Selector.GetHandle("removeSavedColumnsWithAutosaveName:");

	private static readonly IntPtr selCanDragRowsWithIndexesInColumnWithEvent_Handle = Selector.GetHandle("canDragRowsWithIndexes:inColumn:withEvent:");

	private static readonly IntPtr selSetDraggingSourceOperationMaskForLocal_Handle = Selector.GetHandle("setDraggingSourceOperationMask:forLocal:");

	private static readonly IntPtr selEditItemAtIndexPathWithEventSelect_Handle = Selector.GetHandle("editItemAtIndexPath:withEvent:select:");

	private static readonly IntPtr selSetCellClass_Handle = Selector.GetHandle("setCellClass:");

	private static readonly IntPtr selPathHandle = Selector.GetHandle("path");

	private static readonly IntPtr selSetPath_Handle = Selector.GetHandle("setPath:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSBrowser");

	private object __mt_SelectionIndexPath_var;

	private object __mt_SelectionIndexPaths_var;

	private object __mt_BackgroundColor_var;

	private object __mt_CellPrototype_var;

	private object __mt_WeakDelegate_var;

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

	public virtual bool Loaded
	{
		[Export("isLoaded")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLoadedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLoadedHandle);
		}
	}

	public virtual bool AutohidesScroller
	{
		[Export("autohidesScroller")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutohidesScrollerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutohidesScrollerHandle);
		}
		[Export("setAutohidesScroller:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutohidesScroller_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutohidesScroller_Handle, value);
			}
		}
	}

	public virtual NSIndexPath SelectionIndexPath
	{
		[Export("selectionIndexPath")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSIndexPath)(__mt_SelectionIndexPath_var = ((!IsDirectBinding) ? ((NSIndexPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionIndexPathHandle))) : ((NSIndexPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionIndexPathHandle)))));
		}
		[Export("setSelectionIndexPath:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelectionIndexPath_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectionIndexPath_Handle, value.Handle);
			}
			__mt_SelectionIndexPath_var = value;
		}
	}

	public virtual NSIndexPath[] SelectionIndexPaths
	{
		[Export("selectionIndexPaths")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSIndexPath[])(__mt_SelectionIndexPaths_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSIndexPath>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionIndexPathsHandle)) : NSArray.ArrayFromHandle<NSIndexPath>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionIndexPathsHandle))));
		}
		[Export("setSelectionIndexPaths:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelectionIndexPaths_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectionIndexPaths_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_SelectionIndexPaths_var = value;
		}
	}

	public virtual long VisibleColumns
	{
		[Export("numberOfVisibleColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNumberOfVisibleColumnsHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNumberOfVisibleColumnsHandle);
		}
	}

	public virtual long FirstVisibleColumn
	{
		[Export("firstVisibleColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selFirstVisibleColumnHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFirstVisibleColumnHandle);
		}
	}

	public virtual long LastVisibleColumn
	{
		[Export("lastVisibleColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selLastVisibleColumnHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selLastVisibleColumnHandle);
		}
	}

	public virtual double TitleHeight
	{
		[Export("titleHeight")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTitleHeightHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTitleHeightHandle);
		}
	}

	public virtual NSBrowserColumnResizingType ColumnResizingType
	{
		[Export("columnResizingType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSBrowserColumnResizingType)Messaging.UInt64_objc_msgSend(base.Handle, selColumnResizingTypeHandle);
			}
			return (NSBrowserColumnResizingType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selColumnResizingTypeHandle);
		}
		[Export("setColumnResizingType:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetColumnResizingType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetColumnResizingType_Handle, (ulong)value);
			}
		}
	}

	public virtual bool PrefersAllColumnUserResizing
	{
		[Export("prefersAllColumnUserResizing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPrefersAllColumnUserResizingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPrefersAllColumnUserResizingHandle);
		}
		[Export("setPrefersAllColumnUserResizing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPrefersAllColumnUserResizing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPrefersAllColumnUserResizing_Handle, value);
			}
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

	public virtual double DefaultColumnWidth
	{
		[Export("defaultColumnWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDefaultColumnWidthHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDefaultColumnWidthHandle);
		}
		[Export("setDefaultColumnWidth:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetDefaultColumnWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetDefaultColumnWidth_Handle, value);
			}
		}
	}

	public virtual string ColumnsAutosaveName
	{
		[Export("columnsAutosaveName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual Class MatrixClass
	{
		[Export("matrixClass")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return new Class(Messaging.IntPtr_objc_msgSend(base.Handle, selMatrixClassHandle));
			}
			return new Class(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMatrixClassHandle));
		}
		[Export("setMatrixClass:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMatrixClass_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMatrixClass_Handle, value.Handle);
			}
		}
	}

	public new static Class CellClass
	{
		[Export("cellClass")]
		get
		{
			NSApplication.EnsureUIThread();
			return new Class(Messaging.IntPtr_objc_msgSend(class_ptr, selCellClassHandle));
		}
	}

	public virtual NSObject CellPrototype
	{
		[Export("cellPrototype")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_CellPrototype_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCellPrototypeHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCellPrototypeHandle))));
		}
		[Export("setCellPrototype:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCellPrototype_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCellPrototype_Handle, value.Handle);
			}
			__mt_CellPrototype_var = value;
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
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

	public NSBrowserDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSBrowserDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual bool ReusesColumns
	{
		[Export("reusesColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selReusesColumnsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selReusesColumnsHandle);
		}
		[Export("setReusesColumns:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetReusesColumns_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetReusesColumns_Handle, value);
			}
		}
	}

	public virtual bool HasHorizontalScroller
	{
		[Export("hasHorizontalScroller")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasHorizontalScrollerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasHorizontalScrollerHandle);
		}
		[Export("setHasHorizontalScroller:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasHorizontalScroller_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasHorizontalScroller_Handle, value);
			}
		}
	}

	public virtual bool SeparatesColumns
	{
		[Export("separatesColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSeparatesColumnsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSeparatesColumnsHandle);
		}
		[Export("setSeparatesColumns:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSeparatesColumns_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSeparatesColumns_Handle, value);
			}
		}
	}

	public virtual bool Titled
	{
		[Export("isTitled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTitledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTitledHandle);
		}
		[Export("setTitled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTitled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTitled_Handle, value);
			}
		}
	}

	public virtual double MinColumnWidth
	{
		[Export("minColumnWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMinColumnWidthHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMinColumnWidthHandle);
		}
		[Export("setMinColumnWidth:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetMinColumnWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetMinColumnWidth_Handle, value);
			}
		}
	}

	public virtual long MaxVisibleColumns
	{
		[Export("maxVisibleColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selMaxVisibleColumnsHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMaxVisibleColumnsHandle);
		}
		[Export("setMaxVisibleColumns:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMaxVisibleColumns_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMaxVisibleColumns_Handle, value);
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

	public virtual bool AllowsBranchSelection
	{
		[Export("allowsBranchSelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsBranchSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsBranchSelectionHandle);
		}
		[Export("setAllowsBranchSelection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsBranchSelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsBranchSelection_Handle, value);
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

	public virtual bool TakesTitleFromPreviousColumn
	{
		[Export("takesTitleFromPreviousColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTakesTitleFromPreviousColumnHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTakesTitleFromPreviousColumnHandle);
		}
		[Export("setTakesTitleFromPreviousColumn:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTakesTitleFromPreviousColumn_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTakesTitleFromPreviousColumn_Handle, value);
			}
		}
	}

	public virtual bool SendsActionOnArrowKeys
	{
		[Export("sendsActionOnArrowKeys")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSendsActionOnArrowKeysHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSendsActionOnArrowKeysHandle);
		}
		[Export("setSendsActionOnArrowKeys:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSendsActionOnArrowKeys_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSendsActionOnArrowKeys_Handle, value);
			}
		}
	}

	public virtual string PathSeparator
	{
		[Export("pathSeparator")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual long LastColumn
	{
		[Export("lastColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selLastColumnHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selLastColumnHandle);
		}
		[Export("setLastColumn:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetLastColumn_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetLastColumn_Handle, value);
			}
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSBrowser()
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
	public NSBrowser(NSCoder coder)
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
	public NSBrowser(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSBrowser(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSBrowser(CGRect frameRect)
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

	[Export("loadColumnZero")]
	public virtual void LoadColumnZero()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLoadColumnZeroHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLoadColumnZeroHandle);
		}
	}

	[Export("itemAtIndexPath:")]
	public virtual NSObject ItemAtIndexPath(NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selItemAtIndexPath_Handle, indexPath.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemAtIndexPath_Handle, indexPath.Handle));
	}

	[Export("itemAtRow:inColumn:")]
	public virtual NSObject GetItem(long row, long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64_Int64(base.Handle, selItemAtRowInColumn_Handle, row, column));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selItemAtRowInColumn_Handle, row, column));
	}

	[Export("indexPathForColumn:")]
	public virtual NSIndexPath IndexPathForColumn(long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSIndexPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selIndexPathForColumn_Handle, column));
		}
		return (NSIndexPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selIndexPathForColumn_Handle, column));
	}

	[Export("isLeafItem:")]
	public virtual bool IsLeafItem(NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsLeafItem_Handle, item.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsLeafItem_Handle, item.Handle);
	}

	[Export("reloadDataForRowIndexes:inColumn:")]
	public virtual void ReloadData(NSIndexSet rowIndexes, long column)
	{
		NSApplication.EnsureUIThread();
		if (rowIndexes == null)
		{
			throw new ArgumentNullException("rowIndexes");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selReloadDataForRowIndexesInColumn_Handle, rowIndexes.Handle, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selReloadDataForRowIndexesInColumn_Handle, rowIndexes.Handle, column);
		}
	}

	[Export("parentForItemsInColumn:")]
	public virtual NSObject ParentForItems(long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selParentForItemsInColumn_Handle, column));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selParentForItemsInColumn_Handle, column));
	}

	[Export("scrollRowToVisible:inColumn:")]
	public virtual void ScrollRowToVisible(long row, long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_Int64(base.Handle, selScrollRowToVisibleInColumn_Handle, row, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selScrollRowToVisibleInColumn_Handle, row, column);
		}
	}

	[Export("setTitle:ofColumn:")]
	public virtual void SetTitle(string aString, long column)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selSetTitleOfColumn_Handle, arg, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selSetTitleOfColumn_Handle, arg, column);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("titleOfColumn:")]
	public virtual string ColumnTitle(long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selTitleOfColumn_Handle, column));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selTitleOfColumn_Handle, column));
	}

	[Export("pathToColumn:")]
	public virtual string ColumnPath(long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selPathToColumn_Handle, column));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selPathToColumn_Handle, column));
	}

	[Export("clickedColumn")]
	public virtual long ClickedColumn()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend(base.Handle, selClickedColumnHandle);
		}
		return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selClickedColumnHandle);
	}

	[Export("clickedRow")]
	public virtual long ClickedRow()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend(base.Handle, selClickedRowHandle);
		}
		return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selClickedRowHandle);
	}

	[Export("selectedColumn")]
	public virtual long SelectedColumn()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend(base.Handle, selSelectedColumnHandle);
		}
		return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSelectedColumnHandle);
	}

	[Export("selectedCell")]
	public new virtual NSObject SelectedCell()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedCellHandle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedCellHandle));
	}

	[Export("selectedCellInColumn:")]
	public virtual NSObject SelectedCellInColumn(long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selSelectedCellInColumn_Handle, column));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selSelectedCellInColumn_Handle, column));
	}

	[Export("selectedCells")]
	public virtual NSCell[] SelectedCells()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSCell>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedCellsHandle));
		}
		return NSArray.ArrayFromHandle<NSCell>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedCellsHandle));
	}

	[Export("selectRow:inColumn:")]
	public virtual void Select(long row, long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_Int64(base.Handle, selSelectRowInColumn_Handle, row, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selSelectRowInColumn_Handle, row, column);
		}
	}

	[Export("selectedRowInColumn:")]
	public virtual long SelectedRow(long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_Int64(base.Handle, selSelectedRowInColumn_Handle, column);
		}
		return Messaging.Int64_objc_msgSendSuper_Int64(base.SuperHandle, selSelectedRowInColumn_Handle, column);
	}

	[Export("selectRowIndexes:inColumn:")]
	public virtual void SelectRowIndexes(NSIndexSet indexes, long column)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selSelectRowIndexesInColumn_Handle, indexes.Handle, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selSelectRowIndexesInColumn_Handle, indexes.Handle, column);
		}
	}

	[Export("selectedRowIndexesInColumn:")]
	public virtual NSIndexSet SelectedRowIndexes(long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selSelectedRowIndexesInColumn_Handle, column));
		}
		return (NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selSelectedRowIndexesInColumn_Handle, column));
	}

	[Export("reloadColumn:")]
	public virtual void ReloadColumn(long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selReloadColumn_Handle, column);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selReloadColumn_Handle, column);
		}
	}

	[Export("validateVisibleColumns")]
	public virtual void ValidateVisibleColumns()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selValidateVisibleColumnsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selValidateVisibleColumnsHandle);
		}
	}

	[Export("scrollColumnsRightBy:")]
	public virtual void ScrollColumnsRightBy(long shiftAmount)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selScrollColumnsRightBy_Handle, shiftAmount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selScrollColumnsRightBy_Handle, shiftAmount);
		}
	}

	[Export("scrollColumnsLeftBy:")]
	public virtual void ScrollColumnsLeftBy(long shiftAmount)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selScrollColumnsLeftBy_Handle, shiftAmount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selScrollColumnsLeftBy_Handle, shiftAmount);
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

	[Export("columnOfMatrix:")]
	public virtual long ColumnOfMatrix(NSMatrix matrix)
	{
		NSApplication.EnsureUIThread();
		if (matrix == null)
		{
			throw new ArgumentNullException("matrix");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selColumnOfMatrix_Handle, matrix.Handle);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selColumnOfMatrix_Handle, matrix.Handle);
	}

	[Export("matrixInColumn:")]
	public virtual NSMatrix MatrixInColumn(long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSMatrix)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selMatrixInColumn_Handle, column));
		}
		return (NSMatrix)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selMatrixInColumn_Handle, column));
	}

	[Export("loadedCellAtRow:column:")]
	public virtual NSCell LoadedCell(long row, long col)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64_Int64(base.Handle, selLoadedCellAtRowColumn_Handle, row, col));
		}
		return (NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selLoadedCellAtRowColumn_Handle, row, col));
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

	[Export("doClick:")]
	public virtual void DoClick(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDoClick_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDoClick_Handle, sender.Handle);
		}
	}

	[Export("doDoubleClick:")]
	public virtual void DoDoubleClick(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDoDoubleClick_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDoDoubleClick_Handle, sender.Handle);
		}
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

	[Export("titleFrameOfColumn:")]
	public virtual CGRect TitleFrameOfColumn(long column)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_Int64(out retval, base.Handle, selTitleFrameOfColumn_Handle, column);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_Int64(out retval, base.SuperHandle, selTitleFrameOfColumn_Handle, column);
		}
		return retval;
	}

	[Export("drawTitleOfColumn:inRect:")]
	public virtual void DrawTitle(long column, CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_CGRect(base.Handle, selDrawTitleOfColumnInRect_Handle, column, aRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_CGRect(base.SuperHandle, selDrawTitleOfColumnInRect_Handle, column, aRect);
		}
	}

	[Export("frameOfColumn:")]
	public virtual CGRect ColumnFrame(long column)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_Int64(out retval, base.Handle, selFrameOfColumn_Handle, column);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_Int64(out retval, base.SuperHandle, selFrameOfColumn_Handle, column);
		}
		return retval;
	}

	[Export("frameOfInsideOfColumn:")]
	public virtual CGRect ColumnInsideFrame(long column)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_Int64(out retval, base.Handle, selFrameOfInsideOfColumn_Handle, column);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_Int64(out retval, base.SuperHandle, selFrameOfInsideOfColumn_Handle, column);
		}
		return retval;
	}

	[Export("frameOfRow:inColumn:")]
	public virtual CGRect RowFrame(long row, long column)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_Int64_Int64(out retval, base.Handle, selFrameOfRowInColumn_Handle, row, column);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_Int64_Int64(out retval, base.SuperHandle, selFrameOfRowInColumn_Handle, row, column);
		}
		return retval;
	}

	[Export("getRow:column:forPoint:")]
	public virtual bool GetRowColumnForPoint(out long row, out long column, CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_out_Int64_out_Int64_CGPoint(base.Handle, selGetRowColumnForPoint_Handle, out row, out column, point);
		}
		return Messaging.bool_objc_msgSendSuper_out_Int64_out_Int64_CGPoint(base.SuperHandle, selGetRowColumnForPoint_Handle, out row, out column, point);
	}

	[Export("columnWidthForColumnContentWidth:")]
	public virtual double ColumnWidthForColumnContentWidth(double columnContentWidth)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Double(base.Handle, selColumnWidthForColumnContentWidth_Handle, columnContentWidth);
		}
		return Messaging.Double_objc_msgSendSuper_Double(base.SuperHandle, selColumnWidthForColumnContentWidth_Handle, columnContentWidth);
	}

	[Export("columnContentWidthForColumnWidth:")]
	public virtual double ColumnContentWidthForColumnWidth(double columnWidth)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Double(base.Handle, selColumnContentWidthForColumnWidth_Handle, columnWidth);
		}
		return Messaging.Double_objc_msgSendSuper_Double(base.SuperHandle, selColumnContentWidthForColumnWidth_Handle, columnWidth);
	}

	[Export("setColumnResizingType:")]
	public virtual void SetColumnResizingType(NSBrowserColumnResizingType columnResizingType)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selSetColumnResizingType_Handle, (ulong)columnResizingType);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetColumnResizingType_Handle, (ulong)columnResizingType);
		}
	}

	[Export("setWidth:ofColumn:")]
	public virtual void SetColumnWidth(double columnWidth, long columnIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_Int64(base.Handle, selSetWidthOfColumn_Handle, columnWidth, columnIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_Int64(base.SuperHandle, selSetWidthOfColumn_Handle, columnWidth, columnIndex);
		}
	}

	[Export("widthOfColumn:")]
	public virtual double GetColumnWidth(long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Int64(base.Handle, selWidthOfColumn_Handle, column);
		}
		return Messaging.Double_objc_msgSendSuper_Int64(base.SuperHandle, selWidthOfColumn_Handle, column);
	}

	[Export("noteHeightOfRowsWithIndexesChanged:inColumn:")]
	public virtual void NoteHeightOfRows(NSIndexSet indexSet, long columnIndex)
	{
		NSApplication.EnsureUIThread();
		if (indexSet == null)
		{
			throw new ArgumentNullException("indexSet");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selNoteHeightOfRowsWithIndexesChangedInColumn_Handle, indexSet.Handle, columnIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selNoteHeightOfRowsWithIndexesChangedInColumn_Handle, indexSet.Handle, columnIndex);
		}
	}

	[Export("removeSavedColumnsWithAutosaveName:")]
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

	[Export("canDragRowsWithIndexes:inColumn:withEvent:")]
	public virtual bool CanDragRowsWithIndexes(NSIndexSet rowIndexes, long column, NSEvent theEvent)
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
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_Int64_IntPtr(base.Handle, selCanDragRowsWithIndexesInColumnWithEvent_Handle, rowIndexes.Handle, column, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_Int64_IntPtr(base.SuperHandle, selCanDragRowsWithIndexesInColumnWithEvent_Handle, rowIndexes.Handle, column, theEvent.Handle);
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

	[Export("editItemAtIndexPath:withEvent:select:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, selEditItemAtIndexPathWithEventSelect_Handle, indexPath.Handle, theEvent.Handle, select);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool(base.SuperHandle, selEditItemAtIndexPathWithEventSelect_Handle, indexPath.Handle, theEvent.Handle, select);
		}
	}

	[Export("setCellClass:")]
	public virtual void SetCellClass(Class factoryId)
	{
		NSApplication.EnsureUIThread();
		if (factoryId == null)
		{
			throw new ArgumentNullException("factoryId");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCellClass_Handle, factoryId.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCellClass_Handle, factoryId.Handle);
		}
	}

	[Export("path")]
	protected virtual string GetPath()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPathHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathHandle));
	}

	[Export("setPath:")]
	protected virtual bool SetPath(string path)
	{
		NSApplication.EnsureUIThread();
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPath_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_SelectionIndexPath_var = null;
			__mt_SelectionIndexPaths_var = null;
			__mt_BackgroundColor_var = null;
			__mt_CellPrototype_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
