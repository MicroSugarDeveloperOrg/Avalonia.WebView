using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace Contacts;

[Register("CNContact", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CNContact : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSItemProviderReading, INSItemProviderWriting, INSMutableCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAreKeysAvailable_ = "areKeysAvailable:";

	private static readonly IntPtr selAreKeysAvailable_Handle = Selector.GetHandle("areKeysAvailable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBirthday = "birthday";

	private static readonly IntPtr selBirthdayHandle = Selector.GetHandle("birthday");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComparatorForNameSortOrder_ = "comparatorForNameSortOrder:";

	private static readonly IntPtr selComparatorForNameSortOrder_Handle = Selector.GetHandle("comparatorForNameSortOrder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContactRelations = "contactRelations";

	private static readonly IntPtr selContactRelationsHandle = Selector.GetHandle("contactRelations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContactType = "contactType";

	private static readonly IntPtr selContactTypeHandle = Selector.GetHandle("contactType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDates = "dates";

	private static readonly IntPtr selDatesHandle = Selector.GetHandle("dates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepartmentName = "departmentName";

	private static readonly IntPtr selDepartmentNameHandle = Selector.GetHandle("departmentName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorForAllComparatorKeys = "descriptorForAllComparatorKeys";

	private static readonly IntPtr selDescriptorForAllComparatorKeysHandle = Selector.GetHandle("descriptorForAllComparatorKeys");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmailAddresses = "emailAddresses";

	private static readonly IntPtr selEmailAddressesHandle = Selector.GetHandle("emailAddresses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFamilyName = "familyName";

	private static readonly IntPtr selFamilyNameHandle = Selector.GetHandle("familyName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGivenName = "givenName";

	private static readonly IntPtr selGivenNameHandle = Selector.GetHandle("givenName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageData = "imageData";

	private static readonly IntPtr selImageDataHandle = Selector.GetHandle("imageData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageDataAvailable = "imageDataAvailable";

	private static readonly IntPtr selImageDataAvailableHandle = Selector.GetHandle("imageDataAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstantMessageAddresses = "instantMessageAddresses";

	private static readonly IntPtr selInstantMessageAddressesHandle = Selector.GetHandle("instantMessageAddresses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsKeyAvailable_ = "isKeyAvailable:";

	private static readonly IntPtr selIsKeyAvailable_Handle = Selector.GetHandle("isKeyAvailable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsUnifiedWithContactWithIdentifier_ = "isUnifiedWithContactWithIdentifier:";

	private static readonly IntPtr selIsUnifiedWithContactWithIdentifier_Handle = Selector.GetHandle("isUnifiedWithContactWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemProviderVisibilityForRepresentationWithTypeIdentifier_ = "itemProviderVisibilityForRepresentationWithTypeIdentifier:";

	private static readonly IntPtr selItemProviderVisibilityForRepresentationWithTypeIdentifier_Handle = Selector.GetHandle("itemProviderVisibilityForRepresentationWithTypeIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJobTitle = "jobTitle";

	private static readonly IntPtr selJobTitleHandle = Selector.GetHandle("jobTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_ = "loadDataWithTypeIdentifier:forItemProviderCompletionHandler:";

	private static readonly IntPtr selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_Handle = Selector.GetHandle("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedStringForKey_ = "localizedStringForKey:";

	private static readonly IntPtr selLocalizedStringForKey_Handle = Selector.GetHandle("localizedStringForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMiddleName = "middleName";

	private static readonly IntPtr selMiddleNameHandle = Selector.GetHandle("middleName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableCopyWithZone_ = "mutableCopyWithZone:";

	private static readonly IntPtr selMutableCopyWithZone_Handle = Selector.GetHandle("mutableCopyWithZone:");

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
	private const string selObjectWithItemProviderData_TypeIdentifier_Error_ = "objectWithItemProviderData:typeIdentifier:error:";

	private static readonly IntPtr selObjectWithItemProviderData_TypeIdentifier_Error_Handle = Selector.GetHandle("objectWithItemProviderData:typeIdentifier:error:");

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
	private const string selPredicateForContactsInContainerWithIdentifier_ = "predicateForContactsInContainerWithIdentifier:";

	private static readonly IntPtr selPredicateForContactsInContainerWithIdentifier_Handle = Selector.GetHandle("predicateForContactsInContainerWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateForContactsInGroupWithIdentifier_ = "predicateForContactsInGroupWithIdentifier:";

	private static readonly IntPtr selPredicateForContactsInGroupWithIdentifier_Handle = Selector.GetHandle("predicateForContactsInGroupWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateForContactsMatchingEmailAddress_ = "predicateForContactsMatchingEmailAddress:";

	private static readonly IntPtr selPredicateForContactsMatchingEmailAddress_Handle = Selector.GetHandle("predicateForContactsMatchingEmailAddress:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateForContactsMatchingName_ = "predicateForContactsMatchingName:";

	private static readonly IntPtr selPredicateForContactsMatchingName_Handle = Selector.GetHandle("predicateForContactsMatchingName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateForContactsMatchingPhoneNumber_ = "predicateForContactsMatchingPhoneNumber:";

	private static readonly IntPtr selPredicateForContactsMatchingPhoneNumber_Handle = Selector.GetHandle("predicateForContactsMatchingPhoneNumber:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateForContactsWithIdentifiers_ = "predicateForContactsWithIdentifiers:";

	private static readonly IntPtr selPredicateForContactsWithIdentifiers_Handle = Selector.GetHandle("predicateForContactsWithIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviousFamilyName = "previousFamilyName";

	private static readonly IntPtr selPreviousFamilyNameHandle = Selector.GetHandle("previousFamilyName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadableTypeIdentifiersForItemProvider = "readableTypeIdentifiersForItemProvider";

	private static readonly IntPtr selReadableTypeIdentifiersForItemProviderHandle = Selector.GetHandle("readableTypeIdentifiersForItemProvider");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSocialProfiles = "socialProfiles";

	private static readonly IntPtr selSocialProfilesHandle = Selector.GetHandle("socialProfiles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selThumbnailImageData = "thumbnailImageData";

	private static readonly IntPtr selThumbnailImageDataHandle = Selector.GetHandle("thumbnailImageData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUrlAddresses = "urlAddresses";

	private static readonly IntPtr selUrlAddressesHandle = Selector.GetHandle("urlAddresses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritableTypeIdentifiersForItemProvider = "writableTypeIdentifiersForItemProvider";

	private static readonly IntPtr selWritableTypeIdentifiersForItemProviderHandle = Selector.GetHandle("writableTypeIdentifiersForItemProvider");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CNContact");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ErrorDomain;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyNotFetchedExceptionName;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDateComponents? Birthday
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CNLabeledValue<CNContactRelation>[] ContactRelations
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CNContactType ContactType
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CNLabeledValue<NSDateComponents>[] Dates
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DepartmentName
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CNLabeledValue<NSString>[] EmailAddresses
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string FamilyName
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GivenName
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
		[Export("identifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? ImageData
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool ImageDataAvailable
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("imageDataAvailable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selImageDataAvailableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selImageDataAvailableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CNLabeledValue<CNInstantMessageAddress>[] InstantMessageAddresses
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string JobTitle
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MiddleName
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string NamePrefix
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string NameSuffix
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Nickname
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDateComponents? NonGregorianBirthday
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Note
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string OrganizationName
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CNLabeledValue<CNPhoneNumber>[] PhoneNumbers
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PhoneticFamilyName
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PhoneticGivenName
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PhoneticMiddleName
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	public virtual string PhoneticOrganizationName
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CNLabeledValue<CNPostalAddress>[] PostalAddresses
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PreviousFamilyName
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public static string[] ReadableTypeIdentifiers
	{
		[Export("readableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selReadableTypeIdentifiersForItemProviderHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CNLabeledValue<CNSocialProfile>[] SocialProfiles
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? ThumbnailImageData
	{
		[Export("thumbnailImageData", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selThumbnailImageDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selThumbnailImageDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CNLabeledValue<NSString>[] UrlAddresses
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public static string[] WritableTypeIdentifiers
	{
		[Export("writableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selWritableTypeIdentifiersForItemProviderHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual string[] WritableTypeIdentifiersForItemProvider
	{
		[Export("writableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selWritableTypeIdentifiersForItemProviderHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWritableTypeIdentifiersForItemProviderHandle));
		}
	}

	[Field("CNErrorDomain", "Contacts")]
	public static NSString ErrorDomain
	{
		get
		{
			if (_ErrorDomain == null)
			{
				_ErrorDomain = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNErrorDomain");
			}
			return _ErrorDomain;
		}
	}

	[Field("CNContactPropertyNotFetchedExceptionName", "Contacts")]
	public static NSString PropertyNotFetchedExceptionName
	{
		get
		{
			if (_PropertyNotFetchedExceptionName == null)
			{
				_PropertyNotFetchedExceptionName = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactPropertyNotFetchedExceptionName");
			}
			return _PropertyNotFetchedExceptionName;
		}
	}

	public virtual bool IsKeyAvailable(CNContactOptions options)
	{
		NSString contactKey = ContactOptionsToNSString(options);
		return IsKeyAvailable(contactKey);
	}

	public static string LocalizeProperty(CNContactOptions options)
	{
		NSString contactKey = ContactOptionsToNSString(options);
		return LocalizeProperty(contactKey);
	}

	private static NSString ContactOptionsToNSString(CNContactOptions options)
	{
		if (options <= CNContactOptions.ThumbnailImageData)
		{
			if (options <= CNContactOptions.DepartmentName)
			{
				if (options <= CNContactOptions.PhoneticFamilyName)
				{
					CNContactOptions num = options - 1;
					if ((ulong)num <= 3uL)
					{
						switch (num)
						{
						case CNContactOptions.None:
							return CNContactKey.Nickname;
						case CNContactOptions.Nickname:
							return CNContactKey.PhoneticGivenName;
						case CNContactOptions.Nickname | CNContactOptions.PhoneticGivenName:
							return CNContactKey.PhoneticMiddleName;
						case CNContactOptions.PhoneticGivenName:
							goto IL_020c;
						}
					}
					if (options == CNContactOptions.PhoneticFamilyName)
					{
						return CNContactKey.PhoneticFamilyName;
					}
				}
				else
				{
					switch (options)
					{
					case CNContactOptions.OrganizationName:
						return CNContactKey.OrganizationName;
					case CNContactOptions.DepartmentName:
						return CNContactKey.DepartmentName;
					}
				}
			}
			else
			{
				switch (options)
				{
				case CNContactOptions.JobTitle:
					return CNContactKey.JobTitle;
				case CNContactOptions.Birthday:
					return CNContactKey.Birthday;
				case CNContactOptions.NonGregorianBirthday:
					return CNContactKey.NonGregorianBirthday;
				case CNContactOptions.Note:
					return CNContactKey.Note;
				case CNContactOptions.ThumbnailImageData:
					return CNContactKey.ThumbnailImageData;
				}
			}
		}
		else
		{
			switch (options)
			{
			case CNContactOptions.Type:
				return CNContactKey.Type;
			case CNContactOptions.PhoneNumbers:
				return CNContactKey.PhoneNumbers;
			case CNContactOptions.EmailAddresses:
				return CNContactKey.EmailAddresses;
			case CNContactOptions.PostalAddresses:
				return CNContactKey.PostalAddresses;
			case CNContactOptions.Dates:
				return CNContactKey.Dates;
			case CNContactOptions.UrlAddresses:
				return CNContactKey.UrlAddresses;
			case CNContactOptions.Relations:
				return CNContactKey.Relations;
			case CNContactOptions.SocialProfiles:
				return CNContactKey.SocialProfiles;
			case CNContactOptions.InstantMessageAddresses:
				return CNContactKey.InstantMessageAddresses;
			}
		}
		goto IL_020c;
		IL_020c:
		throw new ArgumentOutOfRangeException("contactOption");
	}

	public bool AreKeysAvailable<T>(T[] keyDescriptors) where T : INSObjectProtocol, INSSecureCoding, INSCopying
	{
		using NSArray keyDescriptors2 = NSArray.From(keyDescriptors, -1L);
		return AreKeysAvailable(keyDescriptors2);
	}

	public bool AreKeysAvailable(CNContactOptions options)
	{
		using NSMutableArray nSMutableArray = new NSMutableArray();
		foreach (CNContactOptions value in Enum.GetValues(typeof(CNContactOptions)))
		{
			if ((options & value) != 0)
			{
				nSMutableArray.Add(ContactOptionsToNSString(value));
			}
		}
		return AreKeysAvailable(nSMutableArray);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CNContact()
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
	public CNContact(NSCoder coder)
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
	protected CNContact(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CNContact(IntPtr handle)
		: base(handle)
	{
	}

	[Export("areKeysAvailable:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual bool AreKeysAvailable(NSArray keyDescriptors)
	{
		if (keyDescriptors == null)
		{
			throw new ArgumentNullException("keyDescriptors");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAreKeysAvailable_Handle, keyDescriptors.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAreKeysAvailable_Handle, keyDescriptors.Handle);
	}

	[Export("comparatorForNameSortOrder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: DelegateProxy(typeof(Trampolines.SDFuncArity3V0))]
	public static Func<NSObject, NSObject, NSComparisonResult> ComparatorForName(CNContactSortOrder sortOrder)
	{
		IntPtr block = Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selComparatorForNameSortOrder_Handle, (long)sortOrder);
		return Trampolines.NIDFuncArity3V0.Create(block);
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

	[Export("descriptorForAllComparatorKeys")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static ICNKeyDescriptor GetDescriptorForAllComparatorKeys()
	{
		return Runtime.GetINativeObject<ICNKeyDescriptor>(Messaging.IntPtr_objc_msgSend(class_ptr, selDescriptorForAllComparatorKeysHandle), owns: false);
	}

	[Export("itemProviderVisibilityForRepresentationWithTypeIdentifier:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSItemProviderRepresentationVisibility GetItemProviderVisibilityForTypeIdentifier(string typeIdentifier)
	{
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		IntPtr arg = NSString.CreateNative(typeIdentifier);
		NSItemProviderRepresentationVisibility result = (NSItemProviderRepresentationVisibility)((!base.IsDirectBinding) ? Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemProviderVisibilityForRepresentationWithTypeIdentifier_Handle, arg) : Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selItemProviderVisibilityForRepresentationWithTypeIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("objectWithItemProviderData:typeIdentifier:error:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INSItemProviderReading? GetObject(NSData data, string typeIdentifier, out NSError? outError)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(typeIdentifier);
		INSItemProviderReading iNativeObject = Runtime.GetINativeObject<INSItemProviderReading>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selObjectWithItemProviderData_TypeIdentifier_Error_Handle, data.Handle, arg2, ref arg), owns: false);
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return iNativeObject;
	}

	[Export("predicateForContactsMatchingName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPredicate GetPredicateForContacts(string matchingName)
	{
		if (matchingName == null)
		{
			throw new ArgumentNullException("matchingName");
		}
		IntPtr arg = NSString.CreateNative(matchingName);
		NSPredicate nSObject = Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPredicateForContactsMatchingName_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("predicateForContactsMatchingPhoneNumber:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPredicate GetPredicateForContacts(CNPhoneNumber phoneNumber)
	{
		if (phoneNumber == null)
		{
			throw new ArgumentNullException("phoneNumber");
		}
		return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPredicateForContactsMatchingPhoneNumber_Handle, phoneNumber.Handle));
	}

	[Export("predicateForContactsWithIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPredicate GetPredicateForContacts(string[] identifiers)
	{
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		NSArray nSArray = NSArray.FromStrings(identifiers);
		NSPredicate nSObject = Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPredicateForContactsWithIdentifiers_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("predicateForContactsInContainerWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPredicate GetPredicateForContactsInContainer(string containerIdentifier)
	{
		if (containerIdentifier == null)
		{
			throw new ArgumentNullException("containerIdentifier");
		}
		IntPtr arg = NSString.CreateNative(containerIdentifier);
		NSPredicate nSObject = Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPredicateForContactsInContainerWithIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("predicateForContactsInGroupWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPredicate GetPredicateForContactsInGroup(string groupIdentifier)
	{
		if (groupIdentifier == null)
		{
			throw new ArgumentNullException("groupIdentifier");
		}
		IntPtr arg = NSString.CreateNative(groupIdentifier);
		NSPredicate nSObject = Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPredicateForContactsInGroupWithIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("predicateForContactsMatchingEmailAddress:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPredicate GetPredicateForContactsMatchingEmailAddress(string emailAddress)
	{
		if (emailAddress == null)
		{
			throw new ArgumentNullException("emailAddress");
		}
		IntPtr arg = NSString.CreateNative(emailAddress);
		NSPredicate nSObject = Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPredicateForContactsMatchingEmailAddress_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("isKeyAvailable:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsKeyAvailable(NSString contactKey)
	{
		if (contactKey == null)
		{
			throw new ArgumentNullException("contactKey");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsKeyAvailable_Handle, contactKey.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsKeyAvailable_Handle, contactKey.Handle);
	}

	[Export("isUnifiedWithContactWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsUnifiedWithContact(string contactIdentifier)
	{
		if (contactIdentifier == null)
		{
			throw new ArgumentNullException("contactIdentifier");
		}
		IntPtr arg = NSString.CreateNative(contactIdentifier);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsUnifiedWithContactWithIdentifier_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsUnifiedWithContactWithIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSProgress? LoadData(string typeIdentifier, [BlockProxy(typeof(Trampolines.NIDActionArity2V3))] Action<NSData, NSError> completionHandler)
	{
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(typeIdentifier);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V3.Handler, completionHandler);
		NSProgress result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_Handle, arg, (IntPtr)ptr)) : Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_Handle, arg, (IntPtr)ptr)));
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
		return result;
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSData> LoadDataAsync(string typeIdentifier)
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		LoadData(typeIdentifier, delegate(NSData arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSData> LoadDataAsync(string typeIdentifier, out NSProgress result)
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		result = LoadData(typeIdentifier, delegate(NSData arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("localizedStringForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string LocalizeProperty(NSString contactKey)
	{
		if (contactKey == null)
		{
			throw new ArgumentNullException("contactKey");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLocalizedStringForKey_Handle, contactKey.Handle));
	}

	[Export("mutableCopyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject MutableCopy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}
}
