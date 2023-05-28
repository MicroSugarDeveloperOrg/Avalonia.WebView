using Foundation;
using ObjCRuntime;

namespace VideoSubscriberAccount;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class VSAccountManagerAccessOptions : DictionaryContainer
{
	public bool? CheckAccessOptionPrompt
	{
		get
		{
			return GetBoolValue(VSCheckAccessOptionKeys.CheckAccessOptionPrompt);
		}
		set
		{
			SetBooleanValue(VSCheckAccessOptionKeys.CheckAccessOptionPrompt, value);
		}
	}

	[Preserve(Conditional = true)]
	public VSAccountManagerAccessOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public VSAccountManagerAccessOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
