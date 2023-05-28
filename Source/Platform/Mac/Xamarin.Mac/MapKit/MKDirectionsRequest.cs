using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKDirectionsRequest", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKDirectionsRequest : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrivalDate = "arrivalDate";

	private static readonly IntPtr selArrivalDateHandle = Selector.GetHandle("arrivalDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepartureDate = "departureDate";

	private static readonly IntPtr selDepartureDateHandle = Selector.GetHandle("departureDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestination = "destination";

	private static readonly IntPtr selDestinationHandle = Selector.GetHandle("destination");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentsOfURL_ = "initWithContentsOfURL:";

	private static readonly IntPtr selInitWithContentsOfURL_Handle = Selector.GetHandle("initWithContentsOfURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDirectionsRequestURL_ = "isDirectionsRequestURL:";

	private static readonly IntPtr selIsDirectionsRequestURL_Handle = Selector.GetHandle("isDirectionsRequestURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestsAlternateRoutes = "requestsAlternateRoutes";

	private static readonly IntPtr selRequestsAlternateRoutesHandle = Selector.GetHandle("requestsAlternateRoutes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetArrivalDate_ = "setArrivalDate:";

	private static readonly IntPtr selSetArrivalDate_Handle = Selector.GetHandle("setArrivalDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDepartureDate_ = "setDepartureDate:";

	private static readonly IntPtr selSetDepartureDate_Handle = Selector.GetHandle("setDepartureDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDestination_ = "setDestination:";

	private static readonly IntPtr selSetDestination_Handle = Selector.GetHandle("setDestination:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRequestsAlternateRoutes_ = "setRequestsAlternateRoutes:";

	private static readonly IntPtr selSetRequestsAlternateRoutes_Handle = Selector.GetHandle("setRequestsAlternateRoutes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSource_ = "setSource:";

	private static readonly IntPtr selSetSource_Handle = Selector.GetHandle("setSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransportType_ = "setTransportType:";

	private static readonly IntPtr selSetTransportType_Handle = Selector.GetHandle("setTransportType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSource = "source";

	private static readonly IntPtr selSourceHandle = Selector.GetHandle("source");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransportType = "transportType";

	private static readonly IntPtr selTransportTypeHandle = Selector.GetHandle("transportType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKDirectionsRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual NSDate? ArrivalDate
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("arrivalDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selArrivalDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArrivalDateHandle));
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("setArrivalDate:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetArrivalDate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetArrivalDate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual NSDate? DepartureDate
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("departureDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDepartureDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDepartureDateHandle));
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("setDepartureDate:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDepartureDate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDepartureDate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKMapItem? Destination
	{
		[Export("destination")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MKMapItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationHandle));
			}
			return Runtime.GetNSObject<MKMapItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationHandle));
		}
		[Export("setDestination:")]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDestination_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDestination_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual bool RequestsAlternateRoutes
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("requestsAlternateRoutes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRequestsAlternateRoutesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRequestsAlternateRoutesHandle);
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("setRequestsAlternateRoutes:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRequestsAlternateRoutes_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRequestsAlternateRoutes_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKMapItem? Source
	{
		[Export("source")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MKMapItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceHandle));
			}
			return Runtime.GetNSObject<MKMapItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceHandle));
		}
		[Export("setSource:")]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual MKDirectionsTransportType TransportType
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("transportType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MKDirectionsTransportType)Messaging.UInt64_objc_msgSend(base.Handle, selTransportTypeHandle);
			}
			return (MKDirectionsTransportType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTransportTypeHandle);
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("setTransportType:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTransportType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTransportType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKDirectionsRequest()
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
	protected MKDirectionsRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKDirectionsRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithContentsOfURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKDirectionsRequest(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContentsOfURL_Handle, url.Handle), "initWithContentsOfURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContentsOfURL_Handle, url.Handle), "initWithContentsOfURL:");
		}
	}

	[Export("isDirectionsRequestURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsDirectionsRequestUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selIsDirectionsRequestURL_Handle, url.Handle);
	}
}
