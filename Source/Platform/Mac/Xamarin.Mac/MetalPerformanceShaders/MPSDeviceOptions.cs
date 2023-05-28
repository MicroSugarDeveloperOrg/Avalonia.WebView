using System;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Flags]
[Native]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[TV(12, 2)]
[Mac(10, 14, 4)]
[iOS(12, 2)]
public enum MPSDeviceOptions : ulong
{
	Default = 0uL,
	LowPower = 1uL,
	SkipRemovable = 2uL
}
