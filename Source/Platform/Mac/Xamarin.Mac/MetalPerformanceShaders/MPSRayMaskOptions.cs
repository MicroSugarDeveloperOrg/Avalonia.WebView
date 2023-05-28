using System;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Flags]
[Native]
public enum MPSRayMaskOptions : ulong
{
	None = 0uL,
	Primitive = 1uL,
	Instance = 2uL
}
