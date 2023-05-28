using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
internal static class RestoredStateKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PeripheralsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScanOptionsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScanServicesKey;

	[Field("CBCentralManagerRestoredStatePeripheralsKey", "CoreBluetooth")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString PeripheralsKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_PeripheralsKey == null)
			{
				_PeripheralsKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBCentralManagerRestoredStatePeripheralsKey");
			}
			return _PeripheralsKey;
		}
	}

	[Field("CBCentralManagerRestoredStateScanOptionsKey", "CoreBluetooth")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString ScanOptionsKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_ScanOptionsKey == null)
			{
				_ScanOptionsKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBCentralManagerRestoredStateScanOptionsKey");
			}
			return _ScanOptionsKey;
		}
	}

	[Field("CBCentralManagerRestoredStateScanServicesKey", "CoreBluetooth")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString ScanServicesKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_ScanServicesKey == null)
			{
				_ScanServicesKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBCentralManagerRestoredStateScanServicesKey");
			}
			return _ScanServicesKey;
		}
	}
}
