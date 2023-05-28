using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol(Name = "NSCollectionViewDelegate", WrapperType = typeof(NSCollectionViewDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanDragItems", Selector = "collectionView:canDragItemsAtIndexes:withEvent:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSIndexSet),
	typeof(NSEvent)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteItems", Selector = "collectionView:writeItemsAtIndexes:toPasteboard:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSIndexSet),
	typeof(NSPasteboard)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "NamesOfPromisedFilesDroppedAtDestination", Selector = "collectionView:namesOfPromisedFilesDroppedAtDestination:forDraggedItemsAtIndexes:", ReturnType = typeof(string[]), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSUrl),
	typeof(NSIndexSet)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidateDrop", Selector = "collectionView:validateDrop:proposedIndex:dropOperation:", ReturnType = typeof(NSDragOperation), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSDraggingInfo),
	typeof(nint),
	typeof(NSCollectionViewDropOperation)
}, ParameterByRef = new bool[] { false, false, true, true })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AcceptDrop", Selector = "collectionView:acceptDrop:index:dropOperation:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSDraggingInfo),
	typeof(nint),
	typeof(NSCollectionViewDropOperation)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanDragItems", Selector = "collectionView:canDragItemsAtIndexPaths:withEvent:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSSet),
	typeof(NSEvent)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteItems", Selector = "collectionView:writeItemsAtIndexPaths:toPasteboard:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSSet),
	typeof(NSPasteboard)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetNamesOfPromisedFiles", Selector = "collectionView:namesOfPromisedFilesDroppedAtDestination:forDraggedItemsAtIndexPaths:", ReturnType = typeof(string[]), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSUrl),
	typeof(NSSet)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDraggingImage", Selector = "collectionView:draggingImageForItemsAtIndexPaths:withEvent:offset:", ReturnType = typeof(NSImage), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSSet),
	typeof(NSEvent),
	typeof(CGPoint)
}, ParameterByRef = new bool[] { false, false, false, true })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidateDropOperation", Selector = "collectionView:validateDrop:proposedIndexPath:dropOperation:", ReturnType = typeof(NSDragOperation), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSDraggingInfo),
	typeof(NSIndexPath),
	typeof(NSCollectionViewDropOperation)
}, ParameterByRef = new bool[] { false, false, true, true })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AcceptDrop", Selector = "collectionView:acceptDrop:indexPath:dropOperation:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSDraggingInfo),
	typeof(NSIndexPath),
	typeof(NSCollectionViewDropOperation)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPasteboardWriter", Selector = "collectionView:pasteboardWriterForItemAtIndexPath:", ReturnType = typeof(INSPasteboardWriting), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSIndexPath)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingSessionWillBegin", Selector = "collectionView:draggingSession:willBeginAtPoint:forItemsAtIndexPaths:", ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSDraggingSession),
	typeof(CGPoint),
	typeof(NSSet)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldChangeItems", Selector = "collectionView:shouldChangeItemsAtIndexPaths:toHighlightState:", ReturnType = typeof(NSSet), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSSet),
	typeof(NSCollectionViewItemHighlightState)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemsChanged", Selector = "collectionView:didChangeItemsAtIndexPaths:toHighlightState:", ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSSet),
	typeof(NSCollectionViewItemHighlightState)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSelectItems", Selector = "collectionView:shouldSelectItemsAtIndexPaths:", ReturnType = typeof(NSSet), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSSet)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldDeselectItems", Selector = "collectionView:shouldDeselectItemsAtIndexPaths:", ReturnType = typeof(NSSet), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSSet)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemsSelected", Selector = "collectionView:didSelectItemsAtIndexPaths:", ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSSet)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemsDeselected", Selector = "collectionView:didDeselectItemsAtIndexPaths:", ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSSet)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayItem", Selector = "collectionView:willDisplayItem:forRepresentedObjectAtIndexPath:", ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSCollectionViewItem),
	typeof(NSIndexPath)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplaySupplementaryView", Selector = "collectionView:willDisplaySupplementaryView:forElementKind:atIndexPath:", ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSView),
	typeof(NSString),
	typeof(NSIndexPath)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DisplayingItemEnded", Selector = "collectionView:didEndDisplayingItem:forRepresentedObjectAtIndexPath:", ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSCollectionViewItem),
	typeof(NSIndexPath)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DisplayingSupplementaryViewEnded", Selector = "collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:", ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSView),
	typeof(string),
	typeof(NSIndexPath)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "TransitionLayout", Selector = "collectionView:transitionLayoutForOldLayout:newLayout:", ReturnType = typeof(NSCollectionViewTransitionLayout), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSCollectionViewLayout),
	typeof(NSCollectionViewLayout)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PasteboardWriterForItem", Selector = "collectionView:pasteboardWriterForItemAtIndex:", ReturnType = typeof(INSPasteboardWriting), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateDraggingItemsForDrag", Selector = "collectionView:updateDraggingItemsForDrag:", ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSDraggingInfo)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingSessionWillBegin", Selector = "collectionView:draggingSession:willBeginAtPoint:forItemsAtIndexes:", ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSDraggingSession),
	typeof(CGPoint),
	typeof(NSIndexSet)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingSessionEnded", Selector = "collectionView:draggingSession:endedAtPoint:dragOperation:", ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSDraggingSession),
	typeof(CGPoint),
	typeof(NSDragOperation)
}, ParameterByRef = new bool[] { false, false, false, false })]
public interface INSCollectionViewDelegate : INativeObject, IDisposable
{
}
