using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol(Name = "NSTableViewDelegate", WrapperType = typeof(NSTableViewDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayCell", Selector = "tableView:willDisplayCell:forTableColumn:row:", ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSObject),
	typeof(NSTableColumn),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldEditTableColumn", Selector = "tableView:shouldEditTableColumn:row:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSTableColumn),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionShouldChange", Selector = "selectionShouldChangeInTableView:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSTableView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSelectRow", Selector = "tableView:shouldSelectRow:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSelectionIndexes", Selector = "tableView:selectionIndexesForProposedSelection:", ReturnType = typeof(NSIndexSet), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSIndexSet)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSelectTableColumn", Selector = "tableView:shouldSelectTableColumn:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSTableColumn)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MouseDownInHeaderOfTableColumn", Selector = "tableView:mouseDownInHeaderOfTableColumn:", ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSTableColumn)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidClickTableColumn", Selector = "tableView:didClickTableColumn:", ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSTableColumn)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDragTableColumn", Selector = "tableView:didDragTableColumn:", ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSTableColumn)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRowHeight", Selector = "tableView:heightOfRow:", ReturnType = typeof(nfloat), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSelectString", Selector = "tableView:typeSelectStringForTableColumn:row:", ReturnType = typeof(string), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSTableColumn),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetNextTypeSelectMatch", Selector = "tableView:nextTypeSelectMatchFromRow:toRow:forString:", ReturnType = typeof(nint), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(nint),
	typeof(nint),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldTypeSelect", Selector = "tableView:shouldTypeSelectForEvent:withCurrentSearchString:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSEvent),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowCellExpansion", Selector = "tableView:shouldShowCellExpansionForTableColumn:row:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSTableColumn),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldTrackCell", Selector = "tableView:shouldTrackCell:forTableColumn:row:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSCell),
	typeof(NSTableColumn),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDataCell", Selector = "tableView:dataCellForTableColumn:row:", ReturnType = typeof(NSCell), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSTableColumn),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsGroupRow", Selector = "tableView:isGroupRow:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSizeToFitColumnWidth", Selector = "tableView:sizeToFitWidthOfColumn:", ReturnType = typeof(nfloat), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldReorder", Selector = "tableView:shouldReorderColumn:toColumn:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(nint),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionDidChange", Selector = "tableViewSelectionDidChange:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ColumnDidMove", Selector = "tableViewColumnDidMove:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ColumnDidResize", Selector = "tableViewColumnDidResize:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionIsChanging", Selector = "tableViewSelectionIsChanging:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetViewForItem", Selector = "tableView:viewForTableColumn:row:", ReturnType = typeof(NSView), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSTableColumn),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CoreGetRowView", Selector = "tableView:rowViewForRow:", ReturnType = typeof(NSTableRowView), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddRowView", Selector = "tableView:didAddRowView:forRow:", ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSTableRowView),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveRowView", Selector = "tableView:didRemoveRowView:forRow:", ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSTableRowView),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RowActions", Selector = "tableView:rowActionsForRow:edge:", ReturnType = typeof(NSTableViewRowAction[]), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(nint),
	typeof(NSTableRowActionEdge)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetToolTip", Selector = "tableView:toolTipForCell:rect:tableColumn:row:mouseLocation:", ReturnType = typeof(NSString), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSCell),
	typeof(CGRect),
	typeof(NSTableColumn),
	typeof(nint),
	typeof(CGPoint)
}, ParameterByRef = new bool[] { false, false, true, false, false, false })]
public interface INSTableViewDelegate : INativeObject, IDisposable
{
}
