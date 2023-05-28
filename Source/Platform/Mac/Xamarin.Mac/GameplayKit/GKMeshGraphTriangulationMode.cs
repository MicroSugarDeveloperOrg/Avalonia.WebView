using System;
using ObjCRuntime;

namespace GameplayKit;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum GKMeshGraphTriangulationMode : ulong
{
	Vertices = 1uL,
	Centers = 2uL,
	EdgeMidpoints = 4uL
}
