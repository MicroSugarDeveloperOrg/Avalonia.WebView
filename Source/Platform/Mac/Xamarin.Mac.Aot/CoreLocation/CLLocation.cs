using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreLocation;

[Register("CLLocation", true)]
public class CLLocation : NSObject
{
	public static readonly double AccuracyBest;

	public static readonly double AccuracyNearestTenMeters;

	public static readonly double AccuracyHundredMeters;

	public static readonly double AccuracyKilometer;

	public static readonly double AccuracyThreeKilometers;

	public static readonly double AccurracyBestForNavigation;

	private static readonly IntPtr selCoordinateHandle;

	private static readonly IntPtr selAltitudeHandle;

	private static readonly IntPtr selHorizontalAccuracyHandle;

	private static readonly IntPtr selVerticalAccuracyHandle;

	private static readonly IntPtr selCourseHandle;

	private static readonly IntPtr selSpeedHandle;

	private static readonly IntPtr selTimestampHandle;

	private static readonly IntPtr selInitWithLatitudeLongitude_Handle;

	private static readonly IntPtr selInitWithCoordinateAltitudeHorizontalAccuracyVerticalAccuracyTimestamp_Handle;

	private static readonly IntPtr selDescriptionHandle;

	private static readonly IntPtr selGetDistanceFrom_Handle;

	private static readonly IntPtr selDistanceFromLocation_Handle;

	private static readonly IntPtr selInitWithCoordinateAltitudeHorizontalAccuracyVerticalAccuracyCourseSpeedTimestamp_Handle;

	private static readonly IntPtr class_ptr;

	private object __mt_Timestamp_var;

	private static NSString _ErrorUserInfoAlternateRegionKey;

	public override IntPtr ClassHandle => class_ptr;

	public virtual CLLocationCoordinate2D Coordinate
	{
		[Export("coordinate")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CLLocationCoordinate2D_objc_msgSend(base.Handle, selCoordinateHandle);
			}
			return Messaging.CLLocationCoordinate2D_objc_msgSendSuper(base.SuperHandle, selCoordinateHandle);
		}
	}

	public virtual double Altitude
	{
		[Export("altitude")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selAltitudeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selAltitudeHandle);
		}
	}

	public virtual double HorizontalAccuracy
	{
		[Export("horizontalAccuracy")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selHorizontalAccuracyHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selHorizontalAccuracyHandle);
		}
	}

	public virtual double VerticalAccuracy
	{
		[Export("verticalAccuracy")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selVerticalAccuracyHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selVerticalAccuracyHandle);
		}
	}

	public virtual double Course
	{
		[Export("course")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCourseHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCourseHandle);
		}
	}

	public virtual double Speed
	{
		[Export("speed")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selSpeedHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selSpeedHandle);
		}
	}

	public virtual NSDate Timestamp
	{
		[Export("timestamp")]
		get
		{
			return (NSDate)(__mt_Timestamp_var = ((!IsDirectBinding) ? ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimestampHandle))) : ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTimestampHandle)))));
		}
	}

	[Field("kCLErrorUserInfoAlternateRegionKey", "CoreLocation")]
	[MountainLion]
	public static NSString ErrorUserInfoAlternateRegionKey
	{
		[MountainLion]
		get
		{
			if (_ErrorUserInfoAlternateRegionKey == null)
			{
				_ErrorUserInfoAlternateRegionKey = Dlfcn.GetStringConstant(Libraries.CoreLocation.Handle, "kCLErrorUserInfoAlternateRegionKey");
			}
			return _ErrorUserInfoAlternateRegionKey;
		}
	}

	static CLLocation()
	{
		selCoordinateHandle = Selector.GetHandle("coordinate");
		selAltitudeHandle = Selector.GetHandle("altitude");
		selHorizontalAccuracyHandle = Selector.GetHandle("horizontalAccuracy");
		selVerticalAccuracyHandle = Selector.GetHandle("verticalAccuracy");
		selCourseHandle = Selector.GetHandle("course");
		selSpeedHandle = Selector.GetHandle("speed");
		selTimestampHandle = Selector.GetHandle("timestamp");
		selInitWithLatitudeLongitude_Handle = Selector.GetHandle("initWithLatitude:longitude:");
		selInitWithCoordinateAltitudeHorizontalAccuracyVerticalAccuracyTimestamp_Handle = Selector.GetHandle("initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:timestamp:");
		selDescriptionHandle = Selector.GetHandle("description");
		selGetDistanceFrom_Handle = Selector.GetHandle("getDistanceFrom:");
		selDistanceFromLocation_Handle = Selector.GetHandle("distanceFromLocation:");
		selInitWithCoordinateAltitudeHorizontalAccuracyVerticalAccuracyCourseSpeedTimestamp_Handle = Selector.GetHandle("initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:course:speed:timestamp:");
		class_ptr = Class.GetHandle("CLLocation");
		IntPtr intPtr = Libraries.CoreLocation.Handle;
		if (!(intPtr == IntPtr.Zero))
		{
			AccurracyBestForNavigation = Dlfcn.GetDouble(intPtr, "kCLLocationAccuracyBestForNavigation");
			AccuracyBest = Dlfcn.GetDouble(intPtr, "kCLLocationAccuracyBest");
			AccuracyNearestTenMeters = Dlfcn.GetDouble(intPtr, "kCLLocationAccuracyNearestTenMeters");
			AccuracyHundredMeters = Dlfcn.GetDouble(intPtr, "kCLLocationAccuracyHundredMeters");
			AccuracyKilometer = Dlfcn.GetDouble(intPtr, "kCLLocationAccuracyKilometer");
			AccuracyThreeKilometers = Dlfcn.GetDouble(intPtr, "kCLLocationAccuracyThreeKilometers");
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CLLocation()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CLLocation(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CLLocation(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CLLocation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithLatitude:longitude:")]
	public CLLocation(double latitude, double longitude)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_Double_Double(base.Handle, selInitWithLatitudeLongitude_Handle, latitude, longitude);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_Double_Double(base.SuperHandle, selInitWithLatitudeLongitude_Handle, latitude, longitude);
		}
	}

	[Export("initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:timestamp:")]
	public CLLocation(CLLocationCoordinate2D coordinate, double altitude, double hAccuracy, double vAccuracy, NSDate timestamp)
		: base(NSObjectFlag.Empty)
	{
		if (timestamp == null)
		{
			throw new ArgumentNullException("timestamp");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_Double_Double_IntPtr(base.Handle, selInitWithCoordinateAltitudeHorizontalAccuracyVerticalAccuracyTimestamp_Handle, coordinate, altitude, hAccuracy, vAccuracy, timestamp.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double_Double_Double_IntPtr(base.SuperHandle, selInitWithCoordinateAltitudeHorizontalAccuracyVerticalAccuracyTimestamp_Handle, coordinate, altitude, hAccuracy, vAccuracy, timestamp.Handle);
		}
	}

	[Export("description")]
	public new virtual string Description()
	{
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDescriptionHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDescriptionHandle));
	}

	[Export("getDistanceFrom:")]
	[Obsolete("Replaced by DistanceFrom", false)]
	public virtual double Distancefrom(CLLocation location)
	{
		if (location == null)
		{
			throw new ArgumentNullException("location");
		}
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_IntPtr(base.Handle, selGetDistanceFrom_Handle, location.Handle);
		}
		return Messaging.Double_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetDistanceFrom_Handle, location.Handle);
	}

	[Export("distanceFromLocation:")]
	public virtual double DistanceFrom(CLLocation location)
	{
		if (location == null)
		{
			throw new ArgumentNullException("location");
		}
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_IntPtr(base.Handle, selDistanceFromLocation_Handle, location.Handle);
		}
		return Messaging.Double_objc_msgSendSuper_IntPtr(base.SuperHandle, selDistanceFromLocation_Handle, location.Handle);
	}

	[Export("initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:course:speed:timestamp:")]
	public CLLocation(CLLocationCoordinate2D coordinate, double altitude, double hAccuracy, double vAccuracy, double course, double speed, NSDate timestamp)
		: base(NSObjectFlag.Empty)
	{
		if (timestamp == null)
		{
			throw new ArgumentNullException("timestamp");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_Double_Double_Double_Double_IntPtr(base.Handle, selInitWithCoordinateAltitudeHorizontalAccuracyVerticalAccuracyCourseSpeedTimestamp_Handle, coordinate, altitude, hAccuracy, vAccuracy, course, speed, timestamp.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double_Double_Double_Double_Double_IntPtr(base.SuperHandle, selInitWithCoordinateAltitudeHorizontalAccuracyVerticalAccuracyCourseSpeedTimestamp_Handle, coordinate, altitude, hAccuracy, vAccuracy, course, speed, timestamp.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Timestamp_var = null;
		}
	}
}
