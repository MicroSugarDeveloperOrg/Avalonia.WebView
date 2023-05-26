using System;
using Foundation;
using ObjCRuntime;

namespace CoreSpotlight;

public static class CSSearchableIndexDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidThrottle(this ICSSearchableIndexDelegate This, CSSearchableIndex searchableIndex)
	{
		if (searchableIndex == null)
		{
			throw new ArgumentNullException("searchableIndex");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("searchableIndexDidThrottle:"), searchableIndex.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFinishThrottle(this ICSSearchableIndexDelegate This, CSSearchableIndex searchableIndex)
	{
		if (searchableIndex == null)
		{
			throw new ArgumentNullException("searchableIndex");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("searchableIndexDidFinishThrottle:"), searchableIndex.Handle);
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData? GetData(this ICSSearchableIndexDelegate This, CSSearchableIndex searchableIndex, string itemIdentifier, string typeIdentifier, out NSError outError)
	{
		if (searchableIndex == null)
		{
			throw new ArgumentNullException("searchableIndex");
		}
		if (itemIdentifier == null)
		{
			throw new ArgumentNullException("itemIdentifier");
		}
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr intPtr = NSString.CreateNative(itemIdentifier);
		IntPtr intPtr2 = NSString.CreateNative(typeIdentifier);
		NSData nSObject = Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr(This.Handle, Selector.GetHandle("dataForSearchableIndex:itemIdentifier:typeIdentifier:error:"), searchableIndex.Handle, intPtr, intPtr2, ref arg));
		NSString.ReleaseNative(intPtr);
		NSString.ReleaseNative(intPtr2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl? GetFileUrl(this ICSSearchableIndexDelegate This, CSSearchableIndex searchableIndex, string itemIdentifier, string typeIdentifier, bool inPlace, out NSError outError)
	{
		if (searchableIndex == null)
		{
			throw new ArgumentNullException("searchableIndex");
		}
		if (itemIdentifier == null)
		{
			throw new ArgumentNullException("itemIdentifier");
		}
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr intPtr = NSString.CreateNative(itemIdentifier);
		IntPtr intPtr2 = NSString.CreateNative(typeIdentifier);
		NSUrl nSObject = Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_ref_IntPtr(This.Handle, Selector.GetHandle("fileURLForSearchableIndex:itemIdentifier:typeIdentifier:inPlace:error:"), searchableIndex.Handle, intPtr, intPtr2, inPlace, ref arg));
		NSString.ReleaseNative(intPtr);
		NSString.ReleaseNative(intPtr2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}
}
