using Foundation;
using ObjCRuntime;

namespace VideoSubscriberAccount;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class VSErrorInfo : DictionaryContainer
{
	public string? SamlResponse => GetStringValue(VSErrorInfoKeys.SamlResponseKey);

	public string? SamlResponseStatus => GetStringValue(VSErrorInfoKeys.SamlResponseStatusKey);

	public string? UnsupportedProviderIdentifier => GetStringValue(VSErrorInfoKeys.UnsupportedProviderIdentifierKey);

	[Introduced(PlatformName.TvOS, 10, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	public string? AccountProviderResponse => GetStringValue(VSErrorInfoKeys.AccountProviderResponseKey);

	[Preserve(Conditional = true)]
	public VSErrorInfo()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public VSErrorInfo(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
