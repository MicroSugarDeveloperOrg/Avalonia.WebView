using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Watch(4, 0)]
public class StartAdvertisingOptions : DictionaryContainer
{
	public string LocalName
	{
		get
		{
			return GetStringValue(CBAdvertisement.DataLocalNameKey);
		}
		set
		{
			SetStringValue(CBAdvertisement.DataLocalNameKey, value);
		}
	}

	public CBUUID[] ServicesUUID
	{
		get
		{
			return GetArray<CBUUID>(CBAdvertisement.DataServiceUUIDsKey);
		}
		set
		{
			SetArrayValue(CBAdvertisement.DataServiceUUIDsKey, value);
		}
	}

	public StartAdvertisingOptions()
		: base(new NSMutableDictionary())
	{
	}

	public StartAdvertisingOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
