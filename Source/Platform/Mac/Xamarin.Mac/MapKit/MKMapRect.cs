using System.Runtime.InteropServices;
using CoreGraphics;
using ObjCRuntime;

namespace MapKit;

[Mac(10, 9)]
public struct MKMapRect
{
	[TV(9, 2)]
	public static readonly MKMapRect Null = new MKMapRect(double.PositiveInfinity, double.PositiveInfinity, 0.0, 0.0);

	public MKMapPoint Origin;

	public MKMapSize Size;

	public double MinX => Origin.X;

	public double MinY => Origin.Y;

	public double MaxX => Origin.X + Size.Width;

	public double MaxY => Origin.Y + Size.Height;

	public double MidX => Origin.X + Size.Width / 2.0;

	public double MidY => Origin.Y + Size.Height / 2.0;

	public double Width => Size.Width;

	public double Height => Size.Height;

	public bool IsNull => double.IsInfinity(Origin.X) || double.IsInfinity(Origin.Y);

	public bool IsEmpty => IsNull || Size.Width == 0.0 || Size.Height == 0.0;

	[TV(9, 2)]
	public MKMapRect World => new MKMapRect(0.0, 0.0, 268435456.0, 268435456.0);

	public bool Spans180thMeridian => MKMapRectSpans180thMeridian(this);

	public MKMapRect(MKMapPoint origin, MKMapSize size)
	{
		Origin = origin;
		Size = size;
	}

	public MKMapRect(double x, double y, double width, double height)
	{
		Origin.X = x;
		Origin.Y = y;
		Size.Width = width;
		Size.Height = height;
	}

	public static bool operator ==(MKMapRect a, MKMapRect b)
	{
		return a.Origin == b.Origin && a.Size == b.Size;
	}

	public static bool operator !=(MKMapRect a, MKMapRect b)
	{
		return a.Origin != b.Origin || a.Size != b.Size;
	}

	public override bool Equals(object other)
	{
		if (other is MKMapRect mKMapRect)
		{
			return mKMapRect.Origin == Origin && mKMapRect.Size == Size;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return Origin.GetHashCode() ^ Size.GetHashCode();
	}

	public override string ToString()
	{
		return $"{{{Origin}, {Size}}}";
	}

	[DllImport("/System/Library/Frameworks/MapKit.framework/MapKit")]
	private static extern bool MKMapRectContainsPoint(MKMapRect rect, MKMapPoint point);

	public bool Contains(MKMapPoint point)
	{
		return MKMapRectContainsPoint(this, point);
	}

	[DllImport("/System/Library/Frameworks/MapKit.framework/MapKit")]
	private static extern bool MKMapRectContainsRect(MKMapRect rect1, MKMapRect rect2);

	public bool Contains(MKMapRect rect)
	{
		return MKMapRectContainsRect(this, rect);
	}

	[DllImport("/System/Library/Frameworks/MapKit.framework/MapKit", EntryPoint = "MKMapRectUnion")]
	public static extern MKMapRect Union(MKMapRect rect1, MKMapRect rect2);

	[DllImport("/System/Library/Frameworks/MapKit.framework/MapKit", EntryPoint = "MKMapRectIntersection")]
	public static extern MKMapRect Intersection(MKMapRect rect1, MKMapRect rect2);

	[DllImport("/System/Library/Frameworks/MapKit.framework/MapKit", EntryPoint = "MKMapRectIntersectsRect")]
	public static extern bool Intersects(MKMapRect rect1, MKMapRect rect2);

	[DllImport("/System/Library/Frameworks/MapKit.framework/MapKit")]
	private static extern MKMapRect MKMapRectInset(MKMapRect rect, double dx, double dy);

	public MKMapRect Inset(double dx, double dy)
	{
		return MKMapRectInset(this, dx, dy);
	}

	[DllImport("/System/Library/Frameworks/MapKit.framework/MapKit")]
	private static extern MKMapRect MKMapRectOffset(MKMapRect rect, double dx, double dy);

	public MKMapRect Offset(double dx, double dy)
	{
		return MKMapRectOffset(this, dx, dy);
	}

	[DllImport("/System/Library/Frameworks/MapKit.framework/MapKit")]
	private static extern void MKMapRectDivide(MKMapRect rect, out MKMapRect slice, out MKMapRect remainder, double amount, CGRectEdge edge);

	public MKMapRect Divide(double amount, CGRectEdge edge, out MKMapRect remainder)
	{
		MKMapRectDivide(this, out var slice, out remainder, amount, edge);
		return slice;
	}

	[DllImport("/System/Library/Frameworks/MapKit.framework/MapKit")]
	private static extern bool MKMapRectSpans180thMeridian(MKMapRect rect);

	[DllImport("/System/Library/Frameworks/MapKit.framework/MapKit")]
	private static extern MKMapRect MKMapRectRemainder(MKMapRect rect);

	public MKMapRect Remainder()
	{
		return MKMapRectRemainder(this);
	}
}
