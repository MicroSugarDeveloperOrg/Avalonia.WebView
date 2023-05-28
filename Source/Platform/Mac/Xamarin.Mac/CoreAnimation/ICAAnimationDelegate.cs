using System;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Protocol(Name = "CAAnimationDelegate", WrapperType = typeof(CAAnimationDelegateWrapper), FormalSince = "10.12")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AnimationStarted", Selector = "animationDidStart:", ParameterType = new Type[] { typeof(CAAnimation) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AnimationStopped", Selector = "animationDidStop:finished:", ParameterType = new Type[]
{
	typeof(CAAnimation),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false })]
public interface ICAAnimationDelegate : INativeObject, IDisposable
{
}
