using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Protocol]
[Register("CBCentralManagerDelegate", false)]
[Model]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
public abstract class CBCentralManagerDelegate : NSObject, ICBCentralManagerDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected CBCentralManagerDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CBCentralManagerDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CBCentralManagerDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("centralManager:didConnectPeripheral:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ConnectedPeripheral(CBCentralManager central, CBPeripheral peripheral)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("centralManager:didDisconnectPeripheral:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisconnectedPeripheral(CBCentralManager central, CBPeripheral peripheral, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("centralManager:didDiscoverPeripheral:advertisementData:RSSI:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DiscoveredPeripheral(CBCentralManager central, CBPeripheral peripheral, NSDictionary advertisementData, NSNumber RSSI)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("centralManager:didFailToConnectPeripheral:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FailedToConnectPeripheral(CBCentralManager central, CBPeripheral peripheral, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("centralManager:didRetrieveConnectedPeripherals:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.iOS, 8, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RetrievedConnectedPeripherals(CBCentralManager central, CBPeripheral[] peripherals)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("centralManager:didRetrievePeripherals:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.iOS, 8, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RetrievedPeripherals(CBCentralManager central, CBPeripheral[] peripherals)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("centralManagerDidUpdateState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void UpdatedState(CBCentralManager central);

	[Export("centralManager:willRestoreState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillRestoreState(CBCentralManager central, NSDictionary dict)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
