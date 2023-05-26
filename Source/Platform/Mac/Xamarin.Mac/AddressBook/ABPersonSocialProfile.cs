using System;
using Foundation;
using ObjCRuntime;

namespace AddressBook;

internal static class ABPersonSocialProfile
{
	public static readonly NSString URLKey;

	public static readonly NSString ServiceKey;

	public static readonly NSString UsernameKey;

	public static readonly NSString UserIdentifierKey;

	static ABPersonSocialProfile()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/AddressBook.framework/AddressBook", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			URLKey = Dlfcn.GetStringConstant(intPtr, "kABPersonSocialProfileURLKey");
			ServiceKey = Dlfcn.GetStringConstant(intPtr, "kABPersonSocialProfileServiceKey");
			UsernameKey = Dlfcn.GetStringConstant(intPtr, "kABPersonSocialProfileUsernameKey");
			UserIdentifierKey = Dlfcn.GetStringConstant(intPtr, "kABPersonSocialProfileUserIdentifierKey");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}
