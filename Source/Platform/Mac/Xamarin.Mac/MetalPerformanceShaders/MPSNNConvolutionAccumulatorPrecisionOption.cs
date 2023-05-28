using System;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Flags]
[Native]
[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
public enum MPSNNConvolutionAccumulatorPrecisionOption : ulong
{
	Half = 0uL,
	Float = 1uL
}
