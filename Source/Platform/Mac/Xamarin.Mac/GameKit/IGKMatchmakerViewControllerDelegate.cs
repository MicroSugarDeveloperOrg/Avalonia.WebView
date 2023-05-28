using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Protocol(Name = "GKMatchmakerViewControllerDelegate", WrapperType = typeof(GKMatchmakerViewControllerDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "WasCancelled", Selector = "matchmakerViewControllerWasCancelled:", ParameterType = new Type[] { typeof(GKMatchmakerViewController) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFailWithError", Selector = "matchmakerViewController:didFailWithError:", ParameterType = new Type[]
{
	typeof(GKMatchmakerViewController),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFindMatch", Selector = "matchmakerViewController:didFindMatch:", ParameterType = new Type[]
{
	typeof(GKMatchmakerViewController),
	typeof(GKMatch)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFindPlayers", Selector = "matchmakerViewController:didFindPlayers:", ParameterType = new Type[]
{
	typeof(GKMatchmakerViewController),
	typeof(string[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFindHostedPlayers", Selector = "matchmakerViewController:didFindHostedPlayers:", ParameterType = new Type[]
{
	typeof(GKMatchmakerViewController),
	typeof(GKPlayer[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedAcceptFromHostedPlayer", Selector = "matchmakerViewController:didReceiveAcceptFromHostedPlayer:", ParameterType = new Type[]
{
	typeof(GKMatchmakerViewController),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "HostedPlayerDidAccept", Selector = "matchmakerViewController:hostedPlayerDidAccept:", ParameterType = new Type[]
{
	typeof(GKMatchmakerViewController),
	typeof(GKPlayer)
}, ParameterByRef = new bool[] { false, false })]
public interface IGKMatchmakerViewControllerDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("matchmakerViewControllerWasCancelled:")]
	[Preserve(Conditional = true)]
	void WasCancelled(GKMatchmakerViewController viewController);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("matchmakerViewController:didFailWithError:")]
	[Preserve(Conditional = true)]
	void DidFailWithError(GKMatchmakerViewController viewController, NSError error);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("matchmakerViewController:didFindMatch:")]
	[Preserve(Conditional = true)]
	void DidFindMatch(GKMatchmakerViewController viewController, GKMatch match);

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'DidFindHostedPlayers' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'DidFindHostedPlayers' instead.")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'DidFindHostedPlayers' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'DidFindHostedPlayers' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("matchmakerViewController:didFindPlayers:")]
	[Preserve(Conditional = true)]
	void DidFindPlayers(GKMatchmakerViewController viewController, string[] playerIDs);

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("matchmakerViewController:didFindHostedPlayers:")]
	[Preserve(Conditional = true)]
	void DidFindHostedPlayers(GKMatchmakerViewController viewController, GKPlayer[] playerIDs);
}
