using System;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "CBCentralManagerDelegate", WrapperType = typeof(CBCentralManagerDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "UpdatedState", Selector = "centralManagerDidUpdateState:", ParameterType = new Type[] { typeof(CBCentralManager) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RetrievedPeripherals", Selector = "centralManager:didRetrievePeripherals:", ParameterType = new Type[]
{
	typeof(CBCentralManager),
	typeof(CBPeripheral[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RetrievedConnectedPeripherals", Selector = "centralManager:didRetrieveConnectedPeripherals:", ParameterType = new Type[]
{
	typeof(CBCentralManager),
	typeof(CBPeripheral[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DiscoveredPeripheral", Selector = "centralManager:didDiscoverPeripheral:advertisementData:RSSI:", ParameterType = new Type[]
{
	typeof(CBCentralManager),
	typeof(CBPeripheral),
	typeof(NSDictionary),
	typeof(NSNumber)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConnectedPeripheral", Selector = "centralManager:didConnectPeripheral:", ParameterType = new Type[]
{
	typeof(CBCentralManager),
	typeof(CBPeripheral)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToConnectPeripheral", Selector = "centralManager:didFailToConnectPeripheral:error:", ParameterType = new Type[]
{
	typeof(CBCentralManager),
	typeof(CBPeripheral),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DisconnectedPeripheral", Selector = "centralManager:didDisconnectPeripheral:error:", ParameterType = new Type[]
{
	typeof(CBCentralManager),
	typeof(CBPeripheral),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillRestoreState", Selector = "centralManager:willRestoreState:", ParameterType = new Type[]
{
	typeof(CBCentralManager),
	typeof(NSDictionary)
}, ParameterByRef = new bool[] { false, false })]
public interface ICBCentralManagerDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("centralManagerDidUpdateState:")]
	[Preserve(Conditional = true)]
	void UpdatedState(CBCentralManager central);
}
