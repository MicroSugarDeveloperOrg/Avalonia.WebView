using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
public class PeripheralScanningOptions : DictionaryContainer
{
	public bool AllowDuplicatesKey
	{
		get
		{
			bool? boolValue = GetBoolValue(CBCentralManager.ScanOptionAllowDuplicatesKey);
			return boolValue.HasValue && boolValue.Value;
		}
		set
		{
			SetNumberValue(CBCentralManager.ScanOptionAllowDuplicatesKey, value ? 1 : 0);
		}
	}

	[Preserve(Conditional = true)]
	public PeripheralScanningOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public PeripheralScanningOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
