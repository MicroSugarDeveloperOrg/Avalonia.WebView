using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public class CFProxy
{
	private NSDictionary settings;

	private static NSString kCFProxyAutoConfigurationJavaScriptKey;

	private static NSString kCFProxyAutoConfigurationURLKey;

	private static NSString kCFProxyHostNameKey;

	private static NSString kCFProxyPasswordKey;

	private static NSString kCFProxyPortNumberKey;

	private static NSString kCFProxyTypeKey;

	private static NSString kCFProxyUsernameKey;

	private static NSString kCFProxyTypeNone;

	private static NSString kCFProxyTypeAutoConfigurationURL;

	private static NSString kCFProxyTypeAutoConfigurationJavaScript;

	private static NSString kCFProxyTypeFTP;

	private static NSString kCFProxyTypeHTTP;

	private static NSString kCFProxyTypeHTTPS;

	private static NSString kCFProxyTypeSOCKS;

	private static NSString AutoConfigurationJavaScriptKey
	{
		get
		{
			if (kCFProxyAutoConfigurationJavaScriptKey == null)
			{
				kCFProxyAutoConfigurationJavaScriptKey = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFProxyAutoConfigurationJavaScriptKey");
			}
			return kCFProxyAutoConfigurationJavaScriptKey;
		}
	}

	private static NSString AutoConfigurationURLKey
	{
		get
		{
			if (kCFProxyAutoConfigurationURLKey == null)
			{
				kCFProxyAutoConfigurationURLKey = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFProxyAutoConfigurationURLKey");
			}
			return kCFProxyAutoConfigurationURLKey;
		}
	}

	private static NSString HostNameKey
	{
		get
		{
			if (kCFProxyHostNameKey == null)
			{
				kCFProxyHostNameKey = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFProxyHostNameKey");
			}
			return kCFProxyHostNameKey;
		}
	}

	private static NSString PasswordKey
	{
		get
		{
			if (kCFProxyPasswordKey == null)
			{
				kCFProxyPasswordKey = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFProxyPasswordKey");
			}
			return kCFProxyPasswordKey;
		}
	}

	private static NSString PortNumberKey
	{
		get
		{
			if (kCFProxyPortNumberKey == null)
			{
				kCFProxyPortNumberKey = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFProxyPortNumberKey");
			}
			return kCFProxyPortNumberKey;
		}
	}

	private static NSString ProxyTypeKey
	{
		get
		{
			if (kCFProxyTypeKey == null)
			{
				kCFProxyTypeKey = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFProxyTypeKey");
			}
			return kCFProxyTypeKey;
		}
	}

	private static NSString UsernameKey
	{
		get
		{
			if (kCFProxyUsernameKey == null)
			{
				kCFProxyUsernameKey = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFProxyUsernameKey");
			}
			return kCFProxyUsernameKey;
		}
	}

	private static NSString CFProxyTypeNone
	{
		get
		{
			if (kCFProxyTypeNone == null)
			{
				kCFProxyTypeNone = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFProxyTypeNone");
			}
			return kCFProxyTypeNone;
		}
	}

	private static NSString CFProxyTypeAutoConfigurationURL
	{
		get
		{
			if (kCFProxyTypeAutoConfigurationURL == null)
			{
				kCFProxyTypeAutoConfigurationURL = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFProxyTypeAutoConfigurationURL");
			}
			return kCFProxyTypeAutoConfigurationURL;
		}
	}

	private static NSString CFProxyTypeAutoConfigurationJavaScript
	{
		get
		{
			if (kCFProxyTypeAutoConfigurationJavaScript == null)
			{
				kCFProxyTypeAutoConfigurationJavaScript = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFProxyTypeAutoConfigurationJavaScript");
			}
			return kCFProxyTypeAutoConfigurationJavaScript;
		}
	}

	private static NSString CFProxyTypeFTP
	{
		get
		{
			if (kCFProxyTypeFTP == null)
			{
				kCFProxyTypeFTP = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFProxyTypeFTP");
			}
			return kCFProxyTypeFTP;
		}
	}

	private static NSString CFProxyTypeHTTP
	{
		get
		{
			if (kCFProxyTypeHTTP == null)
			{
				kCFProxyTypeHTTP = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFProxyTypeHTTP");
			}
			return kCFProxyTypeHTTP;
		}
	}

	private static NSString CFProxyTypeHTTPS
	{
		get
		{
			if (kCFProxyTypeHTTPS == null)
			{
				kCFProxyTypeHTTPS = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFProxyTypeHTTPS");
			}
			return kCFProxyTypeHTTPS;
		}
	}

	private static NSString CFProxyTypeSOCKS
	{
		get
		{
			if (kCFProxyTypeSOCKS == null)
			{
				kCFProxyTypeSOCKS = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFProxyTypeSOCKS");
			}
			return kCFProxyTypeSOCKS;
		}
	}

	public NSString AutoConfigurationJavaScript
	{
		get
		{
			if (AutoConfigurationJavaScriptKey == null)
			{
				return null;
			}
			return (NSString)settings[AutoConfigurationJavaScriptKey];
		}
	}

	public NSUrl AutoConfigurationUrl
	{
		get
		{
			if (AutoConfigurationURLKey == null)
			{
				return null;
			}
			return (NSUrl)settings[AutoConfigurationURLKey];
		}
	}

	public string HostName
	{
		get
		{
			if (HostNameKey == null)
			{
				return null;
			}
			NSString nSString = (NSString)settings[HostNameKey];
			return (nSString != null) ? nSString.ToString() : null;
		}
	}

	public string Password
	{
		get
		{
			if (PasswordKey == null)
			{
				return null;
			}
			NSString nSString = (NSString)settings[PasswordKey];
			return (nSString != null) ? nSString.ToString() : null;
		}
	}

	public int Port
	{
		get
		{
			if (PortNumberKey == null)
			{
				return 0;
			}
			return ((NSNumber)settings[PortNumberKey])?.Int32Value ?? 0;
		}
	}

	public CFProxyType ProxyType
	{
		get
		{
			if (ProxyTypeKey == null)
			{
				return CFProxyType.None;
			}
			return CFProxyTypeToEnum((NSString)settings[ProxyTypeKey]);
		}
	}

	public string Username
	{
		get
		{
			if (UsernameKey == null)
			{
				return null;
			}
			NSString nSString = (NSString)settings[UsernameKey];
			return (nSString != null) ? nSString.ToString() : null;
		}
	}

	internal CFProxy(NSDictionary settings)
	{
		this.settings = settings;
	}

	private static CFProxyType CFProxyTypeToEnum(NSString type)
	{
		if (CFProxyTypeAutoConfigurationJavaScript != null && type.Handle == CFProxyTypeAutoConfigurationJavaScript.Handle)
		{
			return CFProxyType.AutoConfigurationJavaScript;
		}
		if (CFProxyTypeAutoConfigurationURL != null && type.Handle == CFProxyTypeAutoConfigurationURL.Handle)
		{
			return CFProxyType.AutoConfigurationUrl;
		}
		if (CFProxyTypeFTP != null && type.Handle == CFProxyTypeFTP.Handle)
		{
			return CFProxyType.FTP;
		}
		if (CFProxyTypeHTTP != null && type.Handle == CFProxyTypeHTTP.Handle)
		{
			return CFProxyType.HTTP;
		}
		if (CFProxyTypeHTTP != null && type.Handle == CFProxyTypeHTTPS.Handle)
		{
			return CFProxyType.HTTPS;
		}
		if (CFProxyTypeSOCKS != null && type.Handle == CFProxyTypeSOCKS.Handle)
		{
			return CFProxyType.SOCKS;
		}
		return CFProxyType.None;
	}
}
