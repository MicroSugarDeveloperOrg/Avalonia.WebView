using ObjCRuntime;

namespace Foundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class ProxyConfigurationDictionary : DictionaryContainer
{
	public bool? HttpEnable
	{
		get
		{
			return GetBoolValue(ProxyConfigurationDictionaryKeys.HttpEnableKey);
		}
		set
		{
			SetBooleanValue(ProxyConfigurationDictionaryKeys.HttpEnableKey, value);
		}
	}

	public string? HttpProxyHost
	{
		get
		{
			return GetStringValue(ProxyConfigurationDictionaryKeys.HttpProxyHostKey);
		}
		set
		{
			SetStringValue(ProxyConfigurationDictionaryKeys.HttpProxyHostKey, value);
		}
	}

	public int? HttpProxyPort
	{
		get
		{
			return GetInt32Value(ProxyConfigurationDictionaryKeys.HttpProxyPortKey);
		}
		set
		{
			SetNumberValue(ProxyConfigurationDictionaryKeys.HttpProxyPortKey, value);
		}
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public bool? HttpsEnable
	{
		get
		{
			return GetBoolValue(ProxyConfigurationDictionaryKeys.HttpsEnableKey);
		}
		set
		{
			SetBooleanValue(ProxyConfigurationDictionaryKeys.HttpsEnableKey, value);
		}
	}

	public string? HttpsProxyHost
	{
		get
		{
			return GetStringValue(ProxyConfigurationDictionaryKeys.HttpsProxyHostKey);
		}
		set
		{
			SetStringValue(ProxyConfigurationDictionaryKeys.HttpsProxyHostKey, value);
		}
	}

	public int? HttpsProxyPort
	{
		get
		{
			return GetInt32Value(ProxyConfigurationDictionaryKeys.HttpsProxyPortKey);
		}
		set
		{
			SetNumberValue(ProxyConfigurationDictionaryKeys.HttpsProxyPortKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public ProxyConfigurationDictionary()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public ProxyConfigurationDictionary(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
