using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Native]
public enum PHPhotosError : long
{
	Invalid = -1L,
	UserCancelled = 3072L,
	LibraryVolumeOffline = 3114L,
	RelinquishingLibraryBundleToWriter = 3142L,
	SwitchingSystemPhotoLibrary = 3143L
}
