using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public static class NSOutlineViewDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillDisplayCell(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject cell, NSTableColumn? tableColumn, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:willDisplayCell:forTableColumn:item:"), outlineView.Handle, cell.Handle, tableColumn?.Handle ?? IntPtr.Zero, item.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldEditTableColumn(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:shouldEditTableColumn:item:"), outlineView.Handle, tableColumn?.Handle ?? IntPtr.Zero, item.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool SelectionShouldChange(this INSOutlineViewDelegate This, NSOutlineView outlineView)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("selectionShouldChangeInOutlineView:"), outlineView.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldSelectItem(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:shouldSelectItem:"), outlineView.Handle, item.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSIndexSet GetSelectionIndexes(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSIndexSet proposedSelectionIndexes)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (proposedSelectionIndexes == null)
		{
			throw new ArgumentNullException("proposedSelectionIndexes");
		}
		return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:selectionIndexesForProposedSelection:"), outlineView.Handle, proposedSelectionIndexes.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldSelectTableColumn(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn? tableColumn)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:shouldSelectTableColumn:"), outlineView.Handle, tableColumn?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MouseDown(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn tableColumn)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:mouseDownInHeaderOfTableColumn:"), outlineView.Handle, tableColumn.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidClickTableColumn(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn tableColumn)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:didClickTableColumn:"), outlineView.Handle, tableColumn.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidDragTableColumn(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn tableColumn)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:didDragTableColumn:"), outlineView.Handle, tableColumn.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string ToolTipForCell(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSCell cell, ref CGRect rect, NSTableColumn? tableColumn, NSObject item, CGPoint mouseLocation)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_CGRect_IntPtr_IntPtr_CGPoint(This.Handle, Selector.GetHandle("outlineView:toolTipForCell:rect:tableColumn:item:mouseLocation:"), outlineView.Handle, cell.Handle, ref rect, tableColumn?.Handle ?? IntPtr.Zero, item.Handle, mouseLocation));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat GetRowHeight(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Messaging.nfloat_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:heightOfRowByItem:"), outlineView.Handle, item.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetSelectString(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:typeSelectStringForTableColumn:item:"), outlineView.Handle, tableColumn?.Handle ?? IntPtr.Zero, item.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject GetNextTypeSelectMatch(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject startItem, NSObject endItem, string searchString)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (startItem == null)
		{
			throw new ArgumentNullException("startItem");
		}
		if (endItem == null)
		{
			throw new ArgumentNullException("endItem");
		}
		if (searchString == null)
		{
			throw new ArgumentNullException("searchString");
		}
		IntPtr intPtr = NSString.CreateNative(searchString);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:nextTypeSelectMatchFromItem:toItem:forString:"), outlineView.Handle, startItem.Handle, endItem.Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldTypeSelect(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSEvent theEvent, string? searchString)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		IntPtr intPtr = NSString.CreateNative(searchString);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:shouldTypeSelectForEvent:withCurrentSearchString:"), outlineView.Handle, theEvent.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldShowCellExpansion(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:shouldShowCellExpansionForTableColumn:item:"), outlineView.Handle, tableColumn?.Handle ?? IntPtr.Zero, item.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldTrackCell(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSCell cell, NSTableColumn? tableColumn, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:shouldTrackCell:forTableColumn:item:"), outlineView.Handle, cell.Handle, tableColumn?.Handle ?? IntPtr.Zero, item.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCell GetCell(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn tableColumn, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (tableColumn == null)
		{
			throw new ArgumentNullException("tableColumn");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Runtime.GetNSObject<NSCell>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:dataCellForTableColumn:item:"), outlineView.Handle, tableColumn.Handle, item.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSView GetView(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:viewForTableColumn:item:"), outlineView.Handle, tableColumn?.Handle ?? IntPtr.Zero, item.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsGroupItem(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:isGroupItem:"), outlineView.Handle, item.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldExpandItem(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:shouldExpandItem:"), outlineView.Handle, item.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldCollapseItem(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:shouldCollapseItem:"), outlineView.Handle, item.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillDisplayOutlineCell(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject cell, NSTableColumn? tableColumn, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:willDisplayOutlineCell:forTableColumn:item:"), outlineView.Handle, cell.Handle, tableColumn?.Handle ?? IntPtr.Zero, item.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat GetSizeToFitColumnWidth(this INSOutlineViewDelegate This, NSOutlineView outlineView, nint column)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		return Messaging.nfloat_objc_msgSend_IntPtr_nint(This.Handle, Selector.GetHandle("outlineView:sizeToFitWidthOfColumn:"), outlineView.Handle, column);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldReorder(this INSOutlineViewDelegate This, NSOutlineView outlineView, nint columnIndex, nint newColumnIndex)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		return Messaging.bool_objc_msgSend_IntPtr_nint_nint(This.Handle, Selector.GetHandle("outlineView:shouldReorderColumn:toColumn:"), outlineView.Handle, columnIndex, newColumnIndex);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldShowOutlineCell(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:shouldShowOutlineCellForItem:"), outlineView.Handle, item.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ColumnDidMove(this INSOutlineViewDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("outlineViewColumnDidMove:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ColumnDidResize(this INSOutlineViewDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("outlineViewColumnDidResize:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SelectionIsChanging(this INSOutlineViewDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("outlineViewSelectionIsChanging:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ItemWillExpand(this INSOutlineViewDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("outlineViewItemWillExpand:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ItemDidExpand(this INSOutlineViewDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("outlineViewItemDidExpand:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ItemWillCollapse(this INSOutlineViewDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("outlineViewItemWillCollapse:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ItemDidCollapse(this INSOutlineViewDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("outlineViewItemDidCollapse:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SelectionDidChange(this INSOutlineViewDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("outlineViewSelectionDidChange:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTableRowView RowViewForItem(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Runtime.GetNSObject<NSTableRowView>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("outlineView:rowViewForItem:"), outlineView.Handle, item.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidAddRowView(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableRowView rowView, nint row)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (rowView == null)
		{
			throw new ArgumentNullException("rowView");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("outlineView:didAddRowView:forRow:"), outlineView.Handle, rowView.Handle, row);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidRemoveRowView(this INSOutlineViewDelegate This, NSOutlineView outlineView, NSTableRowView rowView, nint row)
	{
		NSApplication.EnsureUIThread();
		if (outlineView == null)
		{
			throw new ArgumentNullException("outlineView");
		}
		if (rowView == null)
		{
			throw new ArgumentNullException("rowView");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("outlineView:didRemoveRowView:forRow:"), outlineView.Handle, rowView.Handle, row);
	}
}
