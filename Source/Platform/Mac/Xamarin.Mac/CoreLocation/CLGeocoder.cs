using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Contacts;
using Foundation;
using ObjCRuntime;

namespace CoreLocation;

[Register("CLGeocoder", true)]
public class CLGeocoder : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelGeocode = "cancelGeocode";

	private static readonly IntPtr selCancelGeocodeHandle = Selector.GetHandle("cancelGeocode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGeocodeAddressDictionary_CompletionHandler_ = "geocodeAddressDictionary:completionHandler:";

	private static readonly IntPtr selGeocodeAddressDictionary_CompletionHandler_Handle = Selector.GetHandle("geocodeAddressDictionary:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGeocodeAddressString_CompletionHandler_ = "geocodeAddressString:completionHandler:";

	private static readonly IntPtr selGeocodeAddressString_CompletionHandler_Handle = Selector.GetHandle("geocodeAddressString:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGeocodeAddressString_InRegion_CompletionHandler_ = "geocodeAddressString:inRegion:completionHandler:";

	private static readonly IntPtr selGeocodeAddressString_InRegion_CompletionHandler_Handle = Selector.GetHandle("geocodeAddressString:inRegion:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGeocodeAddressString_InRegion_PreferredLocale_CompletionHandler_ = "geocodeAddressString:inRegion:preferredLocale:completionHandler:";

	private static readonly IntPtr selGeocodeAddressString_InRegion_PreferredLocale_CompletionHandler_Handle = Selector.GetHandle("geocodeAddressString:inRegion:preferredLocale:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGeocodePostalAddress_CompletionHandler_ = "geocodePostalAddress:completionHandler:";

	private static readonly IntPtr selGeocodePostalAddress_CompletionHandler_Handle = Selector.GetHandle("geocodePostalAddress:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGeocodePostalAddress_PreferredLocale_CompletionHandler_ = "geocodePostalAddress:preferredLocale:completionHandler:";

	private static readonly IntPtr selGeocodePostalAddress_PreferredLocale_CompletionHandler_Handle = Selector.GetHandle("geocodePostalAddress:preferredLocale:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsGeocoding = "isGeocoding";

	private static readonly IntPtr selIsGeocodingHandle = Selector.GetHandle("isGeocoding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReverseGeocodeLocation_CompletionHandler_ = "reverseGeocodeLocation:completionHandler:";

	private static readonly IntPtr selReverseGeocodeLocation_CompletionHandler_Handle = Selector.GetHandle("reverseGeocodeLocation:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReverseGeocodeLocation_PreferredLocale_CompletionHandler_ = "reverseGeocodeLocation:preferredLocale:completionHandler:";

	private static readonly IntPtr selReverseGeocodeLocation_PreferredLocale_CompletionHandler_Handle = Selector.GetHandle("reverseGeocodeLocation:preferredLocale:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CLGeocoder");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Geocoding
	{
		[Export("isGeocoding")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsGeocodingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsGeocodingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CLGeocoder()
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
	protected CLGeocoder(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CLGeocoder(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cancelGeocode")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelGeocode()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelGeocodeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelGeocodeHandle);
		}
	}

	[Export("geocodeAddressDictionary:completionHandler:")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'GeocodeAddress (string, CLRegion, NSLocale, CLGeocodeCompletionHandler)' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'GeocodeAddress (string, CLRegion, NSLocale, CLGeocodeCompletionHandler)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'GeocodeAddress (string, CLRegion, NSLocale, CLGeocodeCompletionHandler)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GeocodeAddress(NSDictionary addressDictionary, [BlockProxy(typeof(Trampolines.NIDCLGeocodeCompletionHandler))] CLGeocodeCompletionHandler completionHandler)
	{
		if (addressDictionary == null)
		{
			throw new ArgumentNullException("addressDictionary");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDCLGeocodeCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selGeocodeAddressDictionary_CompletionHandler_Handle, addressDictionary.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGeocodeAddressDictionary_CompletionHandler_Handle, addressDictionary.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'GeocodeAddress (string, CLRegion, NSLocale, CLGeocodeCompletionHandler)' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'GeocodeAddress (string, CLRegion, NSLocale, CLGeocodeCompletionHandler)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'GeocodeAddress (string, CLRegion, NSLocale, CLGeocodeCompletionHandler)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CLPlacemark[]> GeocodeAddressAsync(NSDictionary addressDictionary)
	{
		TaskCompletionSource<CLPlacemark[]> tcs = new TaskCompletionSource<CLPlacemark[]>();
		GeocodeAddress(addressDictionary, delegate(CLPlacemark[] placemarks_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(placemarks_);
			}
		});
		return tcs.Task;
	}

	[Export("geocodeAddressString:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GeocodeAddress(string addressString, [BlockProxy(typeof(Trampolines.NIDCLGeocodeCompletionHandler))] CLGeocodeCompletionHandler completionHandler)
	{
		if (addressString == null)
		{
			throw new ArgumentNullException("addressString");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(addressString);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDCLGeocodeCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selGeocodeAddressString_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGeocodeAddressString_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CLPlacemark[]> GeocodeAddressAsync(string addressString)
	{
		TaskCompletionSource<CLPlacemark[]> tcs = new TaskCompletionSource<CLPlacemark[]>();
		GeocodeAddress(addressString, delegate(CLPlacemark[] placemarks_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(placemarks_);
			}
		});
		return tcs.Task;
	}

	[Export("geocodeAddressString:inRegion:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GeocodeAddress(string addressString, CLRegion? region, [BlockProxy(typeof(Trampolines.NIDCLGeocodeCompletionHandler))] CLGeocodeCompletionHandler completionHandler)
	{
		if (addressString == null)
		{
			throw new ArgumentNullException("addressString");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(addressString);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDCLGeocodeCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selGeocodeAddressString_InRegion_CompletionHandler_Handle, arg, region?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selGeocodeAddressString_InRegion_CompletionHandler_Handle, arg, region?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CLPlacemark[]> GeocodeAddressAsync(string addressString, CLRegion? region)
	{
		TaskCompletionSource<CLPlacemark[]> tcs = new TaskCompletionSource<CLPlacemark[]>();
		GeocodeAddress(addressString, region, delegate(CLPlacemark[] placemarks_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(placemarks_);
			}
		});
		return tcs.Task;
	}

	[Export("geocodeAddressString:inRegion:preferredLocale:completionHandler:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GeocodeAddress(string addressString, CLRegion? region, NSLocale? locale, [BlockProxy(typeof(Trampolines.NIDCLGeocodeCompletionHandler))] CLGeocodeCompletionHandler completionHandler)
	{
		if (addressString == null)
		{
			throw new ArgumentNullException("addressString");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(addressString);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDCLGeocodeCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selGeocodeAddressString_InRegion_PreferredLocale_CompletionHandler_Handle, arg, region?.Handle ?? IntPtr.Zero, locale?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selGeocodeAddressString_InRegion_PreferredLocale_CompletionHandler_Handle, arg, region?.Handle ?? IntPtr.Zero, locale?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CLPlacemark[]> GeocodeAddressAsync(string addressString, CLRegion? region, NSLocale? locale)
	{
		TaskCompletionSource<CLPlacemark[]> tcs = new TaskCompletionSource<CLPlacemark[]>();
		GeocodeAddress(addressString, region, locale, delegate(CLPlacemark[] placemarks_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(placemarks_);
			}
		});
		return tcs.Task;
	}

	[Export("geocodePostalAddress:completionHandler:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GeocodePostalAddress(CNPostalAddress postalAddress, [BlockProxy(typeof(Trampolines.NIDCLGeocodeCompletionHandler))] CLGeocodeCompletionHandler completionHandler)
	{
		if (postalAddress == null)
		{
			throw new ArgumentNullException("postalAddress");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDCLGeocodeCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selGeocodePostalAddress_CompletionHandler_Handle, postalAddress.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGeocodePostalAddress_CompletionHandler_Handle, postalAddress.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CLPlacemark[]> GeocodePostalAddressAsync(CNPostalAddress postalAddress)
	{
		TaskCompletionSource<CLPlacemark[]> tcs = new TaskCompletionSource<CLPlacemark[]>();
		GeocodePostalAddress(postalAddress, delegate(CLPlacemark[] placemarks_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(placemarks_);
			}
		});
		return tcs.Task;
	}

	[Export("geocodePostalAddress:preferredLocale:completionHandler:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GeocodePostalAddress(CNPostalAddress postalAddress, NSLocale? locale, [BlockProxy(typeof(Trampolines.NIDCLGeocodeCompletionHandler))] CLGeocodeCompletionHandler completionHandler)
	{
		if (postalAddress == null)
		{
			throw new ArgumentNullException("postalAddress");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDCLGeocodeCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selGeocodePostalAddress_PreferredLocale_CompletionHandler_Handle, postalAddress.Handle, locale?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selGeocodePostalAddress_PreferredLocale_CompletionHandler_Handle, postalAddress.Handle, locale?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CLPlacemark[]> GeocodePostalAddressAsync(CNPostalAddress postalAddress, NSLocale? locale)
	{
		TaskCompletionSource<CLPlacemark[]> tcs = new TaskCompletionSource<CLPlacemark[]>();
		GeocodePostalAddress(postalAddress, locale, delegate(CLPlacemark[] placemarks_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(placemarks_);
			}
		});
		return tcs.Task;
	}

	[Export("reverseGeocodeLocation:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ReverseGeocodeLocation(CLLocation location, [BlockProxy(typeof(Trampolines.NIDCLGeocodeCompletionHandler))] CLGeocodeCompletionHandler completionHandler)
	{
		if (location == null)
		{
			throw new ArgumentNullException("location");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDCLGeocodeCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selReverseGeocodeLocation_CompletionHandler_Handle, location.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReverseGeocodeLocation_CompletionHandler_Handle, location.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CLPlacemark[]> ReverseGeocodeLocationAsync(CLLocation location)
	{
		TaskCompletionSource<CLPlacemark[]> tcs = new TaskCompletionSource<CLPlacemark[]>();
		ReverseGeocodeLocation(location, delegate(CLPlacemark[] placemarks_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(placemarks_);
			}
		});
		return tcs.Task;
	}

	[Export("reverseGeocodeLocation:preferredLocale:completionHandler:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ReverseGeocodeLocation(CLLocation location, NSLocale? locale, [BlockProxy(typeof(Trampolines.NIDCLGeocodeCompletionHandler))] CLGeocodeCompletionHandler completionHandler)
	{
		if (location == null)
		{
			throw new ArgumentNullException("location");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDCLGeocodeCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selReverseGeocodeLocation_PreferredLocale_CompletionHandler_Handle, location.Handle, locale?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selReverseGeocodeLocation_PreferredLocale_CompletionHandler_Handle, location.Handle, locale?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CLPlacemark[]> ReverseGeocodeLocationAsync(CLLocation location, NSLocale? locale)
	{
		TaskCompletionSource<CLPlacemark[]> tcs = new TaskCompletionSource<CLPlacemark[]>();
		ReverseGeocodeLocation(location, locale, delegate(CLPlacemark[] placemarks_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(placemarks_);
			}
		});
		return tcs.Task;
	}
}
