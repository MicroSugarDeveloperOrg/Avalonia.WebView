using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

internal sealed class MTLRenderCommandEncoderWrapper : BaseWrapper, IMTLRenderCommandEncoder, INativeObject, IDisposable, IMTLCommandEncoder
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public IMTLDevice Device
	{
		[Export("device")]
		get
		{
			return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("device")), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public string Label
	{
		[Export("label")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("label")));
		}
		[Export("setLabel:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setLabel:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[Preserve(Conditional = true)]
	public MTLRenderCommandEncoderWrapper(IntPtr handle, bool owns)
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

	[Export("setVertexTexture:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetVertexTexture(IMTLTexture texture, nuint index)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, Selector.GetHandle("setVertexTexture:atIndex:"), texture.Handle, index);
	}

	[Export("setVertexSamplerState:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetVertexSamplerState(IMTLSamplerState sampler, nuint index)
	{
		if (sampler == null)
		{
			throw new ArgumentNullException("sampler");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, Selector.GetHandle("setVertexSamplerState:atIndex:"), sampler.Handle, index);
	}

	[Export("setVertexSamplerState:lodMinClamp:lodMaxClamp:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetVertexSamplerState(IMTLSamplerState sampler, float lodMinClamp, float lodMaxClamp, nuint index)
	{
		if (sampler == null)
		{
			throw new ArgumentNullException("sampler");
		}
		Messaging.void_objc_msgSend_IntPtr_float_float_nuint(base.Handle, Selector.GetHandle("setVertexSamplerState:lodMinClamp:lodMaxClamp:atIndex:"), sampler.Handle, lodMinClamp, lodMaxClamp, index);
	}

	[Export("setViewport:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetViewport(MTLViewport viewport)
	{
		Messaging.void_objc_msgSend_MTLViewport(base.Handle, Selector.GetHandle("setViewport:"), viewport);
	}

	[Export("setFrontFacingWinding:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetFrontFacingWinding(MTLWinding frontFacingWinding)
	{
		Messaging.void_objc_msgSend_UInt64(base.Handle, Selector.GetHandle("setFrontFacingWinding:"), (ulong)frontFacingWinding);
	}

	[Export("setCullMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetCullMode(MTLCullMode cullMode)
	{
		Messaging.void_objc_msgSend_UInt64(base.Handle, Selector.GetHandle("setCullMode:"), (ulong)cullMode);
	}

	[Export("setDepthBias:slopeScale:clamp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetDepthBias(float depthBias, float slopeScale, float clamp)
	{
		Messaging.void_objc_msgSend_float_float_float(base.Handle, Selector.GetHandle("setDepthBias:slopeScale:clamp:"), depthBias, slopeScale, clamp);
	}

	[Export("setScissorRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetScissorRect(MTLScissorRect rect)
	{
		Messaging.void_objc_msgSend_MTLScissorRect(base.Handle, Selector.GetHandle("setScissorRect:"), rect);
	}

	[Export("setTriangleFillMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetTriangleFillMode(MTLTriangleFillMode fillMode)
	{
		Messaging.void_objc_msgSend_UInt64(base.Handle, Selector.GetHandle("setTriangleFillMode:"), (ulong)fillMode);
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

	[Export("setFragmentBufferOffset:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetFragmentBufferOffset(nuint offset, nuint index)
	{
		Messaging.void_objc_msgSend_nuint_nuint(base.Handle, Selector.GetHandle("setFragmentBufferOffset:atIndex:"), offset, index);
	}

	[Export("setFragmentBytes:length:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetFragmentBytes(IntPtr bytes, nuint length, nuint index)
	{
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint(base.Handle, Selector.GetHandle("setFragmentBytes:length:atIndex:"), bytes, length, index);
	}

	[Export("setFragmentTexture:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetFragmentTexture(IMTLTexture texture, nuint index)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, Selector.GetHandle("setFragmentTexture:atIndex:"), texture.Handle, index);
	}

	[Export("setFragmentSamplerState:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetFragmentSamplerState(IMTLSamplerState sampler, nuint index)
	{
		if (sampler == null)
		{
			throw new ArgumentNullException("sampler");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, Selector.GetHandle("setFragmentSamplerState:atIndex:"), sampler.Handle, index);
	}

	[Export("setFragmentSamplerState:lodMinClamp:lodMaxClamp:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetFragmentSamplerState(IMTLSamplerState sampler, float lodMinClamp, float lodMaxClamp, nuint index)
	{
		if (sampler == null)
		{
			throw new ArgumentNullException("sampler");
		}
		Messaging.void_objc_msgSend_IntPtr_float_float_nuint(base.Handle, Selector.GetHandle("setFragmentSamplerState:lodMinClamp:lodMaxClamp:atIndex:"), sampler.Handle, lodMinClamp, lodMaxClamp, index);
	}

	[Export("setBlendColorRed:green:blue:alpha:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetBlendColor(float red, float green, float blue, float alpha)
	{
		Messaging.void_objc_msgSend_float_float_float_float(base.Handle, Selector.GetHandle("setBlendColorRed:green:blue:alpha:"), red, green, blue, alpha);
	}

	[Export("setDepthStencilState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetDepthStencilState(IMTLDepthStencilState depthStencilState)
	{
		if (depthStencilState == null)
		{
			throw new ArgumentNullException("depthStencilState");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setDepthStencilState:"), depthStencilState.Handle);
	}

	[Export("setStencilReferenceValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetStencilReferenceValue(uint referenceValue)
	{
		Messaging.void_objc_msgSend_UInt32(base.Handle, Selector.GetHandle("setStencilReferenceValue:"), referenceValue);
	}

	[Export("setVisibilityResultMode:offset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetVisibilityResultMode(MTLVisibilityResultMode mode, nuint offset)
	{
		Messaging.void_objc_msgSend_UInt64_nuint(base.Handle, Selector.GetHandle("setVisibilityResultMode:offset:"), (ulong)mode, offset);
	}

	[Export("drawPrimitives:vertexStart:vertexCount:instanceCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DrawPrimitives(MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount, nuint instanceCount)
	{
		Messaging.void_objc_msgSend_UInt64_nuint_nuint_nuint(base.Handle, Selector.GetHandle("drawPrimitives:vertexStart:vertexCount:instanceCount:"), (ulong)primitiveType, vertexStart, vertexCount, instanceCount);
	}

	[Export("drawPrimitives:vertexStart:vertexCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DrawPrimitives(MTLPrimitiveType primitiveType, nuint vertexStart, nuint vertexCount)
	{
		Messaging.void_objc_msgSend_UInt64_nuint_nuint(base.Handle, Selector.GetHandle("drawPrimitives:vertexStart:vertexCount:"), (ulong)primitiveType, vertexStart, vertexCount);
	}

	[Export("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DrawIndexedPrimitives(MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset, nuint instanceCount)
	{
		if (indexBuffer == null)
		{
			throw new ArgumentNullException("indexBuffer");
		}
		Messaging.void_objc_msgSend_UInt64_nuint_UInt64_IntPtr_nuint_nuint(base.Handle, Selector.GetHandle("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:"), (ulong)primitiveType, indexCount, (ulong)indexType, indexBuffer.Handle, indexBufferOffset, instanceCount);
	}

	[Export("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DrawIndexedPrimitives(MTLPrimitiveType primitiveType, nuint indexCount, MTLIndexType indexType, IMTLBuffer indexBuffer, nuint indexBufferOffset)
	{
		if (indexBuffer == null)
		{
			throw new ArgumentNullException("indexBuffer");
		}
		Messaging.void_objc_msgSend_UInt64_nuint_UInt64_IntPtr_nuint(base.Handle, Selector.GetHandle("drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:"), (ulong)primitiveType, indexCount, (ulong)indexType, indexBuffer.Handle, indexBufferOffset);
	}

	[Export("setFragmentBuffers:offsets:withRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetFragmentBuffers(IMTLBuffer buffers, IntPtr IntPtrOffsets, NSRange range)
	{
		if (buffers == null)
		{
			throw new ArgumentNullException("buffers");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange(base.Handle, Selector.GetHandle("setFragmentBuffers:offsets:withRange:"), buffers.Handle, IntPtrOffsets, range);
	}

	[Export("setFragmentSamplerStates:lodMinClamps:lodMaxClamps:withRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetFragmentSamplerStates(IMTLSamplerState[] samplers, IntPtr floatArrayPtrLodMinClamps, IntPtr floatArrayPtrLodMaxClamps, NSRange range)
	{
		if (samplers == null)
		{
			throw new ArgumentNullException("samplers");
		}
		NSArray nSArray = NSArray.FromNSObjects(samplers);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange(base.Handle, Selector.GetHandle("setFragmentSamplerStates:lodMinClamps:lodMaxClamps:withRange:"), nSArray.Handle, floatArrayPtrLodMinClamps, floatArrayPtrLodMaxClamps, range);
		nSArray.Dispose();
	}

	[Export("setFragmentSamplerStates:withRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetFragmentSamplerStates(IMTLSamplerState[] samplers, NSRange range)
	{
		if (samplers == null)
		{
			throw new ArgumentNullException("samplers");
		}
		NSArray nSArray = NSArray.FromNSObjects(samplers);
		Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, Selector.GetHandle("setFragmentSamplerStates:withRange:"), nSArray.Handle, range);
		nSArray.Dispose();
	}

	[Export("setFragmentTextures:withRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetFragmentTextures(IMTLTexture[] textures, NSRange range)
	{
		if (textures == null)
		{
			throw new ArgumentNullException("textures");
		}
		NSArray nSArray = NSArray.FromNSObjects(textures);
		Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, Selector.GetHandle("setFragmentTextures:withRange:"), nSArray.Handle, range);
		nSArray.Dispose();
	}

	[Export("setVertexBuffers:offsets:withRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetVertexBuffers(IMTLBuffer[] buffers, IntPtr uintArrayPtrOffsets, NSRange range)
	{
		if (buffers == null)
		{
			throw new ArgumentNullException("buffers");
		}
		NSArray nSArray = NSArray.FromNSObjects(buffers);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange(base.Handle, Selector.GetHandle("setVertexBuffers:offsets:withRange:"), nSArray.Handle, uintArrayPtrOffsets, range);
		nSArray.Dispose();
	}

	[Export("setVertexBufferOffset:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetVertexBufferOffset(nuint offset, nuint index)
	{
		Messaging.void_objc_msgSend_nuint_nuint(base.Handle, Selector.GetHandle("setVertexBufferOffset:atIndex:"), offset, index);
	}

	[Export("setVertexBytes:length:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetVertexBytes(IntPtr bytes, nuint length, nuint index)
	{
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint(base.Handle, Selector.GetHandle("setVertexBytes:length:atIndex:"), bytes, length, index);
	}

	[Export("setVertexSamplerStates:lodMinClamps:lodMaxClamps:withRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetVertexSamplerStates(IMTLSamplerState[] samplers, IntPtr floatArrayPtrLodMinClamps, IntPtr floatArrayPtrLodMaxClamps, NSRange range)
	{
		if (samplers == null)
		{
			throw new ArgumentNullException("samplers");
		}
		NSArray nSArray = NSArray.FromNSObjects(samplers);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange(base.Handle, Selector.GetHandle("setVertexSamplerStates:lodMinClamps:lodMaxClamps:withRange:"), nSArray.Handle, floatArrayPtrLodMinClamps, floatArrayPtrLodMaxClamps, range);
		nSArray.Dispose();
	}

	[Export("setVertexSamplerStates:withRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetVertexSamplerStates(IMTLSamplerState[] samplers, NSRange range)
	{
		if (samplers == null)
		{
			throw new ArgumentNullException("samplers");
		}
		NSArray nSArray = NSArray.FromNSObjects(samplers);
		Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, Selector.GetHandle("setVertexSamplerStates:withRange:"), nSArray.Handle, range);
		nSArray.Dispose();
	}

	[Export("setVertexTextures:withRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetVertexTextures(IMTLTexture[] textures, NSRange range)
	{
		if (textures == null)
		{
			throw new ArgumentNullException("textures");
		}
		NSArray nSArray = NSArray.FromNSObjects(textures);
		Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, Selector.GetHandle("setVertexTextures:withRange:"), nSArray.Handle, range);
		nSArray.Dispose();
	}

	[Export("endEncoding")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void EndEncoding()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("endEncoding"));
	}

	[Export("insertDebugSignpost:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void InsertDebugSignpost(string signpost)
	{
		if (signpost == null)
		{
			throw new ArgumentNullException("signpost");
		}
		IntPtr intPtr = NSString.CreateNative(signpost);
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("insertDebugSignpost:"), intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[Export("pushDebugGroup:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void PushDebugGroup(string debugGroup)
	{
		if (debugGroup == null)
		{
			throw new ArgumentNullException("debugGroup");
		}
		IntPtr intPtr = NSString.CreateNative(debugGroup);
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("pushDebugGroup:"), intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[Export("popDebugGroup")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void PopDebugGroup()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("popDebugGroup"));
	}
}
