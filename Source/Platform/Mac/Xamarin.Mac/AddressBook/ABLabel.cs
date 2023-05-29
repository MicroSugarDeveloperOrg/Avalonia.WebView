using System;
using Foundation;
using ObjCRuntime;

namespace AddressBook;

public static class ABLabel
{
	public static NSString Home { get; private set; }

	public static NSString Other { get; private set; }

	public static NSString Work { get; private set; }

	static ABLabel()
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
			Home = Dlfcn.GetStringConstant(intPtr, "kABHomeLabel");
			Other = Dlfcn.GetStringConstant(intPtr, "kABOtherLabel");
			Work = Dlfcn.GetStringConstant(intPtr, "kABWorkLabel");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}
