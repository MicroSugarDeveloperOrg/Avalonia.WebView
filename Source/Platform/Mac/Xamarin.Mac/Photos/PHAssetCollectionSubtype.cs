using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Native]
public enum PHAssetCollectionSubtype : long
{
	AlbumRegular = 2L,
	AlbumSyncedEvent = 3L,
	AlbumSyncedFaces = 4L,
	AlbumSyncedAlbum = 5L,
	AlbumImported = 6L,
	AlbumMyPhotoStream = 100L,
	AlbumCloudShared = 101L,
	SmartAlbumGeneric = 200L,
	SmartAlbumPanoramas = 201L,
	SmartAlbumVideos = 202L,
	SmartAlbumFavorites = 203L,
	SmartAlbumTimelapses = 204L,
	SmartAlbumAllHidden = 205L,
	SmartAlbumRecentlyAdded = 206L,
	SmartAlbumBursts = 207L,
	SmartAlbumSlomoVideos = 208L,
	SmartAlbumUserLibrary = 209L,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	SmartAlbumSelfPortraits = 210L,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	SmartAlbumScreenshots = 211L,
	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	SmartAlbumDepthEffect = 212L,
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	SmartAlbumLivePhotos = 213L,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	SmartAlbumAnimated = 214L,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	SmartAlbumLongExposures = 215L,
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	SmartAlbumUnableToUpload = 216L,
	Any = long.MaxValue
}
