using System;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Flags]
[Native]
[TV(11, 3)]
[Mac(10, 13, 4)]
[iOS(11, 3)]
public enum MPSCnnConvolutionGradientOption : ulong
{
	GradientWithData = 1uL,
	GradientWithWeightsAndBias = 2uL,
	All = 3uL
}
