using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSHTTPCookieStorage", true)]
public class NSHttpCookieStorage : NSObject
{
	public static NSString CookiesChangedNotification;

	public static NSString AcceptPolicyChangedNotification;

	private static readonly IntPtr selSharedHTTPCookieStorageHandle;

	private static readonly IntPtr selCookiesHandle;

	private static readonly IntPtr selCookieAcceptPolicyHandle;

	private static readonly IntPtr selSetCookieAcceptPolicy_Handle;

	private static readonly IntPtr selSetCookie_Handle;

	private static readonly IntPtr selDeleteCookie_Handle;

	private static readonly IntPtr selCookiesForURL_Handle;

	private static readonly IntPtr selSetCookiesForURLMainDocumentURL_Handle;

	private static readonly IntPtr selSortedCookiesUsingDescriptors_Handle;

	private static readonly IntPtr class_ptr;

	private static object __mt_SharedStorage_var_static;

	private object __mt_Cookies_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSHttpCookieStorage SharedStorage
	{
		[Export("sharedHTTPCookieStorage")]
		get
		{
			return (NSHttpCookieStorage)(__mt_SharedStorage_var_static = (NSHttpCookieStorage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedHTTPCookieStorageHandle)));
		}
	}

	public virtual NSHttpCookie[] Cookies
	{
		[Export("cookies")]
		get
		{
			return (NSHttpCookie[])(__mt_Cookies_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSHttpCookie>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCookiesHandle)) : NSArray.ArrayFromHandle<NSHttpCookie>(Messaging.IntPtr_objc_msgSend(base.Handle, selCookiesHandle))));
		}
	}

	public virtual NSHttpCookieAcceptPolicy AcceptPolicy
	{
		[Export("cookieAcceptPolicy")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSHttpCookieAcceptPolicy)Messaging.UInt64_objc_msgSend(base.Handle, selCookieAcceptPolicyHandle);
			}
			return (NSHttpCookieAcceptPolicy)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCookieAcceptPolicyHandle);
		}
		[Export("setCookieAcceptPolicy:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetCookieAcceptPolicy_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetCookieAcceptPolicy_Handle, (ulong)value);
			}
		}
	}

	static NSHttpCookieStorage()
	{
		selSharedHTTPCookieStorageHandle = Selector.GetHandle("sharedHTTPCookieStorage");
		selCookiesHandle = Selector.GetHandle("cookies");
		selCookieAcceptPolicyHandle = Selector.GetHandle("cookieAcceptPolicy");
		selSetCookieAcceptPolicy_Handle = Selector.GetHandle("setCookieAcceptPolicy:");
		selSetCookie_Handle = Selector.GetHandle("setCookie:");
		selDeleteCookie_Handle = Selector.GetHandle("deleteCookie:");
		selCookiesForURL_Handle = Selector.GetHandle("cookiesForURL:");
		selSetCookiesForURLMainDocumentURL_Handle = Selector.GetHandle("setCookies:forURL:mainDocumentURL:");
		selSortedCookiesUsingDescriptors_Handle = Selector.GetHandle("sortedCookiesUsingDescriptors:");
		class_ptr = Class.GetHandle("NSHTTPCookieStorage");
		IntPtr intPtr = Libraries.Foundation.Handle;
		if (!(intPtr == IntPtr.Zero))
		{
			CookiesChangedNotification = Dlfcn.GetStringConstant(intPtr, "NSHTTPCookieManagerAcceptPolicyChangedNotification");
			AcceptPolicyChangedNotification = Dlfcn.GetStringConstant(intPtr, "NSHTTPCookieManagerCookiesChangedNotification");
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSHttpCookieStorage(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSHttpCookieStorage(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSHttpCookieStorage(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setCookie:")]
	public virtual void SetCookie(NSHttpCookie cookie)
	{
		if (cookie == null)
		{
			throw new ArgumentNullException("cookie");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCookie_Handle, cookie.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCookie_Handle, cookie.Handle);
		}
	}

	[Export("deleteCookie:")]
	public virtual void DeleteCookie(NSHttpCookie cookie)
	{
		if (cookie == null)
		{
			throw new ArgumentNullException("cookie");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeleteCookie_Handle, cookie.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeleteCookie_Handle, cookie.Handle);
		}
	}

	[Export("cookiesForURL:")]
	public virtual NSHttpCookie[] CookiesForUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSHttpCookie>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCookiesForURL_Handle, url.Handle));
		}
		return NSArray.ArrayFromHandle<NSHttpCookie>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCookiesForURL_Handle, url.Handle));
	}

	[Export("setCookies:forURL:mainDocumentURL:")]
	public virtual void SetCookies(NSHttpCookie[] cookies, NSUrl forUrl, NSUrl mainDocumentUrl)
	{
		if (cookies == null)
		{
			throw new ArgumentNullException("cookies");
		}
		if (forUrl == null)
		{
			throw new ArgumentNullException("forUrl");
		}
		if (mainDocumentUrl == null)
		{
			throw new ArgumentNullException("mainDocumentUrl");
		}
		NSArray nSArray = NSArray.FromNSObjects(cookies);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSetCookiesForURLMainDocumentURL_Handle, nSArray.Handle, forUrl.Handle, mainDocumentUrl.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSetCookiesForURLMainDocumentURL_Handle, nSArray.Handle, forUrl.Handle, mainDocumentUrl.Handle);
		}
		nSArray.Dispose();
	}

	[Export("sortedCookiesUsingDescriptors:")]
	public virtual NSHttpCookie[] GetSortedCookies(NSSortDescriptor[] sortDescriptors)
	{
		if (sortDescriptors == null)
		{
			throw new ArgumentNullException("sortDescriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(sortDescriptors);
		NSHttpCookie[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSHttpCookie>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSortedCookiesUsingDescriptors_Handle, nSArray.Handle)) : NSArray.ArrayFromHandle<NSHttpCookie>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSortedCookiesUsingDescriptors_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Cookies_var = null;
		}
	}
}
