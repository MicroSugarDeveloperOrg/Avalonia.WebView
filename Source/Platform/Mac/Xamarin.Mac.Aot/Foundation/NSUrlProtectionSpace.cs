using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSURLProtectionSpace", true)]
public class NSUrlProtectionSpace : NSObject
{
	private static readonly IntPtr selRealmHandle = Selector.GetHandle("realm");

	private static readonly IntPtr selReceivesCredentialSecurelyHandle = Selector.GetHandle("receivesCredentialSecurely");

	private static readonly IntPtr selIsProxyHandle = Selector.GetHandle("isProxy");

	private static readonly IntPtr selHostHandle = Selector.GetHandle("host");

	private static readonly IntPtr selPortHandle = Selector.GetHandle("port");

	private static readonly IntPtr selProxyTypeHandle = Selector.GetHandle("proxyType");

	private static readonly IntPtr selProtocolHandle = Selector.GetHandle("protocol");

	private static readonly IntPtr selAuthenticationMethodHandle = Selector.GetHandle("authenticationMethod");

	private static readonly IntPtr selDistinguishedNamesHandle = Selector.GetHandle("distinguishedNames");

	private static readonly IntPtr selServerTrustHandle = Selector.GetHandle("serverTrust");

	private static readonly IntPtr selInitWithHostPortProtocolRealmAuthenticationMethod_Handle = Selector.GetHandle("initWithHost:port:protocol:realm:authenticationMethod:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSURLProtectionSpace");

	private object __mt_DistinguishedNames_var;

	private static NSString _HTTP;

	private static NSString _HTTPS;

	private static NSString _FTP;

	private static NSString _HTTPProxy;

	private static NSString _HTTPSProxy;

	private static NSString _FTPProxy;

	private static NSString _SOCKSProxy;

	private static NSString _AuthenticationMethodDefault;

	private static NSString _AuthenticationMethodHTTPBasic;

	private static NSString _AuthenticationMethodHTTPDigest;

	private static NSString _AuthenticationMethodHTMLForm;

	private static NSString _AuthenticationMethodNTL;

	private static NSString _AuthenticationMethodNegotiat;

	private static NSString _AuthenticationMethodClientCertificate;

	private static NSString _AuthenticationMethodServerTrus;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Realm
	{
		[Export("realm")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRealmHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRealmHandle));
		}
	}

	public virtual bool ReceivesCredentialSecurely
	{
		[Export("receivesCredentialSecurely")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selReceivesCredentialSecurelyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selReceivesCredentialSecurelyHandle);
		}
	}

	public virtual bool IsProxy
	{
		[Export("isProxy")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsProxyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsProxyHandle);
		}
	}

	public virtual string Host
	{
		[Export("host")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selHostHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHostHandle));
		}
	}

	public virtual long Port
	{
		[Export("port")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selPortHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selPortHandle);
		}
	}

	public virtual string ProxyType
	{
		[Export("proxyType")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selProxyTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProxyTypeHandle));
		}
	}

	public virtual string Protocol
	{
		[Export("protocol")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selProtocolHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProtocolHandle));
		}
	}

	public virtual string AuthenticationMethod
	{
		[Export("authenticationMethod")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAuthenticationMethodHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAuthenticationMethodHandle));
		}
	}

	public virtual NSData[] DistinguishedNames
	{
		[Export("distinguishedNames")]
		get
		{
			return (NSData[])(__mt_DistinguishedNames_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDistinguishedNamesHandle)) : NSArray.ArrayFromHandle<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDistinguishedNamesHandle))));
		}
	}

	public virtual IntPtr ServerTrust
	{
		[Export("serverTrust")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selServerTrustHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selServerTrustHandle);
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

	[Field("NSURLAuthenticationMethodNTLM", "Foundation")]
	public static NSString AuthenticationMethodNTL
	{
		get
		{
			if (_AuthenticationMethodNTL == null)
			{
				_AuthenticationMethodNTL = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLAuthenticationMethodNTLM");
			}
			return _AuthenticationMethodNTL;
		}
	}

	[Field("NSURLAuthenticationMethodNegotiate", "Foundation")]
	public static NSString AuthenticationMethodNegotiat
	{
		get
		{
			if (_AuthenticationMethodNegotiat == null)
			{
				_AuthenticationMethodNegotiat = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLAuthenticationMethodNegotiate");
			}
			return _AuthenticationMethodNegotiat;
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

	[Field("NSURLAuthenticationMethodServerTrust", "Foundation")]
	public static NSString AuthenticationMethodServerTrus
	{
		get
		{
			if (_AuthenticationMethodServerTrus == null)
			{
				_AuthenticationMethodServerTrus = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLAuthenticationMethodServerTrust");
			}
			return _AuthenticationMethodServerTrus;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUrlProtectionSpace(NSCoder coder)
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
	public NSUrlProtectionSpace(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUrlProtectionSpace(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithHost:port:protocol:realm:authenticationMethod:")]
	public NSUrlProtectionSpace(string host, long port, string protocol, string realm, string authenticationMethod)
		: base(NSObjectFlag.Empty)
	{
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		if (protocol == null)
		{
			throw new ArgumentNullException("protocol");
		}
		if (realm == null)
		{
			throw new ArgumentNullException("realm");
		}
		if (authenticationMethod == null)
		{
			throw new ArgumentNullException("authenticationMethod");
		}
		IntPtr arg = NSString.CreateNative(host);
		IntPtr arg2 = NSString.CreateNative(protocol);
		IntPtr arg3 = NSString.CreateNative(realm);
		IntPtr arg4 = NSString.CreateNative(authenticationMethod);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_Int64_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithHostPortProtocolRealmAuthenticationMethod_Handle, arg, port, arg2, arg3, arg4);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithHostPortProtocolRealmAuthenticationMethod_Handle, arg, port, arg2, arg3, arg4);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		NSString.ReleaseNative(arg4);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DistinguishedNames_var = null;
		}
	}
}
