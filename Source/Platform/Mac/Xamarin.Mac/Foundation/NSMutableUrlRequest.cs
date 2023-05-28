using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMutableURLRequest", true)]
public class NSMutableUrlRequest : NSUrlRequest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHTTPBody = "HTTPBody";

	private static readonly IntPtr selHTTPBodyHandle = Selector.GetHandle("HTTPBody");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHTTPBodyStream = "HTTPBodyStream";

	private static readonly IntPtr selHTTPBodyStreamHandle = Selector.GetHandle("HTTPBodyStream");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHTTPMethod = "HTTPMethod";

	private static readonly IntPtr selHTTPMethodHandle = Selector.GetHandle("HTTPMethod");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHTTPShouldHandleCookies = "HTTPShouldHandleCookies";

	private static readonly IntPtr selHTTPShouldHandleCookiesHandle = Selector.GetHandle("HTTPShouldHandleCookies");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURL = "URL";

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllHTTPHeaderFields = "allHTTPHeaderFields";

	private static readonly IntPtr selAllHTTPHeaderFieldsHandle = Selector.GetHandle("allHTTPHeaderFields");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsCellularAccess = "allowsCellularAccess";

	private static readonly IntPtr selAllowsCellularAccessHandle = Selector.GetHandle("allowsCellularAccess");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsConstrainedNetworkAccess = "allowsConstrainedNetworkAccess";

	private static readonly IntPtr selAllowsConstrainedNetworkAccessHandle = Selector.GetHandle("allowsConstrainedNetworkAccess");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsExpensiveNetworkAccess = "allowsExpensiveNetworkAccess";

	private static readonly IntPtr selAllowsExpensiveNetworkAccessHandle = Selector.GetHandle("allowsExpensiveNetworkAccess");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCachePolicy = "cachePolicy";

	private static readonly IntPtr selCachePolicyHandle = Selector.GetHandle("cachePolicy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_ = "initWithURL:";

	private static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle("initWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_CachePolicy_TimeoutInterval_ = "initWithURL:cachePolicy:timeoutInterval:";

	private static readonly IntPtr selInitWithURL_CachePolicy_TimeoutInterval_Handle = Selector.GetHandle("initWithURL:cachePolicy:timeoutInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMainDocumentURL = "mainDocumentURL";

	private static readonly IntPtr selMainDocumentURLHandle = Selector.GetHandle("mainDocumentURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNetworkServiceType = "networkServiceType";

	private static readonly IntPtr selNetworkServiceTypeHandle = Selector.GetHandle("networkServiceType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllHTTPHeaderFields_ = "setAllHTTPHeaderFields:";

	private static readonly IntPtr selSetAllHTTPHeaderFields_Handle = Selector.GetHandle("setAllHTTPHeaderFields:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsCellularAccess_ = "setAllowsCellularAccess:";

	private static readonly IntPtr selSetAllowsCellularAccess_Handle = Selector.GetHandle("setAllowsCellularAccess:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsConstrainedNetworkAccess_ = "setAllowsConstrainedNetworkAccess:";

	private static readonly IntPtr selSetAllowsConstrainedNetworkAccess_Handle = Selector.GetHandle("setAllowsConstrainedNetworkAccess:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsExpensiveNetworkAccess_ = "setAllowsExpensiveNetworkAccess:";

	private static readonly IntPtr selSetAllowsExpensiveNetworkAccess_Handle = Selector.GetHandle("setAllowsExpensiveNetworkAccess:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCachePolicy_ = "setCachePolicy:";

	private static readonly IntPtr selSetCachePolicy_Handle = Selector.GetHandle("setCachePolicy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHTTPBody_ = "setHTTPBody:";

	private static readonly IntPtr selSetHTTPBody_Handle = Selector.GetHandle("setHTTPBody:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHTTPBodyStream_ = "setHTTPBodyStream:";

	private static readonly IntPtr selSetHTTPBodyStream_Handle = Selector.GetHandle("setHTTPBodyStream:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHTTPMethod_ = "setHTTPMethod:";

	private static readonly IntPtr selSetHTTPMethod_Handle = Selector.GetHandle("setHTTPMethod:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHTTPShouldHandleCookies_ = "setHTTPShouldHandleCookies:";

	private static readonly IntPtr selSetHTTPShouldHandleCookies_Handle = Selector.GetHandle("setHTTPShouldHandleCookies:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMainDocumentURL_ = "setMainDocumentURL:";

	private static readonly IntPtr selSetMainDocumentURL_Handle = Selector.GetHandle("setMainDocumentURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNetworkServiceType_ = "setNetworkServiceType:";

	private static readonly IntPtr selSetNetworkServiceType_Handle = Selector.GetHandle("setNetworkServiceType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeoutInterval_ = "setTimeoutInterval:";

	private static readonly IntPtr selSetTimeoutInterval_Handle = Selector.GetHandle("setTimeoutInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetURL_ = "setURL:";

	private static readonly IntPtr selSetURL_Handle = Selector.GetHandle("setURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ForHTTPHeaderField_ = "setValue:forHTTPHeaderField:";

	private static readonly IntPtr selSetValue_ForHTTPHeaderField_Handle = Selector.GetHandle("setValue:forHTTPHeaderField:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeoutInterval = "timeoutInterval";

	private static readonly IntPtr selTimeoutIntervalHandle = Selector.GetHandle("timeoutInterval");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMutableURLRequest");

	public new string this[string key]
	{
		get
		{
			return Header(key);
		}
		set
		{
			_SetValue(value, key);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool AllowsCellularAccess
	{
		[Export("allowsCellularAccess")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsCellularAccessHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsCellularAccessHandle);
		}
		[Export("setAllowsCellularAccess:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsCellularAccess_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsCellularAccess_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public new virtual bool AllowsConstrainedNetworkAccess
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("allowsConstrainedNetworkAccess")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsConstrainedNetworkAccessHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsConstrainedNetworkAccessHandle);
		}
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setAllowsConstrainedNetworkAccess:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsConstrainedNetworkAccess_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsConstrainedNetworkAccess_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public new virtual bool AllowsExpensiveNetworkAccess
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("allowsExpensiveNetworkAccess")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsExpensiveNetworkAccessHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsExpensiveNetworkAccessHandle);
		}
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setAllowsExpensiveNetworkAccess:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsExpensiveNetworkAccess_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsExpensiveNetworkAccess_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSData? Body
	{
		[Export("HTTPBody")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selHTTPBodyHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHTTPBodyHandle));
		}
		[Export("setHTTPBody:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHTTPBody_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHTTPBody_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSInputStream? BodyStream
	{
		[Export("HTTPBodyStream")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSInputStream>(Messaging.IntPtr_objc_msgSend(base.Handle, selHTTPBodyStreamHandle));
			}
			return Runtime.GetNSObject<NSInputStream>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHTTPBodyStreamHandle));
		}
		[Export("setHTTPBodyStream:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHTTPBodyStream_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHTTPBodyStream_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSUrlRequestCachePolicy CachePolicy
	{
		[Export("cachePolicy")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSUrlRequestCachePolicy)Messaging.UInt64_objc_msgSend(base.Handle, selCachePolicyHandle);
			}
			return (NSUrlRequestCachePolicy)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCachePolicyHandle);
		}
		[Export("setCachePolicy:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetCachePolicy_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetCachePolicy_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSDictionary? Headers
	{
		[Export("allHTTPHeaderFields")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selAllHTTPHeaderFieldsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllHTTPHeaderFieldsHandle));
		}
		[Export("setAllHTTPHeaderFields:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAllHTTPHeaderFields_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAllHTTPHeaderFields_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string HttpMethod
	{
		[Export("HTTPMethod")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selHTTPMethodHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHTTPMethodHandle));
		}
		[Export("setHTTPMethod:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHTTPMethod_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHTTPMethod_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSUrl? MainDocumentURL
	{
		[Export("mainDocumentURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selMainDocumentURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMainDocumentURLHandle));
		}
		[Export("setMainDocumentURL:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMainDocumentURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMainDocumentURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSUrlRequestNetworkServiceType NetworkServiceType
	{
		[Export("networkServiceType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSUrlRequestNetworkServiceType)Messaging.UInt64_objc_msgSend(base.Handle, selNetworkServiceTypeHandle);
			}
			return (NSUrlRequestNetworkServiceType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selNetworkServiceTypeHandle);
		}
		[Export("setNetworkServiceType:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetNetworkServiceType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetNetworkServiceType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool ShouldHandleCookies
	{
		[Export("HTTPShouldHandleCookies")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHTTPShouldHandleCookiesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHTTPShouldHandleCookiesHandle);
		}
		[Export("setHTTPShouldHandleCookies:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHTTPShouldHandleCookies_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHTTPShouldHandleCookies_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual double TimeoutInterval
	{
		[Export("timeoutInterval")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimeoutIntervalHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeoutIntervalHandle);
		}
		[Export("setTimeoutInterval:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetTimeoutInterval_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetTimeoutInterval_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSUrl? Url
	{
		[Export("URL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle));
		}
		[Export("setURL:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMutableUrlRequest()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSMutableUrlRequest(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSMutableUrlRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMutableUrlRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMutableUrlRequest(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithURL_Handle, url.Handle), "initWithURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithURL_Handle, url.Handle), "initWithURL:");
		}
	}

	[Export("initWithURL:cachePolicy:timeoutInterval:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMutableUrlRequest(NSUrl url, NSUrlRequestCachePolicy cachePolicy, double timeoutInterval)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_Double(base.Handle, selInitWithURL_CachePolicy_TimeoutInterval_Handle, url.Handle, (ulong)cachePolicy, timeoutInterval), "initWithURL:cachePolicy:timeoutInterval:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_Double(base.SuperHandle, selInitWithURL_CachePolicy_TimeoutInterval_Handle, url.Handle, (ulong)cachePolicy, timeoutInterval), "initWithURL:cachePolicy:timeoutInterval:");
		}
	}

	[Export("setValue:forHTTPHeaderField:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetValue(string value, string field)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (field == null)
		{
			throw new ArgumentNullException("field");
		}
		IntPtr arg = NSString.CreateNative(value);
		IntPtr arg2 = NSString.CreateNative(field);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetValue_ForHTTPHeaderField_Handle, arg, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetValue_ForHTTPHeaderField_Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}
}
