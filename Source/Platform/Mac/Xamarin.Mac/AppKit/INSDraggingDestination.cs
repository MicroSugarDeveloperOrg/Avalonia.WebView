using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSDraggingDestination", WrapperType = typeof(NSDraggingDestinationWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingEntered", Selector = "draggingEntered:", ReturnType = typeof(NSDragOperation), ParameterType = new Type[] { typeof(NSDraggingInfo) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingUpdated", Selector = "draggingUpdated:", ReturnType = typeof(NSDragOperation), ParameterType = new Type[] { typeof(NSDraggingInfo) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingExited", Selector = "draggingExited:", ParameterType = new Type[] { typeof(NSDraggingInfo) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PrepareForDragOperation", Selector = "prepareForDragOperation:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSDraggingInfo) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformDragOperation", Selector = "performDragOperation:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSDraggingInfo) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConcludeDragOperation", Selector = "concludeDragOperation:", ParameterType = new Type[] { typeof(NSDraggingInfo) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingEnded", Selector = "draggingEnded:", ParameterType = new Type[] { typeof(NSDraggingInfo) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "WantsPeriodicDraggingUpdates", Selector = "wantsPeriodicDraggingUpdates", PropertyType = typeof(bool), GetterSelector = "wantsPeriodicDraggingUpdates", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSDraggingDestination : INativeObject, IDisposable
{
}
