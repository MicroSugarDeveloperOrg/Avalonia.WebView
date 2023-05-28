using System;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[TV(11, 3)]
[Mac(10, 13, 4)]
[iOS(11, 3)]
[Flags]
[Native]
public enum MPSNNTrainingStyle : ulong
{
	None = 0uL,
	Cpu = 1uL,
	Gpu = 2uL
}
