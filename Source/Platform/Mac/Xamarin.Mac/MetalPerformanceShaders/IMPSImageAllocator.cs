using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MPSImageAllocator", WrapperType = typeof(MPSImageAllocatorWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetImage", Selector = "imageForCommandBuffer:imageDescriptor:kernel:", ReturnType = typeof(MPSImage), ParameterType = new Type[]
{
	typeof(IMTLCommandBuffer),
	typeof(MPSImageDescriptor),
	typeof(MPSKernel)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetImageBatch", Selector = "imageBatchForCommandBuffer:imageDescriptor:kernel:count:", ReturnType = typeof(NSArray<MPSImage>), ParameterType = new Type[]
{
	typeof(IMTLCommandBuffer),
	typeof(MPSImageDescriptor),
	typeof(MPSKernel),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false })]
public interface IMPSImageAllocator : INativeObject, IDisposable, INSCoding, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("imageForCommandBuffer:imageDescriptor:kernel:")]
	[Preserve(Conditional = true)]
	MPSImage GetImage(IMTLCommandBuffer cmdBuf, MPSImageDescriptor descriptor, MPSKernel kernel);
}
