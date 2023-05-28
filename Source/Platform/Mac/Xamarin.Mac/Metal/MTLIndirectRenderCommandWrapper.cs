using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

internal sealed class MTLIndirectRenderCommandWrapper : BaseWrapper, IMTLIndirectRenderCommand, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MTLIndirectRenderCommandWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("setRenderPipelineState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetRenderPipelineState(IMTLRenderPipelineState pipelineState)
	{
		if (pipelineState == null)
		{
			throw new ArgumentNullException("pipelineState");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setRenderPipelineState:"), pipelineState.Handle);
	}

	[Export("setVertexBuffer:offset:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetVertexBuffer(IMTLBuffer buffer, nuint offset, nuint index)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint(base.Handle, Selector.GetHandle("setVertexBuffer:offset:atIndex:"), buffer.Handle, offset, index);
	}

	[Export("setFragmentBuffer:offset:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetFragmentBuffer(IMTLBuffer buffer, nuint offset, nuint index)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint(base.Handle, Selector.GetHandle("setFragmentBuffer:offset:atIndex:"), buffer.Handle, offset, index);
	}

	[Export("drawPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:instanceCount:baseInstance:tessellationFactorBuffer:tessellationFactorBufferOffset:tessellationFactorBufferInstanceStride:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DrawPatches(nuint numberOfPatchControlPoints, nuint patchStart, nuint patchCount, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, nuint instanceCount, nuint baseInstance, IMTLBuffer buffer, nuint offset, nuint instanceStride)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		Messaging.void_objc_msgSend_nuint_nuint_nuint_IntPtr_nuint_nuint_nuint_IntPtr_nuint_nuint(base.Handle, Selector.GetHandle("drawPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:instanceCount:baseInstance:tessellationFactorBuffer:tessellationFactorBufferOffset:tessellationFactorBufferInstanceStride:"), numberOfPatchControlPoints, patchStart, patchCount, patchIndexBuffer?.Handle ?? IntPtr.Zero, patchIndexBufferOffset, instanceCount, baseInstance, buffer.Handle, offset, instanceStride);
	}

	[Export("drawIndexedPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:instanceCount:baseInstance:tessellationFactorBuffer:tessellationFactorBufferOffset:tessellationFactorBufferInstanceStride:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DrawIndexedPatches(nuint numberOfPatchControlPoints, nuint patchStart, nuint patchCount, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, IMTLBuffer controlPointIndexBuffer, nuint controlPointIndexBufferOffset, nuint instanceCount, nuint baseInstance, IMTLBuffer buffer, nuint offset, nuint instanceStride)
	{
		if (controlPointIndexBuffer == null)
		{
			throw new ArgumentNullException("controlPointIndexBuffer");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		Messaging.void_objc_msgSend_nuint_nuint_nuint_IntPtr_nuint_IntPtr_nuint_nuint_nuint_IntPtr_nuint_nuint(base.Handle, Selector.GetHandle("drawIndexedPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:instanceCount:baseInstance:tessellationFactorBuffer:tessellationFactorBufferOffset:tessellationFactorBufferInstanceStride:"), numberOfPatchControlPoints, patchStart, patchCount, patchIndexBuffer?.Handle ?? IntPtr.Zero, patchIndexBufferOffset, controlPointIndexBuffer.Handle, controlPointIndexBufferOffset, instanceCount, baseInstance, buffer.Handle, offset, instanceStride);
	}

	[Export("drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DrawPrimitives(MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount, nuint instanceCount, nuint baseInstance)
	{
		Messaging.void_objc_msgSend_UInt64_nuint_nuint_nuint_nuint(base.Handle, Selector.GetHandle("drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:"), (ulong)primitiveType, vertexStart, vertexCount, instanceCount, baseInstance);
	}

	[Export("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:baseVertex:baseInstance:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DrawIndexedPrimitives(MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset, nuint instanceCount, nint baseVertex, nuint baseInstance)
	{
		if (indexBuffer == null)
		{
			throw new ArgumentNullException("indexBuffer");
		}
		Messaging.void_objc_msgSend_UInt64_nuint_UInt64_IntPtr_nuint_nuint_nint_nuint(base.Handle, Selector.GetHandle("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:baseVertex:baseInstance:"), (ulong)primitiveType, indexCount, (ulong)indexType, indexBuffer.Handle, indexBufferOffset, instanceCount, baseVertex, baseInstance);
	}

	[Export("reset")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Reset()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("reset"));
	}
}
