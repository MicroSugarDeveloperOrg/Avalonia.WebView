using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Protocol(Name = "CALayerDelegate", WrapperType = typeof(CALayerDelegateWrapper), FormalSince = "10.12")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DisplayLayer", Selector = "displayLayer:", ParameterType = new Type[] { typeof(CALayer) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawLayer", Selector = "drawLayer:inContext:", ParameterType = new Type[]
{
	typeof(CALayer),
	typeof(CGContext)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDrawLayer", Selector = "layerWillDraw:", ParameterType = new Type[] { typeof(CALayer) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "LayoutSublayersOfLayer", Selector = "layoutSublayersOfLayer:", ParameterType = new Type[] { typeof(CALayer) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ActionForLayer", Selector = "actionForLayer:forKey:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(CALayer),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
public interface ICALayerDelegate : INativeObject, IDisposable
{
}
