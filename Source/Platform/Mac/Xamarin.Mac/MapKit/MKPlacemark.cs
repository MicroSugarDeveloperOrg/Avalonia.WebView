using System;
using System.ComponentModel;
using Contacts;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKPlacemark", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKPlacemark : CLPlacemark, IMKAnnotation, INativeObject, IDisposable, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCoordinate = "coordinate";

	private static readonly IntPtr selCoordinateHandle = Selector.GetHandle("coordinate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCountryCode = "countryCode";

	private static readonly IntPtr selCountryCodeHandle = Selector.GetHandle("countryCode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoordinate_ = "initWithCoordinate:";

	private static readonly IntPtr selInitWithCoordinate_Handle = Selector.GetHandle("initWithCoordinate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoordinate_AddressDictionary_ = "initWithCoordinate:addressDictionary:";

	private static readonly IntPtr selInitWithCoordinate_AddressDictionary_Handle = Selector.GetHandle("initWithCoordinate:addressDictionary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoordinate_PostalAddress_ = "initWithCoordinate:postalAddress:";

	private static readonly IntPtr selInitWithCoordinate_PostalAddress_Handle = Selector.GetHandle("initWithCoordinate:postalAddress:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCoordinate_ = "setCoordinate:";

	private static readonly IntPtr selSetCoordinate_Handle = Selector.GetHandle("setCoordinate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubtitle = "subtitle";

	private static readonly IntPtr selSubtitleHandle = Selector.GetHandle("subtitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKPlacemark");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
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
	public virtual string CountryCode
	{
		[Export("countryCode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCountryCodeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCountryCodeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual string Subtitle
	{
		[Export("subtitle", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSubtitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubtitleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual string Title
	{
		[Export("title", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MKPlacemark(NSCoder coder)
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
	protected MKPlacemark(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKPlacemark(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCoordinate:addressDictionary:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKPlacemark(CLLocationCoordinate2D coordinate, NSDictionary? addressDictionary)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D_IntPtr(base.Handle, selInitWithCoordinate_AddressDictionary_Handle, coordinate, addressDictionary?.Handle ?? IntPtr.Zero), "initWithCoordinate:addressDictionary:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr(base.SuperHandle, selInitWithCoordinate_AddressDictionary_Handle, coordinate, addressDictionary?.Handle ?? IntPtr.Zero), "initWithCoordinate:addressDictionary:");
		}
	}

	[Export("initWithCoordinate:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKPlacemark(CLLocationCoordinate2D coordinate)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D(base.Handle, selInitWithCoordinate_Handle, coordinate), "initWithCoordinate:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CLLocationCoordinate2D(base.SuperHandle, selInitWithCoordinate_Handle, coordinate), "initWithCoordinate:");
		}
	}

	[Export("initWithCoordinate:postalAddress:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKPlacemark(CLLocationCoordinate2D coordinate, CNPostalAddress postalAddress)
		: base(NSObjectFlag.Empty)
	{
		if (postalAddress == null)
		{
			throw new ArgumentNullException("postalAddress");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D_IntPtr(base.Handle, selInitWithCoordinate_PostalAddress_Handle, coordinate, postalAddress.Handle), "initWithCoordinate:postalAddress:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr(base.SuperHandle, selInitWithCoordinate_PostalAddress_Handle, coordinate, postalAddress.Handle), "initWithCoordinate:postalAddress:");
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public new virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("setCoordinate:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCoordinate(CLLocationCoordinate2D value)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CLLocationCoordinate2D(base.Handle, selSetCoordinate_Handle, value);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D(base.SuperHandle, selSetCoordinate_Handle, value);
		}
	}
}
