using ObjCRuntime;

namespace Metal;

[Native]
public enum MTLFeatureSet : ulong
{
	iOS_GPUFamily1_v1 = 0uL,
	iOS_GPUFamily1_v2 = 2uL,
	iOS_GPUFamily2_v1 = 1uL,
	iOS_GPUFamily2_v2 = 3uL,
	iOS_GPUFamily3_v1 = 4uL,
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	iOS_GPUFamily1_v3 = 5uL,
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	iOS_GPUFamily2_v3 = 6uL,
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	iOS_GPUFamily3_v2 = 7uL,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	iOS_GPUFamily1_v4 = 8uL,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	iOS_GPUFamily2_v4 = 9uL,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	iOS_GPUFamily3_v3 = 10uL,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	iOS_GPUFamily4_v1 = 11uL,
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	iOS_GPUFamily1_v5 = 12uL,
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	iOS_GPUFamily2_v5 = 13uL,
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	iOS_GPUFamily3_v4 = 14uL,
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	iOS_GPUFamily4_v2 = 15uL,
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	iOS_GPUFamily5_v1 = 16uL,
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	macOS_GPUFamily1_v1 = 10000uL,
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'macOS, GPUFamily1, v1' instead.")]
	OSX_GPUFamily1_v1 = 10000uL,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	macOS_GPUFamily1_v2 = 10001uL,
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'macOS, GPUFamily1, v2' instead.")]
	OSX_GPUFamily1_v2 = 10001uL,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	macOS_ReadWriteTextureTier2 = 10002uL,
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'macOS, ReadWriteTextureTier2' instead.")]
	OSX_ReadWriteTextureTier2 = 10002uL,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	macOS_GPUFamily1_v3 = 10003uL,
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	macOS_GPUFamily1_v4 = 10004uL,
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	macOS_GPUFamily2_v1 = 10005uL,
	[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
	TVOS_GPUFamily1_v1 = 30000uL,
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	tvOS_GPUFamily1_v2 = 30001uL,
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	tvOS_GPUFamily1_v3 = 30002uL,
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	tvOS_GPUFamily2_v1 = 30003uL,
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	tvOS_GPUFamily1_v4 = 30004uL
}
