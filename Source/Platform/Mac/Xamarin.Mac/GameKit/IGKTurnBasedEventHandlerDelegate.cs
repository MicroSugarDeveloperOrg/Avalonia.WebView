using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'GKLocalPlayer.RegisterListener' with an object that implements 'IGKTurnBasedEventListener'.")]
[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'GKLocalPlayer.RegisterListener' with an object that implements 'IGKTurnBasedEventListener'.")]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "GKTurnBasedEventHandlerDelegate", WrapperType = typeof(GKTurnBasedEventHandlerDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleInviteFromGameCenter", Selector = "handleInviteFromGameCenter:", ParameterType = new Type[] { typeof(NSString[]) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleTurnEventForMatch", Selector = "handleTurnEventForMatch:", ParameterType = new Type[] { typeof(GKTurnBasedMatch) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleMatchEnded", Selector = "handleMatchEnded:", ParameterType = new Type[] { typeof(GKTurnBasedMatch) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleTurnEvent", Selector = "handleTurnEventForMatch:didBecomeActive:", ParameterType = new Type[]
{
	typeof(GKTurnBasedMatch),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false })]
public interface IGKTurnBasedEventHandlerDelegate : INativeObject, IDisposable
{
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("handleInviteFromGameCenter:")]
	[Preserve(Conditional = true)]
	void HandleInviteFromGameCenter(NSString[] playersToInvite);
}
