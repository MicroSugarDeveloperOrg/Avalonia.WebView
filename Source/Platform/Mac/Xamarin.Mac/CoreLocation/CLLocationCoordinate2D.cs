using System.Runtime.InteropServices;

namespace CoreLocation;

public struct CLLocationCoordinate2D
{
	public double Latitude;

	public double Longitude;

	public CLLocationCoordinate2D(double latitude, double longitude)
	{
		Latitude = latitude;
		Longitude = longitude;
	}

	[DllImport("/System/Library/Frameworks/CoreLocation.framework/CoreLocation")]
	private static extern int CLLocationCoordinate2DIsValid(CLLocationCoordinate2D cord);

	public bool IsValid()
	{
		return CLLocationCoordinate2DIsValid(this) != 0;
	}
}
