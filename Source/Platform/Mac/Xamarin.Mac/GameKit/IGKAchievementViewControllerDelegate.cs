using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'GKGameCenterViewController' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'GKGameCenterViewController' instead.")]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Protocol(Name = "GKAchievementViewControllerDelegate", WrapperType = typeof(GKAchievementViewControllerDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFinish", Selector = "achievementViewControllerDidFinish:", ParameterType = new Type[] { typeof(GKAchievementViewController) }, ParameterByRef = new bool[] { false })]
public interface IGKAchievementViewControllerDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("achievementViewControllerDidFinish:")]
	[Preserve(Conditional = true)]
	void DidFinish(GKAchievementViewController viewController);
}
