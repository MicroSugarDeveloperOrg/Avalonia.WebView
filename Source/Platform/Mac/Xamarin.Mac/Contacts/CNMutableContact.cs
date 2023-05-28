using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Contacts;

[Register("CNMutableContact", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CNMutableContact : CNContact
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBirthday = "birthday";

	private static readonly IntPtr selBirthdayHandle = Selector.GetHandle("birthday");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContactRelations = "contactRelations";

	private static readonly IntPtr selContactRelationsHandle = Selector.GetHandle("contactRelations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContactType = "contactType";

	private static readonly IntPtr selContactTypeHandle = Selector.GetHandle("contactType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDates = "dates";

	private static readonly IntPtr selDatesHandle = Selector.GetHandle("dates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepartmentName = "departmentName";

	private static readonly IntPtr selDepartmentNameHandle = Selector.GetHandle("departmentName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmailAddresses = "emailAddresses";

	private static readonly IntPtr selEmailAddressesHandle = Selector.GetHandle("emailAddresses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFamilyName = "familyName";

	private static readonly IntPtr selFamilyNameHandle = Selector.GetHandle("familyName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGivenName = "givenName";

	private static readonly IntPtr selGivenNameHandle = Selector.GetHandle("givenName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageData = "imageData";

	private static readonly IntPtr selImageDataHandle = Selector.GetHandle("imageData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstantMessageAddresses = "instantMessageAddresses";

	private static readonly IntPtr selInstantMessageAddressesHandle = Selector.GetHandle("instantMessageAddresses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJobTitle = "jobTitle";

	private static readonly IntPtr selJobTitleHandle = Selector.GetHandle("jobTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMiddleName = "middleName";

	private static readonly IntPtr selMiddleNameHandle = Selector.GetHandle("middleName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNamePrefix = "namePrefix";

	private static readonly IntPtr selNamePrefixHandle = Selector.GetHandle("namePrefix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNameSuffix = "nameSuffix";

	private static readonly IntPtr selNameSuffixHandle = Selector.GetHandle("nameSuffix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNickname = "nickname";

	private static readonly IntPtr selNicknameHandle = Selector.GetHandle("nickname");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNonGregorianBirthday = "nonGregorianBirthday";

	private static readonly IntPtr selNonGregorianBirthdayHandle = Selector.GetHandle("nonGregorianBirthday");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNote = "note";

	private static readonly IntPtr selNoteHandle = Selector.GetHandle("note");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrganizationName = "organizationName";

	private static readonly IntPtr selOrganizationNameHandle = Selector.GetHandle("organizationName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhoneNumbers = "phoneNumbers";

	private static readonly IntPtr selPhoneNumbersHandle = Selector.GetHandle("phoneNumbers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhoneticFamilyName = "phoneticFamilyName";

	private static readonly IntPtr selPhoneticFamilyNameHandle = Selector.GetHandle("phoneticFamilyName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhoneticGivenName = "phoneticGivenName";

	private static readonly IntPtr selPhoneticGivenNameHandle = Selector.GetHandle("phoneticGivenName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhoneticMiddleName = "phoneticMiddleName";

	private static readonly IntPtr selPhoneticMiddleNameHandle = Selector.GetHandle("phoneticMiddleName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhoneticOrganizationName = "phoneticOrganizationName";

	private static readonly IntPtr selPhoneticOrganizationNameHandle = Selector.GetHandle("phoneticOrganizationName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPostalAddresses = "postalAddresses";

	private static readonly IntPtr selPostalAddressesHandle = Selector.GetHandle("postalAddresses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviousFamilyName = "previousFamilyName";

	private static readonly IntPtr selPreviousFamilyNameHandle = Selector.GetHandle("previousFamilyName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBirthday_ = "setBirthday:";

	private static readonly IntPtr selSetBirthday_Handle = Selector.GetHandle("setBirthday:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContactRelations_ = "setContactRelations:";

	private static readonly IntPtr selSetContactRelations_Handle = Selector.GetHandle("setContactRelations:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContactType_ = "setContactType:";

	private static readonly IntPtr selSetContactType_Handle = Selector.GetHandle("setContactType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDates_ = "setDates:";

	private static readonly IntPtr selSetDates_Handle = Selector.GetHandle("setDates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDepartmentName_ = "setDepartmentName:";

	private static readonly IntPtr selSetDepartmentName_Handle = Selector.GetHandle("setDepartmentName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmailAddresses_ = "setEmailAddresses:";

	private static readonly IntPtr selSetEmailAddresses_Handle = Selector.GetHandle("setEmailAddresses:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFamilyName_ = "setFamilyName:";

	private static readonly IntPtr selSetFamilyName_Handle = Selector.GetHandle("setFamilyName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGivenName_ = "setGivenName:";

	private static readonly IntPtr selSetGivenName_Handle = Selector.GetHandle("setGivenName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageData_ = "setImageData:";

	private static readonly IntPtr selSetImageData_Handle = Selector.GetHandle("setImageData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInstantMessageAddresses_ = "setInstantMessageAddresses:";

	private static readonly IntPtr selSetInstantMessageAddresses_Handle = Selector.GetHandle("setInstantMessageAddresses:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetJobTitle_ = "setJobTitle:";

	private static readonly IntPtr selSetJobTitle_Handle = Selector.GetHandle("setJobTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMiddleName_ = "setMiddleName:";

	private static readonly IntPtr selSetMiddleName_Handle = Selector.GetHandle("setMiddleName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNamePrefix_ = "setNamePrefix:";

	private static readonly IntPtr selSetNamePrefix_Handle = Selector.GetHandle("setNamePrefix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNameSuffix_ = "setNameSuffix:";

	private static readonly IntPtr selSetNameSuffix_Handle = Selector.GetHandle("setNameSuffix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNickname_ = "setNickname:";

	private static readonly IntPtr selSetNickname_Handle = Selector.GetHandle("setNickname:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNonGregorianBirthday_ = "setNonGregorianBirthday:";

	private static readonly IntPtr selSetNonGregorianBirthday_Handle = Selector.GetHandle("setNonGregorianBirthday:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNote_ = "setNote:";

	private static readonly IntPtr selSetNote_Handle = Selector.GetHandle("setNote:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOrganizationName_ = "setOrganizationName:";

	private static readonly IntPtr selSetOrganizationName_Handle = Selector.GetHandle("setOrganizationName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPhoneNumbers_ = "setPhoneNumbers:";

	private static readonly IntPtr selSetPhoneNumbers_Handle = Selector.GetHandle("setPhoneNumbers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPhoneticFamilyName_ = "setPhoneticFamilyName:";

	private static readonly IntPtr selSetPhoneticFamilyName_Handle = Selector.GetHandle("setPhoneticFamilyName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPhoneticGivenName_ = "setPhoneticGivenName:";

	private static readonly IntPtr selSetPhoneticGivenName_Handle = Selector.GetHandle("setPhoneticGivenName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPhoneticMiddleName_ = "setPhoneticMiddleName:";

	private static readonly IntPtr selSetPhoneticMiddleName_Handle = Selector.GetHandle("setPhoneticMiddleName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPhoneticOrganizationName_ = "setPhoneticOrganizationName:";

	private static readonly IntPtr selSetPhoneticOrganizationName_Handle = Selector.GetHandle("setPhoneticOrganizationName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPostalAddresses_ = "setPostalAddresses:";

	private static readonly IntPtr selSetPostalAddresses_Handle = Selector.GetHandle("setPostalAddresses:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreviousFamilyName_ = "setPreviousFamilyName:";

	private static readonly IntPtr selSetPreviousFamilyName_Handle = Selector.GetHandle("setPreviousFamilyName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSocialProfiles_ = "setSocialProfiles:";

	private static readonly IntPtr selSetSocialProfiles_Handle = Selector.GetHandle("setSocialProfiles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUrlAddresses_ = "setUrlAddresses:";

	private static readonly IntPtr selSetUrlAddresses_Handle = Selector.GetHandle("setUrlAddresses:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSocialProfiles = "socialProfiles";

	private static readonly IntPtr selSocialProfilesHandle = Selector.GetHandle("socialProfiles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUrlAddresses = "urlAddresses";

	private static readonly IntPtr selUrlAddressesHandle = Selector.GetHandle("urlAddresses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CNMutableContact");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSDateComponents? Birthday
	{
		[Export("birthday", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDateComponents>(Messaging.IntPtr_objc_msgSend(base.Handle, selBirthdayHandle));
			}
			return Runtime.GetNSObject<NSDateComponents>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBirthdayHandle));
		}
		[Export("setBirthday:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBirthday_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBirthday_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CNLabeledValue<CNContactRelation>[] ContactRelations
	{
		[Export("contactRelations", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CNLabeledValue<CNContactRelation>>(Messaging.IntPtr_objc_msgSend(base.Handle, selContactRelationsHandle));
			}
			return NSArray.ArrayFromHandle<CNLabeledValue<CNContactRelation>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContactRelationsHandle));
		}
		[Export("setContactRelations:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContactRelations_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContactRelations_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CNContactType ContactType
	{
		[Export("contactType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CNContactType)Messaging.Int64_objc_msgSend(base.Handle, selContactTypeHandle);
			}
			return (CNContactType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selContactTypeHandle);
		}
		[Export("setContactType:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetContactType_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetContactType_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CNLabeledValue<NSDateComponents>[] Dates
	{
		[Export("dates", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CNLabeledValue<NSDateComponents>>(Messaging.IntPtr_objc_msgSend(base.Handle, selDatesHandle));
			}
			return NSArray.ArrayFromHandle<CNLabeledValue<NSDateComponents>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDatesHandle));
		}
		[Export("setDates:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDates_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDates_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string DepartmentName
	{
		[Export("departmentName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDepartmentNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDepartmentNameHandle));
		}
		[Export("setDepartmentName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDepartmentName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDepartmentName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CNLabeledValue<NSString>[] EmailAddresses
	{
		[Export("emailAddresses", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CNLabeledValue<NSString>>(Messaging.IntPtr_objc_msgSend(base.Handle, selEmailAddressesHandle));
			}
			return NSArray.ArrayFromHandle<CNLabeledValue<NSString>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEmailAddressesHandle));
		}
		[Export("setEmailAddresses:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEmailAddresses_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEmailAddresses_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string FamilyName
	{
		[Export("familyName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFamilyNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFamilyNameHandle));
		}
		[Export("setFamilyName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFamilyName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFamilyName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string GivenName
	{
		[Export("givenName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selGivenNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGivenNameHandle));
		}
		[Export("setGivenName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGivenName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGivenName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSData? ImageData
	{
		[Export("imageData", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageDataHandle));
		}
		[Export("setImageData:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImageData_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImageData_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CNLabeledValue<CNInstantMessageAddress>[] InstantMessageAddresses
	{
		[Export("instantMessageAddresses", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CNLabeledValue<CNInstantMessageAddress>>(Messaging.IntPtr_objc_msgSend(base.Handle, selInstantMessageAddressesHandle));
			}
			return NSArray.ArrayFromHandle<CNLabeledValue<CNInstantMessageAddress>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInstantMessageAddressesHandle));
		}
		[Export("setInstantMessageAddresses:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInstantMessageAddresses_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInstantMessageAddresses_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string JobTitle
	{
		[Export("jobTitle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selJobTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selJobTitleHandle));
		}
		[Export("setJobTitle:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetJobTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetJobTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string MiddleName
	{
		[Export("middleName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMiddleNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMiddleNameHandle));
		}
		[Export("setMiddleName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMiddleName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMiddleName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string NamePrefix
	{
		[Export("namePrefix")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNamePrefixHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNamePrefixHandle));
		}
		[Export("setNamePrefix:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNamePrefix_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNamePrefix_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string NameSuffix
	{
		[Export("nameSuffix")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameSuffixHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameSuffixHandle));
		}
		[Export("setNameSuffix:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNameSuffix_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNameSuffix_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string Nickname
	{
		[Export("nickname")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNicknameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNicknameHandle));
		}
		[Export("setNickname:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNickname_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNickname_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSDateComponents? NonGregorianBirthday
	{
		[Export("nonGregorianBirthday", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDateComponents>(Messaging.IntPtr_objc_msgSend(base.Handle, selNonGregorianBirthdayHandle));
			}
			return Runtime.GetNSObject<NSDateComponents>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNonGregorianBirthdayHandle));
		}
		[Export("setNonGregorianBirthday:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNonGregorianBirthday_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNonGregorianBirthday_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string Note
	{
		[Export("note")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNoteHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNoteHandle));
		}
		[Export("setNote:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNote_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNote_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string OrganizationName
	{
		[Export("organizationName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOrganizationNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOrganizationNameHandle));
		}
		[Export("setOrganizationName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOrganizationName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOrganizationName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CNLabeledValue<CNPhoneNumber>[] PhoneNumbers
	{
		[Export("phoneNumbers", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CNLabeledValue<CNPhoneNumber>>(Messaging.IntPtr_objc_msgSend(base.Handle, selPhoneNumbersHandle));
			}
			return NSArray.ArrayFromHandle<CNLabeledValue<CNPhoneNumber>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPhoneNumbersHandle));
		}
		[Export("setPhoneNumbers:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPhoneNumbers_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPhoneNumbers_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string PhoneticFamilyName
	{
		[Export("phoneticFamilyName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPhoneticFamilyNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPhoneticFamilyNameHandle));
		}
		[Export("setPhoneticFamilyName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPhoneticFamilyName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPhoneticFamilyName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string PhoneticGivenName
	{
		[Export("phoneticGivenName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPhoneticGivenNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPhoneticGivenNameHandle));
		}
		[Export("setPhoneticGivenName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPhoneticGivenName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPhoneticGivenName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string PhoneticMiddleName
	{
		[Export("phoneticMiddleName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPhoneticMiddleNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPhoneticMiddleNameHandle));
		}
		[Export("setPhoneticMiddleName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPhoneticMiddleName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPhoneticMiddleName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	public new virtual string PhoneticOrganizationName
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Export("phoneticOrganizationName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPhoneticOrganizationNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPhoneticOrganizationNameHandle));
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Export("setPhoneticOrganizationName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPhoneticOrganizationName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPhoneticOrganizationName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CNLabeledValue<CNPostalAddress>[] PostalAddresses
	{
		[Export("postalAddresses", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CNLabeledValue<CNPostalAddress>>(Messaging.IntPtr_objc_msgSend(base.Handle, selPostalAddressesHandle));
			}
			return NSArray.ArrayFromHandle<CNLabeledValue<CNPostalAddress>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPostalAddressesHandle));
		}
		[Export("setPostalAddresses:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPostalAddresses_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPostalAddresses_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string PreviousFamilyName
	{
		[Export("previousFamilyName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPreviousFamilyNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreviousFamilyNameHandle));
		}
		[Export("setPreviousFamilyName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPreviousFamilyName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPreviousFamilyName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CNLabeledValue<CNSocialProfile>[] SocialProfiles
	{
		[Export("socialProfiles", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CNLabeledValue<CNSocialProfile>>(Messaging.IntPtr_objc_msgSend(base.Handle, selSocialProfilesHandle));
			}
			return NSArray.ArrayFromHandle<CNLabeledValue<CNSocialProfile>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSocialProfilesHandle));
		}
		[Export("setSocialProfiles:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSocialProfiles_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSocialProfiles_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CNLabeledValue<NSString>[] UrlAddresses
	{
		[Export("urlAddresses", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CNLabeledValue<NSString>>(Messaging.IntPtr_objc_msgSend(base.Handle, selUrlAddressesHandle));
			}
			return NSArray.ArrayFromHandle<CNLabeledValue<NSString>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUrlAddressesHandle));
		}
		[Export("setUrlAddresses:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUrlAddresses_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUrlAddresses_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CNMutableContact()
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
	public CNMutableContact(NSCoder coder)
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
	protected CNMutableContact(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CNMutableContact(IntPtr handle)
		: base(handle)
	{
	}
}
