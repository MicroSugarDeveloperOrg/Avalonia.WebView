using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSAnimationDelegate", WrapperType = typeof(NSAnimationDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AnimationShouldStart", Selector = "animationShouldStart:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSAnimation) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AnimationDidStop", Selector = "animationDidStop:", ParameterType = new Type[] { typeof(NSAnimation) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AnimationDidEnd", Selector = "animationDidEnd:", ParameterType = new Type[] { typeof(NSAnimation) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ComputeAnimationCurve", Selector = "animation:valueForProgress:", ReturnType = typeof(float), ParameterType = new Type[]
{
	typeof(NSAnimation),
	typeof(float)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AnimationDidReachProgressMark", Selector = "animation:didReachProgressMark:", ParameterType = new Type[]
{
	typeof(NSAnimation),
	typeof(float)
}, ParameterByRef = new bool[] { false, false })]
public interface INSAnimationDelegate : INativeObject, IDisposable
{
}
