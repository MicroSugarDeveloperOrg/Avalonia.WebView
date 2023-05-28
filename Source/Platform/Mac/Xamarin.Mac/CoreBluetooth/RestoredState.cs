using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
public class RestoredState : DictionaryContainer
{
	public CBPeripheral[]? Peripherals
	{
		get
		{
			return GetArray<CBPeripheral>(RestoredStateKeys.PeripheralsKey);
		}
		set
		{
			SetArrayValue(RestoredStateKeys.PeripheralsKey, value);
		}
	}

	public CBPeripheral[]? ScanServices
	{
		get
		{
			return GetArray<CBPeripheral>(RestoredStateKeys.ScanServicesKey);
		}
		set
		{
			SetArrayValue(RestoredStateKeys.ScanServicesKey, value);
		}
	}

	public PeripheralScanningOptions? ScanOptions
	{
		get
		{
			return GetStrongDictionary<PeripheralScanningOptions>(RestoredStateKeys.ScanOptionsKey);
		}
		set
		{
			SetNativeValue(RestoredStateKeys.ScanOptionsKey, value.GetDictionary());
		}
	}

	[Preserve(Conditional = true)]
	public RestoredState()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public RestoredState(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
