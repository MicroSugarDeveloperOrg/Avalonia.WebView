using System;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum MTLResourceOptions : ulong
{
	CpuCacheModeDefault = 0uL,
	CpuCacheModeWriteCombined = 1uL,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	StorageModeShared = 0uL,
	StorageModeManaged = 0x10uL,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	StorageModePrivate = 0x20uL,
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	StorageModeMemoryless = 0x30uL,
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	HazardTrackingModeUntracked = 0x100uL
}
