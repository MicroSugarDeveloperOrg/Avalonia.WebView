using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSOutlineViewDelegate", true)]
[Model]
public class NSOutlineViewDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOutlineViewDelegate()
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
	public NSOutlineViewDelegate(NSCoder coder)
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
	public NSOutlineViewDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSOutlineViewDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("outlineView:willDisplayCell:forTableColumn:item:")]
	public virtual void WillDisplayCell(NSOutlineView outlineView, NSObject cell, NSTableColumn tableColumn, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:shouldEditTableColumn:item:")]
	public virtual bool ShouldEditTableColumn(NSOutlineView outlineView, NSTableColumn tableColumn, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("selectionShouldChangeInOutlineView:")]
	public virtual bool SelectionShouldChange(NSOutlineView outlineView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:shouldSelectItem:")]
	public virtual bool ShouldSelectItem(NSOutlineView outlineView, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:selectionIndexesForProposedSelection:")]
	public virtual NSIndexSet GetSelectionIndexes(NSOutlineView outlineView, NSIndexSet proposedSelectionIndexes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:shouldSelectTableColumn:")]
	public virtual bool ShouldSelectTableColumn(NSOutlineView outlineView, NSTableColumn tableColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:mouseDownInHeaderOfTableColumn:")]
	public virtual void MouseDown(NSOutlineView outlineView, NSTableColumn tableColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:didClickTableColumn:")]
	public virtual void DidClickTableColumn(NSOutlineView outlineView, NSTableColumn tableColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:didDragTableColumn:")]
	public virtual void DidDragTableColumn(NSOutlineView outlineView, NSTableColumn tableColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:toolTipForCell:rect:tableColumn:item:mouseLocation:")]
	public virtual string ToolTipForCell(NSOutlineView outlineView, NSCell cell, ref CGRect rect, NSTableColumn tableColumn, NSObject item, CGPoint mouseLocation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:heightOfRowByItem:")]
	public virtual double GetRowHeight(NSOutlineView outlineView, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:typeSelectStringForTableColumn:item:")]
	public virtual string GetSelectString(NSOutlineView outlineView, NSTableColumn tableColumn, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:nextTypeSelectMatchFromItem:toItem:forString:")]
	public virtual NSObject GetNextTypeSelectMatch(NSOutlineView outlineView, NSObject startItem, NSObject endItem, string searchString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:shouldTypeSelectForEvent:withCurrentSearchString:")]
	public virtual bool ShouldTypeSelect(NSOutlineView outlineView, NSEvent theEvent, string searchString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:shouldShowCellExpansionForTableColumn:item:")]
	public virtual bool ShouldShowCellExpansion(NSOutlineView outlineView, NSTableColumn tableColumn, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:shouldTrackCell:forTableColumn:item:")]
	public virtual bool ShouldTrackCell(NSOutlineView outlineView, NSCell cell, NSTableColumn tableColumn, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:dataCellForTableColumn:item:")]
	public virtual NSCell GetCell(NSOutlineView outlineView, NSTableColumn tableColumn, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:viewForTableColumn:item:")]
	public virtual NSView GetView(NSOutlineView outlineView, NSTableColumn tableColumn, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:isGroupItem:")]
	public virtual bool IsGroupItem(NSOutlineView outlineView, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:shouldExpandItem:")]
	public virtual bool ShouldExpandItem(NSOutlineView outlineView, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:shouldCollapseItem:")]
	public virtual bool ShouldCollapseItem(NSOutlineView outlineView, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:willDisplayOutlineCell:forTableColumn:item:")]
	public virtual void WillDisplayOutlineCell(NSOutlineView outlineView, NSObject cell, NSTableColumn tableColumn, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:sizeToFitWidthOfColumn:")]
	public virtual double GetSizeToFitColumnWidth(NSOutlineView outlineView, long column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:shouldReorderColumn:toColumn:")]
	public virtual bool ShouldReorder(NSOutlineView outlineView, long columnIndex, long newColumnIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:shouldShowOutlineCellForItem:")]
	public virtual bool ShouldShowOutlineCell(NSOutlineView outlineView, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineViewColumnDidMove:")]
	public virtual void ColumnDidMove(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineViewColumnDidResize:")]
	public virtual void ColumnDidResize(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineViewSelectionIsChanging:")]
	public virtual void SelectionIsChanging(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineViewItemWillExpand:")]
	public virtual void ItemWillExpand(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineViewItemDidExpand:")]
	public virtual void ItemDidExpand(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineViewItemWillCollapse:")]
	public virtual void ItemWillCollapse(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineViewItemDidCollapse:")]
	public virtual void ItemDidCollapse(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineViewSelectionDidChange:")]
	public virtual void SelectionDidChange(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
