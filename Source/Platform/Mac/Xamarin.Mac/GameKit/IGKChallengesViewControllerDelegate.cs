using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Protocol(Name = "GKChallengesViewControllerDelegate", WrapperType = typeof(GKChallengesViewControllerDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFinish", Selector = "challengesViewControllerDidFinish:", ParameterType = new Type[] { typeof(GKChallengesViewController) }, ParameterByRef = new bool[] { false })]
public interface IGKChallengesViewControllerDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("challengesViewControllerDidFinish:")]
	[Preserve(Conditional = true)]
	void DidFinish(GKChallengesViewController viewController);
}
