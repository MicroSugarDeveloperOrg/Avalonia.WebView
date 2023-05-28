using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSDraggingSource", WrapperType = typeof(NSDraggingSourceWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingSourceOperationMaskForLocal", Selector = "draggingSourceOperationMaskForLocal:", ReturnType = typeof(NSDragOperation), ParameterType = new Type[] { typeof(bool) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "NamesOfPromisedFilesDroppedAtDestination", Selector = "namesOfPromisedFilesDroppedAtDestination:", ReturnType = typeof(string[]), ParameterType = new Type[] { typeof(NSUrl) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggedImageBeganAt", Selector = "draggedImage:beganAt:", ParameterType = new Type[]
{
	typeof(NSImage),
	typeof(CGPoint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggedImageEndedAtOperation", Selector = "draggedImage:endedAt:operation:", ParameterType = new Type[]
{
	typeof(NSImage),
	typeof(CGPoint),
	typeof(NSDragOperation)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggedImageMovedTo", Selector = "draggedImage:movedTo:", ParameterType = new Type[]
{
	typeof(NSImage),
	typeof(CGPoint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggedImageEndedAtDeposited", Selector = "draggedImage:endedAt:deposited:", ParameterType = new Type[]
{
	typeof(NSImage),
	typeof(CGPoint),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "IgnoreModifierKeysWhileDragging", Selector = "ignoreModifierKeysWhileDragging", PropertyType = typeof(bool), GetterSelector = "ignoreModifierKeysWhileDragging", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSDraggingSource : INativeObject, IDisposable
{
}
