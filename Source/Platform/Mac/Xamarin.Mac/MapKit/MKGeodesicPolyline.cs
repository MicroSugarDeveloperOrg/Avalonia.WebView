using System;
using System.ComponentModel;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKGeodesicPolyline", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKGeodesicPolyline : MKPolyline
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPolylineWithCoordinates_Count_ = "polylineWithCoordinates:count:";

	private static readonly IntPtr selPolylineWithCoordinates_Count_Handle = Selector.GetHandle("polylineWithCoordinates:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPolylineWithPoints_Count_ = "polylineWithPoints:count:";

	private static readonly IntPtr selPolylineWithPoints_Count_Handle = Selector.GetHandle("polylineWithPoints:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKGeodesicPolyline");

	public override IntPtr ClassHandle => class_ptr;

	public new unsafe static MKGeodesicPolyline FromPoints(MKMapPoint[] points)
	{
		if (points == null)
		{
			throw new ArgumentNullException("points");
		}
		if (points.Length == 0)
		{
			return PolylineWithPoints(IntPtr.Zero, 0);
		}
		fixed (MKMapPoint* ptr = &points[0])
		{
			return PolylineWithPoints((IntPtr)ptr, points.Length);
		}
	}

	public new unsafe static MKGeodesicPolyline FromCoordinates(CLLocationCoordinate2D[] coords)
	{
		if (coords == null)
		{
			throw new ArgumentNullException("coords");
		}
		if (coords.Length == 0)
		{
			return PolylineWithCoordinates(IntPtr.Zero, 0);
		}
		fixed (CLLocationCoordinate2D* ptr = &coords[0])
		{
			return PolylineWithCoordinates((IntPtr)ptr, coords.Length);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKGeodesicPolyline()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MKGeodesicPolyline(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKGeodesicPolyline(IntPtr handle)
		: base(handle)
	{
	}

	[Export("polylineWithCoordinates:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static MKGeodesicPolyline PolylineWithCoordinates(IntPtr coords, nint count)
	{
		return Runtime.GetNSObject<MKGeodesicPolyline>(Messaging.IntPtr_objc_msgSend_IntPtr_nint(class_ptr, selPolylineWithCoordinates_Count_Handle, coords, count));
	}

	[Export("polylineWithPoints:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static MKGeodesicPolyline PolylineWithPoints(IntPtr points, nint count)
	{
		return Runtime.GetNSObject<MKGeodesicPolyline>(Messaging.IntPtr_objc_msgSend_IntPtr_nint(class_ptr, selPolylineWithPoints_Count_Handle, points, count));
	}
}
