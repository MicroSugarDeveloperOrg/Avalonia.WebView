using ObjCRuntime;

namespace MetalPerformanceShaders;

[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[TV(11, 0)]
[Mac(10, 13)]
[iOS(11, 0)]
public enum MPSMatrixDecompositionStatus
{
	Success = 0,
	Failure = -1,
	Singular = -2,
	NonPositiveDefinite = -3
}
