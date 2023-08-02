using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSHTTPCookie", true)]
public class NSHttpCookie : NSObject
{
	public static NSString KeyName;

	public static NSString KeyValue;

	public static NSString KeyOriginURL;

	public static NSString KeyVersion;

	public static NSString KeyDomain;

	public static NSString KeyPath;

	public static NSString KeySecure;

	public static NSString KeyExpires;

	public static NSString KeyComment;

	public static NSString KeyCommentURL;

	public static NSString KeyDiscard;

	public static NSString KeyMaximumAge;

	public static NSString KeyPort;

	private static readonly IntPtr selPropertiesHandle;

	private static readonly IntPtr selVersionHandle;

	private static readonly IntPtr selValueHandle;

	private static readonly IntPtr selExpiresDateHandle;

	private static readonly IntPtr selIsSessionOnlyHandle;

	private static readonly IntPtr selDomainHandle;

	private static readonly IntPtr selNameHandle;

	private static readonly IntPtr selPathHandle;

	private static readonly IntPtr selIsSecureHandle;

	private static readonly IntPtr selIsHTTPOnlyHandle;

	private static readonly IntPtr selCommentHandle;

	private static readonly IntPtr selCommentURLHandle;

	private static readonly IntPtr selPortListHandle;

	private static readonly IntPtr selInitWithProperties_Handle;

	private static readonly IntPtr selCookieWithProperties_Handle;

	private static readonly IntPtr selRequestHeaderFieldsWithCookies_Handle;

	private static readonly IntPtr selCookiesWithResponseHeaderFieldsForURL_Handle;

	private static readonly IntPtr class_ptr;

	private object __mt_Properties_var;

	private object __mt_ExpiresDate_var;

	private object __mt_CommentUrl_var;

	private object __mt_PortList_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSDictionary Properties
	{
		[Export("properties")]
		get
		{
			return (NSDictionary)(__mt_Properties_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPropertiesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPropertiesHandle)))));
		}
	}

	public virtual ulong Version
	{
		[Export("version")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selVersionHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selVersionHandle);
		}
	}

	public virtual string Value
	{
		[Export("value")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueHandle));
		}
	}

	public virtual NSDate ExpiresDate
	{
		[Export("expiresDate")]
		get
		{
			return (NSDate)(__mt_ExpiresDate_var = ((!IsDirectBinding) ? ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExpiresDateHandle))) : ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selExpiresDateHandle)))));
		}
	}

	public virtual bool IsSessionOnly
	{
		[Export("isSessionOnly")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSessionOnlyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSessionOnlyHandle);
		}
	}

	public virtual string Domain
	{
		[Export("domain")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDomainHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDomainHandle));
		}
	}

	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	public virtual string Path
	{
		[Export("path")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathHandle));
		}
	}

	public virtual bool IsSecure
	{
		[Export("isSecure")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSecureHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSecureHandle);
		}
	}

	public virtual bool IsHttpOnly
	{
		[Export("isHTTPOnly")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHTTPOnlyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHTTPOnlyHandle);
		}
	}

	public virtual string Comment
	{
		[Export("comment")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCommentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCommentHandle));
		}
	}

	public virtual NSUrl CommentUrl
	{
		[Export("commentURL")]
		get
		{
			return (NSUrl)(__mt_CommentUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCommentURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCommentURLHandle)))));
		}
	}

	public virtual NSNumber[] PortList
	{
		[Export("portList")]
		get
		{
			return (NSNumber[])(__mt_PortList_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPortListHandle)) : NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selPortListHandle))));
		}
	}

	static NSHttpCookie()
	{
		selPropertiesHandle = Selector.GetHandle("properties");
		selVersionHandle = Selector.GetHandle("version");
		selValueHandle = Selector.GetHandle("value");
		selExpiresDateHandle = Selector.GetHandle("expiresDate");
		selIsSessionOnlyHandle = Selector.GetHandle("isSessionOnly");
		selDomainHandle = Selector.GetHandle("domain");
		selNameHandle = Selector.GetHandle("name");
		selPathHandle = Selector.GetHandle("path");
		selIsSecureHandle = Selector.GetHandle("isSecure");
		selIsHTTPOnlyHandle = Selector.GetHandle("isHTTPOnly");
		selCommentHandle = Selector.GetHandle("comment");
		selCommentURLHandle = Selector.GetHandle("commentURL");
		selPortListHandle = Selector.GetHandle("portList");
		selInitWithProperties_Handle = Selector.GetHandle("initWithProperties:");
		selCookieWithProperties_Handle = Selector.GetHandle("cookieWithProperties:");
		selRequestHeaderFieldsWithCookies_Handle = Selector.GetHandle("requestHeaderFieldsWithCookies:");
		selCookiesWithResponseHeaderFieldsForURL_Handle = Selector.GetHandle("cookiesWithResponseHeaderFields:forURL:");
		class_ptr = Class.GetHandle("NSHTTPCookie");
		IntPtr intPtr = Libraries.Foundation.Handle;
		if (!(intPtr == IntPtr.Zero))
		{
			KeyName = Dlfcn.GetStringConstant(intPtr, "NSHTTPCookieName");
			KeyValue = Dlfcn.GetStringConstant(intPtr, "NSHTTPCookieValue");
			KeyOriginURL = Dlfcn.GetStringConstant(intPtr, "NSHTTPCookieOriginURL");
			KeyVersion = Dlfcn.GetStringConstant(intPtr, "NSHTTPCookieVersion");
			KeyDomain = Dlfcn.GetStringConstant(intPtr, "NSHTTPCookieDomain");
			KeyPath = Dlfcn.GetStringConstant(intPtr, "NSHTTPCookiePath");
			KeySecure = Dlfcn.GetStringConstant(intPtr, "NSHTTPCookieSecure");
			KeyExpires = Dlfcn.GetStringConstant(intPtr, "NSHTTPCookieExpires");
			KeyComment = Dlfcn.GetStringConstant(intPtr, "NSHTTPCookieComment");
			KeyCommentURL = Dlfcn.GetStringConstant(intPtr, "NSHTTPCookieCommentURL");
			KeyDiscard = Dlfcn.GetStringConstant(intPtr, "NSHTTPCookieDiscard");
			KeyMaximumAge = Dlfcn.GetStringConstant(intPtr, "NSHTTPCookieMaximumAge");
			KeyPort = Dlfcn.GetStringConstant(intPtr, "NSHTTPCookiePort");
		}
	}

	public NSHttpCookie(string name, string value)
		: this(name, value, null, null)
	{
		CreateCookie(name, value, null, null, null, null, null, null, null, null, null, null);
	}

	public NSHttpCookie(string name, string value, string path)
		: this(name, value, path, null)
	{
		CreateCookie(name, value, path, null, null, null, null, null, null, null, null, null);
	}

	public NSHttpCookie(string name, string value, string path, string domain)
	{
		CreateCookie(name, value, path, domain, null, null, null, null, null, null, null, null);
	}

	private void CreateCookie(string name, string value, string path, string domain, string comment, string commentUrl, bool? discard, DateTime? expires, int? maximumAge, string ports, bool? secure, int? version)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (string.IsNullOrEmpty(path))
		{
			path = "/";
		}
		if (string.IsNullOrEmpty(domain))
		{
			domain = "*";
		}
		using NSMutableDictionary nSMutableDictionary = new NSMutableDictionary();
		nSMutableDictionary.Add(KeyName, new NSString(name));
		nSMutableDictionary.Add(KeyValue, new NSString(value));
		nSMutableDictionary.Add(KeyPath, new NSString(path));
		nSMutableDictionary.Add(KeyDomain, new NSString(domain));
		if (!string.IsNullOrEmpty(comment))
		{
			nSMutableDictionary.Add(KeyComment, new NSString(comment));
		}
		if (!string.IsNullOrEmpty(commentUrl))
		{
			nSMutableDictionary.Add(KeyCommentURL, new NSString(commentUrl));
		}
		if (discard.HasValue)
		{
			nSMutableDictionary.Add(KeyDiscard, new NSString(discard.Value ? "TRUE" : "FALSE"));
		}
		if (expires.HasValue && expires.Value != DateTime.MinValue)
		{
			nSMutableDictionary.Add(KeyExpires, (NSDate)expires.Value);
		}
		if (maximumAge.HasValue)
		{
			nSMutableDictionary.Add(KeyMaximumAge, new NSString(maximumAge.Value.ToString()));
		}
		if (!string.IsNullOrEmpty(ports))
		{
			nSMutableDictionary.Add(KeyPort, new NSString(ports.Replace("\"", string.Empty)));
		}
		if (secure.HasValue && secure.Value)
		{
			nSMutableDictionary.Add(KeySecure, new NSString("1"));
		}
		if (version.HasValue)
		{
			nSMutableDictionary.Add(KeyVersion, new NSString(version.Value.ToString()));
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithProperties_Handle, nSMutableDictionary.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithProperties_Handle, nSMutableDictionary.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSHttpCookie(NSCoder coder)
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
	public NSHttpCookie(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSHttpCookie(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithProperties:")]
	public NSHttpCookie(NSDictionary properties)
		: base(NSObjectFlag.Empty)
	{
		if (properties == null)
		{
			throw new ArgumentNullException("properties");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithProperties_Handle, properties.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithProperties_Handle, properties.Handle);
		}
	}

	[Export("cookieWithProperties:")]
	public static NSHttpCookie CookieFromProperties(NSDictionary properties)
	{
		if (properties == null)
		{
			throw new ArgumentNullException("properties");
		}
		return (NSHttpCookie)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCookieWithProperties_Handle, properties.Handle));
	}

	[Export("requestHeaderFieldsWithCookies:")]
	public static NSDictionary RequestHeaderFieldsWithCookies(NSHttpCookie[] cookies)
	{
		if (cookies == null)
		{
			throw new ArgumentNullException("cookies");
		}
		NSArray nSArray = NSArray.FromNSObjects(cookies);
		NSDictionary result = (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selRequestHeaderFieldsWithCookies_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("cookiesWithResponseHeaderFields:forURL:")]
	public static NSHttpCookie[] CookiesWithResponseHeaderFields(NSDictionary headerFields, NSUrl url)
	{
		if (headerFields == null)
		{
			throw new ArgumentNullException("headerFields");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return NSArray.ArrayFromHandle<NSHttpCookie>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selCookiesWithResponseHeaderFieldsForURL_Handle, headerFields.Handle, url.Handle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Properties_var = null;
			__mt_ExpiresDate_var = null;
			__mt_CommentUrl_var = null;
			__mt_PortList_var = null;
		}
	}
}
