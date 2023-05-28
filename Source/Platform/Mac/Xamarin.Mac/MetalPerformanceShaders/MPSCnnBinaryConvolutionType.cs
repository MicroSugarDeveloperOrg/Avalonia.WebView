using ObjCRuntime;

namespace MetalPerformanceShaders;

[TV(11, 0)]
[Mac(10, 13)]
[iOS(11, 0)]
[Native]
public enum MPSCnnBinaryConvolutionType : ulong
{
	BinaryWeights,
	Xnor,
	And
}
