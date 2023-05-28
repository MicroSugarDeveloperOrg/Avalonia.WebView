using System;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

public static class CBCentralManagerDelegate_Extensions
{
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.iOS, 8, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RetrievedPeripherals(this ICBCentralManagerDelegate This, CBCentralManager central, CBPeripheral[] peripherals)
	{
		if (central == null)
		{
			throw new ArgumentNullException("central");
		}
		if (peripherals == null)
		{
			throw new ArgumentNullException("peripherals");
		}
		NSArray nSArray = NSArray.FromNSObjects(peripherals);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("centralManager:didRetrievePeripherals:"), central.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.iOS, 8, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RetrievedConnectedPeripherals(this ICBCentralManagerDelegate This, CBCentralManager central, CBPeripheral[] peripherals)
	{
		if (central == null)
		{
			throw new ArgumentNullException("central");
		}
		if (peripherals == null)
		{
			throw new ArgumentNullException("peripherals");
		}
		NSArray nSArray = NSArray.FromNSObjects(peripherals);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("centralManager:didRetrieveConnectedPeripherals:"), central.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DiscoveredPeripheral(this ICBCentralManagerDelegate This, CBCentralManager central, CBPeripheral peripheral, NSDictionary advertisementData, NSNumber RSSI)
	{
		if (central == null)
		{
			throw new ArgumentNullException("central");
		}
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (advertisementData == null)
		{
			throw new ArgumentNullException("advertisementData");
		}
		if (RSSI == null)
		{
			throw new ArgumentNullException("RSSI");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("centralManager:didDiscoverPeripheral:advertisementData:RSSI:"), central.Handle, peripheral.Handle, advertisementData.Handle, RSSI.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ConnectedPeripheral(this ICBCentralManagerDelegate This, CBCentralManager central, CBPeripheral peripheral)
	{
		if (central == null)
		{
			throw new ArgumentNullException("central");
		}
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("centralManager:didConnectPeripheral:"), central.Handle, peripheral.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FailedToConnectPeripheral(this ICBCentralManagerDelegate This, CBCentralManager central, CBPeripheral peripheral, NSError error)
	{
		if (central == null)
		{
			throw new ArgumentNullException("central");
		}
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("centralManager:didFailToConnectPeripheral:error:"), central.Handle, peripheral.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DisconnectedPeripheral(this ICBCentralManagerDelegate This, CBCentralManager central, CBPeripheral peripheral, NSError error)
	{
		if (central == null)
		{
			throw new ArgumentNullException("central");
		}
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("centralManager:didDisconnectPeripheral:error:"), central.Handle, peripheral.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillRestoreState(this ICBCentralManagerDelegate This, CBCentralManager central, NSDictionary dict)
	{
		if (central == null)
		{
			throw new ArgumentNullException("central");
		}
		if (dict == null)
		{
			throw new ArgumentNullException("dict");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("centralManager:willRestoreState:"), central.Handle, dict.Handle);
	}
}
