using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLComputeCommandEncoder", WrapperType = typeof(MTLComputeCommandEncoderWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetComputePipelineState", Selector = "setComputePipelineState:", ParameterType = new Type[] { typeof(IMTLComputePipelineState) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBuffer", Selector = "setBuffer:offset:atIndex:", ParameterType = new Type[]
{
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTexture", Selector = "setTexture:atIndex:", ParameterType = new Type[]
{
	typeof(IMTLTexture),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetSamplerState", Selector = "setSamplerState:atIndex:", ParameterType = new Type[]
{
	typeof(IMTLSamplerState),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetSamplerState", Selector = "setSamplerState:lodMinClamp:lodMaxClamp:atIndex:", ParameterType = new Type[]
{
	typeof(IMTLSamplerState),
	typeof(float),
	typeof(float),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetThreadgroupMemoryLength", Selector = "setThreadgroupMemoryLength:atIndex:", ParameterType = new Type[]
{
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DispatchThreadgroups", Selector = "dispatchThreadgroups:threadsPerThreadgroup:", ParameterType = new Type[]
{
	typeof(MTLSize),
	typeof(MTLSize)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DispatchThreadgroups", Selector = "dispatchThreadgroupsWithIndirectBuffer:indirectBufferOffset:threadsPerThreadgroup:", ParameterType = new Type[]
{
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(MTLSize)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBuffers", Selector = "setBuffers:offsets:withRange:", ParameterType = new Type[]
{
	typeof(IMTLBuffer[]),
	typeof(IntPtr),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetSamplerStates", Selector = "setSamplerStates:lodMinClamps:lodMaxClamps:withRange:", ParameterType = new Type[]
{
	typeof(IMTLSamplerState[]),
	typeof(IntPtr),
	typeof(IntPtr),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetSamplerStates", Selector = "setSamplerStates:withRange:", ParameterType = new Type[]
{
	typeof(IMTLSamplerState[]),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTextures", Selector = "setTextures:withRange:", ParameterType = new Type[]
{
	typeof(IMTLTexture[]),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBufferOffset", Selector = "setBufferOffset:atIndex:", ParameterType = new Type[]
{
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBytes", Selector = "setBytes:length:atIndex:", ParameterType = new Type[]
{
	typeof(IntPtr),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetStage", Selector = "setStageInRegion:", ParameterType = new Type[] { typeof(MTLRegion) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetStageInRegion", Selector = "setStageInRegionWithIndirectBuffer:indirectBufferOffset:", ParameterType = new Type[]
{
	typeof(IMTLBuffer),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Update", Selector = "updateFence:", ParameterType = new Type[] { typeof(IMTLFence) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Wait", Selector = "waitForFence:", ParameterType = new Type[] { typeof(IMTLFence) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DispatchThreads", Selector = "dispatchThreads:threadsPerThreadgroup:", ParameterType = new Type[]
{
	typeof(MTLSize),
	typeof(MTLSize)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UseResource", Selector = "useResource:usage:", ParameterType = new Type[]
{
	typeof(IMTLResource),
	typeof(MTLResourceUsage)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UseResources", Selector = "useResources:count:usage:", ParameterType = new Type[]
{
	typeof(IMTLResource[]),
	typeof(nuint),
	typeof(MTLResourceUsage)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UseHeap", Selector = "useHeap:", ParameterType = new Type[] { typeof(IMTLHeap) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UseHeaps", Selector = "useHeaps:count:", ParameterType = new Type[]
{
	typeof(IMTLHeap[]),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MemoryBarrier", Selector = "memoryBarrierWithScope:", ParameterType = new Type[] { typeof(MTLBarrierScope) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MemoryBarrier", Selector = "memoryBarrierWithResources:count:", ParameterType = new Type[]
{
	typeof(IMTLResource[]),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SampleCounters", Selector = "sampleCountersInBuffer:atSampleIndex:withBarrier:", ParameterType = new Type[]
{
	typeof(MTLCounterSampleBuffer),
	typeof(nuint),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "DispatchType", Selector = "dispatchType", PropertyType = typeof(MTLDispatchType), GetterSelector = "dispatchType", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLComputeCommandEncoder : INativeObject, IDisposable, IMTLCommandEncoder
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setComputePipelineState:")]
	[Preserve(Conditional = true)]
	void SetComputePipelineState(IMTLComputePipelineState state);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setBuffer:offset:atIndex:")]
	[Preserve(Conditional = true)]
	void SetBuffer(IMTLBuffer buffer, nuint offset, nuint index);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setTexture:atIndex:")]
	[Preserve(Conditional = true)]
	void SetTexture(IMTLTexture texture, nuint index);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setSamplerState:atIndex:")]
	[Preserve(Conditional = true)]
	void SetSamplerState(IMTLSamplerState sampler, nuint index);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setSamplerState:lodMinClamp:lodMaxClamp:atIndex:")]
	[Preserve(Conditional = true)]
	void SetSamplerState(IMTLSamplerState sampler, float lodMinClamp, float lodMaxClamp, nuint index);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setThreadgroupMemoryLength:atIndex:")]
	[Preserve(Conditional = true)]
	void SetThreadgroupMemoryLength(nuint length, nuint index);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("dispatchThreadgroups:threadsPerThreadgroup:")]
	[Preserve(Conditional = true)]
	void DispatchThreadgroups(MTLSize threadgroupsPerGrid, MTLSize threadsPerThreadgroup);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setBuffers:offsets:withRange:")]
	[Preserve(Conditional = true)]
	void SetBuffers(IMTLBuffer[] buffers, IntPtr offsets, NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setSamplerStates:lodMinClamps:lodMaxClamps:withRange:")]
	[Preserve(Conditional = true)]
	void SetSamplerStates(IMTLSamplerState[] samplers, IntPtr floatArrayPtrLodMinClamps, IntPtr floatArrayPtrLodMaxClamps, NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setSamplerStates:withRange:")]
	[Preserve(Conditional = true)]
	void SetSamplerStates(IMTLSamplerState[] samplers, NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setTextures:withRange:")]
	[Preserve(Conditional = true)]
	void SetTextures(IMTLTexture[] textures, NSRange range);

	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setBufferOffset:atIndex:")]
	[Preserve(Conditional = true)]
	void SetBufferOffset(nuint offset, nuint index);

	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setBytes:length:atIndex:")]
	[Preserve(Conditional = true)]
	void SetBytes(IntPtr bytes, nuint length, nuint index);
}
