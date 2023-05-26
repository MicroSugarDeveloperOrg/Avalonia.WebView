using CoreLocation;
using System.Runtime.InteropServices;

namespace MapKit;

[Mac(10, 9)]
public struct MKMapPoint
{
    public double X;

    public double Y;

    [DllImport("/System/Library/Frameworks/MapKit.framework/MapKit", EntryPoint = "MKMapPointForCoordinate")]
    public static extern MKMapPoint FromCoordinate(CLLocationCoordinate2D coordinate);

    [DllImport("/System/Library/Frameworks/MapKit.framework/MapKit", EntryPoint = "MKCoordinateForMapPoint")]
    public static extern CLLocationCoordinate2D ToCoordinate(MKMapPoint mapPoint);

    public MKMapPoint(double x, double y)
    {
        X = x;
        Y = y;
    }

    public static bool operator ==(MKMapPoint a, MKMapPoint b)
    {
        return a.X == b.X && a.Y == b.Y;
    }

    public static bool operator !=(MKMapPoint a, MKMapPoint b)
    {
        return a.X != b.X || a.Y != b.Y;
    }

    public override bool Equals(object other)
    {
        if (other is MKMapPoint mKMapPoint)
        {
            return mKMapPoint.X == X && mKMapPoint.Y == Y;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return (int)(X + Y);
    }

    public override string ToString()
    {
        return $"{{{X}, {Y}}}";
    }
}