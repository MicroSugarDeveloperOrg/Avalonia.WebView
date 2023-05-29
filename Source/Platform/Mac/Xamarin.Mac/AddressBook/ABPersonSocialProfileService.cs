using System;
using Foundation;
using ObjCRuntime;

namespace AddressBook;

public static class ABPersonSocialProfileService
{
	public static readonly NSString Twitter;

	public static readonly NSString GameCenter;

	public static readonly NSString Facebook;

	public static readonly NSString Myspace;

	public static readonly NSString LinkedIn;

	public static readonly NSString Flickr;

	public static readonly NSString SinaWeibo;

	static ABPersonSocialProfileService()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/AddressBook.framework/AddressBook", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			Twitter = Dlfcn.GetStringConstant(intPtr, "kABPersonSocialProfileServiceTwitter");
			GameCenter = Dlfcn.GetStringConstant(intPtr, "kABPersonSocialProfileServiceGameCenter");
			Facebook = Dlfcn.GetStringConstant(intPtr, "kABPersonSocialProfileServiceFacebook");
			Myspace = Dlfcn.GetStringConstant(intPtr, "kABPersonSocialProfileServiceMyspace");
			LinkedIn = Dlfcn.GetStringConstant(intPtr, "kABPersonSocialProfileServiceLinkedIn");
			Flickr = Dlfcn.GetStringConstant(intPtr, "kABPersonSocialProfileServiceFlickr");
			SinaWeibo = Dlfcn.GetStringConstant(intPtr, "kABPersonSocialProfileServiceSinaWeibo");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}
