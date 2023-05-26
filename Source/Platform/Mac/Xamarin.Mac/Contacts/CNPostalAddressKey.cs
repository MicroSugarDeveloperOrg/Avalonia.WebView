using Foundation;
using ObjCRuntime;

namespace Contacts;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class CNPostalAddressKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _City;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Country;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsoCountryCode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PostalCode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _State;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Street;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SubAdministrativeArea;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SubLocality;

	[Field("CNPostalAddressCityKey", "Contacts")]
	public static NSString City
	{
		get
		{
			if (_City == null)
			{
				_City = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNPostalAddressCityKey");
			}
			return _City;
		}
	}

	[Field("CNPostalAddressCountryKey", "Contacts")]
	public static NSString Country
	{
		get
		{
			if (_Country == null)
			{
				_Country = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNPostalAddressCountryKey");
			}
			return _Country;
		}
	}

	[Field("CNPostalAddressISOCountryCodeKey", "Contacts")]
	public static NSString IsoCountryCode
	{
		get
		{
			if (_IsoCountryCode == null)
			{
				_IsoCountryCode = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNPostalAddressISOCountryCodeKey");
			}
			return _IsoCountryCode;
		}
	}

	[Field("CNPostalAddressPostalCodeKey", "Contacts")]
	public static NSString PostalCode
	{
		get
		{
			if (_PostalCode == null)
			{
				_PostalCode = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNPostalAddressPostalCodeKey");
			}
			return _PostalCode;
		}
	}

	[Field("CNPostalAddressStateKey", "Contacts")]
	public static NSString State
	{
		get
		{
			if (_State == null)
			{
				_State = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNPostalAddressStateKey");
			}
			return _State;
		}
	}

	[Field("CNPostalAddressStreetKey", "Contacts")]
	public static NSString Street
	{
		get
		{
			if (_Street == null)
			{
				_Street = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNPostalAddressStreetKey");
			}
			return _Street;
		}
	}

	[Field("CNPostalAddressSubAdministrativeAreaKey", "Contacts")]
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 3, PlatformArchitecture.All, null)]
	public static NSString SubAdministrativeArea
	{
		[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_SubAdministrativeArea == null)
			{
				_SubAdministrativeArea = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNPostalAddressSubAdministrativeAreaKey");
			}
			return _SubAdministrativeArea;
		}
	}

	[Field("CNPostalAddressSubLocalityKey", "Contacts")]
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 3, PlatformArchitecture.All, null)]
	public static NSString SubLocality
	{
		[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_SubLocality == null)
			{
				_SubLocality = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNPostalAddressSubLocalityKey");
			}
			return _SubLocality;
		}
	}
}
