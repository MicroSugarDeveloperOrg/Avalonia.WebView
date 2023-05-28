using System;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

public static class CBPeripheralManagerDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillRestoreState(this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, NSDictionary dict)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (dict == null)
		{
			throw new ArgumentNullException("dict");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheralManager:willRestoreState:"), peripheral.Handle, dict.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void AdvertisingStarted(this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, NSError error)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheralManagerDidStartAdvertising:error:"), peripheral.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ServiceAdded(this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, CBService service, NSError error)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheralManager:didAddService:error:"), peripheral.Handle, service.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CharacteristicSubscribed(this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, CBCentral central, CBCharacteristic characteristic)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (central == null)
		{
			throw new ArgumentNullException("central");
		}
		if (characteristic == null)
		{
			throw new ArgumentNullException("characteristic");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheralManager:central:didSubscribeToCharacteristic:"), peripheral.Handle, central.Handle, characteristic.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CharacteristicUnsubscribed(this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, CBCentral central, CBCharacteristic characteristic)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (central == null)
		{
			throw new ArgumentNullException("central");
		}
		if (characteristic == null)
		{
			throw new ArgumentNullException("characteristic");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheralManager:central:didUnsubscribeFromCharacteristic:"), peripheral.Handle, central.Handle, characteristic.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ReadRequestReceived(this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, CBATTRequest request)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheralManager:didReceiveReadRequest:"), peripheral.Handle, request.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WriteRequestsReceived(this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, CBATTRequest[] requests)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (requests == null)
		{
			throw new ArgumentNullException("requests");
		}
		NSArray nSArray = NSArray.FromNSObjects(requests);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheralManager:didReceiveWriteRequests:"), peripheral.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ReadyToUpdateSubscribers(this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("peripheralManagerIsReadyToUpdateSubscribers:"), peripheral.Handle);
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidOpenL2CapChannel(this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, CBL2CapChannel? channel, NSError? error)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("peripheralManager:didOpenL2CAPChannel:error:"), peripheral.Handle, channel?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidUnpublishL2CapChannel(this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, ushort psm, NSError? error)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		Messaging.void_objc_msgSend_IntPtr_UInt16_IntPtr(This.Handle, Selector.GetHandle("peripheralManager:didUnpublishL2CAPChannel:error:"), peripheral.Handle, psm, error?.Handle ?? IntPtr.Zero);
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidPublishL2CapChannel(this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, ushort psm, NSError? error)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		Messaging.void_objc_msgSend_IntPtr_UInt16_IntPtr(This.Handle, Selector.GetHandle("peripheralManager:didPublishL2CAPChannel:error:"), peripheral.Handle, psm, error?.Handle ?? IntPtr.Zero);
	}
}
