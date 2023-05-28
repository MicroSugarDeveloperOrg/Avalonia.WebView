using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKRoute", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKRoute : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdvisoryNotices = "advisoryNotices";

	private static readonly IntPtr selAdvisoryNoticesHandle = Selector.GetHandle("advisoryNotices");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDistance = "distance";

	private static readonly IntPtr selDistanceHandle = Selector.GetHandle("distance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpectedTravelTime = "expectedTravelTime";

	private static readonly IntPtr selExpectedTravelTimeHandle = Selector.GetHandle("expectedTravelTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPolyline = "polyline";

	private static readonly IntPtr selPolylineHandle = Selector.GetHandle("polyline");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSteps = "steps";

	private static readonly IntPtr selStepsHandle = Selector.GetHandle("steps");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransportType = "transportType";

	private static readonly IntPtr selTransportTypeHandle = Selector.GetHandle("transportType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKRoute");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] AdvisoryNotices
	{
		[Export("advisoryNotices")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAdvisoryNoticesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAdvisoryNoticesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Distance
	{
		[Export("distance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDistanceHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDistanceHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double ExpectedTravelTime
	{
		[Export("expectedTravelTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selExpectedTravelTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selExpectedTravelTimeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKPolyline Polyline
	{
		[Export("polyline")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MKPolyline>(Messaging.IntPtr_objc_msgSend(base.Handle, selPolylineHandle));
			}
			return Runtime.GetNSObject<MKPolyline>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPolylineHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKRouteStep[] Steps
	{
		[Export("steps")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<MKRouteStep>(Messaging.IntPtr_objc_msgSend(base.Handle, selStepsHandle));
			}
			return NSArray.ArrayFromHandle<MKRouteStep>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStepsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKDirectionsTransportType TransportType
	{
		[Export("transportType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MKDirectionsTransportType)Messaging.UInt64_objc_msgSend(base.Handle, selTransportTypeHandle);
			}
			return (MKDirectionsTransportType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTransportTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKRoute()
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
	protected MKRoute(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKRoute(IntPtr handle)
		: base(handle)
	{
	}
}
