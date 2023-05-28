using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKMapSnapshotOptions", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKMapSnapshotOptions : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppearance = "appearance";

	private static readonly IntPtr selAppearanceHandle = Selector.GetHandle("appearance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCamera = "camera";

	private static readonly IntPtr selCameraHandle = Selector.GetHandle("camera");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMapRect = "mapRect";

	private static readonly IntPtr selMapRectHandle = Selector.GetHandle("mapRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMapType = "mapType";

	private static readonly IntPtr selMapTypeHandle = Selector.GetHandle("mapType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointOfInterestFilter = "pointOfInterestFilter";

	private static readonly IntPtr selPointOfInterestFilterHandle = Selector.GetHandle("pointOfInterestFilter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegion = "region";

	private static readonly IntPtr selRegionHandle = Selector.GetHandle("region");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAppearance_ = "setAppearance:";

	private static readonly IntPtr selSetAppearance_Handle = Selector.GetHandle("setAppearance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCamera_ = "setCamera:";

	private static readonly IntPtr selSetCamera_Handle = Selector.GetHandle("setCamera:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMapRect_ = "setMapRect:";

	private static readonly IntPtr selSetMapRect_Handle = Selector.GetHandle("setMapRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMapType_ = "setMapType:";

	private static readonly IntPtr selSetMapType_Handle = Selector.GetHandle("setMapType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPointOfInterestFilter_ = "setPointOfInterestFilter:";

	private static readonly IntPtr selSetPointOfInterestFilter_Handle = Selector.GetHandle("setPointOfInterestFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRegion_ = "setRegion:";

	private static readonly IntPtr selSetRegion_Handle = Selector.GetHandle("setRegion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsBuildings_ = "setShowsBuildings:";

	private static readonly IntPtr selSetShowsBuildings_Handle = Selector.GetHandle("setShowsBuildings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsPointsOfInterest_ = "setShowsPointsOfInterest:";

	private static readonly IntPtr selSetShowsPointsOfInterest_Handle = Selector.GetHandle("setShowsPointsOfInterest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSize_ = "setSize:";

	private static readonly IntPtr selSetSize_Handle = Selector.GetHandle("setSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsBuildings = "showsBuildings";

	private static readonly IntPtr selShowsBuildingsHandle = Selector.GetHandle("showsBuildings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsPointsOfInterest = "showsPointsOfInterest";

	private static readonly IntPtr selShowsPointsOfInterestHandle = Selector.GetHandle("showsPointsOfInterest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSize = "size";

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKMapSnapshotOptions");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public virtual NSAppearance? Appearance
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("appearance", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAppearance>(Messaging.IntPtr_objc_msgSend(base.Handle, selAppearanceHandle));
			}
			return Runtime.GetNSObject<NSAppearance>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAppearanceHandle));
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("setAppearance:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAppearance_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAppearance_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKMapCamera Camera
	{
		[Export("camera", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MKMapCamera>(Messaging.IntPtr_objc_msgSend(base.Handle, selCameraHandle));
			}
			return Runtime.GetNSObject<MKMapCamera>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCameraHandle));
		}
		[Export("setCamera:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCamera_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCamera_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKMapRect MapRect
	{
		[Export("mapRect", ArgumentSemantic.Assign)]
		get
		{
			MKMapRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.MKMapRect_objc_msgSend_stret(out retval, base.Handle, selMapRectHandle);
			}
			else
			{
				Messaging.MKMapRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMapRectHandle);
			}
			return retval;
		}
		[Export("setMapRect:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MKMapRect(base.Handle, selSetMapRect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MKMapRect(base.SuperHandle, selSetMapRect_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKMapType MapType
	{
		[Export("mapType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MKMapType)Messaging.UInt64_objc_msgSend(base.Handle, selMapTypeHandle);
			}
			return (MKMapType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMapTypeHandle);
		}
		[Export("setMapType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMapType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMapType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual MKPointOfInterestFilter? PointOfInterestFilter
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("pointOfInterestFilter", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MKPointOfInterestFilter>(Messaging.IntPtr_objc_msgSend(base.Handle, selPointOfInterestFilterHandle));
			}
			return Runtime.GetNSObject<MKPointOfInterestFilter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPointOfInterestFilterHandle));
		}
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setPointOfInterestFilter:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPointOfInterestFilter_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPointOfInterestFilter_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKCoordinateRegion Region
	{
		[Export("region", ArgumentSemantic.Assign)]
		get
		{
			MKCoordinateRegion retval;
			if (base.IsDirectBinding)
			{
				Messaging.MKCoordinateRegion_objc_msgSend_stret(out retval, base.Handle, selRegionHandle);
			}
			else
			{
				Messaging.MKCoordinateRegion_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRegionHandle);
			}
			return retval;
		}
		[Export("setRegion:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MKCoordinateRegion(base.Handle, selSetRegion_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MKCoordinateRegion(base.SuperHandle, selSetRegion_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsBuildings
	{
		[Export("showsBuildings")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsBuildingsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsBuildingsHandle);
		}
		[Export("setShowsBuildings:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsBuildings_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsBuildings_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'PointOfInterestFilter' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'PointOfInterestFilter' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'PointOfInterestFilter' instead.")]
	public virtual bool ShowsPointsOfInterest
	{
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'PointOfInterestFilter' instead.")]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'PointOfInterestFilter' instead.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'PointOfInterestFilter' instead.")]
		[Export("showsPointsOfInterest")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsPointsOfInterestHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsPointsOfInterestHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'PointOfInterestFilter' instead.")]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'PointOfInterestFilter' instead.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'PointOfInterestFilter' instead.")]
		[Export("setShowsPointsOfInterest:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsPointsOfInterest_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsPointsOfInterest_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize Size
	{
		[Export("size", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
		}
		[Export("setSize:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKMapSnapshotOptions()
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
	protected MKMapSnapshotOptions(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKMapSnapshotOptions(IntPtr handle)
		: base(handle)
	{
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
}
