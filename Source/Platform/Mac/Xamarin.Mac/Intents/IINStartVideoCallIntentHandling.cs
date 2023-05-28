using System;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'INStartCallIntentHandling' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'INStartCallIntentHandling' instead.")]
[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'INStartCallIntentHandling' instead.")]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Protocol(Name = "INStartVideoCallIntentHandling", WrapperType = typeof(INStartVideoCallIntentHandlingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleStartVideoCall", Selector = "handleStartVideoCall:completion:", ParameterType = new Type[]
{
	typeof(INStartVideoCallIntent),
	typeof(Action<INStartVideoCallIntentResponse>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V49)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConfirmStartVideoCall", Selector = "confirmStartVideoCall:completion:", ParameterType = new Type[]
{
	typeof(INStartVideoCallIntent),
	typeof(Action<INStartVideoCallIntentResponse>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V49)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveContacts", Selector = "resolveContactsForStartVideoCall:withCompletion:", ParameterType = new Type[]
{
	typeof(INStartVideoCallIntent),
	typeof(Action<INPersonResolutionResult[]>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V55)
})]
public interface IINStartVideoCallIntentHandling : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("handleStartVideoCall:completion:")]
	[Preserve(Conditional = true)]
	void HandleStartVideoCall(INStartVideoCallIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V49))] Action<INStartVideoCallIntentResponse> completion);
}
