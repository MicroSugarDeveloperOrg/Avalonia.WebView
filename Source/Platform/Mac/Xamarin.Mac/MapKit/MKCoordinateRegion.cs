using System.Runtime.InteropServices;
using CoreLocation;

namespace MapKit;

[Mac(10, 9)]
public struct MKCoordinateRegion
{
	public CLLocationCoordinate2D Center;

	public MKCoordinateSpan Span;

	public MKCoordinateRegion(CLLocationCoordinate2D center, MKCoordinateSpan span)
	{
		Center = center;
		Span = span;
	}

	[DllImport("/System/Library/Frameworks/MapKit.framework/MapKit", EntryPoint = "MKCoordinateRegionMakeWithDistance")]
	public static extern MKCoordinateRegion FromDistance(CLLocationCoordinate2D center, double latitudinalMeters, double longitudinalMeters);

	[DllImport("/System/Library/Frameworks/MapKit.framework/MapKit", EntryPoint = "MKCoordinateRegionForMapRect")]
	public static extern MKCoordinateRegion FromMapRect(MKMapRect rect);

	public override string ToString()
	{
		return $"(Center={Center}, Span={Span}";
	}
}
