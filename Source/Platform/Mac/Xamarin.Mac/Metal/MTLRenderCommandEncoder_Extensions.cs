using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

public static class MTLRenderCommandEncoder_Extensions
{
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetDepthClipMode(this IMTLRenderCommandEncoder This, MTLDepthClipMode depthClipMode)
	{
		Messaging.void_objc_msgSend_UInt64(This.Handle, Selector.GetHandle("setDepthClipMode:"), (ulong)depthClipMode);
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetStencilFrontReferenceValue(this IMTLRenderCommandEncoder This, uint frontReferenceValue, uint backReferenceValue)
	{
		Messaging.void_objc_msgSend_UInt32_UInt32(This.Handle, Selector.GetHandle("setStencilFrontReferenceValue:backReferenceValue:"), frontReferenceValue, backReferenceValue);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetColorStoreAction(this IMTLRenderCommandEncoder This, MTLStoreAction storeAction, nuint colorAttachmentIndex)
	{
		Messaging.void_objc_msgSend_UInt64_nuint(This.Handle, Selector.GetHandle("setColorStoreAction:atIndex:"), (ulong)storeAction, colorAttachmentIndex);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetDepthStoreAction(this IMTLRenderCommandEncoder This, MTLStoreAction storeAction)
	{
		Messaging.void_objc_msgSend_UInt64(This.Handle, Selector.GetHandle("setDepthStoreAction:"), (ulong)storeAction);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetStencilStoreAction(this IMTLRenderCommandEncoder This, MTLStoreAction storeAction)
	{
		Messaging.void_objc_msgSend_UInt64(This.Handle, Selector.GetHandle("setStencilStoreAction:"), (ulong)storeAction);
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawPrimitives(this IMTLRenderCommandEncoder This, MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount, nuint instanceCount, nuint baseInstance)
	{
		Messaging.void_objc_msgSend_UInt64_nuint_nuint_nuint_nuint(This.Handle, Selector.GetHandle("drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:"), (ulong)primitiveType, vertexStart, vertexCount, instanceCount, baseInstance);
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawIndexedPrimitives(this IMTLRenderCommandEncoder This, MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset, nuint instanceCount, nint baseVertex, nuint baseInstance)
	{
		if (indexBuffer == null)
		{
			throw new ArgumentNullException("indexBuffer");
		}
		Messaging.void_objc_msgSend_UInt64_nuint_UInt64_IntPtr_nuint_nuint_nint_nuint(This.Handle, Selector.GetHandle("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:baseVertex:baseInstance:"), (ulong)primitiveType, indexCount, (ulong)indexType, indexBuffer.Handle, indexBufferOffset, instanceCount, baseVertex, baseInstance);
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawPrimitives(this IMTLRenderCommandEncoder This, MTLPrimitiveType primitiveType, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
	{
		if (indirectBuffer == null)
		{
			throw new ArgumentNullException("indirectBuffer");
		}
		Messaging.void_objc_msgSend_UInt64_IntPtr_nuint(This.Handle, Selector.GetHandle("drawPrimitives:indirectBuffer:indirectBufferOffset:"), (ulong)primitiveType, indirectBuffer.Handle, indirectBufferOffset);
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawIndexedPrimitives(this IMTLRenderCommandEncoder This, MTLPrimitiveType primitiveType, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
	{
		if (indexBuffer == null)
		{
			throw new ArgumentNullException("indexBuffer");
		}
		if (indirectBuffer == null)
		{
			throw new ArgumentNullException("indirectBuffer");
		}
		Messaging.void_objc_msgSend_UInt64_UInt64_IntPtr_nuint_IntPtr_nuint(This.Handle, Selector.GetHandle("drawIndexedPrimitives:indexType:indexBuffer:indexBufferOffset:indirectBuffer:indirectBufferOffset:"), (ulong)primitiveType, (ulong)indexType, indexBuffer.Handle, indexBufferOffset, indirectBuffer.Handle, indirectBufferOffset);
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'MemoryBarrier (MTLBarrierScope, MTLRenderStages, MTLRenderStages)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void TextureBarrier(this IMTLRenderCommandEncoder This)
	{
		Messaging.void_objc_msgSend(This.Handle, Selector.GetHandle("textureBarrier"));
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Update(this IMTLRenderCommandEncoder This, IMTLFence fence, MTLRenderStages stages)
	{
		if (fence == null)
		{
			throw new ArgumentNullException("fence");
		}
		Messaging.void_objc_msgSend_IntPtr_UInt64(This.Handle, Selector.GetHandle("updateFence:afterStages:"), fence.Handle, (ulong)stages);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Wait(this IMTLRenderCommandEncoder This, IMTLFence fence, MTLRenderStages stages)
	{
		if (fence == null)
		{
			throw new ArgumentNullException("fence");
		}
		Messaging.void_objc_msgSend_IntPtr_UInt64(This.Handle, Selector.GetHandle("waitForFence:beforeStages:"), fence.Handle, (ulong)stages);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetTessellationFactorBuffer(this IMTLRenderCommandEncoder This, IMTLBuffer? buffer, nuint offset, nuint instanceStride)
	{
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint(This.Handle, Selector.GetHandle("setTessellationFactorBuffer:offset:instanceStride:"), buffer?.Handle ?? IntPtr.Zero, offset, instanceStride);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetTessellationFactorScale(this IMTLRenderCommandEncoder This, float scale)
	{
		Messaging.void_objc_msgSend_float(This.Handle, Selector.GetHandle("setTessellationFactorScale:"), scale);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawPatches(this IMTLRenderCommandEncoder This, nuint numberOfPatchControlPoints, nuint patchStart, nuint patchCount, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, nuint instanceCount, nuint baseInstance)
	{
		Messaging.void_objc_msgSend_nuint_nuint_nuint_IntPtr_nuint_nuint_nuint(This.Handle, Selector.GetHandle("drawPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:instanceCount:baseInstance:"), numberOfPatchControlPoints, patchStart, patchCount, patchIndexBuffer?.Handle ?? IntPtr.Zero, patchIndexBufferOffset, instanceCount, baseInstance);
	}

	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawPatches(this IMTLRenderCommandEncoder This, nuint numberOfPatchControlPoints, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
	{
		if (indirectBuffer == null)
		{
			throw new ArgumentNullException("indirectBuffer");
		}
		Messaging.void_objc_msgSend_nuint_IntPtr_nuint_IntPtr_nuint(This.Handle, Selector.GetHandle("drawPatches:patchIndexBuffer:patchIndexBufferOffset:indirectBuffer:indirectBufferOffset:"), numberOfPatchControlPoints, patchIndexBuffer?.Handle ?? IntPtr.Zero, patchIndexBufferOffset, indirectBuffer.Handle, indirectBufferOffset);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawIndexedPatches(this IMTLRenderCommandEncoder This, nuint numberOfPatchControlPoints, nuint patchStart, nuint patchCount, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, IMTLBuffer controlPointIndexBuffer, nuint controlPointIndexBufferOffset, nuint instanceCount, nuint baseInstance)
	{
		if (controlPointIndexBuffer == null)
		{
			throw new ArgumentNullException("controlPointIndexBuffer");
		}
		Messaging.void_objc_msgSend_nuint_nuint_nuint_IntPtr_nuint_IntPtr_nuint_nuint_nuint(This.Handle, Selector.GetHandle("drawIndexedPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:instanceCount:baseInstance:"), numberOfPatchControlPoints, patchStart, patchCount, patchIndexBuffer?.Handle ?? IntPtr.Zero, patchIndexBufferOffset, controlPointIndexBuffer.Handle, controlPointIndexBufferOffset, instanceCount, baseInstance);
	}

	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawIndexedPatches(this IMTLRenderCommandEncoder This, nuint numberOfPatchControlPoints, IMTLBuffer? patchIndexBuffer, nuint patchIndexBufferOffset, IMTLBuffer controlPointIndexBuffer, nuint controlPointIndexBufferOffset, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
	{
		if (controlPointIndexBuffer == null)
		{
			throw new ArgumentNullException("controlPointIndexBuffer");
		}
		if (indirectBuffer == null)
		{
			throw new ArgumentNullException("indirectBuffer");
		}
		Messaging.void_objc_msgSend_nuint_IntPtr_nuint_IntPtr_nuint_IntPtr_nuint(This.Handle, Selector.GetHandle("drawIndexedPatches:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:indirectBuffer:indirectBufferOffset:"), numberOfPatchControlPoints, patchIndexBuffer?.Handle ?? IntPtr.Zero, patchIndexBufferOffset, controlPointIndexBuffer.Handle, controlPointIndexBufferOffset, indirectBuffer.Handle, indirectBufferOffset);
	}

	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "API removed, please do not use.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetViewports(this IMTLRenderCommandEncoder This, IntPtr viewports, nuint count)
	{
		Messaging.void_objc_msgSend_IntPtr_nuint(This.Handle, Selector.GetHandle("setViewports:count:"), viewports, count);
	}

	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "API removed, please do not use.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetScissorRects(this IMTLRenderCommandEncoder This, IntPtr scissorRects, nuint count)
	{
		Messaging.void_objc_msgSend_IntPtr_nuint(This.Handle, Selector.GetHandle("setScissorRects:count:"), scissorRects, count);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetColorStoreActionOptions(this IMTLRenderCommandEncoder This, MTLStoreActionOptions storeActionOptions, nuint colorAttachmentIndex)
	{
		Messaging.void_objc_msgSend_UInt64_nuint(This.Handle, Selector.GetHandle("setColorStoreActionOptions:atIndex:"), (ulong)storeActionOptions, colorAttachmentIndex);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetDepthStoreActionOptions(this IMTLRenderCommandEncoder This, MTLStoreActionOptions storeActionOptions)
	{
		Messaging.void_objc_msgSend_UInt64(This.Handle, Selector.GetHandle("setDepthStoreActionOptions:"), (ulong)storeActionOptions);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetStencilStoreActionOptions(this IMTLRenderCommandEncoder This, MTLStoreActionOptions storeActionOptions)
	{
		Messaging.void_objc_msgSend_UInt64(This.Handle, Selector.GetHandle("setStencilStoreActionOptions:"), (ulong)storeActionOptions);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UseResource(this IMTLRenderCommandEncoder This, IMTLResource resource, MTLResourceUsage usage)
	{
		if (resource == null)
		{
			throw new ArgumentNullException("resource");
		}
		Messaging.void_objc_msgSend_IntPtr_UInt64(This.Handle, Selector.GetHandle("useResource:usage:"), resource.Handle, (ulong)usage);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UseResources(this IMTLRenderCommandEncoder This, IMTLResource[] resources, nuint count, MTLResourceUsage usage)
	{
		if (resources == null)
		{
			throw new ArgumentNullException("resources");
		}
		NSArray nSArray = NSArray.FromNSObjects(resources);
		Messaging.void_objc_msgSend_IntPtr_nuint_UInt64(This.Handle, Selector.GetHandle("useResources:count:usage:"), nSArray.Handle, count, (ulong)usage);
		nSArray.Dispose();
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UseHeap(this IMTLRenderCommandEncoder This, IMTLHeap heap)
	{
		if (heap == null)
		{
			throw new ArgumentNullException("heap");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("useHeap:"), heap.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UseHeaps(this IMTLRenderCommandEncoder This, IMTLHeap[] heaps, nuint count)
	{
		if (heaps == null)
		{
			throw new ArgumentNullException("heaps");
		}
		NSArray nSArray = NSArray.FromNSObjects(heaps);
		Messaging.void_objc_msgSend_IntPtr_nuint(This.Handle, Selector.GetHandle("useHeaps:count:"), nSArray.Handle, count);
		nSArray.Dispose();
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ExecuteCommands(this IMTLRenderCommandEncoder This, IMTLIndirectCommandBuffer indirectCommandBuffer, NSRange executionRange)
	{
		if (indirectCommandBuffer == null)
		{
			throw new ArgumentNullException("indirectCommandBuffer");
		}
		Messaging.void_objc_msgSend_IntPtr_NSRange(This.Handle, Selector.GetHandle("executeCommandsInBuffer:withRange:"), indirectCommandBuffer.Handle, executionRange);
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ExecuteCommands(this IMTLRenderCommandEncoder This, IMTLIndirectCommandBuffer indirectCommandbuffer, IMTLBuffer indirectRangeBuffer, nuint indirectBufferOffset)
	{
		if (indirectCommandbuffer == null)
		{
			throw new ArgumentNullException("indirectCommandbuffer");
		}
		if (indirectRangeBuffer == null)
		{
			throw new ArgumentNullException("indirectRangeBuffer");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint(This.Handle, Selector.GetHandle("executeCommandsInBuffer:indirectBuffer:indirectBufferOffset:"), indirectCommandbuffer.Handle, indirectRangeBuffer.Handle, indirectBufferOffset);
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MemoryBarrier(this IMTLRenderCommandEncoder This, MTLBarrierScope scope, MTLRenderStages after, MTLRenderStages before)
	{
		Messaging.void_objc_msgSend_UInt64_UInt64_UInt64(This.Handle, Selector.GetHandle("memoryBarrierWithScope:afterStages:beforeStages:"), (ulong)scope, (ulong)after, (ulong)before);
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MemoryBarrier(this IMTLRenderCommandEncoder This, IMTLResource[] resources, nuint count, MTLRenderStages after, MTLRenderStages before)
	{
		if (resources == null)
		{
			throw new ArgumentNullException("resources");
		}
		NSArray nSArray = NSArray.FromNSObjects(resources);
		Messaging.void_objc_msgSend_IntPtr_nuint_UInt64_UInt64(This.Handle, Selector.GetHandle("memoryBarrierWithResources:count:afterStages:beforeStages:"), nSArray.Handle, count, (ulong)after, (ulong)before);
		nSArray.Dispose();
	}

	[Introduced(PlatformName.MacCatalyst, 13, 4, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetVertexAmplificationCount(this IMTLRenderCommandEncoder This, nuint count, MTLVertexAmplificationViewMapping viewMappings)
	{
		Messaging.void_objc_msgSend_nuint_MTLVertexAmplificationViewMapping(This.Handle, Selector.GetHandle("setVertexAmplificationCount:viewMappings:"), count, viewMappings);
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UseResource(this IMTLRenderCommandEncoder This, IMTLResource resource, MTLResourceUsage usage, MTLRenderStages stages)
	{
		if (resource == null)
		{
			throw new ArgumentNullException("resource");
		}
		Messaging.void_objc_msgSend_IntPtr_UInt64_UInt64(This.Handle, Selector.GetHandle("useResource:usage:stages:"), resource.Handle, (ulong)usage, (ulong)stages);
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UseResources(this IMTLRenderCommandEncoder This, IMTLResource[] resources, nuint count, MTLResourceUsage usage, MTLRenderStages stages)
	{
		if (resources == null)
		{
			throw new ArgumentNullException("resources");
		}
		NSArray nSArray = NSArray.FromNSObjects(resources);
		Messaging.void_objc_msgSend_IntPtr_nuint_UInt64_UInt64(This.Handle, Selector.GetHandle("useResources:count:usage:stages:"), nSArray.Handle, count, (ulong)usage, (ulong)stages);
		nSArray.Dispose();
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UseHeap(this IMTLRenderCommandEncoder This, IMTLHeap heap, MTLRenderStages stages)
	{
		if (heap == null)
		{
			throw new ArgumentNullException("heap");
		}
		Messaging.void_objc_msgSend_IntPtr_UInt64(This.Handle, Selector.GetHandle("useHeap:stages:"), heap.Handle, (ulong)stages);
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UseHeaps(this IMTLRenderCommandEncoder This, IMTLHeap[] heaps, nuint count, MTLRenderStages stages)
	{
		if (heaps == null)
		{
			throw new ArgumentNullException("heaps");
		}
		NSArray nSArray = NSArray.FromNSObjects(heaps);
		Messaging.void_objc_msgSend_IntPtr_nuint_UInt64(This.Handle, Selector.GetHandle("useHeaps:count:stages:"), nSArray.Handle, count, (ulong)stages);
		nSArray.Dispose();
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SampleCounters(this IMTLRenderCommandEncoder This, MTLCounterSampleBuffer sampleBuffer, nuint sampleIndex, bool barrier)
	{
		if (sampleBuffer == null)
		{
			throw new ArgumentNullException("sampleBuffer");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint_bool(This.Handle, Selector.GetHandle("sampleCountersInBuffer:atSampleIndex:withBarrier:"), sampleBuffer.Handle, sampleIndex, barrier);
	}
}
