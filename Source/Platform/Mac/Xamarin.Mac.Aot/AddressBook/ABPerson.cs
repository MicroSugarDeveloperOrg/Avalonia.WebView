using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace AddressBook;

public class ABPerson : ABRecord, IComparable, IComparable<ABPerson>
{
	public NSData Image
	{
		get
		{
			return (NSData)Runtime.GetNSObject(ABPersonCopyImageData(base.Handle));
		}
		set
		{
			if (!ABPersonSetImageData(base.Handle, value?.Handle ?? IntPtr.Zero, out var error))
			{
				throw CFException.FromCFError(error);
			}
		}
	}

	public bool HasImage => ABPersonHasImageData(base.Handle);

	public static ABPersonCompositeNameFormat CompositeNameFormat => ABPersonGetCompositeNameFormat();

	public static ABPersonSortBy SortOrdering => ABPersonGetSortOrdering();

	public string FirstName
	{
		get
		{
			return PropertyToString(ABPersonPropertyId.FirstName);
		}
		set
		{
			SetValue(ABPersonPropertyId.FirstName, value);
		}
	}

	public string FirstNamePhonetic
	{
		get
		{
			return PropertyToString(ABPersonPropertyId.FirstNamePhonetic);
		}
		set
		{
			SetValue(ABPersonPropertyId.FirstNamePhonetic, value);
		}
	}

	public string LastName
	{
		get
		{
			return PropertyToString(ABPersonPropertyId.LastName);
		}
		set
		{
			SetValue(ABPersonPropertyId.LastName, value);
		}
	}

	public string LastNamePhonetic
	{
		get
		{
			return PropertyToString(ABPersonPropertyId.LastNamePhonetic);
		}
		set
		{
			SetValue(ABPersonPropertyId.LastNamePhonetic, value);
		}
	}

	public string MiddleName
	{
		get
		{
			return PropertyToString(ABPersonPropertyId.MiddleName);
		}
		set
		{
			SetValue(ABPersonPropertyId.MiddleName, value);
		}
	}

	public string MiddleNamePhonetic
	{
		get
		{
			return PropertyToString(ABPersonPropertyId.MiddleNamePhonetic);
		}
		set
		{
			SetValue(ABPersonPropertyId.MiddleNamePhonetic, value);
		}
	}

	public string Prefix
	{
		get
		{
			return PropertyToString(ABPersonPropertyId.Prefix);
		}
		set
		{
			SetValue(ABPersonPropertyId.Prefix, value);
		}
	}

	public string Suffix
	{
		get
		{
			return PropertyToString(ABPersonPropertyId.Suffix);
		}
		set
		{
			SetValue(ABPersonPropertyId.Suffix, value);
		}
	}

	public string Nickname
	{
		get
		{
			return PropertyToString(ABPersonPropertyId.Nickname);
		}
		set
		{
			SetValue(ABPersonPropertyId.Nickname, value);
		}
	}

	public string Organization
	{
		get
		{
			return PropertyToString(ABPersonPropertyId.Organization);
		}
		set
		{
			SetValue(ABPersonPropertyId.Organization, value);
		}
	}

	public string JobTitle
	{
		get
		{
			return PropertyToString(ABPersonPropertyId.JobTitle);
		}
		set
		{
			SetValue(ABPersonPropertyId.JobTitle, value);
		}
	}

	public string Department
	{
		get
		{
			return PropertyToString(ABPersonPropertyId.Department);
		}
		set
		{
			SetValue(ABPersonPropertyId.Department, value);
		}
	}

	[Since(4, 0)]
	public ABRecord Source
	{
		get
		{
			IntPtr intPtr = ABPersonCopySource(base.Handle);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return ABRecord.FromHandle(intPtr, null);
		}
	}

	public NSDate Birthday
	{
		get
		{
			return PropertyTo<NSDate>(ABPersonPropertyId.Birthday);
		}
		set
		{
			SetValue(ABPersonPropertyId.Birthday, value);
		}
	}

	public string Note
	{
		get
		{
			return PropertyToString(ABPersonPropertyId.Note);
		}
		set
		{
			SetValue(ABPersonPropertyId.Note, value);
		}
	}

	public NSDate CreationDate
	{
		get
		{
			return PropertyTo<NSDate>(ABPersonPropertyId.CreationDate);
		}
		set
		{
			SetValue(ABPersonPropertyId.CreationDate, value);
		}
	}

	public NSDate ModificationDate
	{
		get
		{
			return PropertyTo<NSDate>(ABPersonPropertyId.ModificationDate);
		}
		set
		{
			SetValue(ABPersonPropertyId.ModificationDate, value);
		}
	}

	public ABPersonKind PersonKind
	{
		get
		{
			return ABPersonKindId.ToPersonKind(PropertyTo<NSNumber>(ABPersonPropertyId.Kind));
		}
		set
		{
			SetValue(ABPersonPropertyId.Kind, ABPersonKindId.FromPersonKind(value));
		}
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABPersonCreate();

	public ABPerson()
		: base(ABPersonCreate(), owns: true)
	{
		InitConstants.Init();
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABPersonCreateInSource(IntPtr source);

	[Since(4, 0)]
	public ABPerson(ABRecord source)
		: base(IntPtr.Zero, owns: true)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		base.Handle = ABPersonCreateInSource(source.Handle);
	}

	internal ABPerson(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	internal ABPerson(IntPtr handle, ABAddressBook addressbook)
		: base(handle, owns: false)
	{
		base.AddressBook = addressbook;
	}

	int IComparable.CompareTo(object o)
	{
		if (!(o is ABPerson other))
		{
			throw new ArgumentException("Can only compare to other ABPerson instances.", "o");
		}
		return CompareTo(other);
	}

	public int CompareTo(ABPerson other)
	{
		return CompareTo(other, ABPersonSortBy.LastName);
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern int ABPersonComparePeopleByName(IntPtr person1, IntPtr person2, ABPersonSortBy ordering);

	public int CompareTo(ABPerson other, ABPersonSortBy ordering)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (ordering != 0 && ordering != ABPersonSortBy.LastName)
		{
			throw new ArgumentException("Invalid ordering value: " + ordering, "ordering");
		}
		return ABPersonComparePeopleByName(base.Handle, other.Handle, ordering);
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABPersonCopyLocalizedPropertyName(int propertyId);

	public static string LocalizedPropertyName(ABPersonProperty property)
	{
		return Runtime.GetNSObject(ABPersonCopyLocalizedPropertyName(ABPersonPropertyId.ToId(property))).ToString();
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern ABPropertyType ABPersonGetTypeOfProperty(int propertyId);

	public static ABPropertyType GetPropertyType(ABPersonProperty property)
	{
		return ABPersonGetTypeOfProperty(ABPersonPropertyId.ToId(property));
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern bool ABPersonSetImageData(IntPtr person, IntPtr imageData, out IntPtr error);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABPersonCopyImageData(IntPtr person);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern bool ABPersonHasImageData(IntPtr person);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern bool ABPersonRemoveImageData(IntPtr person, out IntPtr error);

	public void RemoveImage()
	{
		if (!ABPersonRemoveImageData(base.Handle, out var error))
		{
			throw CFException.FromCFError(error);
		}
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern ABPersonCompositeNameFormat ABPersonGetCompositeNameFormat();

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern ABPersonSortBy ABPersonGetSortOrdering();

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABPersonCopySource(IntPtr group);

	internal static string ToString(IntPtr value)
	{
		if (value == IntPtr.Zero)
		{
			return null;
		}
		return Runtime.GetNSObject(value).ToString();
	}

	internal static IntPtr ToIntPtr(string value)
	{
		if (value == null)
		{
			return IntPtr.Zero;
		}
		return new NSString(value).Handle;
	}

	public ABMultiValue<string> GetEmails()
	{
		return CreateStringMultiValue(CopyValue(ABPersonPropertyId.Email));
	}

	private static ABMultiValue<string> CreateStringMultiValue(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			return null;
		}
		return new ABMultiValue<string>(handle, ToString, ToIntPtr);
	}

	public void SetEmails(ABMultiValue<string> value)
	{
		SetValue(ABPersonPropertyId.Email, value?.Handle ?? IntPtr.Zero);
	}

	[Advice("Use GetAllAddresses")]
	public ABMultiValue<NSDictionary> GetAddresses()
	{
		return CreateDictionaryMultiValue(CopyValue(ABPersonPropertyId.Address));
	}

	public ABMultiValue<PersonAddress> GetAllAddresses()
	{
		return CreateDictionaryMultiValue(CopyValue(ABPersonPropertyId.Address), (NSDictionary l) => new PersonAddress(l));
	}

	public void SetAddresses(ABMultiValue<NSDictionary> value)
	{
		SetValue(ABPersonPropertyId.Address, value?.Handle ?? IntPtr.Zero);
	}

	public void SetAddresses(ABMultiValue<PersonAddress> addresses)
	{
		SetValue(ABPersonPropertyId.Address, addresses?.Handle ?? IntPtr.Zero);
	}

	private static ABMultiValue<NSDictionary> CreateDictionaryMultiValue(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			return null;
		}
		return new ABMultiValue<NSDictionary>(handle);
	}

	private static ABMultiValue<T> CreateDictionaryMultiValue<T>(IntPtr handle, Func<NSDictionary, T> factory) where T : DictionaryContainer
	{
		if (handle == IntPtr.Zero)
		{
			return null;
		}
		return new ABMultiValue<T>(handle, (IntPtr l) => factory((NSDictionary)Runtime.GetNSObject(l)), (T l) => l.Dictionary.Handle);
	}

	public ABMultiValue<NSDate> GetDates()
	{
		return CreateDateMultiValue(CopyValue(ABPersonPropertyId.Date));
	}

	private static ABMultiValue<NSDate> CreateDateMultiValue(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			return null;
		}
		return new ABMultiValue<NSDate>(handle);
	}

	public void SetDates(ABMultiValue<NSDate> value)
	{
		SetValue(ABPersonPropertyId.Date, value?.Handle ?? IntPtr.Zero);
	}

	public ABMultiValue<string> GetPhones()
	{
		return CreateStringMultiValue(CopyValue(ABPersonPropertyId.Phone));
	}

	public void SetPhones(ABMultiValue<string> value)
	{
		SetValue(ABPersonPropertyId.Phone, value?.Handle ?? IntPtr.Zero);
	}

	[Advice("Use GetInstantMessageServices")]
	public ABMultiValue<NSDictionary> GetInstantMessages()
	{
		return CreateDictionaryMultiValue(CopyValue(ABPersonPropertyId.InstantMessage));
	}

	public ABMultiValue<InstantMessageService> GetInstantMessageServices()
	{
		return CreateDictionaryMultiValue(CopyValue(ABPersonPropertyId.InstantMessage), (NSDictionary l) => new InstantMessageService(l));
	}

	public void SetInstantMessages(ABMultiValue<NSDictionary> value)
	{
		SetValue(ABPersonPropertyId.InstantMessage, value?.Handle ?? IntPtr.Zero);
	}

	public void SetInstantMessages(ABMultiValue<InstantMessageService> services)
	{
		SetValue(ABPersonPropertyId.InstantMessage, services?.Handle ?? IntPtr.Zero);
	}

	[Advice("Use GetSocialProfiles")]
	public ABMultiValue<NSDictionary> GetSocialProfile()
	{
		return CreateDictionaryMultiValue(CopyValue(ABPersonPropertyId.SocialProfile));
	}

	public ABMultiValue<SocialProfile> GetSocialProfiles()
	{
		return CreateDictionaryMultiValue(CopyValue(ABPersonPropertyId.SocialProfile), (NSDictionary l) => new SocialProfile(l));
	}

	public void SetSocialProfile(ABMultiValue<NSDictionary> value)
	{
		SetValue(ABPersonPropertyId.SocialProfile, value?.Handle ?? IntPtr.Zero);
	}

	public void SetSocialProfile(ABMultiValue<SocialProfile> profiles)
	{
		SetValue(ABPersonPropertyId.SocialProfile, profiles?.Handle ?? IntPtr.Zero);
	}

	public ABMultiValue<string> GetUrls()
	{
		return CreateStringMultiValue(CopyValue(ABPersonPropertyId.Url));
	}

	public void SetUrls(ABMultiValue<string> value)
	{
		SetValue(ABPersonPropertyId.Url, value?.Handle ?? IntPtr.Zero);
	}

	public ABMultiValue<string> GetRelatedNames()
	{
		return CreateStringMultiValue(CopyValue(ABPersonPropertyId.RelatedNames));
	}

	public void SetRelatedNames(ABMultiValue<string> value)
	{
		SetValue(ABPersonPropertyId.RelatedNames, value?.Handle ?? IntPtr.Zero);
	}

	public object GetProperty(ABPersonProperty property)
	{
		return property switch
		{
			ABPersonProperty.Address => GetAddresses(), 
			ABPersonProperty.Birthday => Birthday, 
			ABPersonProperty.CreationDate => CreationDate, 
			ABPersonProperty.Date => GetDates(), 
			ABPersonProperty.Department => Department, 
			ABPersonProperty.Email => GetEmails(), 
			ABPersonProperty.FirstName => FirstName, 
			ABPersonProperty.FirstNamePhonetic => FirstNamePhonetic, 
			ABPersonProperty.InstantMessage => GetInstantMessages(), 
			ABPersonProperty.JobTitle => JobTitle, 
			ABPersonProperty.Kind => PersonKind, 
			ABPersonProperty.LastName => LastName, 
			ABPersonProperty.LastNamePhonetic => LastNamePhonetic, 
			ABPersonProperty.MiddleName => MiddleName, 
			ABPersonProperty.MiddleNamePhonetic => MiddleNamePhonetic, 
			ABPersonProperty.ModificationDate => ModificationDate, 
			ABPersonProperty.Nickname => Nickname, 
			ABPersonProperty.Note => Note, 
			ABPersonProperty.Organization => Organization, 
			ABPersonProperty.Phone => GetPhones(), 
			ABPersonProperty.Prefix => Prefix, 
			ABPersonProperty.RelatedNames => GetRelatedNames(), 
			ABPersonProperty.Suffix => Suffix, 
			ABPersonProperty.Url => GetUrls(), 
			ABPersonProperty.SocialProfile => GetSocialProfile(), 
			_ => throw new ArgumentException("Invalid property value: " + property), 
		};
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABPersonCopyArrayOfAllLinkedPeople(IntPtr person);

	[Since(4, 0)]
	public ABPerson[] GetLinkedPeople()
	{
		return NSArray.ArrayFromHandle(ABPersonCopyArrayOfAllLinkedPeople(base.Handle), (IntPtr l) => new ABPerson(l, null));
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABPersonCopyImageDataWithFormat(IntPtr handle, ABPersonImageFormat format);

	[Since(4, 1)]
	public NSData GetImage(ABPersonImageFormat format)
	{
		return (NSData)Runtime.GetNSObject(ABPersonCopyImageDataWithFormat(base.Handle, format));
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABPersonCreateVCardRepresentationWithPeople(IntPtr people);

	[Since(5, 0)]
	public static NSData GetVCards(params ABPerson[] people)
	{
		if (people == null)
		{
			throw new ArgumentNullException("people");
		}
		IntPtr[] array = new IntPtr[people.Length];
		for (int i = 0; i < people.Length; i++)
		{
			array[i] = people[i].Handle;
		}
		return new NSData(ABPersonCreateVCardRepresentationWithPeople(CFArray.Create(array)), owns: true);
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABPersonCreatePeopleInSourceWithVCardRepresentation(IntPtr source, IntPtr vCardData);

	[Since(5, 0)]
	public static ABPerson[] CreateFromVCard(ABRecord source, NSData vCardData)
	{
		if (vCardData == null)
		{
			throw new ArgumentNullException("vCardData");
		}
		return NSArray.ArrayFromHandle(ABPersonCreatePeopleInSourceWithVCardRepresentation(source?.Handle ?? IntPtr.Zero, vCardData.Handle), (IntPtr l) => new ABPerson(l, null));
	}
}
