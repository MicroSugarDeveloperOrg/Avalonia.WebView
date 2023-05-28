using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'GKGameCenterViewController' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'GKGameCenterViewController' instead.")]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Protocol(Name = "GKLeaderboardViewControllerDelegate", WrapperType = typeof(GKLeaderboardViewControllerDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFinish", Selector = "leaderboardViewControllerDidFinish:", ParameterType = new Type[] { typeof(GKLeaderboardViewController) }, ParameterByRef = new bool[] { false })]
public interface IGKLeaderboardViewControllerDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("leaderboardViewControllerDidFinish:")]
	[Preserve(Conditional = true)]
	void DidFinish(GKLeaderboardViewController viewController);
}
