using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSTextDelegate", WrapperType = typeof(NSTextDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "TextShouldBeginEditing", Selector = "textShouldBeginEditing:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSText) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "TextShouldEndEditing", Selector = "textShouldEndEditing:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSText) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "TextDidBeginEditing", Selector = "textDidBeginEditing:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "TextDidEndEditing", Selector = "textDidEndEditing:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "TextDidChange", Selector = "textDidChange:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
public interface INSTextDelegate : INativeObject, IDisposable
{
}
