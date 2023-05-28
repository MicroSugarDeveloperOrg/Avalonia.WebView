using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSTokenFieldDelegate", WrapperType = typeof(NSTokenFieldDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCompletionStrings", Selector = "tokenField:completionsForSubstring:indexOfToken:indexOfSelectedItem:", ReturnType = typeof(string[]), ParameterType = new Type[]
{
	typeof(NSTokenField),
	typeof(string),
	typeof(nint),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAddObjects", Selector = "tokenField:shouldAddObjects:atIndex:", ReturnType = typeof(NSArray), ParameterType = new Type[]
{
	typeof(NSTokenField),
	typeof(NSArray),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDisplayString", Selector = "tokenField:displayStringForRepresentedObject:", ReturnType = typeof(string), ParameterType = new Type[]
{
	typeof(NSTokenField),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetEditingString", Selector = "tokenField:editingStringForRepresentedObject:", ReturnType = typeof(string), ParameterType = new Type[]
{
	typeof(NSTokenField),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRepresentedObject", Selector = "tokenField:representedObjectForEditingString:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(NSTokenField),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteRepresented", Selector = "tokenField:writeRepresentedObjects:toPasteboard:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTokenField),
	typeof(NSArray),
	typeof(NSPasteboard)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Read", Selector = "tokenField:readFromPasteboard:", ReturnType = typeof(NSObject[]), ParameterType = new Type[]
{
	typeof(NSTokenField),
	typeof(NSPasteboard)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetMenu", Selector = "tokenField:menuForRepresentedObject:", ReturnType = typeof(NSMenu), ParameterType = new Type[]
{
	typeof(NSTokenField),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "HasMenu", Selector = "tokenField:hasMenuForRepresentedObject:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTokenField),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetStyle", Selector = "tokenField:styleForRepresentedObject:", ReturnType = typeof(NSTokenStyle), ParameterType = new Type[]
{
	typeof(NSTokenField),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
public interface INSTokenFieldDelegate : INativeObject, IDisposable
{
}
