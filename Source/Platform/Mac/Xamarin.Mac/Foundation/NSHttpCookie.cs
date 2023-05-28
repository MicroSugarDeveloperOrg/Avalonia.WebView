using System.ComponentModel;
using System.Net;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSHTTPCookie", true)]
public class NSHttpCookie : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComment = "comment";

	private static readonly IntPtr selCommentHandle = Selector.GetHandle("comment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommentURL = "commentURL";

	private static readonly IntPtr selCommentURLHandle = Selector.GetHandle("commentURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCookieWithProperties_ = "cookieWithProperties:";

	private static readonly IntPtr selCookieWithProperties_Handle = Selector.GetHandle("cookieWithProperties:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCookiesWithResponseHeaderFields_ForURL_ = "cookiesWithResponseHeaderFields:forURL:";

	private static readonly IntPtr selCookiesWithResponseHeaderFields_ForURL_Handle = Selector.GetHandle("cookiesWithResponseHeaderFields:forURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDomain = "domain";

	private static readonly IntPtr selDomainHandle = Selector.GetHandle("domain");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpiresDate = "expiresDate";

	private static readonly IntPtr selExpiresDateHandle = Selector.GetHandle("expiresDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithProperties_ = "initWithProperties:";

	private static readonly IntPtr selInitWithProperties_Handle = Selector.GetHandle("initWithProperties:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHTTPOnly = "isHTTPOnly";

	private static readonly IntPtr selIsHTTPOnlyHandle = Selector.GetHandle("isHTTPOnly");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSecure = "isSecure";

	private static readonly IntPtr selIsSecureHandle = Selector.GetHandle("isSecure");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSessionOnly = "isSessionOnly";

	private static readonly IntPtr selIsSessionOnlyHandle = Selector.GetHandle("isSessionOnly");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPath = "path";

	private static readonly IntPtr selPathHandle = Selector.GetHandle("path");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPortList = "portList";

	private static readonly IntPtr selPortListHandle = Selector.GetHandle("portList");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProperties = "properties";

	private static readonly IntPtr selPropertiesHandle = Selector.GetHandle("properties");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestHeaderFieldsWithCookies_ = "requestHeaderFieldsWithCookies:";

	private static readonly IntPtr selRequestHeaderFieldsWithCookies_Handle = Selector.GetHandle("requestHeaderFieldsWithCookies:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSameSitePolicy = "sameSitePolicy";

	private static readonly IntPtr selSameSitePolicyHandle = Selector.GetHandle("sameSitePolicy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValue = "value";

	private static readonly IntPtr selValueHandle = Selector.GetHandle("value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVersion = "version";

	private static readonly IntPtr selVersionHandle = Selector.GetHandle("version");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSHTTPCookie");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyComment;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyCommentUrl;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyDiscard;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyDomain;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyExpires;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyMaximumAge;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyOriginUrl;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyPath;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyPort;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeySameSiteLax;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeySameSitePolicy;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeySameSiteStrict;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeySecure;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyValue;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyVersion;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Comment
	{
		[Export("comment")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCommentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCommentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl CommentUrl
	{
		[Export("commentURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selCommentURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCommentURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Domain
	{
		[Export("domain")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDomainHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDomainHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate ExpiresDate
	{
		[Export("expiresDate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selExpiresDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExpiresDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsHttpOnly
	{
		[Export("isHTTPOnly")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHTTPOnlyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHTTPOnlyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsSecure
	{
		[Export("isSecure")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSecureHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSecureHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsSessionOnly
	{
		[Export("isSessionOnly")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSessionOnlyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSessionOnlyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Path
	{
		[Export("path")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[] PortList
	{
		[Export("portList")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selPortListHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPortListHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary Properties
	{
		[Export("properties")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selPropertiesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPropertiesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual NSString? SameSitePolicy
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("sameSitePolicy")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selSameSitePolicyHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSameSitePolicyHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Value
	{
		[Export("value")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Version
	{
		[Export("version")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selVersionHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selVersionHandle);
		}
	}

	[Field("NSHTTPCookieComment", "Foundation")]
	public static NSString KeyComment
	{
		get
		{
			if (_KeyComment == null)
			{
				_KeyComment = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSHTTPCookieComment");
			}
			return _KeyComment;
		}
	}

	[Field("NSHTTPCookieCommentURL", "Foundation")]
	public static NSString KeyCommentUrl
	{
		get
		{
			if (_KeyCommentUrl == null)
			{
				_KeyCommentUrl = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSHTTPCookieCommentURL");
			}
			return _KeyCommentUrl;
		}
	}

	[Field("NSHTTPCookieDiscard", "Foundation")]
	public static NSString KeyDiscard
	{
		get
		{
			if (_KeyDiscard == null)
			{
				_KeyDiscard = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSHTTPCookieDiscard");
			}
			return _KeyDiscard;
		}
	}

	[Field("NSHTTPCookieDomain", "Foundation")]
	public static NSString KeyDomain
	{
		get
		{
			if (_KeyDomain == null)
			{
				_KeyDomain = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSHTTPCookieDomain");
			}
			return _KeyDomain;
		}
	}

	[Field("NSHTTPCookieExpires", "Foundation")]
	public static NSString KeyExpires
	{
		get
		{
			if (_KeyExpires == null)
			{
				_KeyExpires = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSHTTPCookieExpires");
			}
			return _KeyExpires;
		}
	}

	[Field("NSHTTPCookieMaximumAge", "Foundation")]
	public static NSString KeyMaximumAge
	{
		get
		{
			if (_KeyMaximumAge == null)
			{
				_KeyMaximumAge = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSHTTPCookieMaximumAge");
			}
			return _KeyMaximumAge;
		}
	}

	[Field("NSHTTPCookieName", "Foundation")]
	public static NSString KeyName
	{
		get
		{
			if (_KeyName == null)
			{
				_KeyName = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSHTTPCookieName");
			}
			return _KeyName;
		}
	}

	[Field("NSHTTPCookieOriginURL", "Foundation")]
	public static NSString KeyOriginUrl
	{
		get
		{
			if (_KeyOriginUrl == null)
			{
				_KeyOriginUrl = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSHTTPCookieOriginURL");
			}
			return _KeyOriginUrl;
		}
	}

	[Field("NSHTTPCookiePath", "Foundation")]
	public static NSString KeyPath
	{
		get
		{
			if (_KeyPath == null)
			{
				_KeyPath = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSHTTPCookiePath");
			}
			return _KeyPath;
		}
	}

	[Field("NSHTTPCookiePort", "Foundation")]
	public static NSString KeyPort
	{
		get
		{
			if (_KeyPort == null)
			{
				_KeyPort = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSHTTPCookiePort");
			}
			return _KeyPort;
		}
	}

	[Field("NSHTTPCookieSameSiteLax", "Foundation")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString KeySameSiteLax
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_KeySameSiteLax == null)
			{
				_KeySameSiteLax = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSHTTPCookieSameSiteLax");
			}
			return _KeySameSiteLax;
		}
	}

	[Field("NSHTTPCookieSameSitePolicy", "Foundation")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString KeySameSitePolicy
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_KeySameSitePolicy == null)
			{
				_KeySameSitePolicy = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSHTTPCookieSameSitePolicy");
			}
			return _KeySameSitePolicy;
		}
	}

	[Field("NSHTTPCookieSameSiteStrict", "Foundation")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString KeySameSiteStrict
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_KeySameSiteStrict == null)
			{
				_KeySameSiteStrict = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSHTTPCookieSameSiteStrict");
			}
			return _KeySameSiteStrict;
		}
	}

	[Field("NSHTTPCookieSecure", "Foundation")]
	public static NSString KeySecure
	{
		get
		{
			if (_KeySecure == null)
			{
				_KeySecure = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSHTTPCookieSecure");
			}
			return _KeySecure;
		}
	}

	[Field("NSHTTPCookieValue", "Foundation")]
	public static NSString KeyValue
	{
		get
		{
			if (_KeyValue == null)
			{
				_KeyValue = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSHTTPCookieValue");
			}
			return _KeyValue;
		}
	}

	[Field("NSHTTPCookieVersion", "Foundation")]
	public static NSString KeyVersion
	{
		get
		{
			if (_KeyVersion == null)
			{
				_KeyVersion = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSHTTPCookieVersion");
			}
			return _KeyVersion;
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

	public NSHttpCookie(Cookie cookie)
	{
		if (cookie == null)
		{
			throw new ArgumentNullException("cookie");
		}
		string commentUrl = ((cookie.CommentUri != null) ? cookie.CommentUri.ToString() : null);
		bool? discard = null;
		if (cookie.Discard)
		{
			discard = true;
		}
		CreateCookie(cookie.Name, cookie.Value, cookie.Path, cookie.Domain, cookie.Comment, commentUrl, discard, cookie.Expires, null, cookie.Port, cookie.Secure, cookie.Version);
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
			nSMutableDictionary.Add(KeyCommentUrl, new NSString(commentUrl));
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
		if (base.IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithProperties:"), nSMutableDictionary.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithProperties:"), nSMutableDictionary.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSHttpCookie(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSHttpCookie(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithProperties:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSHttpCookie(NSDictionary properties)
		: base(NSObjectFlag.Empty)
	{
		if (properties == null)
		{
			throw new ArgumentNullException("properties");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithProperties_Handle, properties.Handle), "initWithProperties:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithProperties_Handle, properties.Handle), "initWithProperties:");
		}
	}

	[Export("cookieWithProperties:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSHttpCookie CookieFromProperties(NSDictionary properties)
	{
		if (properties == null)
		{
			throw new ArgumentNullException("properties");
		}
		return Runtime.GetNSObject<NSHttpCookie>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCookieWithProperties_Handle, properties.Handle));
	}

	[Export("cookiesWithResponseHeaderFields:forURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		return NSArray.ArrayFromHandle<NSHttpCookie>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selCookiesWithResponseHeaderFields_ForURL_Handle, headerFields.Handle, url.Handle));
	}

	[Export("requestHeaderFieldsWithCookies:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDictionary RequestHeaderFieldsWithCookies(NSHttpCookie[] cookies)
	{
		if (cookies == null)
		{
			throw new ArgumentNullException("cookies");
		}
		NSArray nSArray = NSArray.FromNSObjects(cookies);
		NSDictionary nSObject = Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selRequestHeaderFieldsWithCookies_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}
}
