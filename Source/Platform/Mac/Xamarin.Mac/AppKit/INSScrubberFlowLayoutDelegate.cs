using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSScrubberFlowLayoutDelegate", WrapperType = typeof(NSScrubberFlowLayoutDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Layout", Selector = "scrubber:layout:sizeForItemAtIndex:", ReturnType = typeof(CGSize), ParameterType = new Type[]
{
	typeof(NSScrubber),
	typeof(NSScrubberFlowLayout),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
public interface INSScrubberFlowLayoutDelegate : INativeObject, IDisposable, INSScrubberDelegate
{
}
