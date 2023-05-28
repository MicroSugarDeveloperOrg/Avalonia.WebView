using System;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Protocol(Name = "MPSNDArrayAllocator", WrapperType = typeof(MPSNDArrayAllocatorWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AllocateArray", Selector = "arrayForCommandBuffer:arrayDescriptor:kernel:", ReturnType = typeof(MPSNDArray), ParameterType = new Type[]
{
	typeof(IMTLCommandBuffer),
	typeof(MPSNDArrayDescriptor),
	typeof(MPSKernel)
}, ParameterByRef = new bool[] { false, false, false })]
public interface IMPSNDArrayAllocator : INativeObject, IDisposable, INSCoding, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("arrayForCommandBuffer:arrayDescriptor:kernel:")]
	[Preserve(Conditional = true)]
	MPSNDArray AllocateArray(IMTLCommandBuffer cmdBuf, MPSNDArrayDescriptor descriptor, MPSKernel kernel);
}
