using System;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Protocol(Name = "ICDeviceDelegate", WrapperType = typeof(ICDeviceDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidRemoveDevice", Selector = "didRemoveDevice:", ParameterType = new Type[] { typeof(ICDevice) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOpenSession", Selector = "device:didOpenSessionWithError:", ParameterType = new Type[]
{
	typeof(ICDevice),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBecomeReady", Selector = "deviceDidBecomeReady:", ParameterType = new Type[] { typeof(ICDevice) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCloseSession", Selector = "device:didCloseSessionWithError:", ParameterType = new Type[]
{
	typeof(ICDevice),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeName", Selector = "deviceDidChangeName:", ParameterType = new Type[] { typeof(ICDevice) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeSharingState", Selector = "deviceDidChangeSharingState:", ParameterType = new Type[] { typeof(ICDevice) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveStatusInformation", Selector = "device:didReceiveStatusInformation:", ParameterType = new Type[]
{
	typeof(ICDevice),
	typeof(NSDictionary<NSString, NSObject>)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEncounterError", Selector = "device:didEncounterError:", ParameterType = new Type[]
{
	typeof(ICDevice),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveButtonPress", Selector = "device:didReceiveButtonPress:", ParameterType = new Type[]
{
	typeof(ICDevice),
	typeof(NSString)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveCustomNotification", Selector = "device:didReceiveCustomNotification:data:", ParameterType = new Type[]
{
	typeof(ICDevice),
	typeof(NSDictionary<NSString, NSObject>),
	typeof(NSData)
}, ParameterByRef = new bool[] { false, false, false })]
public interface IICDeviceDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("didRemoveDevice:")]
	[Preserve(Conditional = true)]
	void DidRemoveDevice(ICDevice device);
}
