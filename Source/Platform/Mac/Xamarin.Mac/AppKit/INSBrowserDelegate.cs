using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol(Name = "NSBrowserDelegate", WrapperType = typeof(NSBrowserDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RowsInColumn", Selector = "browser:numberOfRowsInColumn:", ReturnType = typeof(nint), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateRowsForColumn", Selector = "browser:createRowsForColumn:inMatrix:", ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(nint),
	typeof(NSMatrix)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CountChildren", Selector = "browser:numberOfChildrenOfItem:", ReturnType = typeof(nint), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetChild", Selector = "browser:child:ofItem:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(nint),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsLeafItem", Selector = "browser:isLeafItem:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ObjectValueForItem", Selector = "browser:objectValueForItem:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RowHeight", Selector = "browser:heightOfRow:inColumn:", ReturnType = typeof(nfloat), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(nint),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RootItemForBrowser", Selector = "rootItemForBrowser:", ReturnType = typeof(NSObject), ParameterType = new Type[] { typeof(NSBrowser) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetObjectValue", Selector = "browser:setObjectValue:forItem:", ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(NSObject),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldEditItem", Selector = "browser:shouldEditItem:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayCell", Selector = "browser:willDisplayCell:atRow:column:", ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(NSObject),
	typeof(nint),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ColumnTitle", Selector = "browser:titleOfColumn:", ReturnType = typeof(string), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectCellWithString", Selector = "browser:selectCellWithString:inColumn:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(string),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectRowInColumn", Selector = "browser:selectRow:inColumn:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(nint),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsColumnValid", Selector = "browser:isColumnValid:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillScroll", Selector = "browserWillScroll:", ParameterType = new Type[] { typeof(NSBrowser) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidScroll", Selector = "browserDidScroll:", ParameterType = new Type[] { typeof(NSBrowser) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSizeColumn", Selector = "browser:shouldSizeColumn:forUserResize:toWidth:", ReturnType = typeof(nfloat), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(nint),
	typeof(bool),
	typeof(nfloat)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SizeToFitWidth", Selector = "browser:sizeToFitWidthOfColumn:", ReturnType = typeof(nfloat), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ColumnConfigurationDidChange", Selector = "browserColumnConfigurationDidChange:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowCellExpansion", Selector = "browser:shouldShowCellExpansionForRow:column:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(nint),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteRowsWithIndexesToPasteboard", Selector = "browser:writeRowsWithIndexes:inColumn:toPasteboard:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(NSIndexSet),
	typeof(nint),
	typeof(NSPasteboard)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PromisedFilesDroppedAtDestination", Selector = "browser:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:inColumn:", ReturnType = typeof(string[]), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(NSUrl),
	typeof(NSIndexSet),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanDragRowsWithIndexes", Selector = "browser:canDragRowsWithIndexes:inColumn:withEvent:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(NSIndexSet),
	typeof(nint),
	typeof(NSEvent)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidateDrop", Selector = "browser:validateDrop:proposedRow:column:dropOperation:", ReturnType = typeof(NSDragOperation), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(NSDraggingInfo),
	typeof(nint),
	typeof(nint),
	typeof(NSBrowserDropOperation)
}, ParameterByRef = new bool[] { false, false, true, true, true })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AcceptDrop", Selector = "browser:acceptDrop:atRow:column:dropOperation:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(NSDraggingInfo),
	typeof(nint),
	typeof(nint),
	typeof(NSBrowserDropOperation)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "TypeSelectString", Selector = "browser:typeSelectStringForRow:inColumn:", ReturnType = typeof(string), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(nint),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldTypeSelectForEvent", Selector = "browser:shouldTypeSelectForEvent:withCurrentSearchString:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(NSEvent),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "NextTypeSelectMatch", Selector = "browser:nextTypeSelectMatchFromRow:toRow:inColumn:forString:", ReturnType = typeof(nint), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(nint),
	typeof(nint),
	typeof(nint),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PreviewViewControllerForLeafItem", Selector = "browser:previewViewControllerForLeafItem:", ReturnType = typeof(NSViewController), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "HeaderViewControllerForItem", Selector = "browser:headerViewControllerForItem:", ReturnType = typeof(NSViewController), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeLastColumn", Selector = "browser:didChangeLastColumn:toColumn:", ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(nint),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionIndexesForProposedSelection", Selector = "browser:selectionIndexesForProposedSelection:inColumn:", ReturnType = typeof(NSIndexSet), ParameterType = new Type[]
{
	typeof(NSBrowser),
	typeof(NSIndexSet),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
public interface INSBrowserDelegate : INativeObject, IDisposable
{
}
