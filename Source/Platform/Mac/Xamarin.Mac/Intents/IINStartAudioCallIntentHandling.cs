using System;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'INStartCallIntentHandling' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'INStartCallIntentHandling' instead.")]
[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'INStartCallIntentHandling' instead.")]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
[Protocol(Name = "INStartAudioCallIntentHandling", WrapperType = typeof(INStartAudioCallIntentHandlingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleStartAudioCall", Selector = "handleStartAudioCall:completion:", ParameterType = new Type[]
{
	typeof(INStartAudioCallIntent),
	typeof(Action<INStartAudioCallIntentResponse>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V48)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConfirmStartAudioCall", Selector = "confirmStartAudioCall:completion:", ParameterType = new Type[]
{
	typeof(INStartAudioCallIntent),
	typeof(Action<INStartAudioCallIntentResponse>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V48)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveDestinationType", Selector = "resolveDestinationTypeForStartAudioCall:withCompletion:", ParameterType = new Type[]
{
	typeof(INStartAudioCallIntent),
	typeof(Action<INCallDestinationTypeResolutionResult>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V63)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveContacts", Selector = "resolveContactsForStartAudioCall:withCompletion:", ParameterType = new Type[]
{
	typeof(INStartAudioCallIntent),
	typeof(Action<INPersonResolutionResult[]>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V55)
})]
public interface IINStartAudioCallIntentHandling : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("handleStartAudioCall:completion:")]
	[Preserve(Conditional = true)]
	void HandleStartAudioCall(INStartAudioCallIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V48))] Action<INStartAudioCallIntentResponse> completion);
}
