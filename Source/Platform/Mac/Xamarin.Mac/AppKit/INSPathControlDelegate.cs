using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSPathControlDelegate", WrapperType = typeof(NSPathControlDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldDragPathComponentCell", Selector = "pathControl:shouldDragPathComponentCell:withPasteboard:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSPathControl),
	typeof(NSPathComponentCell),
	typeof(NSPasteboard)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidateDrop", Selector = "pathControl:validateDrop:", ReturnType = typeof(NSDragOperation), ParameterType = new Type[]
{
	typeof(NSPathControl),
	typeof(NSDraggingInfo)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AcceptDrop", Selector = "pathControl:acceptDrop:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSPathControl),
	typeof(NSDraggingInfo)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayOpenPanel", Selector = "pathControl:willDisplayOpenPanel:", ParameterType = new Type[]
{
	typeof(NSPathControl),
	typeof(NSOpenPanel)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPopUpMenu", Selector = "pathControl:willPopUpMenu:", ParameterType = new Type[]
{
	typeof(NSPathControl),
	typeof(NSMenu)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldDragItem", Selector = "pathControl:shouldDragItem:withPasteboard:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSPathControl),
	typeof(NSPathControlItem),
	typeof(NSPasteboard)
}, ParameterByRef = new bool[] { false, false, false })]
public interface INSPathControlDelegate : INativeObject, IDisposable
{
}
