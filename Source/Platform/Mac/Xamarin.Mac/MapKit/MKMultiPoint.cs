using System;
using System.ComponentModel;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKMultiPoint", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKMultiPoint : MKShape, IMKGeoJsonObject, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetCoordinates_Range_ = "getCoordinates:range:";

	private static readonly IntPtr selGetCoordinates_Range_Handle = Selector.GetHandle("getCoordinates:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointCount = "pointCount";

	private static readonly IntPtr selPointCountHandle = Selector.GetHandle("pointCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPoints = "points";

	private static readonly IntPtr selPointsHandle = Selector.GetHandle("points");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKMultiPoint");

	public unsafe MKMapPoint[] Points
	{
		get
		{
			MKMapPoint* ptr = (MKMapPoint*)(void*)_Points;
			nint pointCount = PointCount;
			MKMapPoint[] array = new MKMapPoint[(long)pointCount];
			for (int i = 0; i < pointCount; i++)
			{
				array[i] = ptr[i];
			}
			return array;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint PointCount
	{
		[Export("pointCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selPointCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selPointCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _Points
	{
		[Export("points")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selPointsHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPointsHandle);
		}
	}

	public unsafe CLLocationCoordinate2D[] GetCoordinates(int first, int count)
	{
		NSRange range = new NSRange(first, count);
		CLLocationCoordinate2D[] array = new CLLocationCoordinate2D[count];
		fixed (CLLocationCoordinate2D* ptr = &array[0])
		{
			GetCoords((IntPtr)ptr, range);
		}
		return array;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKMultiPoint()
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
	protected MKMultiPoint(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKMultiPoint(IntPtr handle)
		: base(handle)
	{
	}

	[Export("getCoordinates:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void GetCoords(IntPtr dest, NSRange range)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selGetCoordinates_Range_Handle, dest, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selGetCoordinates_Range_Handle, dest, range);
		}
	}
}
