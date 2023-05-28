using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSUnaryImageKernel", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class MPSUnaryImageKernel : MPSKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClipRect = "clipRect";

	private static readonly IntPtr selClipRectHandle = Selector.GetHandle("clipRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEdgeMode = "edgeMode";

	private static readonly IntPtr selEdgeModeHandle = Selector.GetHandle("edgeMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_InPlaceTexture_FallbackCopyAllocator_ = "encodeToCommandBuffer:inPlaceTexture:fallbackCopyAllocator:";

	private static readonly IntPtr selEncodeToCommandBuffer_InPlaceTexture_FallbackCopyAllocator_Handle = Selector.GetHandle("encodeToCommandBuffer:inPlaceTexture:fallbackCopyAllocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceImage_DestinationImage_ = "encodeToCommandBuffer:sourceImage:destinationImage:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceImage_DestinationImage_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceImage:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceTexture_DestinationTexture_ = "encodeToCommandBuffer:sourceTexture:destinationTexture:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceTexture_DestinationTexture_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceTexture:destinationTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ = "initWithDevice:";

	private static readonly IntPtr selInitWithDevice_Handle = Selector.GetHandle("initWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOffset = "offset";

	private static readonly IntPtr selOffsetHandle = Selector.GetHandle("offset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClipRect_ = "setClipRect:";

	private static readonly IntPtr selSetClipRect_Handle = Selector.GetHandle("setClipRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEdgeMode_ = "setEdgeMode:";

	private static readonly IntPtr selSetEdgeMode_Handle = Selector.GetHandle("setEdgeMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOffset_ = "setOffset:";

	private static readonly IntPtr selSetOffset_Handle = Selector.GetHandle("setOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceRegionForDestinationSize_ = "sourceRegionForDestinationSize:";

	private static readonly IntPtr selSourceRegionForDestinationSize_Handle = Selector.GetHandle("sourceRegionForDestinationSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSUnaryImageKernel");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLRegion ClipRect
	{
		[Export("clipRect", ArgumentSemantic.Assign)]
		get
		{
			MTLRegion retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLRegion_objc_msgSend_stret(out retval, base.Handle, selClipRectHandle);
			}
			else
			{
				Messaging.MTLRegion_objc_msgSendSuper_stret(out retval, base.SuperHandle, selClipRectHandle);
			}
			return retval;
		}
		[Export("setClipRect:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MTLRegion(base.Handle, selSetClipRect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MTLRegion(base.SuperHandle, selSetClipRect_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImageEdgeMode EdgeMode
	{
		[Export("edgeMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSImageEdgeMode)Messaging.UInt64_objc_msgSend(base.Handle, selEdgeModeHandle);
			}
			return (MPSImageEdgeMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selEdgeModeHandle);
		}
		[Export("setEdgeMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetEdgeMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetEdgeMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSOffset Offset
	{
		[Export("offset", ArgumentSemantic.Assign)]
		get
		{
			MPSOffset retval;
			if (base.IsDirectBinding)
			{
				Messaging.MPSOffset_objc_msgSend_stret(out retval, base.Handle, selOffsetHandle);
			}
			else
			{
				Messaging.MPSOffset_objc_msgSendSuper_stret(out retval, base.SuperHandle, selOffsetHandle);
			}
			return retval;
		}
		[Export("setOffset:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MPSOffset(base.Handle, selSetOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MPSOffset(base.SuperHandle, selSetOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSUnaryImageKernel(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSUnaryImageKernel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSUnaryImageKernel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSUnaryImageKernel(IMTLDevice device)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithDevice_Handle, device.Handle), "initWithDevice:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithDevice_Handle, device.Handle), "initWithDevice:");
		}
	}

	[Export("initWithCoder:device:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSUnaryImageKernel(NSCoder aDecoder, IMTLDevice device)
		: base(NSObjectFlag.Empty)
	{
		if (aDecoder == null)
		{
			throw new ArgumentNullException("aDecoder");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCoder_Device_Handle, aDecoder.Handle, device.Handle), "initWithCoder:device:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCoder_Device_Handle, aDecoder.Handle, device.Handle), "initWithCoder:device:");
		}
	}

	[Export("encodeToCommandBuffer:inPlaceTexture:fallbackCopyAllocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual bool EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, out NSObject texture, [BlockProxy(typeof(Trampolines.NIDMPSCopyAllocator))] MPSCopyAllocator? copyAllocator)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		IntPtr arg = IntPtr.Zero;
		BlockLiteral* ptr;
		if (copyAllocator == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDMPSCopyAllocator.Handler, copyAllocator);
		}
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_InPlaceTexture_FallbackCopyAllocator_Handle, commandBuffer.Handle, ref arg, (IntPtr)ptr) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_InPlaceTexture_FallbackCopyAllocator_Handle, commandBuffer.Handle, ref arg, (IntPtr)ptr));
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		texture = Runtime.GetNSObject<NSObject>(arg);
		return result;
	}

	[Export("encodeToCommandBuffer:sourceTexture:destinationTexture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, IMTLTexture sourceTexture, IMTLTexture destinationTexture)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceTexture == null)
		{
			throw new ArgumentNullException("sourceTexture");
		}
		if (destinationTexture == null)
		{
			throw new ArgumentNullException("destinationTexture");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_SourceTexture_DestinationTexture_Handle, commandBuffer.Handle, sourceTexture.Handle, destinationTexture.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_SourceTexture_DestinationTexture_Handle, commandBuffer.Handle, sourceTexture.Handle, destinationTexture.Handle);
		}
	}

	[Export("encodeToCommandBuffer:sourceImage:destinationImage:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSImage destinationImage)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_SourceImage_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, destinationImage.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_SourceImage_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, destinationImage.Handle);
		}
	}

	[Export("sourceRegionForDestinationSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSRegion SourceRegionForDestinationSize(MTLSize destinationSize)
	{
		MPSRegion retval;
		if (base.IsDirectBinding)
		{
			Messaging.MPSRegion_objc_msgSend_stret_MTLSize(out retval, base.Handle, selSourceRegionForDestinationSize_Handle, destinationSize);
		}
		else
		{
			Messaging.MPSRegion_objc_msgSendSuper_stret_MTLSize(out retval, base.SuperHandle, selSourceRegionForDestinationSize_Handle, destinationSize);
		}
		return retval;
	}
}
