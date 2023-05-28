using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

internal static class CBConnectPeripheralOptionsKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NotifyOnConnectionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NotifyOnDisconnectionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NotifyOnNotificationKey;

	[Field("CBConnectPeripheralOptionNotifyOnConnectionKey", "CoreBluetooth")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString NotifyOnConnectionKey
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_NotifyOnConnectionKey == null)
			{
				_NotifyOnConnectionKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBConnectPeripheralOptionNotifyOnConnectionKey");
			}
			return _NotifyOnConnectionKey;
		}
	}

	[Field("CBConnectPeripheralOptionNotifyOnDisconnectionKey", "CoreBluetooth")]
	public static NSString NotifyOnDisconnectionKey
	{
		get
		{
			if (_NotifyOnDisconnectionKey == null)
			{
				_NotifyOnDisconnectionKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBConnectPeripheralOptionNotifyOnDisconnectionKey");
			}
			return _NotifyOnDisconnectionKey;
		}
	}

	[Field("CBConnectPeripheralOptionNotifyOnNotificationKey", "CoreBluetooth")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString NotifyOnNotificationKey
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_NotifyOnNotificationKey == null)
			{
				_NotifyOnNotificationKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBConnectPeripheralOptionNotifyOnNotificationKey");
			}
			return _NotifyOnNotificationKey;
		}
	}
}
