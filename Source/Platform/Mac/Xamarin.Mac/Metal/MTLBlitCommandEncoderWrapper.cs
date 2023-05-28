using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

internal sealed class MTLBlitCommandEncoderWrapper : BaseWrapper, IMTLBlitCommandEncoder, INativeObject, IDisposable, IMTLCommandEncoder
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
	public MTLBlitCommandEncoderWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("synchronizeResource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Synchronize(IMTLResource resource)
	{
		if (resource == null)
		{
			throw new ArgumentNullException("resource");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("synchronizeResource:"), resource.Handle);
	}

	[Export("synchronizeTexture:slice:level:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Synchronize(IMTLTexture texture, nuint slice, nuint level)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint(base.Handle, Selector.GetHandle("synchronizeTexture:slice:level:"), texture.Handle, slice, level);
	}

	[Export("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void CopyFromTexture(IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin)
	{
		if (sourceTexture == null)
		{
			throw new ArgumentNullException("sourceTexture");
		}
		if (destinationTexture == null)
		{
			throw new ArgumentNullException("destinationTexture");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint_MTLOrigin_MTLSize_IntPtr_nuint_nuint_MTLOrigin(base.Handle, Selector.GetHandle("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:"), sourceTexture.Handle, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationTexture.Handle, destinationSlice, destinationLevel, destinationOrigin);
	}

	[Export("copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void CopyFromBuffer(IMTLBuffer sourceBuffer, nuint sourceOffset, nuint sourceBytesPerRow, nuint sourceBytesPerImage, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin)
	{
		if (sourceBuffer == null)
		{
			throw new ArgumentNullException("sourceBuffer");
		}
		if (destinationTexture == null)
		{
			throw new ArgumentNullException("destinationTexture");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint_nuint_MTLSize_IntPtr_nuint_nuint_MTLOrigin(base.Handle, Selector.GetHandle("copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:"), sourceBuffer.Handle, sourceOffset, sourceBytesPerRow, sourceBytesPerImage, sourceSize, destinationTexture.Handle, destinationSlice, destinationLevel, destinationOrigin);
	}

	[Export("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void CopyFromTexture(IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint destinatinBytesPerRow, nuint destinationBytesPerImage)
	{
		if (sourceTexture == null)
		{
			throw new ArgumentNullException("sourceTexture");
		}
		if (destinationBuffer == null)
		{
			throw new ArgumentNullException("destinationBuffer");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint_MTLOrigin_MTLSize_IntPtr_nuint_nuint_nuint(base.Handle, Selector.GetHandle("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:"), sourceTexture.Handle, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationBuffer.Handle, destinationOffset, destinatinBytesPerRow, destinationBytesPerImage);
	}

	[Export("generateMipmapsForTexture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void GenerateMipmapsForTexture(IMTLTexture texture)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("generateMipmapsForTexture:"), texture.Handle);
	}

	[Export("fillBuffer:range:value:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FillBuffer(IMTLBuffer buffer, NSRange range, byte value)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		Messaging.void_objc_msgSend_IntPtr_NSRange_byte(base.Handle, Selector.GetHandle("fillBuffer:range:value:"), buffer.Handle, range, value);
	}

	[Export("copyFromBuffer:sourceOffset:toBuffer:destinationOffset:size:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void CopyFromBuffer(IMTLBuffer sourceBuffer, nuint sourceOffset, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint size)
	{
		if (sourceBuffer == null)
		{
			throw new ArgumentNullException("sourceBuffer");
		}
		if (destinationBuffer == null)
		{
			throw new ArgumentNullException("destinationBuffer");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr_nuint_nuint(base.Handle, Selector.GetHandle("copyFromBuffer:sourceOffset:toBuffer:destinationOffset:size:"), sourceBuffer.Handle, sourceOffset, destinationBuffer.Handle, destinationOffset, size);
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
