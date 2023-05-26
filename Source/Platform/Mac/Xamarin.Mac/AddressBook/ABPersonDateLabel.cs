using System;
using Foundation;
using ObjCRuntime;

namespace AddressBook;

public static class ABPersonDateLabel
{
	public static NSString Anniversary { get; private set; }

	static ABPersonDateLabel()
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
			Anniversary = Dlfcn.GetStringConstant(intPtr, "kABPersonAnniversaryLabel");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}
