using System;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Flags]
[Native]
[TV(11, 3)]
[Mac(10, 13, 4)]
[iOS(11, 3)]
public enum MPSCnnBatchNormalizationFlags : ulong
{
	Default = 0uL,
	CalculateStatisticsAutomatic = 0uL,
	CalculateStatisticsAlways = 1uL,
	CalculateStatisticsNever = 2uL,
	CalculateStatisticsMask = 3uL
}
