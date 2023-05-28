using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Protocol(Name = "GKTurnBasedMatchmakerViewControllerDelegate", WrapperType = typeof(GKTurnBasedMatchmakerViewControllerDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "WasCancelled", Selector = "turnBasedMatchmakerViewControllerWasCancelled:", ParameterType = new Type[] { typeof(GKTurnBasedMatchmakerViewController) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "FailedWithError", Selector = "turnBasedMatchmakerViewController:didFailWithError:", ParameterType = new Type[]
{
	typeof(GKTurnBasedMatchmakerViewController),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "FoundMatch", Selector = "turnBasedMatchmakerViewController:didFindMatch:", ParameterType = new Type[]
{
	typeof(GKTurnBasedMatchmakerViewController),
	typeof(GKTurnBasedMatch)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "PlayerQuitForMatch", Selector = "turnBasedMatchmakerViewController:playerQuitForMatch:", ParameterType = new Type[]
{
	typeof(GKTurnBasedMatchmakerViewController),
	typeof(GKTurnBasedMatch)
}, ParameterByRef = new bool[] { false, false })]
public interface IGKTurnBasedMatchmakerViewControllerDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("turnBasedMatchmakerViewControllerWasCancelled:")]
	[Preserve(Conditional = true)]
	void WasCancelled(GKTurnBasedMatchmakerViewController viewController);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("turnBasedMatchmakerViewController:didFailWithError:")]
	[Preserve(Conditional = true)]
	void FailedWithError(GKTurnBasedMatchmakerViewController viewController, NSError error);

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("turnBasedMatchmakerViewController:didFindMatch:")]
	[Preserve(Conditional = true)]
	void FoundMatch(GKTurnBasedMatchmakerViewController viewController, GKTurnBasedMatch match);

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'GKTurnBasedEventListener.WantsToQuitMatch' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'GKTurnBasedEventListener.WantsToQuitMatch' instead.")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'GKTurnBasedEventListener.WantsToQuitMatch' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'GKTurnBasedEventListener.WantsToQuitMatch' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("turnBasedMatchmakerViewController:playerQuitForMatch:")]
	[Preserve(Conditional = true)]
	void PlayerQuitForMatch(GKTurnBasedMatchmakerViewController viewController, GKTurnBasedMatch match);
}
