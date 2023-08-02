using System;
using Foundation;
using ObjCRuntime;

namespace AddressBook;

public static class ABPersonInstantMessageKey
{
	public static NSString Service { get; private set; }

	public static NSString Username { get; private set; }

	static ABPersonInstantMessageKey()
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
			Service = Dlfcn.GetStringConstant(intPtr, "kABPersonInstantMessageServiceKey");
			Username = Dlfcn.GetStringConstant(intPtr, "kABPersonInstantMessageUsernameKey");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}
