using System;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Flags]
[Native]
public enum MPSPurgeableState : ulong
{
	AllocationDeferred = 0uL,
	KeepCurrent = 1uL,
	NonVolatile = 2uL,
	Volatile = 3uL,
	Empty = 4uL
}
