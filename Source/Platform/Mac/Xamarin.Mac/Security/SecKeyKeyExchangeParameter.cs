using Foundation;
using ObjCRuntime;

namespace Security;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class SecKeyKeyExchangeParameter : DictionaryContainer
{
	public int? RequestedSize
	{
		get
		{
			return GetInt32Value(SecKeyKeyExchangeParameterKey.RequestedSizeKey);
		}
		set
		{
			SetNumberValue(SecKeyKeyExchangeParameterKey.RequestedSizeKey, value);
		}
	}

	public NSData? SharedInfo
	{
		get
		{
			return base.Dictionary[SecKeyKeyExchangeParameterKey.SharedInfoKey] as NSData;
		}
		set
		{
			SetNativeValue(SecKeyKeyExchangeParameterKey.SharedInfoKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public SecKeyKeyExchangeParameter()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public SecKeyKeyExchangeParameter(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
