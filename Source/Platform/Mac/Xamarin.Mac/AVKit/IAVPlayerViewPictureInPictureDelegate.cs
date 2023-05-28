using System;
using Foundation;
using ObjCRuntime;

namespace AVKit;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "AVPlayerViewPictureInPictureDelegate", WrapperType = typeof(AVPlayerViewPictureInPictureDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStart", Selector = "playerViewWillStartPictureInPicture:", ParameterType = new Type[] { typeof(AVPlayerView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStart", Selector = "playerViewDidStartPictureInPicture:", ParameterType = new Type[] { typeof(AVPlayerView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToStart", Selector = "playerView:failedToStartPictureInPictureWithError:", ParameterType = new Type[]
{
	typeof(AVPlayerView),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStop", Selector = "playerViewWillStopPictureInPicture:", ParameterType = new Type[] { typeof(AVPlayerView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStop", Selector = "playerViewDidStopPictureInPicture:", ParameterType = new Type[] { typeof(AVPlayerView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RestoreUserInterface", Selector = "playerView:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:", ParameterType = new Type[]
{
	typeof(AVPlayerView),
	typeof(Action<bool>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V0)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAutomaticallyDismiss", Selector = "playerViewShouldAutomaticallyDismissAtPictureInPictureStart:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(AVPlayerView) }, ParameterByRef = new bool[] { false })]
public interface IAVPlayerViewPictureInPictureDelegate : INativeObject, IDisposable
{
}
