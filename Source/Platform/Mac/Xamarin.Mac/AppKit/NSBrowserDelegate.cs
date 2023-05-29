using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSBrowserDelegate", true)]
[Model]
public class NSBrowserDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSBrowserDelegate()
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
	public NSBrowserDelegate(NSCoder coder)
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
	public NSBrowserDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSBrowserDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("browser:numberOfRowsInColumn:")]
	public virtual long RowsInColumn(NSBrowser sender, long column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:createRowsForColumn:inMatrix:")]
	public virtual void CreateRowsForColumn(NSBrowser sender, long column, NSMatrix matrix)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:numberOfChildrenOfItem:")]
	public virtual long CountChildren(NSBrowser browser, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:child:ofItem:")]
	public virtual NSObject GetChild(NSBrowser browser, long index, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:isLeafItem:")]
	public virtual bool IsLeafItem(NSBrowser browser, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:objectValueForItem:")]
	public virtual NSObject ObjectValueForItem(NSBrowser browser, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:heightOfRow:inColumn:")]
	public virtual double RowHeight(NSBrowser browser, long row, long columnIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("rootItemForBrowser:")]
	public virtual NSObject RootItemForBrowser(NSBrowser browser)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:setObjectValue:forItem:")]
	public virtual void SetObjectValue(NSBrowser browser, NSObject obj, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:shouldEditItem:")]
	public virtual bool ShouldEditItem(NSBrowser browser, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:willDisplayCell:atRow:column:")]
	public virtual void WillDisplayCell(NSBrowser sender, NSObject cell, long row, long column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:titleOfColumn:")]
	public virtual string ColumnTitle(NSBrowser sender, long column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:selectCellWithString:inColumn:")]
	public virtual bool SelectCellWithString(NSBrowser sender, string title, long column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:selectRow:inColumn:")]
	public virtual bool SelectRowInColumn(NSBrowser sender, long row, long column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:isColumnValid:")]
	public virtual bool IsColumnValid(NSBrowser sender, long column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browserWillScroll:")]
	public virtual void WillScroll(NSBrowser sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browserDidScroll:")]
	public virtual void DidScroll(NSBrowser sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:shouldSizeColumn:forUserResize:toWidth:")]
	public virtual double ShouldSizeColumn(NSBrowser browser, long columnIndex, bool userResize, double suggestedWidth)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:sizeToFitWidthOfColumn:")]
	public virtual double SizeToFitWidth(NSBrowser browser, long columnIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browserColumnConfigurationDidChange:")]
	public virtual void ColumnConfigurationDidChange(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:shouldShowCellExpansionForRow:column:")]
	public virtual bool ShouldShowCellExpansion(NSBrowser browser, long row, long column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:writeRowsWithIndexes:inColumn:toPasteboard:")]
	public virtual bool WriteRowsWithIndexesToPasteboard(NSBrowser browser, NSIndexSet rowIndexes, long column, NSPasteboard pasteboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:inColumn:")]
	public virtual string[] PromisedFilesDroppedAtDestination(NSBrowser browser, NSUrl dropDestination, NSIndexSet rowIndexes, long column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:canDragRowsWithIndexes:inColumn:withEvent:")]
	public virtual bool CanDragRowsWithIndexes(NSBrowser browser, NSIndexSet rowIndexes, long column, NSEvent theEvent)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:validateDrop:proposedRow:column:dropOperation:")]
	public virtual NSDragOperation ValidateDrop(NSBrowser browser, NSDraggingInfo info, ref long row, ref long column, NSBrowserDropOperation dropOperation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:acceptDrop:atRow:column:dropOperation:")]
	public virtual bool AcceptDrop(NSBrowser browser, NSDraggingInfo info, long row, long column, NSBrowserDropOperation dropOperation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:typeSelectStringForRow:inColumn:")]
	public virtual string TypeSelectString(NSBrowser browser, long row, long column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:shouldTypeSelectForEvent:withCurrentSearchString:")]
	public virtual bool ShouldTypeSelectForEvent(NSBrowser browser, NSEvent theEvent, string currentSearchString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:nextTypeSelectMatchFromRow:toRow:inColumn:forString:")]
	public virtual long NextTypeSelectMatch(NSBrowser browser, long startRow, long endRow, long column, string searchString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:previewViewControllerForLeafItem:")]
	public virtual NSViewController PreviewViewControllerForLeafItem(NSBrowser browser, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:headerViewControllerForItem:")]
	public virtual NSViewController HeaderViewControllerForItem(NSBrowser browser, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:didChangeLastColumn:toColumn:")]
	public virtual void DidChangeLastColumn(NSBrowser browser, long oldLastColumn, long toColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("browser:selectionIndexesForProposedSelection:inColumn:")]
	public virtual NSIndexSet SelectionIndexesForProposedSelection(NSBrowser browser, NSIndexSet proposedSelectionIndexes, long inColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
