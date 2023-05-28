using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSStackViewDelegate", WrapperType = typeof(NSStackViewDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDetachViews", Selector = "stackView:willDetachViews:", ParameterType = new Type[]
{
	typeof(NSStackView),
	typeof(NSView[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReattachViews", Selector = "stackView:didReattachViews:", ParameterType = new Type[]
{
	typeof(NSStackView),
	typeof(NSView[])
}, ParameterByRef = new bool[] { false, false })]
public interface INSStackViewDelegate : INativeObject, IDisposable
{
}
