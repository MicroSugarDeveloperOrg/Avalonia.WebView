using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public static class NSBrowserDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint RowsInColumn(this INSBrowserDelegate This, NSBrowser sender, nint column)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.nint_objc_msgSend_IntPtr_nint(This.Handle, Selector.GetHandle("browser:numberOfRowsInColumn:"), sender.Handle, column);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CreateRowsForColumn(this INSBrowserDelegate This, NSBrowser sender, nint column, NSMatrix matrix)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (matrix == null)
		{
			throw new ArgumentNullException("matrix");
		}
		Messaging.void_objc_msgSend_IntPtr_nint_IntPtr(This.Handle, Selector.GetHandle("browser:createRowsForColumn:inMatrix:"), sender.Handle, column, matrix.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint CountChildren(this INSBrowserDelegate This, NSBrowser browser, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Messaging.nint_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("browser:numberOfChildrenOfItem:"), browser.Handle, item.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject GetChild(this INSBrowserDelegate This, NSBrowser browser, nint index, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_nint_IntPtr(This.Handle, Selector.GetHandle("browser:child:ofItem:"), browser.Handle, index, item.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsLeafItem(this INSBrowserDelegate This, NSBrowser browser, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("browser:isLeafItem:"), browser.Handle, item.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject ObjectValueForItem(this INSBrowserDelegate This, NSBrowser browser, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("browser:objectValueForItem:"), browser.Handle, item.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat RowHeight(this INSBrowserDelegate This, NSBrowser browser, nint row, nint columnIndex)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		return Messaging.nfloat_objc_msgSend_IntPtr_nint_nint(This.Handle, Selector.GetHandle("browser:heightOfRow:inColumn:"), browser.Handle, row, columnIndex);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject RootItemForBrowser(this INSBrowserDelegate This, NSBrowser browser)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("rootItemForBrowser:"), browser.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetObjectValue(this INSBrowserDelegate This, NSBrowser browser, NSObject obj, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("browser:setObjectValue:forItem:"), browser.Handle, obj.Handle, item.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldEditItem(this INSBrowserDelegate This, NSBrowser browser, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("browser:shouldEditItem:"), browser.Handle, item.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillDisplayCell(this INSBrowserDelegate This, NSBrowser sender, NSObject cell, nint row, nint column)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_nint_nint(This.Handle, Selector.GetHandle("browser:willDisplayCell:atRow:column:"), sender.Handle, cell.Handle, row, column);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string ColumnTitle(this INSBrowserDelegate This, NSBrowser sender, nint column)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nint(This.Handle, Selector.GetHandle("browser:titleOfColumn:"), sender.Handle, column));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool SelectCellWithString(this INSBrowserDelegate This, NSBrowser sender, string title, nint column)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr intPtr = NSString.CreateNative(title);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("browser:selectCellWithString:inColumn:"), sender.Handle, intPtr, column);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool SelectRowInColumn(this INSBrowserDelegate This, NSBrowser sender, nint row, nint column)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.bool_objc_msgSend_IntPtr_nint_nint(This.Handle, Selector.GetHandle("browser:selectRow:inColumn:"), sender.Handle, row, column);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsColumnValid(this INSBrowserDelegate This, NSBrowser sender, nint column)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.bool_objc_msgSend_IntPtr_nint(This.Handle, Selector.GetHandle("browser:isColumnValid:"), sender.Handle, column);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillScroll(this INSBrowserDelegate This, NSBrowser sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("browserWillScroll:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidScroll(this INSBrowserDelegate This, NSBrowser sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("browserDidScroll:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat ShouldSizeColumn(this INSBrowserDelegate This, NSBrowser browser, nint columnIndex, bool userResize, nfloat suggestedWidth)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		return Messaging.nfloat_objc_msgSend_IntPtr_nint_bool_nfloat(This.Handle, Selector.GetHandle("browser:shouldSizeColumn:forUserResize:toWidth:"), browser.Handle, columnIndex, userResize, suggestedWidth);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat SizeToFitWidth(this INSBrowserDelegate This, NSBrowser browser, nint columnIndex)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		return Messaging.nfloat_objc_msgSend_IntPtr_nint(This.Handle, Selector.GetHandle("browser:sizeToFitWidthOfColumn:"), browser.Handle, columnIndex);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ColumnConfigurationDidChange(this INSBrowserDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("browserColumnConfigurationDidChange:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldShowCellExpansion(this INSBrowserDelegate This, NSBrowser browser, nint row, nint column)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		return Messaging.bool_objc_msgSend_IntPtr_nint_nint(This.Handle, Selector.GetHandle("browser:shouldShowCellExpansionForRow:column:"), browser.Handle, row, column);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WriteRowsWithIndexesToPasteboard(this INSBrowserDelegate This, NSBrowser browser, NSIndexSet rowIndexes, nint column, NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (rowIndexes == null)
		{
			throw new ArgumentNullException("rowIndexes");
		}
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_nint_IntPtr(This.Handle, Selector.GetHandle("browser:writeRowsWithIndexes:inColumn:toPasteboard:"), browser.Handle, rowIndexes.Handle, column, pasteboard.Handle);
	}

	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSFilePromiseReceiver' objects instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] PromisedFilesDroppedAtDestination(this INSBrowserDelegate This, NSBrowser browser, NSUrl dropDestination, NSIndexSet rowIndexes, nint column)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (dropDestination == null)
		{
			throw new ArgumentNullException("dropDestination");
		}
		if (rowIndexes == null)
		{
			throw new ArgumentNullException("rowIndexes");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("browser:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:inColumn:"), browser.Handle, dropDestination.Handle, rowIndexes.Handle, column));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CanDragRowsWithIndexes(this INSBrowserDelegate This, NSBrowser browser, NSIndexSet rowIndexes, nint column, NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (rowIndexes == null)
		{
			throw new ArgumentNullException("rowIndexes");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_nint_IntPtr(This.Handle, Selector.GetHandle("browser:canDragRowsWithIndexes:inColumn:withEvent:"), browser.Handle, rowIndexes.Handle, column, theEvent.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDragOperation ValidateDrop(this INSBrowserDelegate This, NSBrowser browser, NSDraggingInfo info, ref nint row, ref nint column, ref NSBrowserDropOperation dropOperation)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSend_IntPtr_IntPtr_ref_nint_ref_nint_ref_NSBrowserDropOperation(This.Handle, Selector.GetHandle("browser:validateDrop:proposedRow:column:dropOperation:"), browser.Handle, info.Handle, ref row, ref column, ref dropOperation);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool AcceptDrop(this INSBrowserDelegate This, NSBrowser browser, NSDraggingInfo info, nint row, nint column, NSBrowserDropOperation dropOperation)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_nint_nint_UInt64(This.Handle, Selector.GetHandle("browser:acceptDrop:atRow:column:dropOperation:"), browser.Handle, info.Handle, row, column, (ulong)dropOperation);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string? TypeSelectString(this INSBrowserDelegate This, NSBrowser browser, nint row, nint column)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nint_nint(This.Handle, Selector.GetHandle("browser:typeSelectStringForRow:inColumn:"), browser.Handle, row, column));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldTypeSelectForEvent(this INSBrowserDelegate This, NSBrowser browser, NSEvent theEvent, string currentSearchString)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (currentSearchString == null)
		{
			throw new ArgumentNullException("currentSearchString");
		}
		IntPtr intPtr = NSString.CreateNative(currentSearchString);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("browser:shouldTypeSelectForEvent:withCurrentSearchString:"), browser.Handle, theEvent.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint NextTypeSelectMatch(this INSBrowserDelegate This, NSBrowser browser, nint startRow, nint endRow, nint column, string searchString)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (searchString == null)
		{
			throw new ArgumentNullException("searchString");
		}
		IntPtr intPtr = NSString.CreateNative(searchString);
		nint result = Messaging.nint_objc_msgSend_IntPtr_nint_nint_nint_IntPtr(This.Handle, Selector.GetHandle("browser:nextTypeSelectMatchFromRow:toRow:inColumn:forString:"), browser.Handle, startRow, endRow, column, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSViewController PreviewViewControllerForLeafItem(this INSBrowserDelegate This, NSBrowser browser, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("browser:previewViewControllerForLeafItem:"), browser.Handle, item.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSViewController HeaderViewControllerForItem(this INSBrowserDelegate This, NSBrowser browser, NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("browser:headerViewControllerForItem:"), browser.Handle, item.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidChangeLastColumn(this INSBrowserDelegate This, NSBrowser browser, nint oldLastColumn, nint toColumn)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		Messaging.void_objc_msgSend_IntPtr_nint_nint(This.Handle, Selector.GetHandle("browser:didChangeLastColumn:toColumn:"), browser.Handle, oldLastColumn, toColumn);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSIndexSet SelectionIndexesForProposedSelection(this INSBrowserDelegate This, NSBrowser browser, NSIndexSet proposedSelectionIndexes, nint inColumn)
	{
		NSApplication.EnsureUIThread();
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (proposedSelectionIndexes == null)
		{
			throw new ArgumentNullException("proposedSelectionIndexes");
		}
		return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("browser:selectionIndexesForProposedSelection:inColumn:"), browser.Handle, proposedSelectionIndexes.Handle, inColumn));
	}
}
