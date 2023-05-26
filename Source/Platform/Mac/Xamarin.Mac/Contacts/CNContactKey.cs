using Foundation;
using ObjCRuntime;

namespace Contacts;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class CNContactKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Birthday;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Dates;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DepartmentName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EmailAddresses;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FamilyName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GivenName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Identifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ImageData;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ImageDataAvailable;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InstantMessageAddresses;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _JobTitle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MiddleName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NamePrefix;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NameSuffix;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Nickname;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NonGregorianBirthday;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Note;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OrganizationName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PhoneNumbers;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PhoneticFamilyName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PhoneticGivenName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PhoneticMiddleName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PhoneticOrganizationName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PostalAddresses;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PreviousFamilyName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Relations;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SocialProfiles;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ThumbnailImageData;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Type;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UrlAddresses;

	[Field("CNContactBirthdayKey", "Contacts")]
	public static NSString Birthday
	{
		get
		{
			if (_Birthday == null)
			{
				_Birthday = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactBirthdayKey");
			}
			return _Birthday;
		}
	}

	[Field("CNContactDatesKey", "Contacts")]
	public static NSString Dates
	{
		get
		{
			if (_Dates == null)
			{
				_Dates = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactDatesKey");
			}
			return _Dates;
		}
	}

	[Field("CNContactDepartmentNameKey", "Contacts")]
	public static NSString DepartmentName
	{
		get
		{
			if (_DepartmentName == null)
			{
				_DepartmentName = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactDepartmentNameKey");
			}
			return _DepartmentName;
		}
	}

	[Field("CNContactEmailAddressesKey", "Contacts")]
	public static NSString EmailAddresses
	{
		get
		{
			if (_EmailAddresses == null)
			{
				_EmailAddresses = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactEmailAddressesKey");
			}
			return _EmailAddresses;
		}
	}

	[Field("CNContactFamilyNameKey", "Contacts")]
	public static NSString FamilyName
	{
		get
		{
			if (_FamilyName == null)
			{
				_FamilyName = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactFamilyNameKey");
			}
			return _FamilyName;
		}
	}

	[Field("CNContactGivenNameKey", "Contacts")]
	public static NSString GivenName
	{
		get
		{
			if (_GivenName == null)
			{
				_GivenName = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactGivenNameKey");
			}
			return _GivenName;
		}
	}

	[Field("CNContactIdentifierKey", "Contacts")]
	public static NSString Identifier
	{
		get
		{
			if (_Identifier == null)
			{
				_Identifier = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactIdentifierKey");
			}
			return _Identifier;
		}
	}

	[Field("CNContactImageDataKey", "Contacts")]
	public static NSString ImageData
	{
		get
		{
			if (_ImageData == null)
			{
				_ImageData = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactImageDataKey");
			}
			return _ImageData;
		}
	}

	[Field("CNContactImageDataAvailableKey", "Contacts")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSString ImageDataAvailable
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			if (_ImageDataAvailable == null)
			{
				_ImageDataAvailable = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactImageDataAvailableKey");
			}
			return _ImageDataAvailable;
		}
	}

	[Field("CNContactInstantMessageAddressesKey", "Contacts")]
	public static NSString InstantMessageAddresses
	{
		get
		{
			if (_InstantMessageAddresses == null)
			{
				_InstantMessageAddresses = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactInstantMessageAddressesKey");
			}
			return _InstantMessageAddresses;
		}
	}

	[Field("CNContactJobTitleKey", "Contacts")]
	public static NSString JobTitle
	{
		get
		{
			if (_JobTitle == null)
			{
				_JobTitle = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactJobTitleKey");
			}
			return _JobTitle;
		}
	}

	[Field("CNContactMiddleNameKey", "Contacts")]
	public static NSString MiddleName
	{
		get
		{
			if (_MiddleName == null)
			{
				_MiddleName = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactMiddleNameKey");
			}
			return _MiddleName;
		}
	}

	[Field("CNContactNamePrefixKey", "Contacts")]
	public static NSString NamePrefix
	{
		get
		{
			if (_NamePrefix == null)
			{
				_NamePrefix = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactNamePrefixKey");
			}
			return _NamePrefix;
		}
	}

	[Field("CNContactNameSuffixKey", "Contacts")]
	public static NSString NameSuffix
	{
		get
		{
			if (_NameSuffix == null)
			{
				_NameSuffix = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactNameSuffixKey");
			}
			return _NameSuffix;
		}
	}

	[Field("CNContactNicknameKey", "Contacts")]
	public static NSString Nickname
	{
		get
		{
			if (_Nickname == null)
			{
				_Nickname = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactNicknameKey");
			}
			return _Nickname;
		}
	}

	[Field("CNContactNonGregorianBirthdayKey", "Contacts")]
	public static NSString NonGregorianBirthday
	{
		get
		{
			if (_NonGregorianBirthday == null)
			{
				_NonGregorianBirthday = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactNonGregorianBirthdayKey");
			}
			return _NonGregorianBirthday;
		}
	}

	[Field("CNContactNoteKey", "Contacts")]
	public static NSString Note
	{
		get
		{
			if (_Note == null)
			{
				_Note = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactNoteKey");
			}
			return _Note;
		}
	}

	[Field("CNContactOrganizationNameKey", "Contacts")]
	public static NSString OrganizationName
	{
		get
		{
			if (_OrganizationName == null)
			{
				_OrganizationName = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactOrganizationNameKey");
			}
			return _OrganizationName;
		}
	}

	[Field("CNContactPhoneNumbersKey", "Contacts")]
	public static NSString PhoneNumbers
	{
		get
		{
			if (_PhoneNumbers == null)
			{
				_PhoneNumbers = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactPhoneNumbersKey");
			}
			return _PhoneNumbers;
		}
	}

	[Field("CNContactPhoneticFamilyNameKey", "Contacts")]
	public static NSString PhoneticFamilyName
	{
		get
		{
			if (_PhoneticFamilyName == null)
			{
				_PhoneticFamilyName = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactPhoneticFamilyNameKey");
			}
			return _PhoneticFamilyName;
		}
	}

	[Field("CNContactPhoneticGivenNameKey", "Contacts")]
	public static NSString PhoneticGivenName
	{
		get
		{
			if (_PhoneticGivenName == null)
			{
				_PhoneticGivenName = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactPhoneticGivenNameKey");
			}
			return _PhoneticGivenName;
		}
	}

	[Field("CNContactPhoneticMiddleNameKey", "Contacts")]
	public static NSString PhoneticMiddleName
	{
		get
		{
			if (_PhoneticMiddleName == null)
			{
				_PhoneticMiddleName = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactPhoneticMiddleNameKey");
			}
			return _PhoneticMiddleName;
		}
	}

	[Field("CNContactPhoneticOrganizationNameKey", "Contacts")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	public static NSString PhoneticOrganizationName
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PhoneticOrganizationName == null)
			{
				_PhoneticOrganizationName = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactPhoneticOrganizationNameKey");
			}
			return _PhoneticOrganizationName;
		}
	}

	[Field("CNContactPostalAddressesKey", "Contacts")]
	public static NSString PostalAddresses
	{
		get
		{
			if (_PostalAddresses == null)
			{
				_PostalAddresses = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactPostalAddressesKey");
			}
			return _PostalAddresses;
		}
	}

	[Field("CNContactPreviousFamilyNameKey", "Contacts")]
	public static NSString PreviousFamilyName
	{
		get
		{
			if (_PreviousFamilyName == null)
			{
				_PreviousFamilyName = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactPreviousFamilyNameKey");
			}
			return _PreviousFamilyName;
		}
	}

	[Field("CNContactRelationsKey", "Contacts")]
	public static NSString Relations
	{
		get
		{
			if (_Relations == null)
			{
				_Relations = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactRelationsKey");
			}
			return _Relations;
		}
	}

	[Field("CNContactSocialProfilesKey", "Contacts")]
	public static NSString SocialProfiles
	{
		get
		{
			if (_SocialProfiles == null)
			{
				_SocialProfiles = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactSocialProfilesKey");
			}
			return _SocialProfiles;
		}
	}

	[Field("CNContactThumbnailImageDataKey", "Contacts")]
	public static NSString ThumbnailImageData
	{
		get
		{
			if (_ThumbnailImageData == null)
			{
				_ThumbnailImageData = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactThumbnailImageDataKey");
			}
			return _ThumbnailImageData;
		}
	}

	[Field("CNContactTypeKey", "Contacts")]
	public static NSString Type
	{
		get
		{
			if (_Type == null)
			{
				_Type = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactTypeKey");
			}
			return _Type;
		}
	}

	[Field("CNContactUrlAddressesKey", "Contacts")]
	public static NSString UrlAddresses
	{
		get
		{
			if (_UrlAddresses == null)
			{
				_UrlAddresses = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactUrlAddressesKey");
			}
			return _UrlAddresses;
		}
	}
}
