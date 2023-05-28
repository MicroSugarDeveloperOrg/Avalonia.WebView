using System.ComponentModel;
using System.Diagnostics;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MapKit;

[Register("MKPolygon", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKPolygon : MKMultiPoint, IMKGeoJsonObject, INativeObject, IDisposable, IMKOverlay, IMKAnnotation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingMapRect = "boundingMapRect";

	private static readonly IntPtr selBoundingMapRectHandle = Selector.GetHandle("boundingMapRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanReplaceMapContent = "canReplaceMapContent";

	private static readonly IntPtr selCanReplaceMapContentHandle = Selector.GetHandle("canReplaceMapContent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCoordinate = "coordinate";

	private static readonly IntPtr selCoordinateHandle = Selector.GetHandle("coordinate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInteriorPolygons = "interiorPolygons";

	private static readonly IntPtr selInteriorPolygonsHandle = Selector.GetHandle("interiorPolygons");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntersectsMapRect_ = "intersectsMapRect:";

	private static readonly IntPtr selIntersectsMapRect_Handle = Selector.GetHandle("intersectsMapRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPolygonWithCoordinates_Count_ = "polygonWithCoordinates:count:";

	private static readonly IntPtr selPolygonWithCoordinates_Count_Handle = Selector.GetHandle("polygonWithCoordinates:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPolygonWithCoordinates_Count_InteriorPolygons_ = "polygonWithCoordinates:count:interiorPolygons:";

	private static readonly IntPtr selPolygonWithCoordinates_Count_InteriorPolygons_Handle = Selector.GetHandle("polygonWithCoordinates:count:interiorPolygons:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPolygonWithPoints_Count_ = "polygonWithPoints:count:";

	private static readonly IntPtr selPolygonWithPoints_Count_Handle = Selector.GetHandle("polygonWithPoints:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPolygonWithPoints_Count_InteriorPolygons_ = "polygonWithPoints:count:interiorPolygons:";

	private static readonly IntPtr selPolygonWithPoints_Count_InteriorPolygons_Handle = Selector.GetHandle("polygonWithPoints:count:interiorPolygons:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKPolygon");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual MKMapRect BoundingMapRect
	{
		[Export("boundingMapRect")]
		get
		{
			MKMapRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.MKMapRect_objc_msgSend_stret(out retval, base.Handle, selBoundingMapRectHandle);
			}
			else
			{
				Messaging.MKMapRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selBoundingMapRectHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual bool CanReplaceMapContent
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("canReplaceMapContent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanReplaceMapContentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanReplaceMapContentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CLLocationCoordinate2D Coordinate
	{
		[Export("coordinate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CLLocationCoordinate2D_objc_msgSend(base.Handle, selCoordinateHandle);
			}
			return Messaging.CLLocationCoordinate2D_objc_msgSendSuper(base.SuperHandle, selCoordinateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKPolygon[] InteriorPolygons
	{
		[Export("interiorPolygons")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<MKPolygon>(Messaging.IntPtr_objc_msgSend(base.Handle, selInteriorPolygonsHandle));
			}
			return NSArray.ArrayFromHandle<MKPolygon>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInteriorPolygonsHandle));
		}
	}

	public unsafe static MKPolygon FromPoints(MKMapPoint[] points)
	{
		if (points == null)
		{
			throw new ArgumentNullException("points");
		}
		if (points.Length == 0)
		{
			return _FromPoints(IntPtr.Zero, 0);
		}
		fixed (MKMapPoint* ptr = &points[0])
		{
			return _FromPoints((IntPtr)ptr, points.Length);
		}
	}

	public unsafe static MKPolygon FromPoints(MKMapPoint[] points, MKPolygon[] interiorPolygons)
	{
		if (points == null)
		{
			throw new ArgumentNullException("points");
		}
		if (points.Length == 0)
		{
			return _FromPoints(IntPtr.Zero, 0);
		}
		fixed (MKMapPoint* ptr = &points[0])
		{
			return _FromPoints((IntPtr)ptr, points.Length, interiorPolygons);
		}
	}

	public unsafe static MKPolygon FromCoordinates(CLLocationCoordinate2D[] coords)
	{
		if (coords == null)
		{
			throw new ArgumentNullException("coords");
		}
		if (coords.Length == 0)
		{
			return _FromCoordinates(IntPtr.Zero, 0);
		}
		fixed (CLLocationCoordinate2D* ptr = &coords[0])
		{
			return _FromCoordinates((IntPtr)ptr, coords.Length);
		}
	}

	public unsafe static MKPolygon FromCoordinates(CLLocationCoordinate2D[] coords, MKPolygon[] interiorPolygons)
	{
		if (coords == null)
		{
			throw new ArgumentNullException("coords");
		}
		if (coords.Length == 0)
		{
			return _FromCoordinates(IntPtr.Zero, 0);
		}
		fixed (CLLocationCoordinate2D* ptr = &coords[0])
		{
			return _FromCoordinates((IntPtr)ptr, coords.Length, interiorPolygons);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKPolygon()
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
	protected MKPolygon(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKPolygon(IntPtr handle)
		: base(handle)
	{
	}

	[Export("intersectsMapRect:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Intersects(MKMapRect rect)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_MKMapRect(base.Handle, selIntersectsMapRect_Handle, rect);
		}
		return Messaging.bool_objc_msgSendSuper_MKMapRect(base.SuperHandle, selIntersectsMapRect_Handle, rect);
	}

	[Export("polygonWithCoordinates:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static MKPolygon _FromCoordinates(IntPtr coords, nint count)
	{
		return Runtime.GetNSObject<MKPolygon>(Messaging.IntPtr_objc_msgSend_IntPtr_nint(class_ptr, selPolygonWithCoordinates_Count_Handle, coords, count));
	}

	[Export("polygonWithCoordinates:count:interiorPolygons:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static MKPolygon _FromCoordinates(IntPtr coords, nint count, MKPolygon[] interiorPolygons)
	{
		if (interiorPolygons == null)
		{
			throw new ArgumentNullException("interiorPolygons");
		}
		NSArray nSArray = NSArray.FromNSObjects(interiorPolygons);
		MKPolygon nSObject = Runtime.GetNSObject<MKPolygon>(Messaging.IntPtr_objc_msgSend_IntPtr_nint_IntPtr(class_ptr, selPolygonWithCoordinates_Count_InteriorPolygons_Handle, coords, count, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("polygonWithPoints:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static MKPolygon _FromPoints(IntPtr points, nint count)
	{
		return Runtime.GetNSObject<MKPolygon>(Messaging.IntPtr_objc_msgSend_IntPtr_nint(class_ptr, selPolygonWithPoints_Count_Handle, points, count));
	}

	[Export("polygonWithPoints:count:interiorPolygons:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static MKPolygon _FromPoints(IntPtr points, nint count, MKPolygon[] interiorPolygons)
	{
		if (interiorPolygons == null)
		{
			throw new ArgumentNullException("interiorPolygons");
		}
		NSArray nSArray = NSArray.FromNSObjects(interiorPolygons);
		MKPolygon nSObject = Runtime.GetNSObject<MKPolygon>(Messaging.IntPtr_objc_msgSend_IntPtr_nint_IntPtr(class_ptr, selPolygonWithPoints_Count_InteriorPolygons_Handle, points, count, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}
}
