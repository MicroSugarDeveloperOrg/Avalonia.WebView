using ObjCRuntime;

namespace Foundation;

public static class NSTextChecking
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AirlineKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CityKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CountryKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FlightKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _JobTitleKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OrganizationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PhoneKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StreetKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ZipKey;

	[Field("NSTextCheckingAirlineKey", "Foundation")]
	public static NSString AirlineKey
	{
		get
		{
			if (_AirlineKey == null)
			{
				_AirlineKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSTextCheckingAirlineKey");
			}
			return _AirlineKey;
		}
	}

	[Field("NSTextCheckingCityKey", "Foundation")]
	public static NSString CityKey
	{
		get
		{
			if (_CityKey == null)
			{
				_CityKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSTextCheckingCityKey");
			}
			return _CityKey;
		}
	}

	[Field("NSTextCheckingCountryKey", "Foundation")]
	public static NSString CountryKey
	{
		get
		{
			if (_CountryKey == null)
			{
				_CountryKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSTextCheckingCountryKey");
			}
			return _CountryKey;
		}
	}

	[Field("NSTextCheckingFlightKey", "Foundation")]
	public static NSString FlightKey
	{
		get
		{
			if (_FlightKey == null)
			{
				_FlightKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSTextCheckingFlightKey");
			}
			return _FlightKey;
		}
	}

	[Field("NSTextCheckingJobTitleKey", "Foundation")]
	public static NSString JobTitleKey
	{
		get
		{
			if (_JobTitleKey == null)
			{
				_JobTitleKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSTextCheckingJobTitleKey");
			}
			return _JobTitleKey;
		}
	}

	[Field("NSTextCheckingNameKey", "Foundation")]
	public static NSString NameKey
	{
		get
		{
			if (_NameKey == null)
			{
				_NameKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSTextCheckingNameKey");
			}
			return _NameKey;
		}
	}

	[Field("NSTextCheckingOrganizationKey", "Foundation")]
	public static NSString OrganizationKey
	{
		get
		{
			if (_OrganizationKey == null)
			{
				_OrganizationKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSTextCheckingOrganizationKey");
			}
			return _OrganizationKey;
		}
	}

	[Field("NSTextCheckingPhoneKey", "Foundation")]
	public static NSString PhoneKey
	{
		get
		{
			if (_PhoneKey == null)
			{
				_PhoneKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSTextCheckingPhoneKey");
			}
			return _PhoneKey;
		}
	}

	[Field("NSTextCheckingStateKey", "Foundation")]
	public static NSString StateKey
	{
		get
		{
			if (_StateKey == null)
			{
				_StateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSTextCheckingStateKey");
			}
			return _StateKey;
		}
	}

	[Field("NSTextCheckingStreetKey", "Foundation")]
	public static NSString StreetKey
	{
		get
		{
			if (_StreetKey == null)
			{
				_StreetKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSTextCheckingStreetKey");
			}
			return _StreetKey;
		}
	}

	[Field("NSTextCheckingZIPKey", "Foundation")]
	public static NSString ZipKey
	{
		get
		{
			if (_ZipKey == null)
			{
				_ZipKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSTextCheckingZIPKey");
			}
			return _ZipKey;
		}
	}
}
