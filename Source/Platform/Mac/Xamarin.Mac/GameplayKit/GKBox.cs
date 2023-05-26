using ObjCRuntime;
using OpenTK;

namespace GameplayKit;

[iOS(10, 0)]
[TV(10, 0)]
[Mac(10, 12)]
public struct GKBox
{
    public Vector3 Min;

    public Vector3 Max;
}
