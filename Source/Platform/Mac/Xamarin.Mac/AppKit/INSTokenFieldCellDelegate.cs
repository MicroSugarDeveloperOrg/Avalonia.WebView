using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol(Name = "NSTokenFieldCellDelegate", WrapperType = typeof(NSTokenFieldCellDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCompletionStrings", Selector = "tokenFieldCell:completionsForSubstring:indexOfToken:indexOfSelectedItem:", ReturnType = typeof(NSArray), ParameterType = new Type[]
{
	typeof(NSTokenFieldCell),
	typeof(string),
	typeof(nint),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false, true })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAddObjects", Selector = "tokenFieldCell:shouldAddObjects:atIndex:", ReturnType = typeof(NSArray), ParameterType = new Type[]
{
	typeof(NSTokenFieldCell),
	typeof(NSObject[]),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDisplayString", Selector = "tokenFieldCell:displayStringForRepresentedObject:", ReturnType = typeof(string), ParameterType = new Type[]
{
	typeof(NSTokenFieldCell),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetEditingString", Selector = "tokenFieldCell:editingStringForRepresentedObject:", ReturnType = typeof(string), ParameterType = new Type[]
{
	typeof(NSTokenFieldCell),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRepresentedObject", Selector = "tokenFieldCell:representedObjectForEditingString:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(NSTokenFieldCell),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteRepresentedObjects", Selector = "tokenFieldCell:writeRepresentedObjects:toPasteboard:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTokenFieldCell),
	typeof(NSObject[]),
	typeof(NSPasteboard)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Read", Selector = "tokenFieldCell:readFromPasteboard:", ReturnType = typeof(NSObject[]), ParameterType = new Type[]
{
	typeof(NSTokenFieldCell),
	typeof(NSPasteboard)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetMenu", Selector = "tokenFieldCell:menuForRepresentedObject:", ReturnType = typeof(NSMenu), ParameterType = new Type[]
{
	typeof(NSTokenFieldCell),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "HasMenu", Selector = "tokenFieldCell:hasMenuForRepresentedObject:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTokenFieldCell),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetStyle", Selector = "tokenFieldCell:styleForRepresentedObject:", ReturnType = typeof(NSTokenStyle), ParameterType = new Type[]
{
	typeof(NSTokenFieldCell),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
public interface INSTokenFieldCellDelegate : INativeObject, IDisposable
{
}
