using ObjCRuntime;

namespace PhotosUI;

[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 1, PlatformArchitecture.All, null)]
[Native]
public enum PHLivePhotoViewPlaybackStyle : long
{
	Undefined,
	Full,
	Hint
}
