using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSBrowserDelegate", false)]
[Model]
public class NSBrowserDelegate : NSObject, INSBrowserDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSBrowserDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSBrowserDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSBrowserDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("browser:acceptDrop:atRow:column:dropOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AcceptDrop(NSBrowser browser, NSDraggingInfo info, nint row, nint column, NSBrowserDropOperation dropOperation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:canDragRowsWithIndexes:inColumn:withEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanDragRowsWithIndexes(NSBrowser browser, NSIndexSet rowIndexes, nint column, NSEvent theEvent)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browserColumnConfigurationDidChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ColumnConfigurationDidChange(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:titleOfColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ColumnTitle(NSBrowser sender, nint column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:numberOfChildrenOfItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint CountChildren(NSBrowser browser, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:createRowsForColumn:inMatrix:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CreateRowsForColumn(NSBrowser sender, nint column, NSMatrix matrix)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:didChangeLastColumn:toColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeLastColumn(NSBrowser browser, nint oldLastColumn, nint toColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browserDidScroll:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidScroll(NSBrowser sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:child:ofItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetChild(NSBrowser browser, nint index, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:headerViewControllerForItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSViewController HeaderViewControllerForItem(NSBrowser browser, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:isColumnValid:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsColumnValid(NSBrowser sender, nint column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:isLeafItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsLeafItem(NSBrowser browser, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:nextTypeSelectMatchFromRow:toRow:inColumn:forString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint NextTypeSelectMatch(NSBrowser browser, nint startRow, nint endRow, nint column, string searchString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:objectValueForItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ObjectValueForItem(NSBrowser browser, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:previewViewControllerForLeafItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSViewController PreviewViewControllerForLeafItem(NSBrowser browser, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:inColumn:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSFilePromiseReceiver' objects instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] PromisedFilesDroppedAtDestination(NSBrowser browser, NSUrl dropDestination, NSIndexSet rowIndexes, nint column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("rootItemForBrowser:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject RootItemForBrowser(NSBrowser browser)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:heightOfRow:inColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat RowHeight(NSBrowser browser, nint row, nint columnIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:numberOfRowsInColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint RowsInColumn(NSBrowser sender, nint column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:selectCellWithString:inColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SelectCellWithString(NSBrowser sender, string title, nint column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:selectRow:inColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SelectRowInColumn(NSBrowser sender, nint row, nint column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:selectionIndexesForProposedSelection:inColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet SelectionIndexesForProposedSelection(NSBrowser browser, NSIndexSet proposedSelectionIndexes, nint inColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:setObjectValue:forItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetObjectValue(NSBrowser browser, NSObject obj, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:shouldEditItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldEditItem(NSBrowser browser, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:shouldShowCellExpansionForRow:column:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldShowCellExpansion(NSBrowser browser, nint row, nint column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:shouldSizeColumn:forUserResize:toWidth:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ShouldSizeColumn(NSBrowser browser, nint columnIndex, bool userResize, nfloat suggestedWidth)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:shouldTypeSelectForEvent:withCurrentSearchString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldTypeSelectForEvent(NSBrowser browser, NSEvent theEvent, string currentSearchString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:sizeToFitWidthOfColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat SizeToFitWidth(NSBrowser browser, nint columnIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:typeSelectStringForRow:inColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? TypeSelectString(NSBrowser browser, nint row, nint column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:validateDrop:proposedRow:column:dropOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDragOperation ValidateDrop(NSBrowser browser, NSDraggingInfo info, ref nint row, ref nint column, ref NSBrowserDropOperation dropOperation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:willDisplayCell:atRow:column:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillDisplayCell(NSBrowser sender, NSObject cell, nint row, nint column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browserWillScroll:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillScroll(NSBrowser sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:writeRowsWithIndexes:inColumn:toPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteRowsWithIndexesToPasteboard(NSBrowser browser, NSIndexSet rowIndexes, nint column, NSPasteboard pasteboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
