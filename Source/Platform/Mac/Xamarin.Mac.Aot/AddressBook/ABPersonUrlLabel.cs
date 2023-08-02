using System;
using Foundation;
using ObjCRuntime;

namespace AddressBook;

public static class ABPersonUrlLabel
{
	public static NSString HomePage { get; private set; }

	static ABPersonUrlLabel()
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
			HomePage = Dlfcn.GetStringConstant(intPtr, "kABPersonHomePageLabel");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}
