using System;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Flags]
[Native]
public enum MPSAccelerationStructureUsage : ulong
{
	None = 0uL,
	Refit = 1uL,
	FrequentRebuild = 2uL
}
