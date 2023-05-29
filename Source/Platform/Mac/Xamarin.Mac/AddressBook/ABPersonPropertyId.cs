using System;
using ObjCRuntime;

namespace AddressBook;

internal static class ABPersonPropertyId
{
	public static int Address { get; private set; }

	public static int Birthday { get; private set; }

	public static int CreationDate { get; private set; }

	public static int Date { get; private set; }

	public static int Department { get; private set; }

	public static int Email { get; private set; }

	public static int FirstName { get; private set; }

	public static int FirstNamePhonetic { get; private set; }

	public static int InstantMessage { get; private set; }

	public static int JobTitle { get; private set; }

	public static int Kind { get; private set; }

	public static int LastName { get; private set; }

	public static int LastNamePhonetic { get; private set; }

	public static int MiddleName { get; private set; }

	public static int MiddleNamePhonetic { get; private set; }

	public static int ModificationDate { get; private set; }

	public static int Nickname { get; private set; }

	public static int Note { get; private set; }

	public static int Organization { get; private set; }

	public static int Phone { get; private set; }

	public static int Prefix { get; private set; }

	public static int RelatedNames { get; private set; }

	public static int Suffix { get; private set; }

	public static int Url { get; private set; }

	public static int SocialProfile { get; private set; }

	static ABPersonPropertyId()
	{
		InitConstants.Init();
	}

	internal static void Init()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/AddressBook.framework/AddressBook", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			Address = Dlfcn.GetInt32(intPtr, "kABPersonAddressProperty");
			Birthday = Dlfcn.GetInt32(intPtr, "kABPersonBirthdayProperty");
			CreationDate = Dlfcn.GetInt32(intPtr, "kABPersonCreationDateProperty");
			Date = Dlfcn.GetInt32(intPtr, "kABPersonDateProperty");
			Department = Dlfcn.GetInt32(intPtr, "kABPersonDepartmentProperty");
			Email = Dlfcn.GetInt32(intPtr, "kABPersonEmailProperty");
			FirstName = Dlfcn.GetInt32(intPtr, "kABPersonFirstNameProperty");
			FirstNamePhonetic = Dlfcn.GetInt32(intPtr, "kABPersonFirstNamePhoneticProperty");
			InstantMessage = Dlfcn.GetInt32(intPtr, "kABPersonInstantMessageProperty");
			JobTitle = Dlfcn.GetInt32(intPtr, "kABPersonJobTitleProperty");
			Kind = Dlfcn.GetInt32(intPtr, "kABPersonKindProperty");
			LastName = Dlfcn.GetInt32(intPtr, "kABPersonLastNameProperty");
			LastNamePhonetic = Dlfcn.GetInt32(intPtr, "kABPersonLastNamePhoneticProperty");
			MiddleName = Dlfcn.GetInt32(intPtr, "kABPersonMiddleNameProperty");
			MiddleNamePhonetic = Dlfcn.GetInt32(intPtr, "kABPersonMiddleNamePhoneticProperty");
			ModificationDate = Dlfcn.GetInt32(intPtr, "kABPersonModificationDateProperty");
			Nickname = Dlfcn.GetInt32(intPtr, "kABPersonNicknameProperty");
			Note = Dlfcn.GetInt32(intPtr, "kABPersonNoteProperty");
			Organization = Dlfcn.GetInt32(intPtr, "kABPersonOrganizationProperty");
			Phone = Dlfcn.GetInt32(intPtr, "kABPersonPhoneProperty");
			Prefix = Dlfcn.GetInt32(intPtr, "kABPersonPrefixProperty");
			RelatedNames = Dlfcn.GetInt32(intPtr, "kABPersonRelatedNamesProperty");
			Suffix = Dlfcn.GetInt32(intPtr, "kABPersonSuffixProperty");
			Url = Dlfcn.GetInt32(intPtr, "kABPersonURLProperty");
			SocialProfile = Dlfcn.GetInt32(intPtr, "kABPersonSocialProfileProperty");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}

	public static int ToId(ABPersonProperty property)
	{
		return property switch
		{
			ABPersonProperty.Address => Address, 
			ABPersonProperty.Birthday => Birthday, 
			ABPersonProperty.CreationDate => CreationDate, 
			ABPersonProperty.Date => Date, 
			ABPersonProperty.Department => Department, 
			ABPersonProperty.Email => Email, 
			ABPersonProperty.FirstName => FirstName, 
			ABPersonProperty.FirstNamePhonetic => FirstNamePhonetic, 
			ABPersonProperty.InstantMessage => InstantMessage, 
			ABPersonProperty.JobTitle => JobTitle, 
			ABPersonProperty.Kind => Kind, 
			ABPersonProperty.LastName => LastName, 
			ABPersonProperty.LastNamePhonetic => LastNamePhonetic, 
			ABPersonProperty.MiddleName => MiddleName, 
			ABPersonProperty.MiddleNamePhonetic => MiddleNamePhonetic, 
			ABPersonProperty.ModificationDate => ModificationDate, 
			ABPersonProperty.Nickname => Nickname, 
			ABPersonProperty.Note => Note, 
			ABPersonProperty.Organization => Organization, 
			ABPersonProperty.Phone => Phone, 
			ABPersonProperty.Prefix => Prefix, 
			ABPersonProperty.RelatedNames => RelatedNames, 
			ABPersonProperty.Suffix => Suffix, 
			ABPersonProperty.Url => Url, 
			ABPersonProperty.SocialProfile => SocialProfile, 
			_ => throw new NotSupportedException("Invalid ABPersonProperty value: " + property), 
		};
	}

	public static ABPersonProperty ToPersonProperty(int id)
	{
		if (id == Address)
		{
			return ABPersonProperty.Address;
		}
		if (id == Birthday)
		{
			return ABPersonProperty.Birthday;
		}
		if (id == CreationDate)
		{
			return ABPersonProperty.CreationDate;
		}
		if (id == Date)
		{
			return ABPersonProperty.Date;
		}
		if (id == Department)
		{
			return ABPersonProperty.Department;
		}
		if (id == Email)
		{
			return ABPersonProperty.Email;
		}
		if (id == FirstName)
		{
			return ABPersonProperty.FirstName;
		}
		if (id == FirstNamePhonetic)
		{
			return ABPersonProperty.FirstNamePhonetic;
		}
		if (id == InstantMessage)
		{
			return ABPersonProperty.InstantMessage;
		}
		if (id == JobTitle)
		{
			return ABPersonProperty.JobTitle;
		}
		if (id == Kind)
		{
			return ABPersonProperty.Kind;
		}
		if (id == LastName)
		{
			return ABPersonProperty.LastName;
		}
		if (id == LastNamePhonetic)
		{
			return ABPersonProperty.LastNamePhonetic;
		}
		if (id == MiddleName)
		{
			return ABPersonProperty.MiddleName;
		}
		if (id == MiddleNamePhonetic)
		{
			return ABPersonProperty.MiddleNamePhonetic;
		}
		if (id == ModificationDate)
		{
			return ABPersonProperty.ModificationDate;
		}
		if (id == Nickname)
		{
			return ABPersonProperty.Nickname;
		}
		if (id == Note)
		{
			return ABPersonProperty.Note;
		}
		if (id == Organization)
		{
			return ABPersonProperty.Organization;
		}
		if (id == Phone)
		{
			return ABPersonProperty.Phone;
		}
		if (id == Prefix)
		{
			return ABPersonProperty.Prefix;
		}
		if (id == RelatedNames)
		{
			return ABPersonProperty.RelatedNames;
		}
		if (id == Suffix)
		{
			return ABPersonProperty.Suffix;
		}
		if (id == Url)
		{
			return ABPersonProperty.Url;
		}
		if (id == SocialProfile)
		{
			return ABPersonProperty.SocialProfile;
		}
		throw new NotSupportedException("Invalid ABPersonPropertyId value: " + id);
	}
}
