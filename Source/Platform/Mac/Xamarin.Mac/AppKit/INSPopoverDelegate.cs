using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSPopoverDelegate", WrapperType = typeof(NSPopoverDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldClose", Selector = "popoverShouldClose:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSPopover) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDetachableWindowForPopover", Selector = "detachableWindowForPopover:", ReturnType = typeof(NSWindow), ParameterType = new Type[] { typeof(NSPopover) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillShow", Selector = "popoverWillShow:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidShow", Selector = "popoverDidShow:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillClose", Selector = "popoverWillClose:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidClose", Selector = "popoverDidClose:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDetach", Selector = "popoverDidDetach:", ParameterType = new Type[] { typeof(NSPopover) }, ParameterByRef = new bool[] { false })]
public interface INSPopoverDelegate : INativeObject, IDisposable
{
}
