using ObjCRuntime;

namespace Foundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
internal static class ProxyConfigurationDictionaryKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HttpEnableKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HttpProxyHostKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HttpProxyPortKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HttpsEnableKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HttpsProxyHostKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HttpsProxyPortKey;

	[Field("kCFNetworkProxiesHTTPEnable", "Foundation")]
	public static NSString HttpEnableKey
	{
		get
		{
			if (_HttpEnableKey == null)
			{
				_HttpEnableKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "kCFNetworkProxiesHTTPEnable");
			}
			return _HttpEnableKey;
		}
	}

	[Field("kCFStreamPropertyHTTPProxyHost", "Foundation")]
	public static NSString HttpProxyHostKey
	{
		get
		{
			if (_HttpProxyHostKey == null)
			{
				_HttpProxyHostKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "kCFStreamPropertyHTTPProxyHost");
			}
			return _HttpProxyHostKey;
		}
	}

	[Field("kCFStreamPropertyHTTPProxyPort", "Foundation")]
	public static NSString HttpProxyPortKey
	{
		get
		{
			if (_HttpProxyPortKey == null)
			{
				_HttpProxyPortKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "kCFStreamPropertyHTTPProxyPort");
			}
			return _HttpProxyPortKey;
		}
	}

	[Field("kCFNetworkProxiesHTTPSEnable", "Foundation")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public static NSString HttpsEnableKey
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		get
		{
			if (_HttpsEnableKey == null)
			{
				_HttpsEnableKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "kCFNetworkProxiesHTTPSEnable");
			}
			return _HttpsEnableKey;
		}
	}

	[Field("kCFStreamPropertyHTTPSProxyHost", "Foundation")]
	public static NSString HttpsProxyHostKey
	{
		get
		{
			if (_HttpsProxyHostKey == null)
			{
				_HttpsProxyHostKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "kCFStreamPropertyHTTPSProxyHost");
			}
			return _HttpsProxyHostKey;
		}
	}

	[Field("kCFStreamPropertyHTTPSProxyPort", "Foundation")]
	public static NSString HttpsProxyPortKey
	{
		get
		{
			if (_HttpsProxyPortKey == null)
			{
				_HttpsProxyPortKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "kCFStreamPropertyHTTPSProxyPort");
			}
			return _HttpsProxyPortKey;
		}
	}
}
