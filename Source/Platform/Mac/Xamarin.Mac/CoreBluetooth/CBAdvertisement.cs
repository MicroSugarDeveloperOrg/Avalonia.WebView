using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
public static class CBAdvertisement
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DataLocalNameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DataManufacturerDataKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DataOverflowServiceUUIDsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DataServiceDataKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DataServiceUUIDsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DataSolicitedServiceUUIDsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DataTxPowerLevelKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsConnectable;

	[Field("CBAdvertisementDataLocalNameKey", "CoreBluetooth")]
	public static NSString DataLocalNameKey
	{
		get
		{
			if (_DataLocalNameKey == null)
			{
				_DataLocalNameKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBAdvertisementDataLocalNameKey");
			}
			return _DataLocalNameKey;
		}
	}

	[Field("CBAdvertisementDataManufacturerDataKey", "CoreBluetooth")]
	public static NSString DataManufacturerDataKey
	{
		get
		{
			if (_DataManufacturerDataKey == null)
			{
				_DataManufacturerDataKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBAdvertisementDataManufacturerDataKey");
			}
			return _DataManufacturerDataKey;
		}
	}

	[Field("CBAdvertisementDataOverflowServiceUUIDsKey", "CoreBluetooth")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString DataOverflowServiceUUIDsKey
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_DataOverflowServiceUUIDsKey == null)
			{
				_DataOverflowServiceUUIDsKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBAdvertisementDataOverflowServiceUUIDsKey");
			}
			return _DataOverflowServiceUUIDsKey;
		}
	}

	[Field("CBAdvertisementDataServiceDataKey", "CoreBluetooth")]
	public static NSString DataServiceDataKey
	{
		get
		{
			if (_DataServiceDataKey == null)
			{
				_DataServiceDataKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBAdvertisementDataServiceDataKey");
			}
			return _DataServiceDataKey;
		}
	}

	[Field("CBAdvertisementDataServiceUUIDsKey", "CoreBluetooth")]
	public static NSString DataServiceUUIDsKey
	{
		get
		{
			if (_DataServiceUUIDsKey == null)
			{
				_DataServiceUUIDsKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBAdvertisementDataServiceUUIDsKey");
			}
			return _DataServiceUUIDsKey;
		}
	}

	[Field("CBAdvertisementDataSolicitedServiceUUIDsKey", "CoreBluetooth")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString DataSolicitedServiceUUIDsKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_DataSolicitedServiceUUIDsKey == null)
			{
				_DataSolicitedServiceUUIDsKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBAdvertisementDataSolicitedServiceUUIDsKey");
			}
			return _DataSolicitedServiceUUIDsKey;
		}
	}

	[Field("CBAdvertisementDataTxPowerLevelKey", "CoreBluetooth")]
	public static NSString DataTxPowerLevelKey
	{
		get
		{
			if (_DataTxPowerLevelKey == null)
			{
				_DataTxPowerLevelKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBAdvertisementDataTxPowerLevelKey");
			}
			return _DataTxPowerLevelKey;
		}
	}

	[Field("CBAdvertisementDataIsConnectable", "CoreBluetooth")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString IsConnectable
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_IsConnectable == null)
			{
				_IsConnectable = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBAdvertisementDataIsConnectable");
			}
			return _IsConnectable;
		}
	}
}
