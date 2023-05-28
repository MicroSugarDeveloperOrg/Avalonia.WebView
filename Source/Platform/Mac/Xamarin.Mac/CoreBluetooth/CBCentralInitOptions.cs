using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
public class CBCentralInitOptions : DictionaryContainer
{
	public bool? ShowPowerAlert
	{
		get
		{
			return GetBoolValue(CBCentralManager.OptionShowPowerAlertKey);
		}
		set
		{
			SetBooleanValue(CBCentralManager.OptionShowPowerAlertKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public CBCentralInitOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public CBCentralInitOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
