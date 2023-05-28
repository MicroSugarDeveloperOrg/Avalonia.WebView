using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

internal sealed class MTLComputeCommandEncoderWrapper : BaseWrapper, IMTLComputeCommandEncoder, INativeObject, IDisposable, IMTLCommandEncoder
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
	public MTLComputeCommandEncoderWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("setComputePipelineState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetComputePipelineState(IMTLComputePipelineState state)
	{
		if (state == null)
		{
			throw new ArgumentNullException("state");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setComputePipelineState:"), state.Handle);
	}

	[Export("setBuffer:offset:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetBuffer(IMTLBuffer buffer, nuint offset, nuint index)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint(base.Handle, Selector.GetHandle("setBuffer:offset:atIndex:"), buffer.Handle, offset, index);
	}

	[Export("setTexture:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetTexture(IMTLTexture texture, nuint index)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, Selector.GetHandle("setTexture:atIndex:"), texture.Handle, index);
	}

	[Export("setSamplerState:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetSamplerState(IMTLSamplerState sampler, nuint index)
	{
		if (sampler == null)
		{
			throw new ArgumentNullException("sampler");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, Selector.GetHandle("setSamplerState:atIndex:"), sampler.Handle, index);
	}

	[Export("setSamplerState:lodMinClamp:lodMaxClamp:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetSamplerState(IMTLSamplerState sampler, float lodMinClamp, float lodMaxClamp, nuint index)
	{
		if (sampler == null)
		{
			throw new ArgumentNullException("sampler");
		}
		Messaging.void_objc_msgSend_IntPtr_float_float_nuint(base.Handle, Selector.GetHandle("setSamplerState:lodMinClamp:lodMaxClamp:atIndex:"), sampler.Handle, lodMinClamp, lodMaxClamp, index);
	}

	[Export("setThreadgroupMemoryLength:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetThreadgroupMemoryLength(nuint length, nuint index)
	{
		Messaging.void_objc_msgSend_nuint_nuint(base.Handle, Selector.GetHandle("setThreadgroupMemoryLength:atIndex:"), length, index);
	}

	[Export("dispatchThreadgroups:threadsPerThreadgroup:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DispatchThreadgroups(MTLSize threadgroupsPerGrid, MTLSize threadsPerThreadgroup)
	{
		Messaging.void_objc_msgSend_MTLSize_MTLSize(base.Handle, Selector.GetHandle("dispatchThreadgroups:threadsPerThreadgroup:"), threadgroupsPerGrid, threadsPerThreadgroup);
	}

	[Export("setBuffers:offsets:withRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetBuffers(IMTLBuffer[] buffers, IntPtr offsets, NSRange range)
	{
		if (buffers == null)
		{
			throw new ArgumentNullException("buffers");
		}
		NSArray nSArray = NSArray.FromNSObjects(buffers);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange(base.Handle, Selector.GetHandle("setBuffers:offsets:withRange:"), nSArray.Handle, offsets, range);
		nSArray.Dispose();
	}

	[Export("setSamplerStates:lodMinClamps:lodMaxClamps:withRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetSamplerStates(IMTLSamplerState[] samplers, IntPtr floatArrayPtrLodMinClamps, IntPtr floatArrayPtrLodMaxClamps, NSRange range)
	{
		if (samplers == null)
		{
			throw new ArgumentNullException("samplers");
		}
		NSArray nSArray = NSArray.FromNSObjects(samplers);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange(base.Handle, Selector.GetHandle("setSamplerStates:lodMinClamps:lodMaxClamps:withRange:"), nSArray.Handle, floatArrayPtrLodMinClamps, floatArrayPtrLodMaxClamps, range);
		nSArray.Dispose();
	}

	[Export("setSamplerStates:withRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetSamplerStates(IMTLSamplerState[] samplers, NSRange range)
	{
		if (samplers == null)
		{
			throw new ArgumentNullException("samplers");
		}
		NSArray nSArray = NSArray.FromNSObjects(samplers);
		Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, Selector.GetHandle("setSamplerStates:withRange:"), nSArray.Handle, range);
		nSArray.Dispose();
	}

	[Export("setTextures:withRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetTextures(IMTLTexture[] textures, NSRange range)
	{
		if (textures == null)
		{
			throw new ArgumentNullException("textures");
		}
		NSArray nSArray = NSArray.FromNSObjects(textures);
		Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, Selector.GetHandle("setTextures:withRange:"), nSArray.Handle, range);
		nSArray.Dispose();
	}

	[Export("setBufferOffset:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetBufferOffset(nuint offset, nuint index)
	{
		Messaging.void_objc_msgSend_nuint_nuint(base.Handle, Selector.GetHandle("setBufferOffset:atIndex:"), offset, index);
	}

	[Export("setBytes:length:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetBytes(IntPtr bytes, nuint length, nuint index)
	{
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint(base.Handle, Selector.GetHandle("setBytes:length:atIndex:"), bytes, length, index);
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
