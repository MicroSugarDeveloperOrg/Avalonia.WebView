using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Native]
public enum PHCollectionListType : long
{
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	MomentList = 1L,
	Folder,
	SmartFolder
}
