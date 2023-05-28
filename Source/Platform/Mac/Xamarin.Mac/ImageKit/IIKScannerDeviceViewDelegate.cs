using System;
using Foundation;
using ImageCaptureCore;
using ObjCRuntime;

namespace ImageKit;

[Protocol(Name = "IKScannerDeviceViewDelegate", WrapperType = typeof(IKScannerDeviceViewDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidScan", Selector = "scannerDeviceView:didScanToURL:fileData:error:", ParameterType = new Type[]
{
	typeof(IKScannerDeviceView),
	typeof(NSUrl),
	typeof(NSData),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEncounterError", Selector = "scannerDeviceView:didEncounterError:", ParameterType = new Type[]
{
	typeof(IKScannerDeviceView),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidScanToUrl", Selector = "scannerDeviceView:didScanToURL:error:", ParameterType = new Type[]
{
	typeof(IKScannerDeviceView),
	typeof(NSUrl),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidScanToBandData", Selector = "scannerDeviceView:didScanToBandData:scanInfo:error:", ParameterType = new Type[]
{
	typeof(IKScannerDeviceView),
	typeof(ICScannerBandData),
	typeof(NSDictionary),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false, false })]
public interface IIKScannerDeviceViewDelegate : INativeObject, IDisposable
{
}
