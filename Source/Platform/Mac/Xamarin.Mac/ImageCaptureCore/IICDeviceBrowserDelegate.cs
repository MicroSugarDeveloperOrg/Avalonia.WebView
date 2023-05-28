using System;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Protocol(Name = "ICDeviceBrowserDelegate", WrapperType = typeof(ICDeviceBrowserDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidAddDevice", Selector = "deviceBrowser:didAddDevice:moreComing:", ParameterType = new Type[]
{
	typeof(ICDeviceBrowser),
	typeof(ICDevice),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidRemoveDevice", Selector = "deviceBrowser:didRemoveDevice:moreGoing:", ParameterType = new Type[]
{
	typeof(ICDeviceBrowser),
	typeof(ICDevice),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DeviceDidChangeName", Selector = "deviceBrowser:deviceDidChangeName:", ParameterType = new Type[]
{
	typeof(ICDeviceBrowser),
	typeof(ICDevice)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DeviceDidChangeSharingState", Selector = "deviceBrowser:deviceDidChangeSharingState:", ParameterType = new Type[]
{
	typeof(ICDeviceBrowser),
	typeof(ICDevice)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RequestsSelectDevice", Selector = "deviceBrowser:requestsSelectDevice:", ParameterType = new Type[]
{
	typeof(ICDeviceBrowser),
	typeof(ICDevice)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEnumerateLocalDevices", Selector = "deviceBrowserDidEnumerateLocalDevices:", ParameterType = new Type[] { typeof(ICDeviceBrowser) }, ParameterByRef = new bool[] { false })]
public interface IICDeviceBrowserDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("deviceBrowser:didAddDevice:moreComing:")]
	[Preserve(Conditional = true)]
	void DidAddDevice(ICDeviceBrowser browser, ICDevice device, bool moreComing);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("deviceBrowser:didRemoveDevice:moreGoing:")]
	[Preserve(Conditional = true)]
	void DidRemoveDevice(ICDeviceBrowser browser, ICDevice device, bool moreGoing);
}
