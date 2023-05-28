using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Protocol]
[Register("CBPeripheralManagerDelegate", false)]
[Model]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public abstract class CBPeripheralManagerDelegate : NSObject, ICBPeripheralManagerDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected CBPeripheralManagerDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CBPeripheralManagerDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CBPeripheralManagerDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("peripheralManagerDidStartAdvertising:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AdvertisingStarted(CBPeripheralManager peripheral, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheralManager:central:didSubscribeToCharacteristic:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CharacteristicSubscribed(CBPeripheralManager peripheral, CBCentral central, CBCharacteristic characteristic)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheralManager:central:didUnsubscribeFromCharacteristic:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CharacteristicUnsubscribed(CBPeripheralManager peripheral, CBCentral central, CBCharacteristic characteristic)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheralManager:didOpenL2CAPChannel:error:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidOpenL2CapChannel(CBPeripheralManager peripheral, CBL2CapChannel? channel, NSError? error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheralManager:didPublishL2CAPChannel:error:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidPublishL2CapChannel(CBPeripheralManager peripheral, ushort psm, NSError? error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheralManager:didUnpublishL2CAPChannel:error:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidUnpublishL2CapChannel(CBPeripheralManager peripheral, ushort psm, NSError? error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheralManager:didReceiveReadRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReadRequestReceived(CBPeripheralManager peripheral, CBATTRequest request)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheralManagerIsReadyToUpdateSubscribers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReadyToUpdateSubscribers(CBPeripheralManager peripheral)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheralManager:didAddService:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ServiceAdded(CBPeripheralManager peripheral, CBService service, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheralManagerDidUpdateState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void StateUpdated(CBPeripheralManager peripheral);

	[Export("peripheralManager:willRestoreState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillRestoreState(CBPeripheralManager peripheral, NSDictionary dict)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheralManager:didReceiveWriteRequests:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WriteRequestsReceived(CBPeripheralManager peripheral, CBATTRequest[] requests)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
