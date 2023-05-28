using ObjCRuntime;

namespace Metal;

[Native]
public enum MTLCommandBufferError : ulong
{
	None = 0uL,
	Internal = 1uL,
	Timeout = 2uL,
	PageFault = 3uL,
	Blacklisted = 4uL,
	NotPermitted = 7uL,
	OutOfMemory = 8uL,
	InvalidResource = 9uL,
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	Memoryless = 10uL,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	DeviceRemoved = 11uL
}
