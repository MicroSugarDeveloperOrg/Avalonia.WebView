using System;
using Foundation;
using ObjCRuntime;

namespace AddressBook;

public static class ABPersonAddressKey
{
	public static NSString City { get; private set; }

	public static NSString Country { get; private set; }

	public static NSString CountryCode { get; private set; }

	public static NSString State { get; private set; }

	public static NSString Street { get; private set; }

	public static NSString Zip { get; private set; }

	static ABPersonAddressKey()
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
			City = Dlfcn.GetStringConstant(intPtr, "kABPersonAddressCityKey");
			Country = Dlfcn.GetStringConstant(intPtr, "kABPersonAddressCountryKey");
			CountryCode = Dlfcn.GetStringConstant(intPtr, "kABPersonAddressCountryCodeKey");
			State = Dlfcn.GetStringConstant(intPtr, "kABPersonAddressStateKey");
			Street = Dlfcn.GetStringConstant(intPtr, "kABPersonAddressStreetKey");
			Zip = Dlfcn.GetStringConstant(intPtr, "kABPersonAddressZIPKey");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}
