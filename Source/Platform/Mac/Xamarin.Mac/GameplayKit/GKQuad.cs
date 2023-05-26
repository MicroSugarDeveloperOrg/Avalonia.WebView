using ObjCRuntime;
using OpenTK;

namespace GameplayKit;

[iOS(10, 0)]
[TV(10, 0)]
[Mac(10, 12)]
public struct GKQuad
{
    public Vector2 Min;

    public Vector2 Max;
}
