using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Protocol]
[Register("CBPeripheralDelegate", false)]
[Model]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
public class CBPeripheralDelegate : NSObject, ICBPeripheralDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CBPeripheralDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CBPeripheralDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CBPeripheralDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("peripheral:didOpenL2CAPChannel:error:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidOpenL2CapChannel(CBPeripheral peripheral, CBL2CapChannel? channel, NSError? error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheral:didDiscoverCharacteristicsForService:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DiscoveredCharacteristic(CBPeripheral peripheral, CBService service, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheral:didDiscoverDescriptorsForCharacteristic:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DiscoveredDescriptor(CBPeripheral peripheral, CBCharacteristic characteristic, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheral:didDiscoverIncludedServicesForService:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DiscoveredIncludedService(CBPeripheral peripheral, CBService service, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheral:didDiscoverServices:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DiscoveredService(CBPeripheral peripheral, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheralDidInvalidateServices:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 6, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.iOS, 8, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidatedService(CBPeripheral peripheral)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheralIsReadyToSendWriteWithoutResponse:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void IsReadyToSendWriteWithoutResponse(CBPeripheral peripheral)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheral:didModifyServices:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ModifiedServices(CBPeripheral peripheral, CBService[] services)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheral:didReadRSSI:error:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RssiRead(CBPeripheral peripheral, NSNumber rssi, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheralDidUpdateRSSI:error:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'RssiRead' instead.")]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'RssiRead' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RssiUpdated(CBPeripheral peripheral, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheral:didUpdateValueForCharacteristic:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdatedCharacterteristicValue(CBPeripheral peripheral, CBCharacteristic characteristic, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheralDidUpdateName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdatedName(CBPeripheral peripheral)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheral:didUpdateNotificationStateForCharacteristic:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdatedNotificationState(CBPeripheral peripheral, CBCharacteristic characteristic, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheral:didUpdateValueForDescriptor:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdatedValue(CBPeripheral peripheral, CBDescriptor descriptor, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheral:didWriteValueForCharacteristic:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WroteCharacteristicValue(CBPeripheral peripheral, CBCharacteristic characteristic, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("peripheral:didWriteValueForDescriptor:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WroteDescriptorValue(CBPeripheral peripheral, CBDescriptor descriptor, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
