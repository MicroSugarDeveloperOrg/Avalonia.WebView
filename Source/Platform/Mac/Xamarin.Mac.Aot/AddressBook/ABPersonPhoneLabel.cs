using System;
using Foundation;
using ObjCRuntime;

namespace AddressBook;

public static class ABPersonPhoneLabel
{
	public static NSString HomeFax { get; private set; }

	public static NSString iPhone { get; private set; }

	public static NSString Main { get; private set; }

	public static NSString Mobile { get; private set; }

	public static NSString Pager { get; private set; }

	public static NSString WorkFax { get; private set; }

	public static NSString OtherFax { get; private set; }

	static ABPersonPhoneLabel()
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
			HomeFax = Dlfcn.GetStringConstant(intPtr, "kABPersonPhoneHomeFAXLabel");
			iPhone = Dlfcn.GetStringConstant(intPtr, "kABPersonPhoneIPhoneLabel");
			Main = Dlfcn.GetStringConstant(intPtr, "kABPersonPhoneMainLabel");
			Mobile = Dlfcn.GetStringConstant(intPtr, "kABPersonPhoneMobileLabel");
			Pager = Dlfcn.GetStringConstant(intPtr, "kABPersonPhonePagerLabel");
			WorkFax = Dlfcn.GetStringConstant(intPtr, "kABPersonPhoneWorkFAXLabel");
			OtherFax = Dlfcn.GetStringConstant(intPtr, "kABPersonPhoneOtherFAXLabel");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}
