using System;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MPSImageTransformProvider", WrapperType = typeof(MPSImageTransformProviderWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetTransform", Selector = "transformForSourceImage:handle:", ReturnType = typeof(MPSScaleTransform), ParameterType = new Type[]
{
	typeof(MPSImage),
	typeof(IMPSHandle)
}, ParameterByRef = new bool[] { false, false })]
public interface IMPSImageTransformProvider : INativeObject, IDisposable, INSCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("transformForSourceImage:handle:")]
	[Preserve(Conditional = true)]
	MPSScaleTransform GetTransform(MPSImage image, IMPSHandle? handle);
}
