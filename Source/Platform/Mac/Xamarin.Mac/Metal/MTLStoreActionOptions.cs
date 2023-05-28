using System;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum MTLStoreActionOptions : ulong
{
	None = 0uL,
	CustomSamplePositions = 1uL
}
