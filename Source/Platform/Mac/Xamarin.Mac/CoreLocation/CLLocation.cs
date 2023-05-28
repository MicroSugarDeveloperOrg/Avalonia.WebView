using System;
using System.ComponentModel;
using CloudKit;
using Foundation;
using ObjCRuntime;

namespace CoreLocation;

[Register("CLLocation", true)]
public class CLLocation : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding, ICKRecordValue
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAltitude = "altitude";

	private static readonly IntPtr selAltitudeHandle = Selector.GetHandle("altitude");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCoordinate = "coordinate";

	private static readonly IntPtr selCoordinateHandle = Selector.GetHandle("coordinate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCourse = "course";

	private static readonly IntPtr selCourseHandle = Selector.GetHandle("course");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCourseAccuracy = "courseAccuracy";

	private static readonly IntPtr selCourseAccuracyHandle = Selector.GetHandle("courseAccuracy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDistanceFromLocation_ = "distanceFromLocation:";

	private static readonly IntPtr selDistanceFromLocation_Handle = Selector.GetHandle("distanceFromLocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloor = "floor";

	private static readonly IntPtr selFloorHandle = Selector.GetHandle("floor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHorizontalAccuracy = "horizontalAccuracy";

	private static readonly IntPtr selHorizontalAccuracyHandle = Selector.GetHandle("horizontalAccuracy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoordinate_Altitude_HorizontalAccuracy_VerticalAccuracy_Course_CourseAccuracy_Speed_SpeedAccuracy_Timestamp_ = "initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:course:courseAccuracy:speed:speedAccuracy:timestamp:";

	private static readonly IntPtr selInitWithCoordinate_Altitude_HorizontalAccuracy_VerticalAccuracy_Course_CourseAccuracy_Speed_SpeedAccuracy_Timestamp_Handle = Selector.GetHandle("initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:course:courseAccuracy:speed:speedAccuracy:timestamp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoordinate_Altitude_HorizontalAccuracy_VerticalAccuracy_Course_Speed_Timestamp_ = "initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:course:speed:timestamp:";

	private static readonly IntPtr selInitWithCoordinate_Altitude_HorizontalAccuracy_VerticalAccuracy_Course_Speed_Timestamp_Handle = Selector.GetHandle("initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:course:speed:timestamp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoordinate_Altitude_HorizontalAccuracy_VerticalAccuracy_Timestamp_ = "initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:timestamp:";

	private static readonly IntPtr selInitWithCoordinate_Altitude_HorizontalAccuracy_VerticalAccuracy_Timestamp_Handle = Selector.GetHandle("initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:timestamp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLatitude_Longitude_ = "initWithLatitude:longitude:";

	private static readonly IntPtr selInitWithLatitude_Longitude_Handle = Selector.GetHandle("initWithLatitude:longitude:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpeed = "speed";

	private static readonly IntPtr selSpeedHandle = Selector.GetHandle("speed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpeedAccuracy = "speedAccuracy";

	private static readonly IntPtr selSpeedAccuracyHandle = Selector.GetHandle("speedAccuracy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimestamp = "timestamp";

	private static readonly IntPtr selTimestampHandle = Selector.GetHandle("timestamp");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVerticalAccuracy = "verticalAccuracy";

	private static readonly IntPtr selVerticalAccuracyHandle = Selector.GetHandle("verticalAccuracy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CLLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ErrorUserInfoAlternateRegionKey;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Altitude
	{
		[Export("altitude")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selAltitudeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selAltitudeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CLLocationCoordinate2D Coordinate
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
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	public virtual double Course
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Export("course")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCourseHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCourseHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
	public virtual double CourseAccuracy
	{
		[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
		[Export("courseAccuracy")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCourseAccuracyHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCourseAccuracyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual CLFloor? Floor
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("floor", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CLFloor>(Messaging.IntPtr_objc_msgSend(base.Handle, selFloorHandle));
			}
			return Runtime.GetNSObject<CLFloor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFloorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double HorizontalAccuracy
	{
		[Export("horizontalAccuracy")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selHorizontalAccuracyHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selHorizontalAccuracyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	public virtual double Speed
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Export("speed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selSpeedHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selSpeedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
	public virtual double SpeedAccuracy
	{
		[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
		[Export("speedAccuracy")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selSpeedAccuracyHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selSpeedAccuracyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate Timestamp
	{
		[Export("timestamp", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selTimestampHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimestampHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double VerticalAccuracy
	{
		[Export("verticalAccuracy")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selVerticalAccuracyHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selVerticalAccuracyHandle);
		}
	}

	[Field("kCLLocationAccuracyBest", "CoreLocation")]
	public static double AccuracyBest => Dlfcn.GetDouble(Libraries.CoreLocation.Handle, "kCLLocationAccuracyBest");

	[Field("kCLLocationAccuracyHundredMeters", "CoreLocation")]
	public static double AccuracyHundredMeters => Dlfcn.GetDouble(Libraries.CoreLocation.Handle, "kCLLocationAccuracyHundredMeters");

	[Field("kCLLocationAccuracyKilometer", "CoreLocation")]
	public static double AccuracyKilometer => Dlfcn.GetDouble(Libraries.CoreLocation.Handle, "kCLLocationAccuracyKilometer");

	[Field("kCLLocationAccuracyNearestTenMeters", "CoreLocation")]
	public static double AccuracyNearestTenMeters => Dlfcn.GetDouble(Libraries.CoreLocation.Handle, "kCLLocationAccuracyNearestTenMeters");

	[Field("kCLLocationAccuracyThreeKilometers", "CoreLocation")]
	public static double AccuracyThreeKilometers => Dlfcn.GetDouble(Libraries.CoreLocation.Handle, "kCLLocationAccuracyThreeKilometers");

	[Field("kCLLocationAccuracyBestForNavigation", "CoreLocation")]
	public static double AccurracyBestForNavigation => Dlfcn.GetDouble(Libraries.CoreLocation.Handle, "kCLLocationAccuracyBestForNavigation");

	[Field("kCLErrorUserInfoAlternateRegionKey", "CoreLocation")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
	public static NSString ErrorUserInfoAlternateRegionKey
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
		get
		{
			if (_ErrorUserInfoAlternateRegionKey == null)
			{
				_ErrorUserInfoAlternateRegionKey = Dlfcn.GetStringConstant(Libraries.CoreLocation.Handle, "kCLErrorUserInfoAlternateRegionKey");
			}
			return _ErrorUserInfoAlternateRegionKey;
		}
	}

	[Obsolete("Use the 'Description' property from 'NSObject'.")]
	public new virtual string Description()
	{
		return base.Description;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CLLocation()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CLLocation(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CLLocation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CLLocation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithLatitude:longitude:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CLLocation(double latitude, double longitude)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Double_Double(base.Handle, selInitWithLatitude_Longitude_Handle, latitude, longitude), "initWithLatitude:longitude:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Double_Double(base.SuperHandle, selInitWithLatitude_Longitude_Handle, latitude, longitude), "initWithLatitude:longitude:");
		}
	}

	[Export("initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:timestamp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CLLocation(CLLocationCoordinate2D coordinate, double altitude, double hAccuracy, double vAccuracy, NSDate timestamp)
		: base(NSObjectFlag.Empty)
	{
		if (timestamp == null)
		{
			throw new ArgumentNullException("timestamp");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_Double_Double_IntPtr(base.Handle, selInitWithCoordinate_Altitude_HorizontalAccuracy_VerticalAccuracy_Timestamp_Handle, coordinate, altitude, hAccuracy, vAccuracy, timestamp.Handle), "initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:timestamp:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double_Double_Double_IntPtr(base.SuperHandle, selInitWithCoordinate_Altitude_HorizontalAccuracy_VerticalAccuracy_Timestamp_Handle, coordinate, altitude, hAccuracy, vAccuracy, timestamp.Handle), "initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:timestamp:");
		}
	}

	[Export("initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:course:speed:timestamp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CLLocation(CLLocationCoordinate2D coordinate, double altitude, double hAccuracy, double vAccuracy, double course, double speed, NSDate timestamp)
		: base(NSObjectFlag.Empty)
	{
		if (timestamp == null)
		{
			throw new ArgumentNullException("timestamp");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_Double_Double_Double_Double_IntPtr(base.Handle, selInitWithCoordinate_Altitude_HorizontalAccuracy_VerticalAccuracy_Course_Speed_Timestamp_Handle, coordinate, altitude, hAccuracy, vAccuracy, course, speed, timestamp.Handle), "initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:course:speed:timestamp:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double_Double_Double_Double_Double_IntPtr(base.SuperHandle, selInitWithCoordinate_Altitude_HorizontalAccuracy_VerticalAccuracy_Course_Speed_Timestamp_Handle, coordinate, altitude, hAccuracy, vAccuracy, course, speed, timestamp.Handle), "initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:course:speed:timestamp:");
		}
	}

	[Export("initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:course:courseAccuracy:speed:speedAccuracy:timestamp:")]
	[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CLLocation(CLLocationCoordinate2D coordinate, double altitude, double hAccuracy, double vAccuracy, double course, double courseAccuracy, double speed, double speedAccuracy, NSDate timestamp)
		: base(NSObjectFlag.Empty)
	{
		if (timestamp == null)
		{
			throw new ArgumentNullException("timestamp");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_Double_Double_Double_Double_Double_Double_IntPtr(base.Handle, selInitWithCoordinate_Altitude_HorizontalAccuracy_VerticalAccuracy_Course_CourseAccuracy_Speed_SpeedAccuracy_Timestamp_Handle, coordinate, altitude, hAccuracy, vAccuracy, course, courseAccuracy, speed, speedAccuracy, timestamp.Handle), "initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:course:courseAccuracy:speed:speedAccuracy:timestamp:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double_Double_Double_Double_Double_Double_Double_IntPtr(base.SuperHandle, selInitWithCoordinate_Altitude_HorizontalAccuracy_VerticalAccuracy_Course_CourseAccuracy_Speed_SpeedAccuracy_Timestamp_Handle, coordinate, altitude, hAccuracy, vAccuracy, course, courseAccuracy, speed, speedAccuracy, timestamp.Handle), "initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:course:courseAccuracy:speed:speedAccuracy:timestamp:");
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("distanceFromLocation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double DistanceFrom(CLLocation location)
	{
		if (location == null)
		{
			throw new ArgumentNullException("location");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_IntPtr(base.Handle, selDistanceFromLocation_Handle, location.Handle);
		}
		return Messaging.Double_objc_msgSendSuper_IntPtr(base.SuperHandle, selDistanceFromLocation_Handle, location.Handle);
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}
}
