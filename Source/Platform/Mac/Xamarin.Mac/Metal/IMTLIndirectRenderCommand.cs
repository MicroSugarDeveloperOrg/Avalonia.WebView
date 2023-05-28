using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLIndirectRenderCommand", WrapperType = typeof(MTLIndirectRenderCommandWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetRenderPipelineState", Selector = "setRenderPipelineState:", ParameterType = new Type[] { typeof(IMTLRenderPipelineState) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVertexBuffer", Selector = "setVertexBuffer:offset:atIndex:", ParameterType = new Type[]
{
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFragmentBuffer", Selector = "setFragmentBuffer:offset:atIndex:", ParameterType = new Type[]
{
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawPatches", Selector = "drawPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:instanceCount:baseInstance:tessellationFactorBuffer:tessellationFactorBufferOffset:tessellationFactorBufferInstanceStride:", ParameterType = new Type[]
{
	typeof(nuint),
	typeof(nuint),
	typeof(nuint),
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint),
	typeof(nuint),
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false, false, false, false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawIndexedPatches", Selector = "drawIndexedPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:instanceCount:baseInstance:tessellationFactorBuffer:tessellationFactorBufferOffset:tessellationFactorBufferInstanceStride:", ParameterType = new Type[]
{
	typeof(nuint),
	typeof(nuint),
	typeof(nuint),
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint),
	typeof(nuint),
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[]
{
	false, false, false, false, false, false, false, false, false, false,
	false, false
})]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawPrimitives", Selector = "drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:", ParameterType = new Type[]
{
	typeof(MTLPrimitiveType),
	typeof(nuint),
	typeof(nuint),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawIndexedPrimitives", Selector = "drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:baseVertex:baseInstance:", ParameterType = new Type[]
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
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Reset", Selector = "reset")]
public interface IMTLIndirectRenderCommand : INativeObject, IDisposable
{
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setRenderPipelineState:")]
	[Preserve(Conditional = true)]
	void SetRenderPipelineState(IMTLRenderPipelineState pipelineState);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setVertexBuffer:offset:atIndex:")]
	[Preserve(Conditional = true)]
	void SetVertexBuffer(IMTLBuffer buffer, nuint offset, nuint index);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setFragmentBuffer:offset:atIndex:")]
	[Preserve(Conditional = true)]
	void SetFragmentBuffer(IMTLBuffer buffer, nuint offset, nuint index);

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("drawPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:instanceCount:baseInstance:tessellationFactorBuffer:tessellationFactorBufferOffset:tessellationFactorBufferInstanceStride:")]
	[Preserve(Conditional = true)]
	void DrawPatches(nuint numberOfPatchControlPoints, nuint patchStart, nuint patchCount, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, nuint instanceCount, nuint baseInstance, IMTLBuffer buffer, nuint offset, nuint instanceStride);

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("drawIndexedPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:instanceCount:baseInstance:tessellationFactorBuffer:tessellationFactorBufferOffset:tessellationFactorBufferInstanceStride:")]
	[Preserve(Conditional = true)]
	void DrawIndexedPatches(nuint numberOfPatchControlPoints, nuint patchStart, nuint patchCount, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, IMTLBuffer controlPointIndexBuffer, nuint controlPointIndexBufferOffset, nuint instanceCount, nuint baseInstance, IMTLBuffer buffer, nuint offset, nuint instanceStride);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:")]
	[Preserve(Conditional = true)]
	void DrawPrimitives(MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount, nuint instanceCount, nuint baseInstance);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:baseVertex:baseInstance:")]
	[Preserve(Conditional = true)]
	void DrawIndexedPrimitives(MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset, nuint instanceCount, nint baseVertex, nuint baseInstance);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("reset")]
	[Preserve(Conditional = true)]
	void Reset();
}
