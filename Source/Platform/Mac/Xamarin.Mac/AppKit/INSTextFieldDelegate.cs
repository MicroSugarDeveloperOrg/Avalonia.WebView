using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSTextFieldDelegate", WrapperType = typeof(NSTextFieldDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "TextShouldBeginEditing", Selector = "control:textShouldBeginEditing:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSControl),
	typeof(NSText)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "TextShouldEndEditing", Selector = "control:textShouldEndEditing:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSControl),
	typeof(NSText)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToFormatString", Selector = "control:didFailToFormatString:errorDescription:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSControl),
	typeof(string),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToValidatePartialString", Selector = "control:didFailToValidatePartialString:errorDescription:", ParameterType = new Type[]
{
	typeof(NSControl),
	typeof(string),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsValidObject", Selector = "control:isValidObject:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSControl),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DoCommandBySelector", Selector = "control:textView:doCommandBySelector:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSControl),
	typeof(NSTextView),
	typeof(Selector)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCompletions", Selector = "control:textView:completions:forPartialWordRange:indexOfSelectedItem:", ReturnType = typeof(string[]), ParameterType = new Type[]
{
	typeof(NSControl),
	typeof(NSTextView),
	typeof(string[]),
	typeof(NSRange),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false, false, true })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "EditingEnded", Selector = "controlTextDidEndEditing:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Changed", Selector = "controlTextDidChange:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "EditingBegan", Selector = "controlTextDidBeginEditing:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCandidates", Selector = "textField:textView:candidatesForSelectedRange:", ReturnType = typeof(NSObject[]), ParameterType = new Type[]
{
	typeof(NSTextField),
	typeof(NSTextView),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTextCheckingResults", Selector = "textField:textView:candidates:forSelectedRange:", ReturnType = typeof(NSTextCheckingResult[]), ParameterType = new Type[]
{
	typeof(NSTextField),
	typeof(NSTextView),
	typeof(NSTextCheckingResult[]),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSelectCandidate", Selector = "textField:textView:shouldSelectCandidateAtIndex:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTextField),
	typeof(NSTextView),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
public interface INSTextFieldDelegate : INativeObject, IDisposable
{
}
