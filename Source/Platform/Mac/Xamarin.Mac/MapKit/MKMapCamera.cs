using System;
using System.ComponentModel;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKMapCamera", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKMapCamera : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAltitude = "altitude";

	private static readonly IntPtr selAltitudeHandle = Selector.GetHandle("altitude");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCamera = "camera";

	private static readonly IntPtr selCameraHandle = Selector.GetHandle("camera");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCameraLookingAtCenterCoordinate_FromDistance_Pitch_Heading_ = "cameraLookingAtCenterCoordinate:fromDistance:pitch:heading:";

	private static readonly IntPtr selCameraLookingAtCenterCoordinate_FromDistance_Pitch_Heading_Handle = Selector.GetHandle("cameraLookingAtCenterCoordinate:fromDistance:pitch:heading:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCameraLookingAtCenterCoordinate_FromEyeCoordinate_EyeAltitude_ = "cameraLookingAtCenterCoordinate:fromEyeCoordinate:eyeAltitude:";

	private static readonly IntPtr selCameraLookingAtCenterCoordinate_FromEyeCoordinate_EyeAltitude_Handle = Selector.GetHandle("cameraLookingAtCenterCoordinate:fromEyeCoordinate:eyeAltitude:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCenterCoordinate = "centerCoordinate";

	private static readonly IntPtr selCenterCoordinateHandle = Selector.GetHandle("centerCoordinate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCenterCoordinateDistance = "centerCoordinateDistance";

	private static readonly IntPtr selCenterCoordinateDistanceHandle = Selector.GetHandle("centerCoordinateDistance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeading = "heading";

	private static readonly IntPtr selHeadingHandle = Selector.GetHandle("heading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPitch = "pitch";

	private static readonly IntPtr selPitchHandle = Selector.GetHandle("pitch");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAltitude_ = "setAltitude:";

	private static readonly IntPtr selSetAltitude_Handle = Selector.GetHandle("setAltitude:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCenterCoordinate_ = "setCenterCoordinate:";

	private static readonly IntPtr selSetCenterCoordinate_Handle = Selector.GetHandle("setCenterCoordinate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCenterCoordinateDistance_ = "setCenterCoordinateDistance:";

	private static readonly IntPtr selSetCenterCoordinateDistance_Handle = Selector.GetHandle("setCenterCoordinateDistance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHeading_ = "setHeading:";

	private static readonly IntPtr selSetHeading_Handle = Selector.GetHandle("setHeading:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPitch_ = "setPitch:";

	private static readonly IntPtr selSetPitch_Handle = Selector.GetHandle("setPitch:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKMapCamera");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'CenterCoordinateDistance' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'CenterCoordinateDistance' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'CenterCoordinateDistance' instead.")]
	public virtual double Altitude
	{
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'CenterCoordinateDistance' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'CenterCoordinateDistance' instead.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'CenterCoordinateDistance' instead.")]
		[Export("altitude")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selAltitudeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selAltitudeHandle);
		}
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'CenterCoordinateDistance' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'CenterCoordinateDistance' instead.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'CenterCoordinateDistance' instead.")]
		[Export("setAltitude:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetAltitude_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetAltitude_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MKMapCamera Camera
	{
		[Export("camera")]
		get
		{
			return Runtime.GetNSObject<MKMapCamera>(Messaging.IntPtr_objc_msgSend(class_ptr, selCameraHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CLLocationCoordinate2D CenterCoordinate
	{
		[Export("centerCoordinate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CLLocationCoordinate2D_objc_msgSend(base.Handle, selCenterCoordinateHandle);
			}
			return Messaging.CLLocationCoordinate2D_objc_msgSendSuper(base.SuperHandle, selCenterCoordinateHandle);
		}
		[Export("setCenterCoordinate:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CLLocationCoordinate2D(base.Handle, selSetCenterCoordinate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D(base.SuperHandle, selSetCenterCoordinate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual double CenterCoordinateDistance
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("centerCoordinateDistance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCenterCoordinateDistanceHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCenterCoordinateDistanceHandle);
		}
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setCenterCoordinateDistance:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetCenterCoordinateDistance_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetCenterCoordinateDistance_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Heading
	{
		[Export("heading")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selHeadingHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selHeadingHandle);
		}
		[Export("setHeading:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetHeading_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetHeading_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Pitch
	{
		[Export("pitch")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selPitchHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selPitchHandle);
		}
		[Export("setPitch:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetPitch_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetPitch_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKMapCamera()
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
	public MKMapCamera(NSCoder coder)
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
	protected MKMapCamera(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKMapCamera(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cameraLookingAtCenterCoordinate:fromEyeCoordinate:eyeAltitude:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MKMapCamera CameraLookingAtCenterCoordinate(CLLocationCoordinate2D centerCoordinate, CLLocationCoordinate2D eyeCoordinate, double eyeAltitude)
	{
		return Runtime.GetNSObject<MKMapCamera>(Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D_CLLocationCoordinate2D_Double(class_ptr, selCameraLookingAtCenterCoordinate_FromEyeCoordinate_EyeAltitude_Handle, centerCoordinate, eyeCoordinate, eyeAltitude));
	}

	[Export("cameraLookingAtCenterCoordinate:fromDistance:pitch:heading:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MKMapCamera CameraLookingAtCenterCoordinate(CLLocationCoordinate2D centerCoordinate, double locationDistance, nfloat pitch, double locationDirectionHeading)
	{
		return Runtime.GetNSObject<MKMapCamera>(Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_nfloat_Double(class_ptr, selCameraLookingAtCenterCoordinate_FromDistance_Pitch_Heading_Handle, centerCoordinate, locationDistance, pitch, locationDirectionHeading));
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
