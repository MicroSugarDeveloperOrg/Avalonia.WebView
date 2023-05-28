using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Watch(4, 0)]
public class PeripheralConnectionOptions : DictionaryContainer
{
	public bool? NotifyOnDisconnection
	{
		get
		{
			return GetBoolValue(CBCentralManager.OptionNotifyOnDisconnectionKey);
		}
		set
		{
			if (!value.HasValue)
			{
				RemoveValue(CBCentralManager.OptionNotifyOnDisconnectionKey);
			}
			else
			{
				SetNumberValue(CBCentralManager.OptionNotifyOnDisconnectionKey, value.Value ? 1 : 0);
			}
		}
	}

	public PeripheralConnectionOptions()
		: base(new NSMutableDictionary())
	{
	}

	public PeripheralConnectionOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
