using ObjCRuntime;

namespace Metal;

[Native]
public enum MTLArgumentType : ulong
{
	Buffer = 0uL,
	ThreadgroupMemory = 1uL,
	Texture = 2uL,
	Sampler = 3uL,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	ImageblockData = 16uL,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	Imageblock = 17uL
}
