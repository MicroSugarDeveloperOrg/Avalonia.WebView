using System;
using Foundation;
using ObjCRuntime;

namespace Contacts;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CNPostalAddressKeyOptionExtensions
{
	private static IntPtr[] values = new IntPtr[8];

	[Field("CNPostalAddressStreetKey", "Contacts")]
	internal unsafe static IntPtr CNPostalAddressStreetKey
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.Contacts.Handle, "CNPostalAddressStreetKey", storage);
			}
		}
	}

	[Field("CNPostalAddressCityKey", "Contacts")]
	internal unsafe static IntPtr CNPostalAddressCityKey
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.Contacts.Handle, "CNPostalAddressCityKey", storage);
			}
		}
	}

	[Field("CNPostalAddressStateKey", "Contacts")]
	internal unsafe static IntPtr CNPostalAddressStateKey
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.Contacts.Handle, "CNPostalAddressStateKey", storage);
			}
		}
	}

	[Field("CNPostalAddressPostalCodeKey", "Contacts")]
	internal unsafe static IntPtr CNPostalAddressPostalCodeKey
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.Contacts.Handle, "CNPostalAddressPostalCodeKey", storage);
			}
		}
	}

	[Field("CNPostalAddressCountryKey", "Contacts")]
	internal unsafe static IntPtr CNPostalAddressCountryKey
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.Contacts.Handle, "CNPostalAddressCountryKey", storage);
			}
		}
	}

	[Field("CNPostalAddressISOCountryCodeKey", "Contacts")]
	internal unsafe static IntPtr CNPostalAddressISOCountryCodeKey
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.Contacts.Handle, "CNPostalAddressISOCountryCodeKey", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 3, PlatformArchitecture.All, null)]
	[Field("CNPostalAddressSubLocalityKey", "Contacts")]
	internal unsafe static IntPtr CNPostalAddressSubLocalityKey
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.Contacts.Handle, "CNPostalAddressSubLocalityKey", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 3, PlatformArchitecture.All, null)]
	[Field("CNPostalAddressSubAdministrativeAreaKey", "Contacts")]
	internal unsafe static IntPtr CNPostalAddressSubAdministrativeAreaKey
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.Contacts.Handle, "CNPostalAddressSubAdministrativeAreaKey", storage);
			}
		}
	}

	public static NSString? GetConstant(this CNPostalAddressKeyOption self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = CNPostalAddressStreetKey;
			break;
		case 1:
			ptr = CNPostalAddressCityKey;
			break;
		case 2:
			ptr = CNPostalAddressStateKey;
			break;
		case 3:
			ptr = CNPostalAddressPostalCodeKey;
			break;
		case 4:
			ptr = CNPostalAddressCountryKey;
			break;
		case 5:
			ptr = CNPostalAddressISOCountryCodeKey;
			break;
		case 6:
			ptr = CNPostalAddressSubLocalityKey;
			break;
		case 7:
			ptr = CNPostalAddressSubAdministrativeAreaKey;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static CNPostalAddressKeyOption GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(CNPostalAddressStreetKey))
		{
			return CNPostalAddressKeyOption.Street;
		}
		if (constant.IsEqualTo(CNPostalAddressCityKey))
		{
			return CNPostalAddressKeyOption.City;
		}
		if (constant.IsEqualTo(CNPostalAddressStateKey))
		{
			return CNPostalAddressKeyOption.State;
		}
		if (constant.IsEqualTo(CNPostalAddressPostalCodeKey))
		{
			return CNPostalAddressKeyOption.PostalCode;
		}
		if (constant.IsEqualTo(CNPostalAddressCountryKey))
		{
			return CNPostalAddressKeyOption.Country;
		}
		if (constant.IsEqualTo(CNPostalAddressISOCountryCodeKey))
		{
			return CNPostalAddressKeyOption.IsoCountryCode;
		}
		if (constant.IsEqualTo(CNPostalAddressSubLocalityKey))
		{
			return CNPostalAddressKeyOption.SubLocality;
		}
		if (constant.IsEqualTo(CNPostalAddressSubAdministrativeAreaKey))
		{
			return CNPostalAddressKeyOption.SubAdministrativeArea;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
