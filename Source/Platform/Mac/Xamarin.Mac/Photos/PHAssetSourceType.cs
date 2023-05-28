using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Native]
public enum PHAssetSourceType : ulong
{
	None = 0uL,
	UserLibrary = 1uL,
	CloudShared = 2uL,
	iTunesSynced = 4uL
}
