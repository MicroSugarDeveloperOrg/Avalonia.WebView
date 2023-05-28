using System.ComponentModel;
using ObjCRuntime;
using Security;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSURLProtectionSpace", true)]
public class NSUrlProtectionSpace : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAuthenticationMethod = "authenticationMethod";

	private static readonly IntPtr selAuthenticationMethodHandle = Selector.GetHandle("authenticationMethod");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDistinguishedNames = "distinguishedNames";

	private static readonly IntPtr selDistinguishedNamesHandle = Selector.GetHandle("distinguishedNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHost = "host";

	private static readonly IntPtr selHostHandle = Selector.GetHandle("host");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithHost_Port_Protocol_Realm_AuthenticationMethod_ = "initWithHost:port:protocol:realm:authenticationMethod:";

	private static readonly IntPtr selInitWithHost_Port_Protocol_Realm_AuthenticationMethod_Handle = Selector.GetHandle("initWithHost:port:protocol:realm:authenticationMethod:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithProxyHost_Port_Type_Realm_AuthenticationMethod_ = "initWithProxyHost:port:type:realm:authenticationMethod:";

	private static readonly IntPtr selInitWithProxyHost_Port_Type_Realm_AuthenticationMethod_Handle = Selector.GetHandle("initWithProxyHost:port:type:realm:authenticationMethod:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsProxy = "isProxy";

	private static readonly IntPtr selIsProxyHandle = Selector.GetHandle("isProxy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPort = "port";

	private static readonly IntPtr selPortHandle = Selector.GetHandle("port");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProtocol = "protocol";

	private static readonly IntPtr selProtocolHandle = Selector.GetHandle("protocol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProxyType = "proxyType";

	private static readonly IntPtr selProxyTypeHandle = Selector.GetHandle("proxyType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRealm = "realm";

	private static readonly IntPtr selRealmHandle = Selector.GetHandle("realm");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReceivesCredentialSecurely = "receivesCredentialSecurely";

	private static readonly IntPtr selReceivesCredentialSecurelyHandle = Selector.GetHandle("receivesCredentialSecurely");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selServerTrust = "serverTrust";

	private static readonly IntPtr selServerTrustHandle = Selector.GetHandle("serverTrust");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSURLProtectionSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuthenticationMethodClientCertificate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuthenticationMethodDefault;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuthenticationMethodHTMLForm;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuthenticationMethodHTTPBasic;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuthenticationMethodHTTPDigest;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuthenticationMethodNTLM;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuthenticationMethodNegotiate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuthenticationMethodServerTrust;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FTP;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FTPProxy;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HTTP;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HTTPProxy;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HTTPS;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HTTPSProxy;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SOCKSProxy;

	public SecTrust ServerSecTrust
	{
		get
		{
			IntPtr serverTrust = ServerTrust;
			return (serverTrust == IntPtr.Zero) ? null : new SecTrust(serverTrust, owns: false);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string AuthenticationMethod
	{
		[Export("authenticationMethod")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAuthenticationMethodHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAuthenticationMethodHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData[] DistinguishedNames
	{
		[Export("distinguishedNames")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDistinguishedNamesHandle));
			}
			return NSArray.ArrayFromHandle<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDistinguishedNamesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Host
	{
		[Export("host")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selHostHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHostHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool IsProxy
	{
		[Export("isProxy")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsProxyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsProxyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Port
	{
		[Export("port")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selPortHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selPortHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Protocol
	{
		[Export("protocol")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selProtocolHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProtocolHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ProxyType
	{
		[Export("proxyType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selProxyTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProxyTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Realm
	{
		[Export("realm")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRealmHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRealmHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReceivesCredentialSecurely
	{
		[Export("receivesCredentialSecurely")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selReceivesCredentialSecurelyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selReceivesCredentialSecurelyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr ServerTrust
	{
		[Export("serverTrust")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selServerTrustHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selServerTrustHandle);
		}
	}

	[Field("NSURLAuthenticationMethodClientCertificate", "Foundation")]
	public static NSString AuthenticationMethodClientCertificate
	{
		get
		{
			if (_AuthenticationMethodClientCertificate == null)
			{
				_AuthenticationMethodClientCertificate = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLAuthenticationMethodClientCertificate");
			}
			return _AuthenticationMethodClientCertificate;
		}
	}

	[Field("NSURLAuthenticationMethodDefault", "Foundation")]
	public static NSString AuthenticationMethodDefault
	{
		get
		{
			if (_AuthenticationMethodDefault == null)
			{
				_AuthenticationMethodDefault = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLAuthenticationMethodDefault");
			}
			return _AuthenticationMethodDefault;
		}
	}

	[Field("NSURLAuthenticationMethodHTMLForm", "Foundation")]
	public static NSString AuthenticationMethodHTMLForm
	{
		get
		{
			if (_AuthenticationMethodHTMLForm == null)
			{
				_AuthenticationMethodHTMLForm = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLAuthenticationMethodHTMLForm");
			}
			return _AuthenticationMethodHTMLForm;
		}
	}

	[Field("NSURLAuthenticationMethodHTTPBasic", "Foundation")]
	public static NSString AuthenticationMethodHTTPBasic
	{
		get
		{
			if (_AuthenticationMethodHTTPBasic == null)
			{
				_AuthenticationMethodHTTPBasic = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLAuthenticationMethodHTTPBasic");
			}
			return _AuthenticationMethodHTTPBasic;
		}
	}

	[Field("NSURLAuthenticationMethodHTTPDigest", "Foundation")]
	public static NSString AuthenticationMethodHTTPDigest
	{
		get
		{
			if (_AuthenticationMethodHTTPDigest == null)
			{
				_AuthenticationMethodHTTPDigest = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLAuthenticationMethodHTTPDigest");
			}
			return _AuthenticationMethodHTTPDigest;
		}
	}

	[Field("NSURLAuthenticationMethodNTLM", "Foundation")]
	public static NSString AuthenticationMethodNTLM
	{
		get
		{
			if (_AuthenticationMethodNTLM == null)
			{
				_AuthenticationMethodNTLM = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLAuthenticationMethodNTLM");
			}
			return _AuthenticationMethodNTLM;
		}
	}

	[Field("NSURLAuthenticationMethodNegotiate", "Foundation")]
	public static NSString AuthenticationMethodNegotiate
	{
		get
		{
			if (_AuthenticationMethodNegotiate == null)
			{
				_AuthenticationMethodNegotiate = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLAuthenticationMethodNegotiate");
			}
			return _AuthenticationMethodNegotiate;
		}
	}

	[Field("NSURLAuthenticationMethodServerTrust", "Foundation")]
	public static NSString AuthenticationMethodServerTrust
	{
		get
		{
			if (_AuthenticationMethodServerTrust == null)
			{
				_AuthenticationMethodServerTrust = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLAuthenticationMethodServerTrust");
			}
			return _AuthenticationMethodServerTrust;
		}
	}

	[Field("NSURLProtectionSpaceFTP", "Foundation")]
	public static NSString FTP
	{
		get
		{
			if (_FTP == null)
			{
				_FTP = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLProtectionSpaceFTP");
			}
			return _FTP;
		}
	}

	[Field("NSURLProtectionSpaceFTPProxy", "Foundation")]
	public static NSString FTPProxy
	{
		get
		{
			if (_FTPProxy == null)
			{
				_FTPProxy = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLProtectionSpaceFTPProxy");
			}
			return _FTPProxy;
		}
	}

	[Field("NSURLProtectionSpaceHTTP", "Foundation")]
	public static NSString HTTP
	{
		get
		{
			if (_HTTP == null)
			{
				_HTTP = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLProtectionSpaceHTTP");
			}
			return _HTTP;
		}
	}

	[Field("NSURLProtectionSpaceHTTPProxy", "Foundation")]
	public static NSString HTTPProxy
	{
		get
		{
			if (_HTTPProxy == null)
			{
				_HTTPProxy = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLProtectionSpaceHTTPProxy");
			}
			return _HTTPProxy;
		}
	}

	[Field("NSURLProtectionSpaceHTTPS", "Foundation")]
	public static NSString HTTPS
	{
		get
		{
			if (_HTTPS == null)
			{
				_HTTPS = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLProtectionSpaceHTTPS");
			}
			return _HTTPS;
		}
	}

	[Field("NSURLProtectionSpaceHTTPSProxy", "Foundation")]
	public static NSString HTTPSProxy
	{
		get
		{
			if (_HTTPSProxy == null)
			{
				_HTTPSProxy = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLProtectionSpaceHTTPSProxy");
			}
			return _HTTPSProxy;
		}
	}

	[Field("NSURLProtectionSpaceSOCKSProxy", "Foundation")]
	public static NSString SOCKSProxy
	{
		get
		{
			if (_SOCKSProxy == null)
			{
				_SOCKSProxy = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLProtectionSpaceSOCKSProxy");
			}
			return _SOCKSProxy;
		}
	}

	public NSUrlProtectionSpace(string host, int port, string protocol, string realm, string authenticationMethod)
		: base(NSObjectFlag.Empty)
	{
		base.Handle = Init(host, port, protocol, realm, authenticationMethod);
	}

	public NSUrlProtectionSpace(string host, int port, string protocol, string realm, string authenticationMethod, bool useProxy)
		: base(NSObjectFlag.Empty)
	{
		if (useProxy)
		{
			base.Handle = InitWithProxy(host, port, protocol, realm, authenticationMethod);
		}
		else
		{
			base.Handle = Init(host, port, protocol, realm, authenticationMethod);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUrlProtectionSpace(NSCoder coder)
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
	protected NSUrlProtectionSpace(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlProtectionSpace(IntPtr handle)
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

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("initWithHost:port:protocol:realm:authenticationMethod:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr Init(string host, nint port, string? protocol, string? realm, string? authenticationMethod)
	{
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		IntPtr arg = NSString.CreateNative(host);
		IntPtr arg2 = NSString.CreateNative(protocol);
		IntPtr arg3 = NSString.CreateNative(realm);
		IntPtr arg4 = NSString.CreateNative(authenticationMethod);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithHost_Port_Protocol_Realm_AuthenticationMethod_Handle, arg, port, arg2, arg3, arg4) : Messaging.IntPtr_objc_msgSend_IntPtr_nint_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithHost_Port_Protocol_Realm_AuthenticationMethod_Handle, arg, port, arg2, arg3, arg4));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		NSString.ReleaseNative(arg4);
		return result;
	}

	[Export("initWithProxyHost:port:type:realm:authenticationMethod:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithProxy(string host, nint port, string? type, string? realm, string? authenticationMethod)
	{
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		IntPtr arg = NSString.CreateNative(host);
		IntPtr arg2 = NSString.CreateNative(type);
		IntPtr arg3 = NSString.CreateNative(realm);
		IntPtr arg4 = NSString.CreateNative(authenticationMethod);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithProxyHost_Port_Type_Realm_AuthenticationMethod_Handle, arg, port, arg2, arg3, arg4) : Messaging.IntPtr_objc_msgSend_IntPtr_nint_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithProxyHost_Port_Type_Realm_AuthenticationMethod_Handle, arg, port, arg2, arg3, arg4));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		NSString.ReleaseNative(arg4);
		return result;
	}
}
