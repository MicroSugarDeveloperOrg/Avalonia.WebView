using Foundation;
using ObjCRuntime;

namespace CoreLocation;

public static class CLLocationDistance
{
	[Field("kCLDistanceFilterNone", "CoreLocation")]
	public static double FilterNone => Dlfcn.GetDouble(Libraries.CoreLocation.Handle, "kCLDistanceFilterNone");

	[Field("CLLocationDistanceMax", "CoreLocation")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static double MaxDistance
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetDouble(Libraries.CoreLocation.Handle, "CLLocationDistanceMax");
		}
	}
}
