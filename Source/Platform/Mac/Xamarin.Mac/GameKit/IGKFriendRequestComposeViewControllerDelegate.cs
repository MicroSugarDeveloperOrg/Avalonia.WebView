using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
[Protocol(Name = "GKFriendRequestComposeViewControllerDelegate", WrapperType = typeof(GKFriendRequestComposeViewControllerDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFinish", Selector = "friendRequestComposeViewControllerDidFinish:", ParameterType = new Type[] { typeof(GKFriendRequestComposeViewController) }, ParameterByRef = new bool[] { false })]
public interface IGKFriendRequestComposeViewControllerDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("friendRequestComposeViewControllerDidFinish:")]
	[Preserve(Conditional = true)]
	void DidFinish(GKFriendRequestComposeViewController viewController);
}
