using System;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MPSDeviceProvider", WrapperType = typeof(MPSDeviceProviderWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetMTLDevice", Selector = "mpsMTLDevice", ReturnType = typeof(IMTLDevice))]
public interface IMPSDeviceProvider : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("mpsMTLDevice")]
	[Preserve(Conditional = true)]
	IMTLDevice GetMTLDevice();
}
