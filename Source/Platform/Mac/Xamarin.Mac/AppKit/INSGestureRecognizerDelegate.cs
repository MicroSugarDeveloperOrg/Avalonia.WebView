using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSGestureRecognizerDelegate", WrapperType = typeof(NSGestureRecognizerDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldBegin", Selector = "gestureRecognizerShouldBegin:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSGestureRecognizer) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldRecognizeSimultaneously", Selector = "gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSGestureRecognizer),
	typeof(NSGestureRecognizer)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldRequireFailure", Selector = "gestureRecognizer:shouldRequireFailureOfGestureRecognizer:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSGestureRecognizer),
	typeof(NSGestureRecognizer)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldBeRequiredToFail", Selector = "gestureRecognizer:shouldBeRequiredToFailByGestureRecognizer:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSGestureRecognizer),
	typeof(NSGestureRecognizer)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldReceiveEvent", Selector = "xamarinselector:removed:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSGestureRecognizer),
	typeof(NSEvent)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAttemptToRecognize", Selector = "gestureRecognizer:shouldAttemptToRecognizeWithEvent:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSGestureRecognizer),
	typeof(NSEvent)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldReceiveTouch", Selector = "gestureRecognizer:shouldReceiveTouch:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSGestureRecognizer),
	typeof(NSTouch)
}, ParameterByRef = new bool[] { false, false })]
public interface INSGestureRecognizerDelegate : INativeObject, IDisposable
{
}
