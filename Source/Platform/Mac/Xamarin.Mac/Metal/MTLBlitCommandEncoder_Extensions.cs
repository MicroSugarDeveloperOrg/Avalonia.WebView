using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

public static class MTLBlitCommandEncoder_Extensions
{
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CopyFromBuffer(this IMTLBlitCommandEncoder This, IMTLBuffer sourceBuffer, nuint sourceOffset, nuint sourceBytesPerRow, nuint sourceBytesPerImage, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin, MTLBlitOption options)
	{
		if (sourceBuffer == null)
		{
			throw new ArgumentNullException("sourceBuffer");
		}
		if (destinationTexture == null)
		{
			throw new ArgumentNullException("destinationTexture");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint_nuint_MTLSize_IntPtr_nuint_nuint_MTLOrigin_UInt64(This.Handle, Selector.GetHandle("copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:options:"), sourceBuffer.Handle, sourceOffset, sourceBytesPerRow, sourceBytesPerImage, sourceSize, destinationTexture.Handle, destinationSlice, destinationLevel, destinationOrigin, (ulong)options);
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CopyFromTexture(this IMTLBlitCommandEncoder This, IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint destinatinBytesPerRow, nuint destinationBytesPerImage, MTLBlitOption options)
	{
		if (sourceTexture == null)
		{
			throw new ArgumentNullException("sourceTexture");
		}
		if (destinationBuffer == null)
		{
			throw new ArgumentNullException("destinationBuffer");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint_MTLOrigin_MTLSize_IntPtr_nuint_nuint_nuint_UInt64(This.Handle, Selector.GetHandle("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:options:"), sourceTexture.Handle, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationBuffer.Handle, destinationOffset, destinatinBytesPerRow, destinationBytesPerImage, (ulong)options);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Update(this IMTLBlitCommandEncoder This, IMTLFence fence)
	{
		if (fence == null)
		{
			throw new ArgumentNullException("fence");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("updateFence:"), fence.Handle);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Wait(this IMTLBlitCommandEncoder This, IMTLFence fence)
	{
		if (fence == null)
		{
			throw new ArgumentNullException("fence");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("waitForFence:"), fence.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OptimizeContentsForGpuAccess(this IMTLBlitCommandEncoder This, IMTLTexture texture)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("optimizeContentsForGPUAccess:"), texture.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OptimizeContentsForGpuAccess(this IMTLBlitCommandEncoder This, IMTLTexture texture, nuint slice, nuint level)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint(This.Handle, Selector.GetHandle("optimizeContentsForGPUAccess:slice:level:"), texture.Handle, slice, level);
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OptimizeContentsForCpuAccess(this IMTLBlitCommandEncoder This, IMTLTexture texture)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("optimizeContentsForCPUAccess:"), texture.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OptimizeContentsForCpuAccess(this IMTLBlitCommandEncoder This, IMTLTexture texture, nuint slice, nuint level)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint(This.Handle, Selector.GetHandle("optimizeContentsForCPUAccess:slice:level:"), texture.Handle, slice, level);
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ResetCommands(this IMTLBlitCommandEncoder This, IMTLIndirectCommandBuffer buffer, NSRange range)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		Messaging.void_objc_msgSend_IntPtr_NSRange(This.Handle, Selector.GetHandle("resetCommandsInBuffer:withRange:"), buffer.Handle, range);
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Copy(this IMTLBlitCommandEncoder This, IMTLIndirectCommandBuffer source, NSRange sourceRange, IMTLIndirectCommandBuffer destination, nuint destinationIndex)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		Messaging.void_objc_msgSend_IntPtr_NSRange_IntPtr_nuint(This.Handle, Selector.GetHandle("copyIndirectCommandBuffer:sourceRange:destination:destinationIndex:"), source.Handle, sourceRange, destination.Handle, destinationIndex);
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Optimize(this IMTLBlitCommandEncoder This, IMTLIndirectCommandBuffer indirectCommandBuffer, NSRange range)
	{
		if (indirectCommandBuffer == null)
		{
			throw new ArgumentNullException("indirectCommandBuffer");
		}
		Messaging.void_objc_msgSend_IntPtr_NSRange(This.Handle, Selector.GetHandle("optimizeIndirectCommandBuffer:withRange:"), indirectCommandBuffer.Handle, range);
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Copy(this IMTLBlitCommandEncoder This, IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, nuint sliceCount, nuint levelCount)
	{
		if (sourceTexture == null)
		{
			throw new ArgumentNullException("sourceTexture");
		}
		if (destinationTexture == null)
		{
			throw new ArgumentNullException("destinationTexture");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint_IntPtr_nuint_nuint_nuint_nuint(This.Handle, Selector.GetHandle("copyFromTexture:sourceSlice:sourceLevel:toTexture:destinationSlice:destinationLevel:sliceCount:levelCount:"), sourceTexture.Handle, sourceSlice, sourceLevel, destinationTexture.Handle, destinationSlice, destinationLevel, sliceCount, levelCount);
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Copy(this IMTLBlitCommandEncoder This, IMTLTexture sourceTexture, IMTLTexture destinationTexture)
	{
		if (sourceTexture == null)
		{
			throw new ArgumentNullException("sourceTexture");
		}
		if (destinationTexture == null)
		{
			throw new ArgumentNullException("destinationTexture");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("copyFromTexture:toTexture:"), sourceTexture.Handle, destinationTexture.Handle);
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SampleCounters(this IMTLBlitCommandEncoder This, MTLCounterSampleBuffer sampleBuffer, nuint sampleIndex, bool barrier)
	{
		if (sampleBuffer == null)
		{
			throw new ArgumentNullException("sampleBuffer");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint_bool(This.Handle, Selector.GetHandle("sampleCountersInBuffer:atSampleIndex:withBarrier:"), sampleBuffer.Handle, sampleIndex, barrier);
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ResolveCounters(this IMTLBlitCommandEncoder This, MTLCounterSampleBuffer sampleBuffer, NSRange range, IMTLBuffer destinationBuffer, nuint destinationOffset)
	{
		if (sampleBuffer == null)
		{
			throw new ArgumentNullException("sampleBuffer");
		}
		if (destinationBuffer == null)
		{
			throw new ArgumentNullException("destinationBuffer");
		}
		Messaging.void_objc_msgSend_IntPtr_NSRange_IntPtr_nuint(This.Handle, Selector.GetHandle("resolveCounters:inRange:destinationBuffer:destinationOffset:"), sampleBuffer.Handle, range, destinationBuffer.Handle, destinationOffset);
	}
}
