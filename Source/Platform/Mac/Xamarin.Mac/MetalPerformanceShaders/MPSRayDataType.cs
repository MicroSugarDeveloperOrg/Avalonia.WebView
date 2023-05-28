using ObjCRuntime;

namespace MetalPerformanceShaders;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Native]
public enum MPSRayDataType : ulong
{
	OriginDirection,
	OriginMinDistanceDirectionMaxDistance,
	OriginMaskDirectionMaxDistance
}
