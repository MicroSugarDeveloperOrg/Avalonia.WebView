using System;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Protocol(Name = "ICScannerDeviceDelegate", WrapperType = typeof(ICScannerDeviceDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBecomeAvailable", Selector = "scannerDeviceDidBecomeAvailable:", ParameterType = new Type[] { typeof(ICScannerDevice) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectFunctionalUnit", Selector = "scannerDevice:didSelectFunctionalUnit:error:", ParameterType = new Type[]
{
	typeof(ICScannerDevice),
	typeof(ICScannerFunctionalUnit),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidScanToUrl", Selector = "scannerDevice:didScanToURL:data:", ParameterType = new Type[]
{
	typeof(ICScannerDevice),
	typeof(NSUrl),
	typeof(NSData)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidScanToUrl", Selector = "scannerDevice:didScanToURL:", ParameterType = new Type[]
{
	typeof(ICScannerDevice),
	typeof(NSUrl)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidScanToBandData", Selector = "scannerDevice:didScanToBandData:", ParameterType = new Type[]
{
	typeof(ICScannerDevice),
	typeof(ICScannerBandData)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCompleteOverviewScan", Selector = "scannerDevice:didCompleteOverviewScanWithError:", ParameterType = new Type[]
{
	typeof(ICScannerDevice),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCompleteScan", Selector = "scannerDevice:didCompleteScanWithError:", ParameterType = new Type[]
{
	typeof(ICScannerDevice),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
public interface IICScannerDeviceDelegate : INativeObject, IDisposable, IICDeviceDelegate
{
}
