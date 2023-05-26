using ObjCRuntime;

namespace GameController;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, null)]
public struct GCRotationRate
{
	public double X;

	public double Y;

	public double Z;
}
