using System.ComponentModel;
using ObjCRuntime;
using Security;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSURLSessionConfiguration", true)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class NSUrlSessionConfiguration : NSObject, INSCopying, INativeObject, IDisposable
{
	public enum SessionConfigurationType
	{
		Default,
		Background,
		Ephemeral
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHTTPAdditionalHeaders = "HTTPAdditionalHeaders";

	private static readonly IntPtr selHTTPAdditionalHeadersHandle = Selector.GetHandle("HTTPAdditionalHeaders");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHTTPCookieAcceptPolicy = "HTTPCookieAcceptPolicy";

	private static readonly IntPtr selHTTPCookieAcceptPolicyHandle = Selector.GetHandle("HTTPCookieAcceptPolicy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHTTPCookieStorage = "HTTPCookieStorage";

	private static readonly IntPtr selHTTPCookieStorageHandle = Selector.GetHandle("HTTPCookieStorage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHTTPMaximumConnectionsPerHost = "HTTPMaximumConnectionsPerHost";

	private static readonly IntPtr selHTTPMaximumConnectionsPerHostHandle = Selector.GetHandle("HTTPMaximumConnectionsPerHost");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHTTPShouldSetCookies = "HTTPShouldSetCookies";

	private static readonly IntPtr selHTTPShouldSetCookiesHandle = Selector.GetHandle("HTTPShouldSetCookies");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHTTPShouldUsePipelining = "HTTPShouldUsePipelining";

	private static readonly IntPtr selHTTPShouldUsePipeliningHandle = Selector.GetHandle("HTTPShouldUsePipelining");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTLSMaximumSupportedProtocol = "TLSMaximumSupportedProtocol";

	private static readonly IntPtr selTLSMaximumSupportedProtocolHandle = Selector.GetHandle("TLSMaximumSupportedProtocol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTLSMaximumSupportedProtocolVersion = "TLSMaximumSupportedProtocolVersion";

	private static readonly IntPtr selTLSMaximumSupportedProtocolVersionHandle = Selector.GetHandle("TLSMaximumSupportedProtocolVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTLSMinimumSupportedProtocol = "TLSMinimumSupportedProtocol";

	private static readonly IntPtr selTLSMinimumSupportedProtocolHandle = Selector.GetHandle("TLSMinimumSupportedProtocol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTLSMinimumSupportedProtocolVersion = "TLSMinimumSupportedProtocolVersion";

	private static readonly IntPtr selTLSMinimumSupportedProtocolVersionHandle = Selector.GetHandle("TLSMinimumSupportedProtocolVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLCache = "URLCache";

	private static readonly IntPtr selURLCacheHandle = Selector.GetHandle("URLCache");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLCredentialStorage = "URLCredentialStorage";

	private static readonly IntPtr selURLCredentialStorageHandle = Selector.GetHandle("URLCredentialStorage");

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
	private const string selBackgroundSessionConfiguration_ = "backgroundSessionConfiguration:";

	private static readonly IntPtr selBackgroundSessionConfiguration_Handle = Selector.GetHandle("backgroundSessionConfiguration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundSessionConfigurationWithIdentifier_ = "backgroundSessionConfigurationWithIdentifier:";

	private static readonly IntPtr selBackgroundSessionConfigurationWithIdentifier_Handle = Selector.GetHandle("backgroundSessionConfigurationWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectionProxyDictionary = "connectionProxyDictionary";

	private static readonly IntPtr selConnectionProxyDictionaryHandle = Selector.GetHandle("connectionProxyDictionary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultSessionConfiguration = "defaultSessionConfiguration";

	private static readonly IntPtr selDefaultSessionConfigurationHandle = Selector.GetHandle("defaultSessionConfiguration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEphemeralSessionConfiguration = "ephemeralSessionConfiguration";

	private static readonly IntPtr selEphemeralSessionConfigurationHandle = Selector.GetHandle("ephemeralSessionConfiguration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDiscretionary = "isDiscretionary";

	private static readonly IntPtr selIsDiscretionaryHandle = Selector.GetHandle("isDiscretionary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNetworkServiceType = "networkServiceType";

	private static readonly IntPtr selNetworkServiceTypeHandle = Selector.GetHandle("networkServiceType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProtocolClasses = "protocolClasses";

	private static readonly IntPtr selProtocolClassesHandle = Selector.GetHandle("protocolClasses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestCachePolicy = "requestCachePolicy";

	private static readonly IntPtr selRequestCachePolicyHandle = Selector.GetHandle("requestCachePolicy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSessionSendsLaunchEvents = "sessionSendsLaunchEvents";

	private static readonly IntPtr selSessionSendsLaunchEventsHandle = Selector.GetHandle("sessionSendsLaunchEvents");

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
	private const string selSetConnectionProxyDictionary_ = "setConnectionProxyDictionary:";

	private static readonly IntPtr selSetConnectionProxyDictionary_Handle = Selector.GetHandle("setConnectionProxyDictionary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDiscretionary_ = "setDiscretionary:";

	private static readonly IntPtr selSetDiscretionary_Handle = Selector.GetHandle("setDiscretionary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHTTPAdditionalHeaders_ = "setHTTPAdditionalHeaders:";

	private static readonly IntPtr selSetHTTPAdditionalHeaders_Handle = Selector.GetHandle("setHTTPAdditionalHeaders:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHTTPCookieAcceptPolicy_ = "setHTTPCookieAcceptPolicy:";

	private static readonly IntPtr selSetHTTPCookieAcceptPolicy_Handle = Selector.GetHandle("setHTTPCookieAcceptPolicy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHTTPCookieStorage_ = "setHTTPCookieStorage:";

	private static readonly IntPtr selSetHTTPCookieStorage_Handle = Selector.GetHandle("setHTTPCookieStorage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHTTPMaximumConnectionsPerHost_ = "setHTTPMaximumConnectionsPerHost:";

	private static readonly IntPtr selSetHTTPMaximumConnectionsPerHost_Handle = Selector.GetHandle("setHTTPMaximumConnectionsPerHost:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHTTPShouldSetCookies_ = "setHTTPShouldSetCookies:";

	private static readonly IntPtr selSetHTTPShouldSetCookies_Handle = Selector.GetHandle("setHTTPShouldSetCookies:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHTTPShouldUsePipelining_ = "setHTTPShouldUsePipelining:";

	private static readonly IntPtr selSetHTTPShouldUsePipelining_Handle = Selector.GetHandle("setHTTPShouldUsePipelining:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNetworkServiceType_ = "setNetworkServiceType:";

	private static readonly IntPtr selSetNetworkServiceType_Handle = Selector.GetHandle("setNetworkServiceType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProtocolClasses_ = "setProtocolClasses:";

	private static readonly IntPtr selSetProtocolClasses_Handle = Selector.GetHandle("setProtocolClasses:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRequestCachePolicy_ = "setRequestCachePolicy:";

	private static readonly IntPtr selSetRequestCachePolicy_Handle = Selector.GetHandle("setRequestCachePolicy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSessionSendsLaunchEvents_ = "setSessionSendsLaunchEvents:";

	private static readonly IntPtr selSetSessionSendsLaunchEvents_Handle = Selector.GetHandle("setSessionSendsLaunchEvents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSharedContainerIdentifier_ = "setSharedContainerIdentifier:";

	private static readonly IntPtr selSetSharedContainerIdentifier_Handle = Selector.GetHandle("setSharedContainerIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldUseExtendedBackgroundIdleMode_ = "setShouldUseExtendedBackgroundIdleMode:";

	private static readonly IntPtr selSetShouldUseExtendedBackgroundIdleMode_Handle = Selector.GetHandle("setShouldUseExtendedBackgroundIdleMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTLSMaximumSupportedProtocol_ = "setTLSMaximumSupportedProtocol:";

	private static readonly IntPtr selSetTLSMaximumSupportedProtocol_Handle = Selector.GetHandle("setTLSMaximumSupportedProtocol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTLSMaximumSupportedProtocolVersion_ = "setTLSMaximumSupportedProtocolVersion:";

	private static readonly IntPtr selSetTLSMaximumSupportedProtocolVersion_Handle = Selector.GetHandle("setTLSMaximumSupportedProtocolVersion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTLSMinimumSupportedProtocol_ = "setTLSMinimumSupportedProtocol:";

	private static readonly IntPtr selSetTLSMinimumSupportedProtocol_Handle = Selector.GetHandle("setTLSMinimumSupportedProtocol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTLSMinimumSupportedProtocolVersion_ = "setTLSMinimumSupportedProtocolVersion:";

	private static readonly IntPtr selSetTLSMinimumSupportedProtocolVersion_Handle = Selector.GetHandle("setTLSMinimumSupportedProtocolVersion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeoutIntervalForRequest_ = "setTimeoutIntervalForRequest:";

	private static readonly IntPtr selSetTimeoutIntervalForRequest_Handle = Selector.GetHandle("setTimeoutIntervalForRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeoutIntervalForResource_ = "setTimeoutIntervalForResource:";

	private static readonly IntPtr selSetTimeoutIntervalForResource_Handle = Selector.GetHandle("setTimeoutIntervalForResource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetURLCache_ = "setURLCache:";

	private static readonly IntPtr selSetURLCache_Handle = Selector.GetHandle("setURLCache:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetURLCredentialStorage_ = "setURLCredentialStorage:";

	private static readonly IntPtr selSetURLCredentialStorage_Handle = Selector.GetHandle("setURLCredentialStorage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWaitsForConnectivity_ = "setWaitsForConnectivity:";

	private static readonly IntPtr selSetWaitsForConnectivity_Handle = Selector.GetHandle("setWaitsForConnectivity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedContainerIdentifier = "sharedContainerIdentifier";

	private static readonly IntPtr selSharedContainerIdentifierHandle = Selector.GetHandle("sharedContainerIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldUseExtendedBackgroundIdleMode = "shouldUseExtendedBackgroundIdleMode";

	private static readonly IntPtr selShouldUseExtendedBackgroundIdleModeHandle = Selector.GetHandle("shouldUseExtendedBackgroundIdleMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeoutIntervalForRequest = "timeoutIntervalForRequest";

	private static readonly IntPtr selTimeoutIntervalForRequestHandle = Selector.GetHandle("timeoutIntervalForRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeoutIntervalForResource = "timeoutIntervalForResource";

	private static readonly IntPtr selTimeoutIntervalForResourceHandle = Selector.GetHandle("timeoutIntervalForResource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWaitsForConnectivity = "waitsForConnectivity";

	private static readonly IntPtr selWaitsForConnectivityHandle = Selector.GetHandle("waitsForConnectivity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSURLSessionConfiguration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_StrongConnectionProxyDictionary_var;

	public SessionConfigurationType SessionType { get; private set; } = SessionConfigurationType.Default;


	public static NSUrlSessionConfiguration DefaultSessionConfiguration
	{
		get
		{
			NSUrlSessionConfiguration defaultSessionConfiguration = _DefaultSessionConfiguration;
			defaultSessionConfiguration.SessionType = SessionConfigurationType.Default;
			return defaultSessionConfiguration;
		}
	}

	public static NSUrlSessionConfiguration EphemeralSessionConfiguration
	{
		get
		{
			NSUrlSessionConfiguration ephemeralSessionConfiguration = _EphemeralSessionConfiguration;
			ephemeralSessionConfiguration.SessionType = SessionConfigurationType.Ephemeral;
			return ephemeralSessionConfiguration;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsCellularAccess
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
	public virtual bool AllowsConstrainedNetworkAccess
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
	public virtual bool AllowsExpensiveNetworkAccess
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
	public virtual NSDictionary? ConnectionProxyDictionary
	{
		[Export("connectionProxyDictionary", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selConnectionProxyDictionaryHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConnectionProxyDictionaryHandle));
		}
		[Export("setConnectionProxyDictionary:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetConnectionProxyDictionary_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetConnectionProxyDictionary_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Discretionary
	{
		[Export("isDiscretionary")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDiscretionaryHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDiscretionaryHandle);
		}
		[Export("setDiscretionary:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDiscretionary_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDiscretionary_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? HttpAdditionalHeaders
	{
		[Export("HTTPAdditionalHeaders", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selHTTPAdditionalHeadersHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHTTPAdditionalHeadersHandle));
		}
		[Export("setHTTPAdditionalHeaders:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHTTPAdditionalHeaders_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHTTPAdditionalHeaders_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSHttpCookieAcceptPolicy HttpCookieAcceptPolicy
	{
		[Export("HTTPCookieAcceptPolicy")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSHttpCookieAcceptPolicy)Messaging.UInt64_objc_msgSend(base.Handle, selHTTPCookieAcceptPolicyHandle);
			}
			return (NSHttpCookieAcceptPolicy)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selHTTPCookieAcceptPolicyHandle);
		}
		[Export("setHTTPCookieAcceptPolicy:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetHTTPCookieAcceptPolicy_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetHTTPCookieAcceptPolicy_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSHttpCookieStorage? HttpCookieStorage
	{
		[Export("HTTPCookieStorage", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSHttpCookieStorage>(Messaging.IntPtr_objc_msgSend(base.Handle, selHTTPCookieStorageHandle));
			}
			return Runtime.GetNSObject<NSHttpCookieStorage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHTTPCookieStorageHandle));
		}
		[Export("setHTTPCookieStorage:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHTTPCookieStorage_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHTTPCookieStorage_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint HttpMaximumConnectionsPerHost
	{
		[Export("HTTPMaximumConnectionsPerHost")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selHTTPMaximumConnectionsPerHostHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selHTTPMaximumConnectionsPerHostHandle);
		}
		[Export("setHTTPMaximumConnectionsPerHost:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetHTTPMaximumConnectionsPerHost_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetHTTPMaximumConnectionsPerHost_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HttpShouldSetCookies
	{
		[Export("HTTPShouldSetCookies")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHTTPShouldSetCookiesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHTTPShouldSetCookiesHandle);
		}
		[Export("setHTTPShouldSetCookies:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHTTPShouldSetCookies_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHTTPShouldSetCookies_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HttpShouldUsePipelining
	{
		[Export("HTTPShouldUsePipelining")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHTTPShouldUsePipeliningHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHTTPShouldUsePipeliningHandle);
		}
		[Export("setHTTPShouldUsePipelining:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHTTPShouldUsePipelining_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHTTPShouldUsePipelining_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Identifier
	{
		[Export("identifier", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlRequestNetworkServiceType NetworkServiceType
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
	public virtual NSUrlRequestCachePolicy RequestCachePolicy
	{
		[Export("requestCachePolicy")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSUrlRequestCachePolicy)Messaging.UInt64_objc_msgSend(base.Handle, selRequestCachePolicyHandle);
			}
			return (NSUrlRequestCachePolicy)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRequestCachePolicyHandle);
		}
		[Export("setRequestCachePolicy:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetRequestCachePolicy_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetRequestCachePolicy_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SessionSendsLaunchEvents
	{
		[Export("sessionSendsLaunchEvents")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSessionSendsLaunchEventsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSessionSendsLaunchEventsHandle);
		}
		[Export("setSessionSendsLaunchEvents:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSessionSendsLaunchEvents_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSessionSendsLaunchEvents_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? SharedContainerIdentifier
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("sharedContainerIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSharedContainerIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSharedContainerIdentifierHandle));
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setSharedContainerIdentifier:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSharedContainerIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSharedContainerIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool ShouldUseExtendedBackgroundIdleMode
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("shouldUseExtendedBackgroundIdleMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldUseExtendedBackgroundIdleModeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldUseExtendedBackgroundIdleModeHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setShouldUseExtendedBackgroundIdleMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldUseExtendedBackgroundIdleMode_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldUseExtendedBackgroundIdleMode_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual ProxyConfigurationDictionary StrongConnectionProxyDictionary
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		get
		{
			return new ProxyConfigurationDictionary(ConnectionProxyDictionary);
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		set
		{
			ConnectionProxyDictionary = value.GetDictionary();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'TlsMaximumSupportedProtocolVersion' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'TlsMaximumSupportedProtocolVersion' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'TlsMaximumSupportedProtocolVersion' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'TlsMaximumSupportedProtocolVersion' instead.")]
	public virtual SslProtocol TLSMaximumSupportedProtocol
	{
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'TlsMaximumSupportedProtocolVersion' instead.")]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'TlsMaximumSupportedProtocolVersion' instead.")]
		[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'TlsMaximumSupportedProtocolVersion' instead.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'TlsMaximumSupportedProtocolVersion' instead.")]
		[Export("TLSMaximumSupportedProtocol")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SslProtocol)Messaging.int_objc_msgSend(base.Handle, selTLSMaximumSupportedProtocolHandle);
			}
			return (SslProtocol)Messaging.int_objc_msgSendSuper(base.SuperHandle, selTLSMaximumSupportedProtocolHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'TlsMaximumSupportedProtocolVersion' instead.")]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'TlsMaximumSupportedProtocolVersion' instead.")]
		[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'TlsMaximumSupportedProtocolVersion' instead.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'TlsMaximumSupportedProtocolVersion' instead.")]
		[Export("setTLSMaximumSupportedProtocol:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetTLSMaximumSupportedProtocol_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetTLSMaximumSupportedProtocol_Handle, (int)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'TlsMinimumSupportedProtocolVersion' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'TlsMinimumSupportedProtocolVersion' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'TlsMinimumSupportedProtocolVersion' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'TlsMinimumSupportedProtocolVersion' instead.")]
	public virtual SslProtocol TLSMinimumSupportedProtocol
	{
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'TlsMinimumSupportedProtocolVersion' instead.")]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'TlsMinimumSupportedProtocolVersion' instead.")]
		[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'TlsMinimumSupportedProtocolVersion' instead.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'TlsMinimumSupportedProtocolVersion' instead.")]
		[Export("TLSMinimumSupportedProtocol")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SslProtocol)Messaging.int_objc_msgSend(base.Handle, selTLSMinimumSupportedProtocolHandle);
			}
			return (SslProtocol)Messaging.int_objc_msgSendSuper(base.SuperHandle, selTLSMinimumSupportedProtocolHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'TlsMinimumSupportedProtocolVersion' instead.")]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'TlsMinimumSupportedProtocolVersion' instead.")]
		[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'TlsMinimumSupportedProtocolVersion' instead.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'TlsMinimumSupportedProtocolVersion' instead.")]
		[Export("setTLSMinimumSupportedProtocol:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetTLSMinimumSupportedProtocol_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetTLSMinimumSupportedProtocol_Handle, (int)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double TimeoutIntervalForRequest
	{
		[Export("timeoutIntervalForRequest")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimeoutIntervalForRequestHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeoutIntervalForRequestHandle);
		}
		[Export("setTimeoutIntervalForRequest:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetTimeoutIntervalForRequest_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetTimeoutIntervalForRequest_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double TimeoutIntervalForResource
	{
		[Export("timeoutIntervalForResource")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimeoutIntervalForResourceHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeoutIntervalForResourceHandle);
		}
		[Export("setTimeoutIntervalForResource:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetTimeoutIntervalForResource_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetTimeoutIntervalForResource_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual TlsProtocolVersion TlsMaximumSupportedProtocolVersion
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("TLSMaximumSupportedProtocolVersion", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (TlsProtocolVersion)Messaging.UInt16_objc_msgSend(base.Handle, selTLSMaximumSupportedProtocolVersionHandle);
			}
			return (TlsProtocolVersion)Messaging.UInt16_objc_msgSendSuper(base.SuperHandle, selTLSMaximumSupportedProtocolVersionHandle);
		}
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setTLSMaximumSupportedProtocolVersion:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt16(base.Handle, selSetTLSMaximumSupportedProtocolVersion_Handle, (ushort)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt16(base.SuperHandle, selSetTLSMaximumSupportedProtocolVersion_Handle, (ushort)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual TlsProtocolVersion TlsMinimumSupportedProtocolVersion
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("TLSMinimumSupportedProtocolVersion", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (TlsProtocolVersion)Messaging.UInt16_objc_msgSend(base.Handle, selTLSMinimumSupportedProtocolVersionHandle);
			}
			return (TlsProtocolVersion)Messaging.UInt16_objc_msgSendSuper(base.SuperHandle, selTLSMinimumSupportedProtocolVersionHandle);
		}
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setTLSMinimumSupportedProtocolVersion:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt16(base.Handle, selSetTLSMinimumSupportedProtocolVersion_Handle, (ushort)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt16(base.SuperHandle, selSetTLSMinimumSupportedProtocolVersion_Handle, (ushort)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlCache? URLCache
	{
		[Export("URLCache", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrlCache>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLCacheHandle));
			}
			return Runtime.GetNSObject<NSUrlCache>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLCacheHandle));
		}
		[Export("setURLCache:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetURLCache_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetURLCache_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlCredentialStorage? URLCredentialStorage
	{
		[Export("URLCredentialStorage", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrlCredentialStorage>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLCredentialStorageHandle));
			}
			return Runtime.GetNSObject<NSUrlCredentialStorage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLCredentialStorageHandle));
		}
		[Export("setURLCredentialStorage:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetURLCredentialStorage_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetURLCredentialStorage_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual bool WaitsForConnectivity
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("waitsForConnectivity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWaitsForConnectivityHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWaitsForConnectivityHandle);
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setWaitsForConnectivity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetWaitsForConnectivity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetWaitsForConnectivity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray? WeakProtocolClasses
	{
		[Export("protocolClasses", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selProtocolClassesHandle));
			}
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProtocolClassesHandle));
		}
		[Export("setProtocolClasses:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetProtocolClasses_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetProtocolClasses_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSUrlSessionConfiguration _DefaultSessionConfiguration
	{
		[Export("defaultSessionConfiguration", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSUrlSessionConfiguration>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultSessionConfigurationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSUrlSessionConfiguration _EphemeralSessionConfiguration
	{
		[Export("ephemeralSessionConfiguration", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSUrlSessionConfiguration>(Messaging.IntPtr_objc_msgSend(class_ptr, selEphemeralSessionConfigurationHandle));
		}
	}

	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'CreateBackgroundSessionConfiguration' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'CreateBackgroundSessionConfiguration' instead.")]
	public static NSUrlSessionConfiguration BackgroundSessionConfiguration(string identifier)
	{
		NSUrlSessionConfiguration nSUrlSessionConfiguration = _BackgroundSessionConfiguration(identifier);
		nSUrlSessionConfiguration.SessionType = SessionConfigurationType.Background;
		return nSUrlSessionConfiguration;
	}

	public static NSUrlSessionConfiguration CreateBackgroundSessionConfiguration(string identifier)
	{
		NSUrlSessionConfiguration nSUrlSessionConfiguration = _CreateBackgroundSessionConfiguration(identifier);
		nSUrlSessionConfiguration.SessionType = SessionConfigurationType.Background;
		return nSUrlSessionConfiguration;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUrlSessionConfiguration(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlSessionConfiguration(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("backgroundSessionConfiguration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSUrlSessionConfiguration _BackgroundSessionConfiguration(string identifier)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSUrlSessionConfiguration nSObject = Runtime.GetNSObject<NSUrlSessionConfiguration>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBackgroundSessionConfiguration_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("backgroundSessionConfigurationWithIdentifier:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSUrlSessionConfiguration _CreateBackgroundSessionConfiguration(string identifier)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSUrlSessionConfiguration nSObject = Runtime.GetNSObject<NSUrlSessionConfiguration>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBackgroundSessionConfigurationWithIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_StrongConnectionProxyDictionary_var = null;
		}
	}
}
