using ObjCRuntime;

namespace MetalPerformanceShaders;

[iOS(11, 3)]
[TV(11, 3)]
[Mac(10, 13, 4)]
public struct MPSImageRegion
{
	public MPSImageCoordinate Offset;

	public MPSImageCoordinate Size;
}
