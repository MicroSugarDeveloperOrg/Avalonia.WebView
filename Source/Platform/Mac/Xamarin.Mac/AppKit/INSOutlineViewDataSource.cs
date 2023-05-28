using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol(Name = "NSOutlineViewDataSource", WrapperType = typeof(NSOutlineViewDataSourceWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetChild", Selector = "outlineView:child:ofItem:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(nint),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemExpandable", Selector = "outlineView:isItemExpandable:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetChildrenCount", Selector = "outlineView:numberOfChildrenOfItem:", ReturnType = typeof(nint), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetObjectValue", Selector = "outlineView:objectValueForTableColumn:byItem:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSTableColumn),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetObjectValue", Selector = "outlineView:setObjectValue:forTableColumn:byItem:", ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSObject),
	typeof(NSTableColumn),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemForPersistentObject", Selector = "outlineView:itemForPersistentObject:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PersistentObjectForItem", Selector = "outlineView:persistentObjectForItem:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SortDescriptorsChanged", Selector = "outlineView:sortDescriptorsDidChange:", ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSSortDescriptor[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OutlineViewwriteItemstoPasteboard", Selector = "outlineView:writeItems:toPasteboard:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSArray),
	typeof(NSPasteboard)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidateDrop", Selector = "outlineView:validateDrop:proposedItem:proposedChildIndex:", ReturnType = typeof(NSDragOperation), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSDraggingInfo),
	typeof(NSObject),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AcceptDrop", Selector = "outlineView:acceptDrop:item:childIndex:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSDraggingInfo),
	typeof(NSObject),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FilesDropped", Selector = "outlineView:namesOfPromisedFilesDroppedAtDestination:forDraggedItems:", ReturnType = typeof(string[]), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSUrl),
	typeof(NSArray)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PasteboardWriterForItem", Selector = "outlineView:pasteboardWriterForItem:", ReturnType = typeof(INSPasteboardWriting), ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingSessionWillBegin", Selector = "outlineView:draggingSession:willBeginAtPoint:forItems:", ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSDraggingSession),
	typeof(CGPoint),
	typeof(NSArray)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingSessionEnded", Selector = "outlineView:draggingSession:endedAtPoint:operation:", ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSDraggingSession),
	typeof(CGPoint),
	typeof(NSDragOperation)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateDraggingItemsForDrag", Selector = "outlineView:updateDraggingItemsForDrag:", ParameterType = new Type[]
{
	typeof(NSOutlineView),
	typeof(NSDraggingInfo)
}, ParameterByRef = new bool[] { false, false })]
public interface INSOutlineViewDataSource : INativeObject, IDisposable
{
}
