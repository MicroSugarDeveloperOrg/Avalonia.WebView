using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

public class CBConnectPeripheralOptions : DictionaryContainer
{
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public bool? NotifyOnConnection
	{
		get
		{
			return GetBoolValue(CBConnectPeripheralOptionsKeys.NotifyOnConnectionKey);
		}
		set
		{
			SetBooleanValue(CBConnectPeripheralOptionsKeys.NotifyOnConnectionKey, value);
		}
	}

	public bool? NotifyOnDisconnection
	{
		get
		{
			return GetBoolValue(CBConnectPeripheralOptionsKeys.NotifyOnDisconnectionKey);
		}
		set
		{
			SetBooleanValue(CBConnectPeripheralOptionsKeys.NotifyOnDisconnectionKey, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public bool? NotifyOnNotification
	{
		get
		{
			return GetBoolValue(CBConnectPeripheralOptionsKeys.NotifyOnNotificationKey);
		}
		set
		{
			SetBooleanValue(CBConnectPeripheralOptionsKeys.NotifyOnNotificationKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public CBConnectPeripheralOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public CBConnectPeripheralOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
