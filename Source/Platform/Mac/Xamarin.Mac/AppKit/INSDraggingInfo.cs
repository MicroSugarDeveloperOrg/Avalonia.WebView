using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol(Name = "NSDraggingInfo", WrapperType = typeof(NSDraggingInfoWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SlideDraggedImageTo", Selector = "slideDraggedImageTo:", ParameterType = new Type[] { typeof(CGPoint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PromisedFilesDroppedAtDestination", Selector = "namesOfPromisedFilesDroppedAtDestination:", ReturnType = typeof(string[]), ParameterType = new Type[] { typeof(NSUrl) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "EnumerateDraggingItems", Selector = "enumerateDraggingItemsWithOptions:forView:classes:searchOptions:usingBlock:", ParameterType = new Type[]
{
	typeof(NSDraggingItemEnumerationOptions),
	typeof(NSView),
	typeof(IntPtr),
	typeof(NSDictionary),
	typeof(NSDraggingEnumerator)
}, ParameterByRef = new bool[] { false, false, false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	null,
	null,
	typeof(Trampolines.NIDNSDraggingEnumerator)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResetSpringLoading", Selector = "resetSpringLoading")]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "DraggingDestinationWindow", Selector = "draggingDestinationWindow", PropertyType = typeof(NSWindow), GetterSelector = "draggingDestinationWindow", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "DraggingSourceOperationMask", Selector = "draggingSourceOperationMask", PropertyType = typeof(NSDragOperation), GetterSelector = "draggingSourceOperationMask", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "DraggingLocation", Selector = "draggingLocation", PropertyType = typeof(CGPoint), GetterSelector = "draggingLocation", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "DraggedImageLocation", Selector = "draggedImageLocation", PropertyType = typeof(CGPoint), GetterSelector = "draggedImageLocation", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "DraggedImage", Selector = "draggedImage", PropertyType = typeof(NSImage), GetterSelector = "draggedImage", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "DraggingPasteboard", Selector = "draggingPasteboard", PropertyType = typeof(NSPasteboard), GetterSelector = "draggingPasteboard", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "DraggingSource", Selector = "draggingSource", PropertyType = typeof(NSObject), GetterSelector = "draggingSource", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "DraggingSequenceNumber", Selector = "draggingSequenceNumber", PropertyType = typeof(nint), GetterSelector = "draggingSequenceNumber", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AnimatesToDestination", Selector = "animatesToDestination", PropertyType = typeof(bool), GetterSelector = "animatesToDestination", SetterSelector = "setAnimatesToDestination:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "NumberOfValidItemsForDrop", Selector = "numberOfValidItemsForDrop", PropertyType = typeof(nint), GetterSelector = "numberOfValidItemsForDrop", SetterSelector = "setNumberOfValidItemsForDrop:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "DraggingFormation", Selector = "draggingFormation", PropertyType = typeof(NSDraggingFormation), GetterSelector = "draggingFormation", SetterSelector = "setDraggingFormation:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "SpringLoadingHighlight", Selector = "springLoadingHighlight", PropertyType = typeof(NSSpringLoadingHighlight), GetterSelector = "springLoadingHighlight", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSDraggingInfo : INativeObject, IDisposable
{
}
