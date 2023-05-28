using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Native]
public enum PHAssetResourceType : long
{
	Photo = 1L,
	Video,
	Audio,
	AlternatePhoto,
	FullSizePhoto,
	FullSizeVideo,
	AdjustmentData,
	AdjustmentBasePhoto,
	[Introduced(PlatformName.iOS, 9, 1, PlatformArchitecture.All, null)]
	PairedVideo,
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	FullSizePairedVideo,
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	AdjustmentBasePairedVideo,
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	AdjustmentBaseVideo
}
