using System;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Protocol(Name = "CBPeripheralManagerDelegate", WrapperType = typeof(CBPeripheralManagerDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "StateUpdated", Selector = "peripheralManagerDidUpdateState:", ParameterType = new Type[] { typeof(CBPeripheralManager) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillRestoreState", Selector = "peripheralManager:willRestoreState:", ParameterType = new Type[]
{
	typeof(CBPeripheralManager),
	typeof(NSDictionary)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AdvertisingStarted", Selector = "peripheralManagerDidStartAdvertising:error:", ParameterType = new Type[]
{
	typeof(CBPeripheralManager),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ServiceAdded", Selector = "peripheralManager:didAddService:error:", ParameterType = new Type[]
{
	typeof(CBPeripheralManager),
	typeof(CBService),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CharacteristicSubscribed", Selector = "peripheralManager:central:didSubscribeToCharacteristic:", ParameterType = new Type[]
{
	typeof(CBPeripheralManager),
	typeof(CBCentral),
	typeof(CBCharacteristic)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CharacteristicUnsubscribed", Selector = "peripheralManager:central:didUnsubscribeFromCharacteristic:", ParameterType = new Type[]
{
	typeof(CBPeripheralManager),
	typeof(CBCentral),
	typeof(CBCharacteristic)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReadRequestReceived", Selector = "peripheralManager:didReceiveReadRequest:", ParameterType = new Type[]
{
	typeof(CBPeripheralManager),
	typeof(CBATTRequest)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteRequestsReceived", Selector = "peripheralManager:didReceiveWriteRequests:", ParameterType = new Type[]
{
	typeof(CBPeripheralManager),
	typeof(CBATTRequest[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReadyToUpdateSubscribers", Selector = "peripheralManagerIsReadyToUpdateSubscribers:", ParameterType = new Type[] { typeof(CBPeripheralManager) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOpenL2CapChannel", Selector = "peripheralManager:didOpenL2CAPChannel:error:", ParameterType = new Type[]
{
	typeof(CBPeripheralManager),
	typeof(CBL2CapChannel),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUnpublishL2CapChannel", Selector = "peripheralManager:didUnpublishL2CAPChannel:error:", ParameterType = new Type[]
{
	typeof(CBPeripheralManager),
	typeof(ushort),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPublishL2CapChannel", Selector = "peripheralManager:didPublishL2CAPChannel:error:", ParameterType = new Type[]
{
	typeof(CBPeripheralManager),
	typeof(ushort),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
public interface ICBPeripheralManagerDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("peripheralManagerDidUpdateState:")]
	[Preserve(Conditional = true)]
	void StateUpdated(CBPeripheralManager peripheral);
}
