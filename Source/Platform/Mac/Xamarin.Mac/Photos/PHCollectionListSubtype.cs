using System;
using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Native]
public enum PHCollectionListSubtype : long
{
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	MomentListCluster = 1L,
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	MomentListYear = 2L,
	RegularFolder = 100L,
	SmartFolderEvents = 200L,
	SmartFolderFaces = 201L,
	[Obsolete("Incorrect value (exists in 'PHAssetCollectionSubtype').", false)]
	SmartAlbumSelfPortraits = 210L,
	[Obsolete("Incorrect value (exists in 'PHAssetCollectionSubtype').", false)]
	SmartAlbumScreenshots = 211L,
	Any = long.MaxValue
}
