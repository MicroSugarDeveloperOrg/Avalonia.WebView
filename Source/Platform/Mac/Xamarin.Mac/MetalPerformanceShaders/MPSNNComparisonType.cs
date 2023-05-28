using System;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Flags]
[Native]
[TV(11, 3)]
[Mac(10, 13, 4)]
[iOS(11, 3)]
public enum MPSNNComparisonType : ulong
{
	Equal = 0uL,
	NotEqual = 1uL,
	Less = 2uL,
	LessOrEqual = 3uL,
	Greater = 4uL,
	GreaterOrEqual = 5uL
}
