using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol(Name = "NSTableViewDataSource", WrapperType = typeof(NSTableViewDataSourceWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRowCount", Selector = "numberOfRowsInTableView:", ReturnType = typeof(nint), ParameterType = new Type[] { typeof(NSTableView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetObjectValue", Selector = "tableView:objectValueForTableColumn:row:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSTableColumn),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetObjectValue", Selector = "tableView:setObjectValue:forTableColumn:row:", ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSObject),
	typeof(NSTableColumn),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SortDescriptorsChanged", Selector = "tableView:sortDescriptorsDidChange:", ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSSortDescriptor[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteRows", Selector = "tableView:writeRowsWithIndexes:toPasteboard:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSIndexSet),
	typeof(NSPasteboard)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidateDrop", Selector = "tableView:validateDrop:proposedRow:proposedDropOperation:", ReturnType = typeof(NSDragOperation), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSDraggingInfo),
	typeof(nint),
	typeof(NSTableViewDropOperation)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AcceptDrop", Selector = "tableView:acceptDrop:row:dropOperation:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSDraggingInfo),
	typeof(nint),
	typeof(NSTableViewDropOperation)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FilesDropped", Selector = "tableView:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:", ReturnType = typeof(string[]), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSUrl),
	typeof(NSIndexSet)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPasteboardWriterForRow", Selector = "tableView:pasteboardWriterForRow:", ReturnType = typeof(INSPasteboardWriting), ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingSessionWillBegin", Selector = "tableView:draggingSession:willBeginAtPoint:forRowIndexes:", ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSDraggingSession),
	typeof(CGPoint),
	typeof(NSIndexSet)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingSessionEnded", Selector = "tableView:draggingSession:endedAtPoint:operation:", ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSDraggingSession),
	typeof(CGPoint),
	typeof(NSDragOperation)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateDraggingItems", Selector = "tableView:updateDraggingItemsForDrag:", ParameterType = new Type[]
{
	typeof(NSTableView),
	typeof(NSDraggingInfo)
}, ParameterByRef = new bool[] { false, false })]
public interface INSTableViewDataSource : INativeObject, IDisposable
{
}
