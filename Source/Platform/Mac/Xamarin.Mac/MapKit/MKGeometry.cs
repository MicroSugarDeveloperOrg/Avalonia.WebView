using System.Runtime.InteropServices;

namespace MapKit;

[Mac(10, 9)]
public static class MKGeometry
{
	[DllImport("/System/Library/Frameworks/MapKit.framework/MapKit", EntryPoint = "MKMapPointsPerMeterAtLatitude")]
	public static extern double MapPointsPerMeterAtLatitude(double latitude);

	[DllImport("/System/Library/Frameworks/MapKit.framework/MapKit", EntryPoint = "MKMetersPerMapPointAtLatitude")]
	public static extern double MetersPerMapPointAtLatitude(double latitude);

	[DllImport("/System/Library/Frameworks/MapKit.framework/MapKit", EntryPoint = "MKMetersBetweenMapPoints")]
	public static extern double MetersBetweenMapPoints(MKMapPoint a, MKMapPoint b);
}
