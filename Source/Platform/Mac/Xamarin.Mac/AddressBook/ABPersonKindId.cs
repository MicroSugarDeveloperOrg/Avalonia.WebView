using System;
using Foundation;
using ObjCRuntime;

namespace AddressBook;

internal static class ABPersonKindId
{
	public static NSNumber Organization { get; private set; }

	public static NSNumber Person { get; private set; }

	static ABPersonKindId()
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
			Organization = Dlfcn.GetNSNumber(intPtr, "kABPersonKindOrganization");
			Person = Dlfcn.GetNSNumber(intPtr, "kABPersonKindPerson");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}

	public static ABPersonKind ToPersonKind(NSNumber value)
	{
		if (Organization == value)
		{
			return ABPersonKind.Organization;
		}
		if (Person == value)
		{
			return ABPersonKind.Person;
		}
		return ABPersonKind.None;
	}

	public static NSNumber FromPersonKind(ABPersonKind value)
	{
		return value switch
		{
			ABPersonKind.Organization => Organization, 
			ABPersonKind.Person => Person, 
			_ => null, 
		};
	}
}
