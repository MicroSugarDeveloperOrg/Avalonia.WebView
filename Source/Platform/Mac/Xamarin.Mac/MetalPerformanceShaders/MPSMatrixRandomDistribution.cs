using System;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Flags]
[Native]
public enum MPSMatrixRandomDistribution : ulong
{
	Default = 1uL,
	Uniform = 2uL
}
