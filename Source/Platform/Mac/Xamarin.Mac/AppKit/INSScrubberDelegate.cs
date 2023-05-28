using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSScrubberDelegate", WrapperType = typeof(NSScrubberDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectItem", Selector = "scrubber:didSelectItemAtIndex:", ParameterType = new Type[]
{
	typeof(NSScrubber),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidHighlightItem", Selector = "scrubber:didHighlightItemAtIndex:", ParameterType = new Type[]
{
	typeof(NSScrubber),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeVisible", Selector = "scrubber:didChangeVisibleRange:", ParameterType = new Type[]
{
	typeof(NSScrubber),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBeginInteracting", Selector = "didBeginInteractingWithScrubber:", ParameterType = new Type[] { typeof(NSScrubber) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishInteracting", Selector = "didFinishInteractingWithScrubber:", ParameterType = new Type[] { typeof(NSScrubber) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCancelInteracting", Selector = "didCancelInteractingWithScrubber:", ParameterType = new Type[] { typeof(NSScrubber) }, ParameterByRef = new bool[] { false })]
public interface INSScrubberDelegate : INativeObject, IDisposable
{
}
