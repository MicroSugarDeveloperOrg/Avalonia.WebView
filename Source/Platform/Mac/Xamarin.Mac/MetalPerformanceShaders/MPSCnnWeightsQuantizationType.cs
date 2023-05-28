using ObjCRuntime;

namespace MetalPerformanceShaders;

[TV(11, 3)]
[Mac(10, 13, 4)]
[iOS(11, 3)]
public enum MPSCnnWeightsQuantizationType : uint
{
	None,
	Linear,
	LookupTable
}
