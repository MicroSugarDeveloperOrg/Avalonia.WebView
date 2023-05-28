using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKMapItem", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKMapItem : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPlacemark_ = "initWithPlacemark:";

	private static readonly IntPtr selInitWithPlacemark_Handle = Selector.GetHandle("initWithPlacemark:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCurrentLocation = "isCurrentLocation";

	private static readonly IntPtr selIsCurrentLocationHandle = Selector.GetHandle("isCurrentLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMapItemForCurrentLocation = "mapItemForCurrentLocation";

	private static readonly IntPtr selMapItemForCurrentLocationHandle = Selector.GetHandle("mapItemForCurrentLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenInMapsWithLaunchOptions_ = "openInMapsWithLaunchOptions:";

	private static readonly IntPtr selOpenInMapsWithLaunchOptions_Handle = Selector.GetHandle("openInMapsWithLaunchOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenMapsWithItems_LaunchOptions_ = "openMapsWithItems:launchOptions:";

	private static readonly IntPtr selOpenMapsWithItems_LaunchOptions_Handle = Selector.GetHandle("openMapsWithItems:launchOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhoneNumber = "phoneNumber";

	private static readonly IntPtr selPhoneNumberHandle = Selector.GetHandle("phoneNumber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlacemark = "placemark";

	private static readonly IntPtr selPlacemarkHandle = Selector.GetHandle("placemark");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointOfInterestCategory = "pointOfInterestCategory";

	private static readonly IntPtr selPointOfInterestCategoryHandle = Selector.GetHandle("pointOfInterestCategory");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPhoneNumber_ = "setPhoneNumber:";

	private static readonly IntPtr selSetPhoneNumber_Handle = Selector.GetHandle("setPhoneNumber:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPointOfInterestCategory_ = "setPointOfInterestCategory:";

	private static readonly IntPtr selSetPointOfInterestCategory_Handle = Selector.GetHandle("setPointOfInterestCategory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeZone_ = "setTimeZone:";

	private static readonly IntPtr selSetTimeZone_Handle = Selector.GetHandle("setTimeZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUrl_ = "setUrl:";

	private static readonly IntPtr selSetUrl_Handle = Selector.GetHandle("setUrl:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeZone = "timeZone";

	private static readonly IntPtr selTimeZoneHandle = Selector.GetHandle("timeZone");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUrl = "url";

	private static readonly IntPtr selUrlHandle = Selector.GetHandle("url");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKMapItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MKLaunchOptionsCameraKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MKLaunchOptionsDirectionsModeDefault;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MKLaunchOptionsDirectionsModeDriving;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MKLaunchOptionsDirectionsModeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MKLaunchOptionsDirectionsModeTransit;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MKLaunchOptionsDirectionsModeWalking;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MKLaunchOptionsMapCenterKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MKLaunchOptionsMapSpanKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MKLaunchOptionsMapTypeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MKLaunchOptionsShowsTrafficKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeIdentifier;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsCurrentLocation
	{
		[Export("isCurrentLocation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCurrentLocationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCurrentLocationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Name
	{
		[Export("name", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Export("setName:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? PhoneNumber
	{
		[Export("phoneNumber", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPhoneNumberHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPhoneNumberHandle));
		}
		[Export("setPhoneNumber:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPhoneNumber_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPhoneNumber_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKPlacemark Placemark
	{
		[Export("placemark", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MKPlacemark>(Messaging.IntPtr_objc_msgSend(base.Handle, selPlacemarkHandle));
			}
			return Runtime.GetNSObject<MKPlacemark>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlacemarkHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual string? PointOfInterestCategory
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("pointOfInterestCategory")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPointOfInterestCategoryHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPointOfInterestCategoryHandle));
		}
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setPointOfInterestCategory:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPointOfInterestCategory_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPointOfInterestCategory_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSTimeZone? TimeZone
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("timeZone")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTimeZone>(Messaging.IntPtr_objc_msgSend(base.Handle, selTimeZoneHandle));
			}
			return Runtime.GetNSObject<NSTimeZone>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimeZoneHandle));
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setTimeZone:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTimeZone_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTimeZone_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? Url
	{
		[Export("url", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selUrlHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUrlHandle));
		}
		[Export("setUrl:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUrl_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUrl_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[Field("MKLaunchOptionsCameraKey", "MapKit")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	internal static NSString MKLaunchOptionsCameraKey
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_MKLaunchOptionsCameraKey == null)
			{
				_MKLaunchOptionsCameraKey = Dlfcn.GetStringConstant(Libraries.MapKit.Handle, "MKLaunchOptionsCameraKey");
			}
			return _MKLaunchOptionsCameraKey;
		}
	}

	[Field("MKLaunchOptionsDirectionsModeDefault", "MapKit")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	internal static NSString MKLaunchOptionsDirectionsModeDefault
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_MKLaunchOptionsDirectionsModeDefault == null)
			{
				_MKLaunchOptionsDirectionsModeDefault = Dlfcn.GetStringConstant(Libraries.MapKit.Handle, "MKLaunchOptionsDirectionsModeDefault");
			}
			return _MKLaunchOptionsDirectionsModeDefault;
		}
	}

	[Field("MKLaunchOptionsDirectionsModeDriving", "MapKit")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	internal static NSString MKLaunchOptionsDirectionsModeDriving
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		get
		{
			if (_MKLaunchOptionsDirectionsModeDriving == null)
			{
				_MKLaunchOptionsDirectionsModeDriving = Dlfcn.GetStringConstant(Libraries.MapKit.Handle, "MKLaunchOptionsDirectionsModeDriving");
			}
			return _MKLaunchOptionsDirectionsModeDriving;
		}
	}

	[Field("MKLaunchOptionsDirectionsModeKey", "MapKit")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	internal static NSString MKLaunchOptionsDirectionsModeKey
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		get
		{
			if (_MKLaunchOptionsDirectionsModeKey == null)
			{
				_MKLaunchOptionsDirectionsModeKey = Dlfcn.GetStringConstant(Libraries.MapKit.Handle, "MKLaunchOptionsDirectionsModeKey");
			}
			return _MKLaunchOptionsDirectionsModeKey;
		}
	}

	[Field("MKLaunchOptionsDirectionsModeTransit", "MapKit")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	internal static NSString MKLaunchOptionsDirectionsModeTransit
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_MKLaunchOptionsDirectionsModeTransit == null)
			{
				_MKLaunchOptionsDirectionsModeTransit = Dlfcn.GetStringConstant(Libraries.MapKit.Handle, "MKLaunchOptionsDirectionsModeTransit");
			}
			return _MKLaunchOptionsDirectionsModeTransit;
		}
	}

	[Field("MKLaunchOptionsDirectionsModeWalking", "MapKit")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	internal static NSString MKLaunchOptionsDirectionsModeWalking
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		get
		{
			if (_MKLaunchOptionsDirectionsModeWalking == null)
			{
				_MKLaunchOptionsDirectionsModeWalking = Dlfcn.GetStringConstant(Libraries.MapKit.Handle, "MKLaunchOptionsDirectionsModeWalking");
			}
			return _MKLaunchOptionsDirectionsModeWalking;
		}
	}

	[Field("MKLaunchOptionsMapCenterKey", "MapKit")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	internal static NSString MKLaunchOptionsMapCenterKey
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		get
		{
			if (_MKLaunchOptionsMapCenterKey == null)
			{
				_MKLaunchOptionsMapCenterKey = Dlfcn.GetStringConstant(Libraries.MapKit.Handle, "MKLaunchOptionsMapCenterKey");
			}
			return _MKLaunchOptionsMapCenterKey;
		}
	}

	[Field("MKLaunchOptionsMapSpanKey", "MapKit")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	internal static NSString MKLaunchOptionsMapSpanKey
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		get
		{
			if (_MKLaunchOptionsMapSpanKey == null)
			{
				_MKLaunchOptionsMapSpanKey = Dlfcn.GetStringConstant(Libraries.MapKit.Handle, "MKLaunchOptionsMapSpanKey");
			}
			return _MKLaunchOptionsMapSpanKey;
		}
	}

	[Field("MKLaunchOptionsMapTypeKey", "MapKit")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	internal static NSString MKLaunchOptionsMapTypeKey
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		get
		{
			if (_MKLaunchOptionsMapTypeKey == null)
			{
				_MKLaunchOptionsMapTypeKey = Dlfcn.GetStringConstant(Libraries.MapKit.Handle, "MKLaunchOptionsMapTypeKey");
			}
			return _MKLaunchOptionsMapTypeKey;
		}
	}

	[Field("MKLaunchOptionsShowsTrafficKey", "MapKit")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	internal static NSString MKLaunchOptionsShowsTrafficKey
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		get
		{
			if (_MKLaunchOptionsShowsTrafficKey == null)
			{
				_MKLaunchOptionsShowsTrafficKey = Dlfcn.GetStringConstant(Libraries.MapKit.Handle, "MKLaunchOptionsShowsTrafficKey");
			}
			return _MKLaunchOptionsShowsTrafficKey;
		}
	}

	[Field("MKMapItemTypeIdentifier", "MapKit")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString TypeIdentifier
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeIdentifier == null)
			{
				_TypeIdentifier = Dlfcn.GetStringConstant(Libraries.MapKit.Handle, "MKMapItemTypeIdentifier");
			}
			return _TypeIdentifier;
		}
	}

	public void OpenInMaps(MKLaunchOptions launchOptions = null)
	{
		_OpenInMaps(launchOptions?.ToDictionary());
	}

	public static bool OpenMaps(MKMapItem[] mapItems = null, MKLaunchOptions launchOptions = null)
	{
		return _OpenMaps(mapItems, launchOptions?.ToDictionary());
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKMapItem()
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
	public MKMapItem(NSCoder coder)
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
	protected MKMapItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKMapItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPlacemark:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKMapItem(MKPlacemark placemark)
		: base(NSObjectFlag.Empty)
	{
		if (placemark == null)
		{
			throw new ArgumentNullException("placemark");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPlacemark_Handle, placemark.Handle), "initWithPlacemark:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPlacemark_Handle, placemark.Handle), "initWithPlacemark:");
		}
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

	[Export("mapItemForCurrentLocation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MKMapItem MapItemForCurrentLocation()
	{
		return Runtime.GetNSObject<MKMapItem>(Messaging.IntPtr_objc_msgSend(class_ptr, selMapItemForCurrentLocationHandle));
	}

	[Export("openInMapsWithLaunchOptions:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual bool _OpenInMaps(NSDictionary? launchOptions)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selOpenInMapsWithLaunchOptions_Handle, launchOptions?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selOpenInMapsWithLaunchOptions_Handle, launchOptions?.Handle ?? IntPtr.Zero);
	}

	[Export("openMapsWithItems:launchOptions:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static bool _OpenMaps(MKMapItem[]? mapItems, NSDictionary? launchOptions)
	{
		NSArray nSArray = ((mapItems == null) ? null : NSArray.FromNSObjects(mapItems));
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(class_ptr, selOpenMapsWithItems_LaunchOptions_Handle, nSArray?.Handle ?? IntPtr.Zero, launchOptions?.Handle ?? IntPtr.Zero);
		nSArray?.Dispose();
		return result;
	}
}
