using System;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSLayerDelegateContentsScaleUpdating", WrapperType = typeof(NSLayerDelegateContentsScaleUpdatingWrapper), IsInformal = true)]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldInheritContentsScale", Selector = "layer:shouldInheritContentsScale:fromWindow:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(CALayer),
	typeof(nfloat),
	typeof(NSWindow)
}, ParameterByRef = new bool[] { false, false, false })]
public interface INSLayerDelegateContentsScaleUpdating : INativeObject, IDisposable
{
}
