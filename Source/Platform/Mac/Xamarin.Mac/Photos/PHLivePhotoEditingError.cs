using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Native]
public enum PHLivePhotoEditingError : long
{
	Unknown,
	Aborted
}
