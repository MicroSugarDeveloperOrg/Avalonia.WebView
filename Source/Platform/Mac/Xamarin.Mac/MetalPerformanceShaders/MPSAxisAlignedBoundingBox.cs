using OpenTK;

namespace MetalPerformanceShaders;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
public struct MPSAxisAlignedBoundingBox
{
    public Vector3 Min;

    public Vector3 Max;
}