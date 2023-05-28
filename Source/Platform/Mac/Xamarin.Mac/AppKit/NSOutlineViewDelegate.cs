using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol]
[Register("NSOutlineViewDelegate", false)]
[Model]
public class NSOutlineViewDelegate : NSObject, INSOutlineViewDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOutlineViewDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSOutlineViewDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSOutlineViewDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("outlineViewColumnDidMove:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ColumnDidMove(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineViewColumnDidResize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ColumnDidResize(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:didAddRowView:forRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidAddRowView(NSOutlineView outlineView, NSTableRowView rowView, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:didClickTableColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidClickTableColumn(NSOutlineView outlineView, NSTableColumn tableColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:didDragTableColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidDragTableColumn(NSOutlineView outlineView, NSTableColumn tableColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:didRemoveRowView:forRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidRemoveRowView(NSOutlineView outlineView, NSTableRowView rowView, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:dataCellForTableColumn:item:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCell GetCell(NSOutlineView outlineView, NSTableColumn tableColumn, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:nextTypeSelectMatchFromItem:toItem:forString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetNextTypeSelectMatch(NSOutlineView outlineView, NSObject startItem, NSObject endItem, string searchString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:heightOfRowByItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetRowHeight(NSOutlineView outlineView, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:typeSelectStringForTableColumn:item:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetSelectString(NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:selectionIndexesForProposedSelection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet GetSelectionIndexes(NSOutlineView outlineView, NSIndexSet proposedSelectionIndexes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:sizeToFitWidthOfColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetSizeToFitColumnWidth(NSOutlineView outlineView, nint column)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:viewForTableColumn:item:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView GetView(NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:isGroupItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsGroupItem(NSOutlineView outlineView, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineViewItemDidCollapse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ItemDidCollapse(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineViewItemDidExpand:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ItemDidExpand(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineViewItemWillCollapse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ItemWillCollapse(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineViewItemWillExpand:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ItemWillExpand(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:mouseDownInHeaderOfTableColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MouseDown(NSOutlineView outlineView, NSTableColumn tableColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:rowViewForItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTableRowView RowViewForItem(NSOutlineView outlineView, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineViewSelectionDidChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectionDidChange(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineViewSelectionIsChanging:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectionIsChanging(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("selectionShouldChangeInOutlineView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SelectionShouldChange(NSOutlineView outlineView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:shouldCollapseItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldCollapseItem(NSOutlineView outlineView, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:shouldEditTableColumn:item:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldEditTableColumn(NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:shouldExpandItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldExpandItem(NSOutlineView outlineView, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:shouldReorderColumn:toColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldReorder(NSOutlineView outlineView, nint columnIndex, nint newColumnIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:shouldSelectItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldSelectItem(NSOutlineView outlineView, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:shouldSelectTableColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldSelectTableColumn(NSOutlineView outlineView, NSTableColumn? tableColumn)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:shouldShowCellExpansionForTableColumn:item:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldShowCellExpansion(NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:shouldShowOutlineCellForItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldShowOutlineCell(NSOutlineView outlineView, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:shouldTrackCell:forTableColumn:item:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldTrackCell(NSOutlineView outlineView, NSCell cell, NSTableColumn? tableColumn, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:shouldTypeSelectForEvent:withCurrentSearchString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldTypeSelect(NSOutlineView outlineView, NSEvent theEvent, string? searchString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:toolTipForCell:rect:tableColumn:item:mouseLocation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ToolTipForCell(NSOutlineView outlineView, NSCell cell, ref CGRect rect, NSTableColumn? tableColumn, NSObject item, CGPoint mouseLocation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:willDisplayCell:forTableColumn:item:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillDisplayCell(NSOutlineView outlineView, NSObject cell, NSTableColumn? tableColumn, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:willDisplayOutlineCell:forTableColumn:item:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillDisplayOutlineCell(NSOutlineView outlineView, NSObject cell, NSTableColumn? tableColumn, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
