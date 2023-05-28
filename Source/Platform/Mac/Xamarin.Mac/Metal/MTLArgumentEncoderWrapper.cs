using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

internal sealed class MTLArgumentEncoderWrapper : BaseWrapper, IMTLArgumentEncoder, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLDevice Device
	{
		[Export("device")]
		get
		{
			return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("device")), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string? Label
	{
		[Export("label")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("label")));
		}
		[Export("setLabel:")]
		set
		{
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setLabel:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint EncodedLength
	{
		[Export("encodedLength")]
		get
		{
			return Messaging.nuint_objc_msgSend(base.Handle, Selector.GetHandle("encodedLength"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint Alignment
	{
		[Export("alignment")]
		get
		{
			return Messaging.nuint_objc_msgSend(base.Handle, Selector.GetHandle("alignment"));
		}
	}

	[Preserve(Conditional = true)]
	public MTLArgumentEncoderWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("setArgumentBuffer:offset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetArgumentBuffer(IMTLBuffer? argumentBuffer, nuint offset)
	{
		Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, Selector.GetHandle("setArgumentBuffer:offset:"), argumentBuffer?.Handle ?? IntPtr.Zero, offset);
	}

	[Export("setArgumentBuffer:startOffset:arrayElement:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetArgumentBuffer(IMTLBuffer? argumentBuffer, nuint startOffset, nuint arrayElement)
	{
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint(base.Handle, Selector.GetHandle("setArgumentBuffer:startOffset:arrayElement:"), argumentBuffer?.Handle ?? IntPtr.Zero, startOffset, arrayElement);
	}

	[Export("setBuffer:offset:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetBuffer(IMTLBuffer? buffer, nuint offset, nuint index)
	{
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint(base.Handle, Selector.GetHandle("setBuffer:offset:atIndex:"), buffer?.Handle ?? IntPtr.Zero, offset, index);
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

	[Export("setTexture:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetTexture(IMTLTexture? texture, nuint index)
	{
		Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, Selector.GetHandle("setTexture:atIndex:"), texture?.Handle ?? IntPtr.Zero, index);
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

	[Export("setSamplerState:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetSamplerState(IMTLSamplerState? sampler, nuint index)
	{
		Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, Selector.GetHandle("setSamplerState:atIndex:"), sampler?.Handle ?? IntPtr.Zero, index);
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

	[Export("constantDataAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IntPtr GetConstantData(nuint index)
	{
		return Messaging.IntPtr_objc_msgSend_nuint(base.Handle, Selector.GetHandle("constantDataAtIndex:"), index);
	}

	[Export("newArgumentEncoderForBufferAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public IMTLArgumentEncoder? CreateArgumentEncoder(nuint index)
	{
		IMTLArgumentEncoder iNativeObject = Runtime.GetINativeObject<IMTLArgumentEncoder>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, Selector.GetHandle("newArgumentEncoderForBufferAtIndex:"), index), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}
}
