using System;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Protocol(Name = "MPSHeapProvider", WrapperType = typeof(MPSHeapProviderWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNewHeap", Selector = "newHeapWithDescriptor:", ReturnType = typeof(IMTLHeap), ParameterType = new Type[] { typeof(MTLHeapDescriptor) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RetireHeap", Selector = "retireHeap:cacheDelay:", ParameterType = new Type[]
{
	typeof(IMTLHeap),
	typeof(double)
}, ParameterByRef = new bool[] { false, false })]
public interface IMPSHeapProvider : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newHeapWithDescriptor:")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLHeap? GetNewHeap(MTLHeapDescriptor descriptor);
}
