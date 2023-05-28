using System;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[iOS(9, 0)]
[Mac(10, 13)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Native]
[Flags]
public enum MPSKernelOptions : ulong
{
	None = 0uL,
	SkipApiValidation = 1uL,
	AllowReducedPrecision = 2uL,
	[iOS(10, 0)]
	[TV(10, 0)]
	DisableInternalTiling = 4uL,
	[iOS(10, 0)]
	[TV(10, 0)]
	InsertDebugGroups = 8uL,
	[iOS(11, 0)]
	[TV(11, 0)]
	Verbose = 0x10uL,
	[Obsolete("Use 'AllowReducedPrecision' instead.")]
	MPSKernelOptionsAllowReducedPrecision = 2uL
}
