using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSGridView", true)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class NSGridView : NSView
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddColumnWithViews_ = "addColumnWithViews:";

	private static readonly IntPtr selAddColumnWithViews_Handle = Selector.GetHandle("addColumnWithViews:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRowWithViews_ = "addRowWithViews:";

	private static readonly IntPtr selAddRowWithViews_Handle = Selector.GetHandle("addRowWithViews:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellAtColumnIndex_RowIndex_ = "cellAtColumnIndex:rowIndex:";

	private static readonly IntPtr selCellAtColumnIndex_RowIndex_Handle = Selector.GetHandle("cellAtColumnIndex:rowIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellForView_ = "cellForView:";

	private static readonly IntPtr selCellForView_Handle = Selector.GetHandle("cellForView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColumnAtIndex_ = "columnAtIndex:";

	private static readonly IntPtr selColumnAtIndex_Handle = Selector.GetHandle("columnAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColumnSpacing = "columnSpacing";

	private static readonly IntPtr selColumnSpacingHandle = Selector.GetHandle("columnSpacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGridViewWithNumberOfColumns_Rows_ = "gridViewWithNumberOfColumns:rows:";

	private static readonly IntPtr selGridViewWithNumberOfColumns_Rows_Handle = Selector.GetHandle("gridViewWithNumberOfColumns:rows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGridViewWithViews_ = "gridViewWithViews:";

	private static readonly IntPtr selGridViewWithViews_Handle = Selector.GetHandle("gridViewWithViews:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfColumn_ = "indexOfColumn:";

	private static readonly IntPtr selIndexOfColumn_Handle = Selector.GetHandle("indexOfColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfRow_ = "indexOfRow:";

	private static readonly IntPtr selIndexOfRow_Handle = Selector.GetHandle("indexOfRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertColumnAtIndex_WithViews_ = "insertColumnAtIndex:withViews:";

	private static readonly IntPtr selInsertColumnAtIndex_WithViews_Handle = Selector.GetHandle("insertColumnAtIndex:withViews:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertRowAtIndex_WithViews_ = "insertRowAtIndex:withViews:";

	private static readonly IntPtr selInsertRowAtIndex_WithViews_Handle = Selector.GetHandle("insertRowAtIndex:withViews:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMergeCellsInHorizontalRange_VerticalRange_ = "mergeCellsInHorizontalRange:verticalRange:";

	private static readonly IntPtr selMergeCellsInHorizontalRange_VerticalRange_Handle = Selector.GetHandle("mergeCellsInHorizontalRange:verticalRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveColumnAtIndex_ToIndex_ = "moveColumnAtIndex:toIndex:";

	private static readonly IntPtr selMoveColumnAtIndex_ToIndex_Handle = Selector.GetHandle("moveColumnAtIndex:toIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveRowAtIndex_ToIndex_ = "moveRowAtIndex:toIndex:";

	private static readonly IntPtr selMoveRowAtIndex_ToIndex_Handle = Selector.GetHandle("moveRowAtIndex:toIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfColumns = "numberOfColumns";

	private static readonly IntPtr selNumberOfColumnsHandle = Selector.GetHandle("numberOfColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfRows = "numberOfRows";

	private static readonly IntPtr selNumberOfRowsHandle = Selector.GetHandle("numberOfRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveColumnAtIndex_ = "removeColumnAtIndex:";

	private static readonly IntPtr selRemoveColumnAtIndex_Handle = Selector.GetHandle("removeColumnAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveRowAtIndex_ = "removeRowAtIndex:";

	private static readonly IntPtr selRemoveRowAtIndex_Handle = Selector.GetHandle("removeRowAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowAlignment = "rowAlignment";

	private static readonly IntPtr selRowAlignmentHandle = Selector.GetHandle("rowAlignment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowAtIndex_ = "rowAtIndex:";

	private static readonly IntPtr selRowAtIndex_Handle = Selector.GetHandle("rowAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowSpacing = "rowSpacing";

	private static readonly IntPtr selRowSpacingHandle = Selector.GetHandle("rowSpacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColumnSpacing_ = "setColumnSpacing:";

	private static readonly IntPtr selSetColumnSpacing_Handle = Selector.GetHandle("setColumnSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRowAlignment_ = "setRowAlignment:";

	private static readonly IntPtr selSetRowAlignment_Handle = Selector.GetHandle("setRowAlignment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRowSpacing_ = "setRowSpacing:";

	private static readonly IntPtr selSetRowSpacing_Handle = Selector.GetHandle("setRowSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetXPlacement_ = "setXPlacement:";

	private static readonly IntPtr selSetXPlacement_Handle = Selector.GetHandle("setXPlacement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetYPlacement_ = "setYPlacement:";

	private static readonly IntPtr selSetYPlacement_Handle = Selector.GetHandle("setYPlacement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selXPlacement = "xPlacement";

	private static readonly IntPtr selXPlacementHandle = Selector.GetHandle("xPlacement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYPlacement = "yPlacement";

	private static readonly IntPtr selYPlacementHandle = Selector.GetHandle("yPlacement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSGridView");

	public override IntPtr ClassHandle => class_ptr;

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
	public virtual nfloat ColumnSpacing
	{
		[Export("columnSpacing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selColumnSpacingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selColumnSpacingHandle);
		}
		[Export("setColumnSpacing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetColumnSpacing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetColumnSpacing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGridRowAlignment RowAlignment
	{
		[Export("rowAlignment", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSGridRowAlignment)Messaging.Int64_objc_msgSend(base.Handle, selRowAlignmentHandle);
			}
			return (NSGridRowAlignment)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRowAlignmentHandle);
		}
		[Export("setRowAlignment:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetRowAlignment_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetRowAlignment_Handle, (long)value);
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
	public virtual nfloat RowSpacing
	{
		[Export("rowSpacing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selRowSpacingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selRowSpacingHandle);
		}
		[Export("setRowSpacing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetRowSpacing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetRowSpacing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGridCellPlacement X
	{
		[Export("xPlacement", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSGridCellPlacement)Messaging.Int64_objc_msgSend(base.Handle, selXPlacementHandle);
			}
			return (NSGridCellPlacement)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selXPlacementHandle);
		}
		[Export("setXPlacement:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetXPlacement_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetXPlacement_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGridCellPlacement Y
	{
		[Export("yPlacement", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSGridCellPlacement)Messaging.Int64_objc_msgSend(base.Handle, selYPlacementHandle);
			}
			return (NSGridCellPlacement)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selYPlacementHandle);
		}
		[Export("setYPlacement:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetYPlacement_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetYPlacement_Handle, (long)value);
			}
		}
	}

	[Field("NSGridViewSizeForContent", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static nfloat SizeForContent
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetNFloat(Libraries.AppKit.Handle, "NSGridViewSizeForContent");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSGridView()
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
	public NSGridView(NSCoder coder)
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
	protected NSGridView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSGridView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSGridView(CGRect frameRect)
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

	[Export("addColumnWithViews:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGridColumn AddColumn(NSView[] views)
	{
		NSApplication.EnsureUIThread();
		if (views == null)
		{
			throw new ArgumentNullException("views");
		}
		NSArray nSArray = NSArray.FromNSObjects(views);
		NSGridColumn result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSGridColumn>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddColumnWithViews_Handle, nSArray.Handle)) : Runtime.GetNSObject<NSGridColumn>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAddColumnWithViews_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("addRowWithViews:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGridRow AddRow(NSView[] views)
	{
		NSApplication.EnsureUIThread();
		if (views == null)
		{
			throw new ArgumentNullException("views");
		}
		NSArray nSArray = NSArray.FromNSObjects(views);
		NSGridRow result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSGridRow>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddRowWithViews_Handle, nSArray.Handle)) : Runtime.GetNSObject<NSGridRow>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAddRowWithViews_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("gridViewWithNumberOfColumns:rows:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSGridView Create(nint columnCount, nint rowCount)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSGridView>(Messaging.IntPtr_objc_msgSend_nint_nint(class_ptr, selGridViewWithNumberOfColumns_Rows_Handle, columnCount, rowCount));
	}

	[Export("gridViewWithViews:")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("You should use either 'NSGridView.Create(NSView [][] rowsAndColumns)' or 'NSGridView.Create(NSView [,] rowsAndColumns)'.", false)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSGridView Create(NSView[] rows)
	{
		NSApplication.EnsureUIThread();
		if (rows == null)
		{
			throw new ArgumentNullException("rows");
		}
		NSArray nSArray = NSArray.FromNSObjects(rows);
		NSGridView nSObject = Runtime.GetNSObject<NSGridView>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selGridViewWithViews_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("gridViewWithViews:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSGridView Create(NSView[][] rowsAndColumns)
	{
		NSApplication.EnsureUIThread();
		if (rowsAndColumns == null)
		{
			throw new ArgumentNullException("rowsAndColumns");
		}
		NSArray nSArray = NSArray.FromNSObjects(rowsAndColumns);
		NSGridView nSObject = Runtime.GetNSObject<NSGridView>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selGridViewWithViews_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("gridViewWithViews:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSGridView Create(NSView[,] rowsAndColumns)
	{
		NSApplication.EnsureUIThread();
		if (rowsAndColumns == null)
		{
			throw new ArgumentNullException("rowsAndColumns");
		}
		NSArray nSArray = NSArray.FromNSObjects(rowsAndColumns);
		NSGridView nSObject = Runtime.GetNSObject<NSGridView>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selGridViewWithViews_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("cellAtColumnIndex:rowIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGridCell GetCell(nint columnIndex, nint rowIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSGridCell>(Messaging.IntPtr_objc_msgSend_nint_nint(base.Handle, selCellAtColumnIndex_RowIndex_Handle, columnIndex, rowIndex));
		}
		return Runtime.GetNSObject<NSGridCell>(Messaging.IntPtr_objc_msgSendSuper_nint_nint(base.SuperHandle, selCellAtColumnIndex_RowIndex_Handle, columnIndex, rowIndex));
	}

	[Export("cellForView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGridCell? GetCell(NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSGridCell>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCellForView_Handle, view.Handle));
		}
		return Runtime.GetNSObject<NSGridCell>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCellForView_Handle, view.Handle));
	}

	[Export("columnAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGridColumn GetColumn(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSGridColumn>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selColumnAtIndex_Handle, index));
		}
		return Runtime.GetNSObject<NSGridColumn>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selColumnAtIndex_Handle, index));
	}

	[Export("indexOfRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetIndex(NSGridRow row)
	{
		NSApplication.EnsureUIThread();
		if (row == null)
		{
			throw new ArgumentNullException("row");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIndexOfRow_Handle, row.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfRow_Handle, row.Handle);
	}

	[Export("indexOfColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetIndex(NSGridColumn column)
	{
		NSApplication.EnsureUIThread();
		if (column == null)
		{
			throw new ArgumentNullException("column");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIndexOfColumn_Handle, column.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfColumn_Handle, column.Handle);
	}

	[Export("rowAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGridRow GetRow(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSGridRow>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selRowAtIndex_Handle, index));
		}
		return Runtime.GetNSObject<NSGridRow>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selRowAtIndex_Handle, index));
	}

	[Export("insertColumnAtIndex:withViews:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGridColumn InsertColumn(nint index, NSView[] views)
	{
		NSApplication.EnsureUIThread();
		if (views == null)
		{
			throw new ArgumentNullException("views");
		}
		NSArray nSArray = NSArray.FromNSObjects(views);
		NSGridColumn result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSGridColumn>(Messaging.IntPtr_objc_msgSendSuper_nint_IntPtr(base.SuperHandle, selInsertColumnAtIndex_WithViews_Handle, index, nSArray.Handle)) : Runtime.GetNSObject<NSGridColumn>(Messaging.IntPtr_objc_msgSend_nint_IntPtr(base.Handle, selInsertColumnAtIndex_WithViews_Handle, index, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("insertRowAtIndex:withViews:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGridRow InsertRow(nint index, NSView[] views)
	{
		NSApplication.EnsureUIThread();
		if (views == null)
		{
			throw new ArgumentNullException("views");
		}
		NSArray nSArray = NSArray.FromNSObjects(views);
		NSGridRow result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSGridRow>(Messaging.IntPtr_objc_msgSendSuper_nint_IntPtr(base.SuperHandle, selInsertRowAtIndex_WithViews_Handle, index, nSArray.Handle)) : Runtime.GetNSObject<NSGridRow>(Messaging.IntPtr_objc_msgSend_nint_IntPtr(base.Handle, selInsertRowAtIndex_WithViews_Handle, index, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("mergeCellsInHorizontalRange:verticalRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MergeCells(NSRange hRange, NSRange vRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_NSRange(base.Handle, selMergeCellsInHorizontalRange_VerticalRange_Handle, hRange, vRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_NSRange(base.SuperHandle, selMergeCellsInHorizontalRange_VerticalRange_Handle, hRange, vRange);
		}
	}

	[Export("moveColumnAtIndex:toIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveColumn(nint fromIndex, nint toIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint(base.Handle, selMoveColumnAtIndex_ToIndex_Handle, fromIndex, toIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint(base.SuperHandle, selMoveColumnAtIndex_ToIndex_Handle, fromIndex, toIndex);
		}
	}

	[Export("moveRowAtIndex:toIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveRow(nint fromIndex, nint toIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint(base.Handle, selMoveRowAtIndex_ToIndex_Handle, fromIndex, toIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint(base.SuperHandle, selMoveRowAtIndex_ToIndex_Handle, fromIndex, toIndex);
		}
	}

	[Export("removeColumnAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveColumn(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selRemoveColumnAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selRemoveColumnAtIndex_Handle, index);
		}
	}

	[Export("removeRowAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveRow(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selRemoveRowAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selRemoveRowAtIndex_Handle, index);
		}
	}
}
