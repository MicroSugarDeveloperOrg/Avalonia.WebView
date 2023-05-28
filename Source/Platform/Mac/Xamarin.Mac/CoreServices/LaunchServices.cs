using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreServices;

public static class LaunchServices
{
	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	[Mac(10, 10)]
	private static extern IntPtr LSCopyDefaultApplicationURLForURL(IntPtr inUrl, LSRoles inRole, IntPtr outError);

	[Mac(10, 10)]
	public static NSUrl GetDefaultApplicationUrlForUrl(NSUrl url, LSRoles roles = LSRoles.All)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<NSUrl>(LSCopyDefaultApplicationURLForURL(url.Handle, roles, IntPtr.Zero));
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	[Mac(10, 10)]
	private static extern IntPtr LSCopyDefaultApplicationURLForContentType(IntPtr inContentType, LSRoles inRole, IntPtr outError);

	[Mac(10, 10)]
	public static NSUrl GetDefaultApplicationUrlForContentType(string contentType, LSRoles roles = LSRoles.All)
	{
		if (contentType == null)
		{
			throw new ArgumentNullException("contentType");
		}
		return Runtime.GetNSObject<NSUrl>(LSCopyDefaultApplicationURLForContentType(new NSString(contentType).Handle, roles, IntPtr.Zero));
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern IntPtr LSCopyApplicationURLsForURL(IntPtr inUrl, LSRoles inRole);

	public static NSUrl[] GetApplicationUrlsForUrl(NSUrl url, LSRoles roles = LSRoles.All)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return NSArray.ArrayFromHandle<NSUrl>(LSCopyApplicationURLsForURL(url.Handle, roles));
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern LSResult LSCanURLAcceptURL(IntPtr inItemUrl, IntPtr inTargetUrl, LSRoles inRole, LSAcceptanceFlags inFlags, out byte outAcceptsItem);

	public static bool CanUrlAcceptUrl(NSUrl itemUrl, NSUrl targetUrl, LSRoles roles, LSAcceptanceFlags acceptanceFlags, out LSResult result)
	{
		if (itemUrl == null)
		{
			throw new ArgumentNullException("itemUrl");
		}
		if (targetUrl == null)
		{
			throw new ArgumentNullException("targetUrl");
		}
		result = LSCanURLAcceptURL(itemUrl.Handle, targetUrl.Handle, roles, acceptanceFlags, out var outAcceptsItem);
		return outAcceptsItem != 0;
	}

	public static bool CanUrlAcceptUrl(NSUrl itemUrl, NSUrl targetUrl, LSRoles roles = LSRoles.All, LSAcceptanceFlags acceptanceFlags = LSAcceptanceFlags.Default)
	{
		LSResult result;
		return CanUrlAcceptUrl(itemUrl, targetUrl, roles, acceptanceFlags, out result);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	[Mac(10, 10)]
	private static extern IntPtr LSCopyApplicationURLsForBundleIdentifier(IntPtr inBundleIdentifier, IntPtr outError);

	[Mac(10, 10)]
	public static NSUrl[] GetApplicationUrlsForBundleIdentifier(string bundleIdentifier)
	{
		if (bundleIdentifier == null)
		{
			throw new ArgumentNullException("bundleIdentifier");
		}
		return NSArray.ArrayFromHandle<NSUrl>(LSCopyApplicationURLsForBundleIdentifier(new NSString(bundleIdentifier).Handle, IntPtr.Zero));
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private unsafe static extern LSResult LSOpenCFURLRef(IntPtr inUrl, void** outLaunchedUrl);

	public unsafe static LSResult Open(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return LSOpenCFURLRef(url.Handle, null);
	}

	public unsafe static LSResult Open(NSUrl url, out NSUrl launchedUrl)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		void* value = default(void*);
		LSResult result = LSOpenCFURLRef(url.Handle, &value);
		launchedUrl = Runtime.GetNSObject<NSUrl>(new IntPtr(value));
		return result;
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern LSResult LSRegisterURL(IntPtr inUrl, byte inUpdate);

	public static LSResult Register(NSUrl url, bool update)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return LSRegisterURL(url.Handle, (byte)(update ? 1u : 0u));
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern IntPtr LSCopyAllRoleHandlersForContentType(IntPtr inContentType, LSRoles inRole);

	public static string[] GetAllRoleHandlersForContentType(string contentType, LSRoles roles = LSRoles.All)
	{
		if (contentType == null)
		{
			throw new ArgumentNullException("contentType");
		}
		return NSArray.StringArrayFromHandle(LSCopyAllRoleHandlersForContentType(new NSString(contentType).Handle, roles));
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern IntPtr LSCopyDefaultRoleHandlerForContentType(IntPtr inContentType, LSRoles inRole);

	public static string GetDefaultRoleHandlerForContentType(string contentType, LSRoles roles = LSRoles.All)
	{
		if (contentType == null)
		{
			throw new ArgumentNullException("contentType");
		}
		return Runtime.GetNSObject<NSString>(LSCopyDefaultRoleHandlerForContentType(new NSString(contentType).Handle, roles));
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern LSResult LSSetDefaultRoleHandlerForContentType(IntPtr inContentType, LSRoles inRole, IntPtr inHandlerBundleID);

	public static LSResult SetDefaultRoleHandlerForContentType(string contentType, string handlerBundleId, LSRoles roles = LSRoles.All)
	{
		if (contentType == null)
		{
			throw new ArgumentNullException("contentType");
		}
		if (handlerBundleId == null)
		{
			throw new ArgumentNullException("handlerBundleId");
		}
		return LSSetDefaultRoleHandlerForContentType(new NSString(contentType).Handle, roles, new NSString(handlerBundleId).Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern IntPtr LSCopyAllHandlersForURLScheme(IntPtr inUrlScheme);

	public static string[] GetAllHandlersForUrlScheme(string urlScheme)
	{
		if (urlScheme == null)
		{
			throw new ArgumentNullException("urlScheme");
		}
		return NSArray.StringArrayFromHandle(LSCopyAllHandlersForURLScheme(new NSString(urlScheme).Handle));
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern IntPtr LSCopyDefaultHandlerForURLScheme(IntPtr inUrlScheme);

	public static string GetDefaultHandlerForUrlScheme(string urlScheme)
	{
		if (urlScheme == null)
		{
			throw new ArgumentNullException("urlScheme");
		}
		return Runtime.GetNSObject<NSString>(LSCopyDefaultHandlerForURLScheme(new NSString(urlScheme).Handle));
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern LSResult LSSetDefaultHandlerForURLScheme(IntPtr inUrlScheme, IntPtr inHandlerBundleId);

	public static LSResult SetDefaultHandlerForUrlScheme(string urlScheme, string handlerBundleId)
	{
		if (urlScheme == null)
		{
			throw new ArgumentNullException("urlScheme");
		}
		if (handlerBundleId == null)
		{
			throw new ArgumentNullException("handlerBundleId");
		}
		return LSSetDefaultHandlerForURLScheme(new NSString(urlScheme).Handle, new NSString(handlerBundleId).Handle);
	}
}
