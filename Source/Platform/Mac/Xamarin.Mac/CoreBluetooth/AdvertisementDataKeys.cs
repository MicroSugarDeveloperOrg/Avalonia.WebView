using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
internal static class AdvertisementDataKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsConnectableKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LocalNameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ManufacturerDataKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OverflowServiceUuidsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ServiceDataKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ServiceUuidsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SolicitedServiceUuidsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TxPowerLevelKey;

	[Field("CBAdvertisementDataIsConnectable", "CoreBluetooth")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString IsConnectableKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_IsConnectableKey == null)
			{
				_IsConnectableKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBAdvertisementDataIsConnectable");
			}
			return _IsConnectableKey;
		}
	}

	[Field("CBAdvertisementDataLocalNameKey", "CoreBluetooth")]
	public static NSString LocalNameKey
	{
		get
		{
			if (_LocalNameKey == null)
			{
				_LocalNameKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBAdvertisementDataLocalNameKey");
			}
			return _LocalNameKey;
		}
	}

	[Field("CBAdvertisementDataManufacturerDataKey", "CoreBluetooth")]
	public static NSString ManufacturerDataKey
	{
		get
		{
			if (_ManufacturerDataKey == null)
			{
				_ManufacturerDataKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBAdvertisementDataManufacturerDataKey");
			}
			return _ManufacturerDataKey;
		}
	}

	[Field("CBAdvertisementDataOverflowServiceUUIDsKey", "CoreBluetooth")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString OverflowServiceUuidsKey
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_OverflowServiceUuidsKey == null)
			{
				_OverflowServiceUuidsKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBAdvertisementDataOverflowServiceUUIDsKey");
			}
			return _OverflowServiceUuidsKey;
		}
	}

	[Field("CBAdvertisementDataServiceDataKey", "CoreBluetooth")]
	public static NSString ServiceDataKey
	{
		get
		{
			if (_ServiceDataKey == null)
			{
				_ServiceDataKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBAdvertisementDataServiceDataKey");
			}
			return _ServiceDataKey;
		}
	}

	[Field("CBAdvertisementDataServiceUUIDsKey", "CoreBluetooth")]
	public static NSString ServiceUuidsKey
	{
		get
		{
			if (_ServiceUuidsKey == null)
			{
				_ServiceUuidsKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBAdvertisementDataServiceUUIDsKey");
			}
			return _ServiceUuidsKey;
		}
	}

	[Field("CBAdvertisementDataSolicitedServiceUUIDsKey", "CoreBluetooth")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString SolicitedServiceUuidsKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_SolicitedServiceUuidsKey == null)
			{
				_SolicitedServiceUuidsKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBAdvertisementDataSolicitedServiceUUIDsKey");
			}
			return _SolicitedServiceUuidsKey;
		}
	}

	[Field("CBAdvertisementDataTxPowerLevelKey", "CoreBluetooth")]
	public static NSString TxPowerLevelKey
	{
		get
		{
			if (_TxPowerLevelKey == null)
			{
				_TxPowerLevelKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBAdvertisementDataTxPowerLevelKey");
			}
			return _TxPowerLevelKey;
		}
	}
}
