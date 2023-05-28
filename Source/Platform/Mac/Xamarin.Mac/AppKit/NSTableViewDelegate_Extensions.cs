using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public static class NSTableViewDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillDisplayCell(this INSTableViewDelegate This, NSTableView tableView, NSObject cell, NSTableColumn tableColumn, nint row)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("tableView:willDisplayCell:forTableColumn:row:"), tableView.Handle, cell.Handle, tableColumn.Handle, row);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldEditTableColumn(this INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn, nint row)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("tableView:shouldEditTableColumn:row:"), tableView.Handle, tableColumn.Handle, row);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool SelectionShouldChange(this INSTableViewDelegate This, NSTableView tableView)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("selectionShouldChangeInTableView:"), tableView.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldSelectRow(this INSTableViewDelegate This, NSTableView tableView, nint row)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		return Messaging.bool_objc_msgSend_IntPtr_nint(This.Handle, Selector.GetHandle("tableView:shouldSelectRow:"), tableView.Handle, row);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSIndexSet GetSelectionIndexes(this INSTableViewDelegate This, NSTableView tableView, NSIndexSet proposedSelectionIndexes)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (proposedSelectionIndexes == null)
		{
			throw new ArgumentNullException("proposedSelectionIndexes");
		}
		return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tableView:selectionIndexesForProposedSelection:"), tableView.Handle, proposedSelectionIndexes.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldSelectTableColumn(this INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tableView:shouldSelectTableColumn:"), tableView.Handle, tableColumn.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MouseDownInHeaderOfTableColumn(this INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tableView:mouseDownInHeaderOfTableColumn:"), tableView.Handle, tableColumn.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidClickTableColumn(this INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tableView:didClickTableColumn:"), tableView.Handle, tableColumn.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidDragTableColumn(this INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tableView:didDragTableColumn:"), tableView.Handle, tableColumn.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat GetRowHeight(this INSTableViewDelegate This, NSTableView tableView, nint row)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		return Messaging.nfloat_objc_msgSend_IntPtr_nint(This.Handle, Selector.GetHandle("tableView:heightOfRow:"), tableView.Handle, row);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetSelectString(this INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn, nint row)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("tableView:typeSelectStringForTableColumn:row:"), tableView.Handle, tableColumn.Handle, row));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint GetNextTypeSelectMatch(this INSTableViewDelegate This, NSTableView tableView, nint startRow, nint endRow, string searchString)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (searchString == null)
		{
			throw new ArgumentNullException("searchString");
		}
		IntPtr intPtr = NSString.CreateNative(searchString);
		nint result = Messaging.nint_objc_msgSend_IntPtr_nint_nint_IntPtr(This.Handle, Selector.GetHandle("tableView:nextTypeSelectMatchFromRow:toRow:forString:"), tableView.Handle, startRow, endRow, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldTypeSelect(this INSTableViewDelegate This, NSTableView tableView, NSEvent theEvent, string searchString)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (searchString == null)
		{
			throw new ArgumentNullException("searchString");
		}
		IntPtr intPtr = NSString.CreateNative(searchString);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tableView:shouldTypeSelectForEvent:withCurrentSearchString:"), tableView.Handle, theEvent.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldShowCellExpansion(this INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn, nint row)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("tableView:shouldShowCellExpansionForTableColumn:row:"), tableView.Handle, tableColumn.Handle, row);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldTrackCell(this INSTableViewDelegate This, NSTableView tableView, NSCell cell, NSTableColumn tableColumn, nint row)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("tableView:shouldTrackCell:forTableColumn:row:"), tableView.Handle, cell.Handle, tableColumn.Handle, row);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCell GetDataCell(this INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn, nint row)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		return Runtime.GetNSObject<NSCell>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("tableView:dataCellForTableColumn:row:"), tableView.Handle, tableColumn.Handle, row));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsGroupRow(this INSTableViewDelegate This, NSTableView tableView, nint row)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		return Messaging.bool_objc_msgSend_IntPtr_nint(This.Handle, Selector.GetHandle("tableView:isGroupRow:"), tableView.Handle, row);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat GetSizeToFitColumnWidth(this INSTableViewDelegate This, NSTableView tableView, nint column)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		return Messaging.nfloat_objc_msgSend_IntPtr_nint(This.Handle, Selector.GetHandle("tableView:sizeToFitWidthOfColumn:"), tableView.Handle, column);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldReorder(this INSTableViewDelegate This, NSTableView tableView, nint columnIndex, nint newColumnIndex)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		return Messaging.bool_objc_msgSend_IntPtr_nint_nint(This.Handle, Selector.GetHandle("tableView:shouldReorderColumn:toColumn:"), tableView.Handle, columnIndex, newColumnIndex);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SelectionDidChange(this INSTableViewDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("tableViewSelectionDidChange:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ColumnDidMove(this INSTableViewDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("tableViewColumnDidMove:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ColumnDidResize(this INSTableViewDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("tableViewColumnDidResize:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SelectionIsChanging(this INSTableViewDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("tableViewSelectionIsChanging:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSView GetViewForItem(this INSTableViewDelegate This, NSTableView tableView, NSTableColumn tableColumn, nint row)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("tableView:viewForTableColumn:row:"), tableView.Handle, tableColumn.Handle, row));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTableRowView CoreGetRowView(this INSTableViewDelegate This, NSTableView tableView, nint row)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		return Runtime.GetNSObject<NSTableRowView>(Messaging.IntPtr_objc_msgSend_IntPtr_nint(This.Handle, Selector.GetHandle("tableView:rowViewForRow:"), tableView.Handle, row));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidAddRowView(this INSTableViewDelegate This, NSTableView tableView, NSTableRowView rowView, nint row)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (rowView == null)
		{
			throw new ArgumentNullException("rowView");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("tableView:didAddRowView:forRow:"), tableView.Handle, rowView.Handle, row);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidRemoveRowView(this INSTableViewDelegate This, NSTableView tableView, NSTableRowView rowView, nint row)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (rowView == null)
		{
			throw new ArgumentNullException("rowView");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("tableView:didRemoveRowView:forRow:"), tableView.Handle, rowView.Handle, row);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTableViewRowAction[] RowActions(this INSTableViewDelegate This, NSTableView tableView, nint row, NSTableRowActionEdge edge)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		return NSArray.ArrayFromHandle<NSTableViewRowAction>(Messaging.IntPtr_objc_msgSend_IntPtr_nint_Int64(This.Handle, Selector.GetHandle("tableView:rowActionsForRow:edge:"), tableView.Handle, row, (long)edge));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString GetToolTip(this INSTableViewDelegate This, NSTableView tableView, NSCell cell, ref CGRect rect, NSTableColumn? tableColumn, nint row, CGPoint mouseLocation)
	{
		NSApplication.EnsureUIThread();
		if (tableView == null)
		{
			throw new ArgumentNullException("tableView");
		}
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_CGRect_IntPtr_nint_CGPoint(This.Handle, Selector.GetHandle("tableView:toolTipForCell:rect:tableColumn:row:mouseLocation:"), tableView.Handle, cell.Handle, ref rect, tableColumn?.Handle ?? IntPtr.Zero, row, mouseLocation));
	}
}
