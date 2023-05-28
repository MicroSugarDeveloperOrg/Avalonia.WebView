using System;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

public static class CBPeripheralDelegate_Extensions
{
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'RssiRead' instead.")]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'RssiRead' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RssiUpdated(this ICBPeripheralDelegate This, CBPeripheral peripheral, NSError error)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheralDidUpdateRSSI:error:"), peripheral.Handle, error.Handle);
	}

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RssiRead(this ICBPeripheralDelegate This, CBPeripheral peripheral, NSNumber rssi, NSError error)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (rssi == null)
		{
			throw new ArgumentNullException("rssi");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheral:didReadRSSI:error:"), peripheral.Handle, rssi.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DiscoveredService(this ICBPeripheralDelegate This, CBPeripheral peripheral, NSError error)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheral:didDiscoverServices:"), peripheral.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DiscoveredIncludedService(this ICBPeripheralDelegate This, CBPeripheral peripheral, CBService service, NSError error)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (service == null)
		{
			throw new ArgumentNullException("service");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheral:didDiscoverIncludedServicesForService:error:"), peripheral.Handle, service.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DiscoveredCharacteristic(this ICBPeripheralDelegate This, CBPeripheral peripheral, CBService service, NSError error)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (service == null)
		{
			throw new ArgumentNullException("service");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheral:didDiscoverCharacteristicsForService:error:"), peripheral.Handle, service.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UpdatedCharacterteristicValue(this ICBPeripheralDelegate This, CBPeripheral peripheral, CBCharacteristic characteristic, NSError error)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (characteristic == null)
		{
			throw new ArgumentNullException("characteristic");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheral:didUpdateValueForCharacteristic:error:"), peripheral.Handle, characteristic.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WroteCharacteristicValue(this ICBPeripheralDelegate This, CBPeripheral peripheral, CBCharacteristic characteristic, NSError error)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (characteristic == null)
		{
			throw new ArgumentNullException("characteristic");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheral:didWriteValueForCharacteristic:error:"), peripheral.Handle, characteristic.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UpdatedNotificationState(this ICBPeripheralDelegate This, CBPeripheral peripheral, CBCharacteristic characteristic, NSError error)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (characteristic == null)
		{
			throw new ArgumentNullException("characteristic");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheral:didUpdateNotificationStateForCharacteristic:error:"), peripheral.Handle, characteristic.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DiscoveredDescriptor(this ICBPeripheralDelegate This, CBPeripheral peripheral, CBCharacteristic characteristic, NSError error)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (characteristic == null)
		{
			throw new ArgumentNullException("characteristic");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheral:didDiscoverDescriptorsForCharacteristic:error:"), peripheral.Handle, characteristic.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UpdatedValue(this ICBPeripheralDelegate This, CBPeripheral peripheral, CBDescriptor descriptor, NSError error)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheral:didUpdateValueForDescriptor:error:"), peripheral.Handle, descriptor.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WroteDescriptorValue(this ICBPeripheralDelegate This, CBPeripheral peripheral, CBDescriptor descriptor, NSError error)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheral:didWriteValueForDescriptor:error:"), peripheral.Handle, descriptor.Handle, error.Handle);
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 6, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.iOS, 8, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void InvalidatedService(this ICBPeripheralDelegate This, CBPeripheral peripheral)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("peripheralDidInvalidateServices:"), peripheral.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UpdatedName(this ICBPeripheralDelegate This, CBPeripheral peripheral)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("peripheralDidUpdateName:"), peripheral.Handle);
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ModifiedServices(this ICBPeripheralDelegate This, CBPeripheral peripheral, CBService[] services)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (services == null)
		{
			throw new ArgumentNullException("services");
		}
		NSArray nSArray = NSArray.FromNSObjects(services);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheral:didModifyServices:"), peripheral.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidOpenL2CapChannel(this ICBPeripheralDelegate This, CBPeripheral peripheral, CBL2CapChannel? channel, NSError? error)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheral:didOpenL2CAPChannel:error:"), peripheral.Handle, channel?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void IsReadyToSendWriteWithoutResponse(this ICBPeripheralDelegate This, CBPeripheral peripheral)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("peripheralIsReadyToSendWriteWithoutResponse:"), peripheral.Handle);
	}
}
