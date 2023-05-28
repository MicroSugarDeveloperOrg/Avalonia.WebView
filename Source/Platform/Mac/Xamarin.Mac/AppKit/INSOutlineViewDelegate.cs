using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol(Name = "NSOutlineViewDelegate", WrapperType = typeof(NSOutlineViewDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayCell", Selector = "outlineView:willDisplayCell:forTableColumn:item:", ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSObject),
	typeof(NSTableColumn),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldEditTableColumn", Selector = "outlineView:shouldEditTableColumn:item:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSTableColumn),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionShouldChange", Selector = "selectionShouldChangeInOutlineView:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSOutlineView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSelectItem", Selector = "outlineView:shouldSelectItem:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSelectionIndexes", Selector = "outlineView:selectionIndexesForProposedSelection:", ReturnType = typeof(NSIndexSet), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSIndexSet)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSelectTableColumn", Selector = "outlineView:shouldSelectTableColumn:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSTableColumn)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MouseDown", Selector = "outlineView:mouseDownInHeaderOfTableColumn:", ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSTableColumn)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidClickTableColumn", Selector = "outlineView:didClickTableColumn:", ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSTableColumn)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDragTableColumn", Selector = "outlineView:didDragTableColumn:", ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSTableColumn)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ToolTipForCell", Selector = "outlineView:toolTipForCell:rect:tableColumn:item:mouseLocation:", ReturnType = typeof(string), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSCell),
	typeof(CGRect),
	typeof(NSTableColumn),
	typeof(NSObject),
	typeof(CGPoint)
}, ParameterByRef = new bool[] { false, false, true, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRowHeight", Selector = "outlineView:heightOfRowByItem:", ReturnType = typeof(nfloat), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSelectString", Selector = "outlineView:typeSelectStringForTableColumn:item:", ReturnType = typeof(string), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSTableColumn),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetNextTypeSelectMatch", Selector = "outlineView:nextTypeSelectMatchFromItem:toItem:forString:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSObject),
	typeof(NSObject),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldTypeSelect", Selector = "outlineView:shouldTypeSelectForEvent:withCurrentSearchString:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSEvent),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowCellExpansion", Selector = "outlineView:shouldShowCellExpansionForTableColumn:item:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSTableColumn),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldTrackCell", Selector = "outlineView:shouldTrackCell:forTableColumn:item:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSCell),
	typeof(NSTableColumn),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCell", Selector = "outlineView:dataCellForTableColumn:item:", ReturnType = typeof(NSCell), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSTableColumn),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetView", Selector = "outlineView:viewForTableColumn:item:", ReturnType = typeof(NSView), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSTableColumn),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsGroupItem", Selector = "outlineView:isGroupItem:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldExpandItem", Selector = "outlineView:shouldExpandItem:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldCollapseItem", Selector = "outlineView:shouldCollapseItem:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayOutlineCell", Selector = "outlineView:willDisplayOutlineCell:forTableColumn:item:", ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSObject),
	typeof(NSTableColumn),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSizeToFitColumnWidth", Selector = "outlineView:sizeToFitWidthOfColumn:", ReturnType = typeof(nfloat), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldReorder", Selector = "outlineView:shouldReorderColumn:toColumn:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(nint),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowOutlineCell", Selector = "outlineView:shouldShowOutlineCellForItem:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ColumnDidMove", Selector = "outlineViewColumnDidMove:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ColumnDidResize", Selector = "outlineViewColumnDidResize:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionIsChanging", Selector = "outlineViewSelectionIsChanging:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemWillExpand", Selector = "outlineViewItemWillExpand:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemDidExpand", Selector = "outlineViewItemDidExpand:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemWillCollapse", Selector = "outlineViewItemWillCollapse:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemDidCollapse", Selector = "outlineViewItemDidCollapse:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionDidChange", Selector = "outlineViewSelectionDidChange:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RowViewForItem", Selector = "outlineView:rowViewForItem:", ReturnType = typeof(NSTableRowView), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddRowView", Selector = "outlineView:didAddRowView:forRow:", ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSTableRowView),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveRowView", Selector = "outlineView:didRemoveRowView:forRow:", ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSTableRowView),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
public interface INSOutlineViewDelegate : INativeObject, IDisposable
{
}
