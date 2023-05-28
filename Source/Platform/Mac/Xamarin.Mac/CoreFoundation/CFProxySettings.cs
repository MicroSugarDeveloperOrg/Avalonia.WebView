using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public class CFProxySettings
{
	private NSDictionary settings;

	private static NSString kCFNetworkProxiesHTTPEnable;

	private static NSString kCFNetworkProxiesHTTPPort;

	private static NSString kCFNetworkProxiesHTTPProxy;

	private static NSString kCFNetworkProxiesProxyAutoConfigEnable;

	private static NSString kCFNetworkProxiesProxyAutoConfigURLString;

	public NSDictionary Dictionary => settings;

	private static NSString CFNetworkProxiesHTTPEnable
	{
		get
		{
			if (kCFNetworkProxiesHTTPEnable == null)
			{
				kCFNetworkProxiesHTTPEnable = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFNetworkProxiesHTTPEnable");
			}
			return kCFNetworkProxiesHTTPEnable;
		}
	}

	private static NSString CFNetworkProxiesHTTPPort
	{
		get
		{
			if (kCFNetworkProxiesHTTPPort == null)
			{
				kCFNetworkProxiesHTTPPort = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFNetworkProxiesHTTPPort");
			}
			return kCFNetworkProxiesHTTPPort;
		}
	}

	private static NSString CFNetworkProxiesHTTPProxy
	{
		get
		{
			if (kCFNetworkProxiesHTTPProxy == null)
			{
				kCFNetworkProxiesHTTPProxy = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFNetworkProxiesHTTPProxy");
			}
			return kCFNetworkProxiesHTTPProxy;
		}
	}

	private static NSString CFNetworkProxiesProxyAutoConfigEnable
	{
		get
		{
			if (kCFNetworkProxiesProxyAutoConfigEnable == null)
			{
				kCFNetworkProxiesProxyAutoConfigEnable = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFNetworkProxiesProxyAutoConfigEnable");
			}
			return kCFNetworkProxiesProxyAutoConfigEnable;
		}
	}

	private static NSString CFNetworkProxiesProxyAutoConfigURLString
	{
		get
		{
			if (kCFNetworkProxiesProxyAutoConfigURLString == null)
			{
				kCFNetworkProxiesProxyAutoConfigURLString = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFNetworkProxiesProxyAutoConfigURLString");
			}
			return kCFNetworkProxiesProxyAutoConfigURLString;
		}
	}

	public bool HTTPEnable
	{
		get
		{
			if (CFNetworkProxiesHTTPEnable == null)
			{
				return false;
			}
			return ((NSNumber)settings[CFNetworkProxiesHTTPEnable])?.BoolValue ?? false;
		}
	}

	public int HTTPPort
	{
		get
		{
			if (CFNetworkProxiesHTTPPort == null)
			{
				return 0;
			}
			return ((NSNumber)settings[CFNetworkProxiesHTTPPort])?.Int32Value ?? 0;
		}
	}

	public string HTTPProxy
	{
		get
		{
			if (CFNetworkProxiesHTTPProxy == null)
			{
				return null;
			}
			NSString nSString = (NSString)settings[CFNetworkProxiesHTTPProxy];
			return (nSString != null) ? nSString.ToString() : null;
		}
	}

	public bool ProxyAutoConfigEnable
	{
		get
		{
			if (CFNetworkProxiesProxyAutoConfigEnable == null)
			{
				return false;
			}
			return ((NSNumber)settings[CFNetworkProxiesProxyAutoConfigEnable])?.BoolValue ?? false;
		}
	}

	public string ProxyAutoConfigURLString
	{
		get
		{
			if (CFNetworkProxiesProxyAutoConfigURLString == null)
			{
				return null;
			}
			NSString nSString = (NSString)settings[CFNetworkProxiesProxyAutoConfigURLString];
			return (nSString != null) ? nSString.ToString() : null;
		}
	}

	internal CFProxySettings(NSDictionary settings)
	{
		this.settings = settings;
	}
}
