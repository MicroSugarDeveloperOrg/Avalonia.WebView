using System;
using Foundation;
using ObjCRuntime;

namespace PhotosUI;

[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Protocol(Name = "PHLivePhotoViewDelegate", WrapperType = typeof(PHLivePhotoViewDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginPlayback", Selector = "livePhotoView:willBeginPlaybackWithStyle:", ParameterType = new Type[]
{
	typeof(PHLivePhotoView),
	typeof(PHLivePhotoViewPlaybackStyle)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndPlayback", Selector = "livePhotoView:didEndPlaybackWithStyle:", ParameterType = new Type[]
{
	typeof(PHLivePhotoView),
	typeof(PHLivePhotoViewPlaybackStyle)
}, ParameterByRef = new bool[] { false, false })]
public interface IPHLivePhotoViewDelegate : INativeObject, IDisposable
{
}
