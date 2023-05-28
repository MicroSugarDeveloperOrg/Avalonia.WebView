using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
public class AdvertisementData : DictionaryContainer
{
	public string? LocalName
	{
		get
		{
			return GetStringValue(AdvertisementDataKeys.LocalNameKey);
		}
		set
		{
			SetStringValue(AdvertisementDataKeys.LocalNameKey, value);
		}
	}

	public NSData? ManufacturerData
	{
		get
		{
			return base.Dictionary[AdvertisementDataKeys.ManufacturerDataKey] as NSData;
		}
		set
		{
			SetNativeValue(AdvertisementDataKeys.ManufacturerDataKey, value);
		}
	}

	public NSDictionary<CBUUID, NSData>? ServiceData
	{
		get
		{
			return GetNSDictionary<CBUUID, NSData>(AdvertisementDataKeys.ServiceDataKey);
		}
		set
		{
			SetNativeValue(AdvertisementDataKeys.ServiceDataKey, value);
		}
	}

	public CBUUID[]? ServiceUuids
	{
		get
		{
			return GetArray<CBUUID>(AdvertisementDataKeys.ServiceUuidsKey);
		}
		set
		{
			SetArrayValue(AdvertisementDataKeys.ServiceUuidsKey, value);
		}
	}

	public CBUUID[]? OverflowServiceUuids
	{
		get
		{
			return GetArray<CBUUID>(AdvertisementDataKeys.OverflowServiceUuidsKey);
		}
		set
		{
			SetArrayValue(AdvertisementDataKeys.OverflowServiceUuidsKey, value);
		}
	}

	public NSNumber? TxPowerLevel
	{
		get
		{
			return base.Dictionary[AdvertisementDataKeys.TxPowerLevelKey] as NSNumber;
		}
		set
		{
			SetNativeValue(AdvertisementDataKeys.TxPowerLevelKey, value);
		}
	}

	public bool? IsConnectable
	{
		get
		{
			return GetBoolValue(AdvertisementDataKeys.IsConnectableKey);
		}
		set
		{
			SetBooleanValue(AdvertisementDataKeys.IsConnectableKey, value);
		}
	}

	public CBUUID[]? SolicitedServiceUuids
	{
		get
		{
			return GetArray<CBUUID>(AdvertisementDataKeys.SolicitedServiceUuidsKey);
		}
		set
		{
			SetArrayValue(AdvertisementDataKeys.SolicitedServiceUuidsKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public AdvertisementData()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public AdvertisementData(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
