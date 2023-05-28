using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKMapCameraZoomRange", true)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MKMapCameraZoomRange : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMaxCenterCoordinateDistance_ = "initWithMaxCenterCoordinateDistance:";

	private static readonly IntPtr selInitWithMaxCenterCoordinateDistance_Handle = Selector.GetHandle("initWithMaxCenterCoordinateDistance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMinCenterCoordinateDistance_ = "initWithMinCenterCoordinateDistance:";

	private static readonly IntPtr selInitWithMinCenterCoordinateDistance_Handle = Selector.GetHandle("initWithMinCenterCoordinateDistance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMinCenterCoordinateDistance_MaxCenterCoordinateDistance_ = "initWithMinCenterCoordinateDistance:maxCenterCoordinateDistance:";

	private static readonly IntPtr selInitWithMinCenterCoordinateDistance_MaxCenterCoordinateDistance_Handle = Selector.GetHandle("initWithMinCenterCoordinateDistance:maxCenterCoordinateDistance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxCenterCoordinateDistance = "maxCenterCoordinateDistance";

	private static readonly IntPtr selMaxCenterCoordinateDistanceHandle = Selector.GetHandle("maxCenterCoordinateDistance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinCenterCoordinateDistance = "minCenterCoordinateDistance";

	private static readonly IntPtr selMinCenterCoordinateDistanceHandle = Selector.GetHandle("minCenterCoordinateDistance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKMapCameraZoomRange");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double MaxCenterCoordinateDistance
	{
		[Export("maxCenterCoordinateDistance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMaxCenterCoordinateDistanceHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMaxCenterCoordinateDistanceHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double MinCenterCoordinateDistance
	{
		[Export("minCenterCoordinateDistance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMinCenterCoordinateDistanceHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMinCenterCoordinateDistanceHandle);
		}
	}

	[Field("MKMapCameraZoomDefault", "MapKit")]
	public static double ZoomDefault => Dlfcn.GetDouble(Libraries.MapKit.Handle, "MKMapCameraZoomDefault");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKMapCameraZoomRange()
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
	public MKMapCameraZoomRange(NSCoder coder)
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
	protected MKMapCameraZoomRange(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKMapCameraZoomRange(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMinCenterCoordinateDistance:maxCenterCoordinateDistance:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKMapCameraZoomRange(double minDistance, double maxDistance)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Double_Double(base.Handle, selInitWithMinCenterCoordinateDistance_MaxCenterCoordinateDistance_Handle, minDistance, maxDistance), "initWithMinCenterCoordinateDistance:maxCenterCoordinateDistance:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Double_Double(base.SuperHandle, selInitWithMinCenterCoordinateDistance_MaxCenterCoordinateDistance_Handle, minDistance, maxDistance), "initWithMinCenterCoordinateDistance:maxCenterCoordinateDistance:");
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

	[Export("initWithMaxCenterCoordinateDistance:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithMaxCenterCoordinateDistance(double maxDistance)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_Double(base.Handle, selInitWithMaxCenterCoordinateDistance_Handle, maxDistance);
		}
		return Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selInitWithMaxCenterCoordinateDistance_Handle, maxDistance);
	}

	[Export("initWithMinCenterCoordinateDistance:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithMinCenterCoordinateDistance(double minDistance)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_Double(base.Handle, selInitWithMinCenterCoordinateDistance_Handle, minDistance);
		}
		return Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selInitWithMinCenterCoordinateDistance_Handle, minDistance);
	}
}
