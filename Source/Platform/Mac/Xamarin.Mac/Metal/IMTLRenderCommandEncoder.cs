using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLRenderCommandEncoder", WrapperType = typeof(MTLRenderCommandEncoderWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetRenderPipelineState", Selector = "setRenderPipelineState:", ParameterType = new Type[] { typeof(IMTLRenderPipelineState) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexBuffer", Selector = "setVertexBuffer:offset:atIndex:", ParameterType = new Type[]
{
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexTexture", Selector = "setVertexTexture:atIndex:", ParameterType = new Type[]
{
	typeof(IMTLTexture),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexSamplerState", Selector = "setVertexSamplerState:atIndex:", ParameterType = new Type[]
{
	typeof(IMTLSamplerState),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexSamplerState", Selector = "setVertexSamplerState:lodMinClamp:lodMaxClamp:atIndex:", ParameterType = new Type[]
{
	typeof(IMTLSamplerState),
	typeof(float),
	typeof(float),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetViewport", Selector = "setViewport:", ParameterType = new Type[] { typeof(MTLViewport) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFrontFacingWinding", Selector = "setFrontFacingWinding:", ParameterType = new Type[] { typeof(MTLWinding) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetCullMode", Selector = "setCullMode:", ParameterType = new Type[] { typeof(MTLCullMode) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetDepthClipMode", Selector = "setDepthClipMode:", ParameterType = new Type[] { typeof(MTLDepthClipMode) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDepthBias", Selector = "setDepthBias:slopeScale:clamp:", ParameterType = new Type[]
{
	typeof(float),
	typeof(float),
	typeof(float)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetScissorRect", Selector = "setScissorRect:", ParameterType = new Type[] { typeof(MTLScissorRect) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTriangleFillMode", Selector = "setTriangleFillMode:", ParameterType = new Type[] { typeof(MTLTriangleFillMode) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentBuffer", Selector = "setFragmentBuffer:offset:atIndex:", ParameterType = new Type[]
{
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentBufferOffset", Selector = "setFragmentBufferOffset:atIndex:", ParameterType = new Type[]
{
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentBytes", Selector = "setFragmentBytes:length:atIndex:", ParameterType = new Type[]
{
	typeof(IntPtr),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentTexture", Selector = "setFragmentTexture:atIndex:", ParameterType = new Type[]
{
	typeof(IMTLTexture),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentSamplerState", Selector = "setFragmentSamplerState:atIndex:", ParameterType = new Type[]
{
	typeof(IMTLSamplerState),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentSamplerState", Selector = "setFragmentSamplerState:lodMinClamp:lodMaxClamp:atIndex:", ParameterType = new Type[]
{
	typeof(IMTLSamplerState),
	typeof(float),
	typeof(float),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBlendColor", Selector = "setBlendColorRed:green:blue:alpha:", ParameterType = new Type[]
{
	typeof(float),
	typeof(float),
	typeof(float),
	typeof(float)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDepthStencilState", Selector = "setDepthStencilState:", ParameterType = new Type[] { typeof(IMTLDepthStencilState) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetStencilReferenceValue", Selector = "setStencilReferenceValue:", ParameterType = new Type[] { typeof(uint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetStencilFrontReferenceValue", Selector = "setStencilFrontReferenceValue:backReferenceValue:", ParameterType = new Type[]
{
	typeof(uint),
	typeof(uint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVisibilityResultMode", Selector = "setVisibilityResultMode:offset:", ParameterType = new Type[]
{
	typeof(MTLVisibilityResultMode),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetColorStoreAction", Selector = "setColorStoreAction:atIndex:", ParameterType = new Type[]
{
	typeof(MTLStoreAction),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetDepthStoreAction", Selector = "setDepthStoreAction:", ParameterType = new Type[] { typeof(MTLStoreAction) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetStencilStoreAction", Selector = "setStencilStoreAction:", ParameterType = new Type[] { typeof(MTLStoreAction) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawPrimitives", Selector = "drawPrimitives:vertexStart:vertexCount:instanceCount:", ParameterType = new Type[]
{
	typeof(MTLPrimitiveType),
	typeof(nuint),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawPrimitives", Selector = "drawPrimitives:vertexStart:vertexCount:", ParameterType = new Type[]
{
	typeof(MTLPrimitiveType),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawIndexedPrimitives", Selector = "drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:", ParameterType = new Type[]
{
	typeof(MTLPrimitiveType),
	typeof(nuint),
	typeof(MTLIndexType),
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawIndexedPrimitives", Selector = "drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:", ParameterType = new Type[]
{
	typeof(MTLPrimitiveType),
	typeof(nuint),
	typeof(MTLIndexType),
	typeof(IMTLBuffer),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawPrimitives", Selector = "drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:", ParameterType = new Type[]
{
	typeof(MTLPrimitiveType),
	typeof(nuint),
	typeof(nuint),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawIndexedPrimitives", Selector = "drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:baseVertex:baseInstance:", ParameterType = new Type[]
{
	typeof(MTLPrimitiveType),
	typeof(nuint),
	typeof(MTLIndexType),
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint),
	typeof(nint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawPrimitives", Selector = "drawPrimitives:indirectBuffer:indirectBufferOffset:", ParameterType = new Type[]
{
	typeof(MTLPrimitiveType),
	typeof(IMTLBuffer),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawIndexedPrimitives", Selector = "drawIndexedPrimitives:indexType:indexBuffer:indexBufferOffset:indirectBuffer:indirectBufferOffset:", ParameterType = new Type[]
{
	typeof(MTLPrimitiveType),
	typeof(MTLIndexType),
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(IMTLBuffer),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentBuffers", Selector = "setFragmentBuffers:offsets:withRange:", ParameterType = new Type[]
{
	typeof(IMTLBuffer),
	typeof(IntPtr),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentSamplerStates", Selector = "setFragmentSamplerStates:lodMinClamps:lodMaxClamps:withRange:", ParameterType = new Type[]
{
	typeof(IMTLSamplerState[]),
	typeof(IntPtr),
	typeof(IntPtr),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentSamplerStates", Selector = "setFragmentSamplerStates:withRange:", ParameterType = new Type[]
{
	typeof(IMTLSamplerState[]),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentTextures", Selector = "setFragmentTextures:withRange:", ParameterType = new Type[]
{
	typeof(IMTLTexture[]),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexBuffers", Selector = "setVertexBuffers:offsets:withRange:", ParameterType = new Type[]
{
	typeof(IMTLBuffer[]),
	typeof(IntPtr),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexBufferOffset", Selector = "setVertexBufferOffset:atIndex:", ParameterType = new Type[]
{
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexBytes", Selector = "setVertexBytes:length:atIndex:", ParameterType = new Type[]
{
	typeof(IntPtr),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexSamplerStates", Selector = "setVertexSamplerStates:lodMinClamps:lodMaxClamps:withRange:", ParameterType = new Type[]
{
	typeof(IMTLSamplerState[]),
	typeof(IntPtr),
	typeof(IntPtr),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexSamplerStates", Selector = "setVertexSamplerStates:withRange:", ParameterType = new Type[]
{
	typeof(IMTLSamplerState[]),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexTextures", Selector = "setVertexTextures:withRange:", ParameterType = new Type[]
{
	typeof(IMTLTexture[]),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "TextureBarrier", Selector = "textureBarrier")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Update", Selector = "updateFence:afterStages:", ParameterType = new Type[]
{
	typeof(IMTLFence),
	typeof(MTLRenderStages)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Wait", Selector = "waitForFence:beforeStages:", ParameterType = new Type[]
{
	typeof(IMTLFence),
	typeof(MTLRenderStages)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetTessellationFactorBuffer", Selector = "setTessellationFactorBuffer:offset:instanceStride:", ParameterType = new Type[]
{
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetTessellationFactorScale", Selector = "setTessellationFactorScale:", ParameterType = new Type[] { typeof(float) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawPatches", Selector = "drawPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:instanceCount:baseInstance:", ParameterType = new Type[]
{
	typeof(nuint),
	typeof(nuint),
	typeof(nuint),
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawPatches", Selector = "drawPatches:patchIndexBuffer:patchIndexBufferOffset:indirectBuffer:indirectBufferOffset:", ParameterType = new Type[]
{
	typeof(nuint),
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(IMTLBuffer),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawIndexedPatches", Selector = "drawIndexedPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:instanceCount:baseInstance:", ParameterType = new Type[]
{
	typeof(nuint),
	typeof(nuint),
	typeof(nuint),
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false, false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawIndexedPatches", Selector = "drawIndexedPatches:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:indirectBuffer:indirectBufferOffset:", ParameterType = new Type[]
{
	typeof(nuint),
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(IMTLBuffer),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetViewports", Selector = "setViewports:count:", ParameterType = new Type[]
{
	typeof(IntPtr),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetScissorRects", Selector = "setScissorRects:count:", ParameterType = new Type[]
{
	typeof(IntPtr),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetColorStoreActionOptions", Selector = "setColorStoreActionOptions:atIndex:", ParameterType = new Type[]
{
	typeof(MTLStoreActionOptions),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetDepthStoreActionOptions", Selector = "setDepthStoreActionOptions:", ParameterType = new Type[] { typeof(MTLStoreActionOptions) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetStencilStoreActionOptions", Selector = "setStencilStoreActionOptions:", ParameterType = new Type[] { typeof(MTLStoreActionOptions) }, ParameterByRef = new bool[] { false })]
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
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ExecuteCommands", Selector = "executeCommandsInBuffer:withRange:", ParameterType = new Type[]
{
	typeof(IMTLIndirectCommandBuffer),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ExecuteCommands", Selector = "executeCommandsInBuffer:indirectBuffer:indirectBufferOffset:", ParameterType = new Type[]
{
	typeof(IMTLIndirectCommandBuffer),
	typeof(IMTLBuffer),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MemoryBarrier", Selector = "memoryBarrierWithScope:afterStages:beforeStages:", ParameterType = new Type[]
{
	typeof(MTLBarrierScope),
	typeof(MTLRenderStages),
	typeof(MTLRenderStages)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MemoryBarrier", Selector = "memoryBarrierWithResources:count:afterStages:beforeStages:", ParameterType = new Type[]
{
	typeof(IMTLResource[]),
	typeof(nuint),
	typeof(MTLRenderStages),
	typeof(MTLRenderStages)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetVertexAmplificationCount", Selector = "setVertexAmplificationCount:viewMappings:", ParameterType = new Type[]
{
	typeof(nuint),
	typeof(MTLVertexAmplificationViewMapping)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UseResource", Selector = "useResource:usage:stages:", ParameterType = new Type[]
{
	typeof(IMTLResource),
	typeof(MTLResourceUsage),
	typeof(MTLRenderStages)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UseResources", Selector = "useResources:count:usage:stages:", ParameterType = new Type[]
{
	typeof(IMTLResource[]),
	typeof(nuint),
	typeof(MTLResourceUsage),
	typeof(MTLRenderStages)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UseHeap", Selector = "useHeap:stages:", ParameterType = new Type[]
{
	typeof(IMTLHeap),
	typeof(MTLRenderStages)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UseHeaps", Selector = "useHeaps:count:stages:", ParameterType = new Type[]
{
	typeof(IMTLHeap[]),
	typeof(nuint),
	typeof(MTLRenderStages)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SampleCounters", Selector = "sampleCountersInBuffer:atSampleIndex:withBarrier:", ParameterType = new Type[]
{
	typeof(MTLCounterSampleBuffer),
	typeof(nuint),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false, false })]
public interface IMTLRenderCommandEncoder : INativeObject, IDisposable, IMTLCommandEncoder
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setRenderPipelineState:")]
	[Preserve(Conditional = true)]
	void SetRenderPipelineState(IMTLRenderPipelineState pipelineState);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setVertexBuffer:offset:atIndex:")]
	[Preserve(Conditional = true)]
	void SetVertexBuffer(IMTLBuffer buffer, nuint offset, nuint index);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setVertexTexture:atIndex:")]
	[Preserve(Conditional = true)]
	void SetVertexTexture(IMTLTexture texture, nuint index);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setVertexSamplerState:atIndex:")]
	[Preserve(Conditional = true)]
	void SetVertexSamplerState(IMTLSamplerState sampler, nuint index);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setVertexSamplerState:lodMinClamp:lodMaxClamp:atIndex:")]
	[Preserve(Conditional = true)]
	void SetVertexSamplerState(IMTLSamplerState sampler, float lodMinClamp, float lodMaxClamp, nuint index);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setViewport:")]
	[Preserve(Conditional = true)]
	void SetViewport(MTLViewport viewport);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setFrontFacingWinding:")]
	[Preserve(Conditional = true)]
	void SetFrontFacingWinding(MTLWinding frontFacingWinding);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setCullMode:")]
	[Preserve(Conditional = true)]
	void SetCullMode(MTLCullMode cullMode);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setDepthBias:slopeScale:clamp:")]
	[Preserve(Conditional = true)]
	void SetDepthBias(float depthBias, float slopeScale, float clamp);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setScissorRect:")]
	[Preserve(Conditional = true)]
	void SetScissorRect(MTLScissorRect rect);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setTriangleFillMode:")]
	[Preserve(Conditional = true)]
	void SetTriangleFillMode(MTLTriangleFillMode fillMode);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setFragmentBuffer:offset:atIndex:")]
	[Preserve(Conditional = true)]
	void SetFragmentBuffer(IMTLBuffer buffer, nuint offset, nuint index);

	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setFragmentBufferOffset:atIndex:")]
	[Preserve(Conditional = true)]
	void SetFragmentBufferOffset(nuint offset, nuint index);

	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setFragmentBytes:length:atIndex:")]
	[Preserve(Conditional = true)]
	void SetFragmentBytes(IntPtr bytes, nuint length, nuint index);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setFragmentTexture:atIndex:")]
	[Preserve(Conditional = true)]
	void SetFragmentTexture(IMTLTexture texture, nuint index);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setFragmentSamplerState:atIndex:")]
	[Preserve(Conditional = true)]
	void SetFragmentSamplerState(IMTLSamplerState sampler, nuint index);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setFragmentSamplerState:lodMinClamp:lodMaxClamp:atIndex:")]
	[Preserve(Conditional = true)]
	void SetFragmentSamplerState(IMTLSamplerState sampler, float lodMinClamp, float lodMaxClamp, nuint index);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setBlendColorRed:green:blue:alpha:")]
	[Preserve(Conditional = true)]
	void SetBlendColor(float red, float green, float blue, float alpha);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setDepthStencilState:")]
	[Preserve(Conditional = true)]
	void SetDepthStencilState(IMTLDepthStencilState depthStencilState);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setStencilReferenceValue:")]
	[Preserve(Conditional = true)]
	void SetStencilReferenceValue(uint referenceValue);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setVisibilityResultMode:offset:")]
	[Preserve(Conditional = true)]
	void SetVisibilityResultMode(MTLVisibilityResultMode mode, nuint offset);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("drawPrimitives:vertexStart:vertexCount:instanceCount:")]
	[Preserve(Conditional = true)]
	void DrawPrimitives(MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount, nuint instanceCount);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("drawPrimitives:vertexStart:vertexCount:")]
	[Preserve(Conditional = true)]
	void DrawPrimitives(MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:")]
	[Preserve(Conditional = true)]
	void DrawIndexedPrimitives(MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset, nuint instanceCount);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:")]
	[Preserve(Conditional = true)]
	void DrawIndexedPrimitives(MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setFragmentBuffers:offsets:withRange:")]
	[Preserve(Conditional = true)]
	void SetFragmentBuffers(IMTLBuffer buffers, IntPtr IntPtrOffsets, NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setFragmentSamplerStates:lodMinClamps:lodMaxClamps:withRange:")]
	[Preserve(Conditional = true)]
	void SetFragmentSamplerStates(IMTLSamplerState[] samplers, IntPtr floatArrayPtrLodMinClamps, IntPtr floatArrayPtrLodMaxClamps, NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setFragmentSamplerStates:withRange:")]
	[Preserve(Conditional = true)]
	void SetFragmentSamplerStates(IMTLSamplerState[] samplers, NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setFragmentTextures:withRange:")]
	[Preserve(Conditional = true)]
	void SetFragmentTextures(IMTLTexture[] textures, NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setVertexBuffers:offsets:withRange:")]
	[Preserve(Conditional = true)]
	void SetVertexBuffers(IMTLBuffer[] buffers, IntPtr uintArrayPtrOffsets, NSRange range);

	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setVertexBufferOffset:atIndex:")]
	[Preserve(Conditional = true)]
	void SetVertexBufferOffset(nuint offset, nuint index);

	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setVertexBytes:length:atIndex:")]
	[Preserve(Conditional = true)]
	void SetVertexBytes(IntPtr bytes, nuint length, nuint index);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setVertexSamplerStates:lodMinClamps:lodMaxClamps:withRange:")]
	[Preserve(Conditional = true)]
	void SetVertexSamplerStates(IMTLSamplerState[] samplers, IntPtr floatArrayPtrLodMinClamps, IntPtr floatArrayPtrLodMaxClamps, NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setVertexSamplerStates:withRange:")]
	[Preserve(Conditional = true)]
	void SetVertexSamplerStates(IMTLSamplerState[] samplers, NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setVertexTextures:withRange:")]
	[Preserve(Conditional = true)]
	void SetVertexTextures(IMTLTexture[] textures, NSRange range);
}
