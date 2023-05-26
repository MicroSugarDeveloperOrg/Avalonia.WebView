using System;
using Foundation;
using ObjCRuntime;

namespace AddressBook;

public static class ABPersonInstantMessageService
{
	public static NSString Aim { get; private set; }

	public static NSString Icq { get; private set; }

	public static NSString Jabber { get; private set; }

	public static NSString Msn { get; private set; }

	public static NSString Yahoo { get; private set; }

	public static NSString QQ { get; private set; }

	public static NSString GoogleTalk { get; private set; }

	public static NSString Skype { get; private set; }

	public static NSString Facebook { get; private set; }

	public static NSString GaduGadu { get; private set; }

	static ABPersonInstantMessageService()
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
			Aim = Dlfcn.GetStringConstant(intPtr, "kABPersonInstantMessageServiceAIM");
			Icq = Dlfcn.GetStringConstant(intPtr, "kABPersonInstantMessageServiceICQ");
			Jabber = Dlfcn.GetStringConstant(intPtr, "kABPersonInstantMessageServiceJabber");
			Msn = Dlfcn.GetStringConstant(intPtr, "kABPersonInstantMessageServiceMSN");
			Yahoo = Dlfcn.GetStringConstant(intPtr, "kABPersonInstantMessageServiceYahoo");
			QQ = Dlfcn.GetStringConstant(intPtr, "kABPersonInstantMessageServiceQQ");
			GoogleTalk = Dlfcn.GetStringConstant(intPtr, "kABPersonInstantMessageServiceGoogleTalk");
			Skype = Dlfcn.GetStringConstant(intPtr, "kABPersonInstantMessageServiceSkype");
			Facebook = Dlfcn.GetStringConstant(intPtr, "kABPersonInstantMessageServiceFacebook");
			GaduGadu = Dlfcn.GetStringConstant(intPtr, "kABPersonInstantMessageServiceGaduGadu");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}
