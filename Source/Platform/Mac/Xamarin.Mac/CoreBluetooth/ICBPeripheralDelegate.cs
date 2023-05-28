using System;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "CBPeripheralDelegate", WrapperType = typeof(CBPeripheralDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RssiUpdated", Selector = "peripheralDidUpdateRSSI:error:", ParameterType = new Type[]
{
	typeof(CBPeripheral),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RssiRead", Selector = "peripheral:didReadRSSI:error:", ParameterType = new Type[]
{
	typeof(CBPeripheral),
	typeof(NSNumber),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DiscoveredService", Selector = "peripheral:didDiscoverServices:", ParameterType = new Type[]
{
	typeof(CBPeripheral),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DiscoveredIncludedService", Selector = "peripheral:didDiscoverIncludedServicesForService:error:", ParameterType = new Type[]
{
	typeof(CBPeripheral),
	typeof(CBService),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DiscoveredCharacteristic", Selector = "peripheral:didDiscoverCharacteristicsForService:error:", ParameterType = new Type[]
{
	typeof(CBPeripheral),
	typeof(CBService),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdatedCharacterteristicValue", Selector = "peripheral:didUpdateValueForCharacteristic:error:", ParameterType = new Type[]
{
	typeof(CBPeripheral),
	typeof(CBCharacteristic),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WroteCharacteristicValue", Selector = "peripheral:didWriteValueForCharacteristic:error:", ParameterType = new Type[]
{
	typeof(CBPeripheral),
	typeof(CBCharacteristic),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdatedNotificationState", Selector = "peripheral:didUpdateNotificationStateForCharacteristic:error:", ParameterType = new Type[]
{
	typeof(CBPeripheral),
	typeof(CBCharacteristic),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DiscoveredDescriptor", Selector = "peripheral:didDiscoverDescriptorsForCharacteristic:error:", ParameterType = new Type[]
{
	typeof(CBPeripheral),
	typeof(CBCharacteristic),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdatedValue", Selector = "peripheral:didUpdateValueForDescriptor:error:", ParameterType = new Type[]
{
	typeof(CBPeripheral),
	typeof(CBDescriptor),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WroteDescriptorValue", Selector = "peripheral:didWriteValueForDescriptor:error:", ParameterType = new Type[]
{
	typeof(CBPeripheral),
	typeof(CBDescriptor),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "InvalidatedService", Selector = "peripheralDidInvalidateServices:", ParameterType = new Type[] { typeof(CBPeripheral) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdatedName", Selector = "peripheralDidUpdateName:", ParameterType = new Type[] { typeof(CBPeripheral) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ModifiedServices", Selector = "peripheral:didModifyServices:", ParameterType = new Type[]
{
	typeof(CBPeripheral),
	typeof(CBService[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOpenL2CapChannel", Selector = "peripheral:didOpenL2CAPChannel:error:", ParameterType = new Type[]
{
	typeof(CBPeripheral),
	typeof(CBL2CapChannel),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsReadyToSendWriteWithoutResponse", Selector = "peripheralIsReadyToSendWriteWithoutResponse:", ParameterType = new Type[] { typeof(CBPeripheral) }, ParameterByRef = new bool[] { false })]
public interface ICBPeripheralDelegate : INativeObject, IDisposable
{
}
