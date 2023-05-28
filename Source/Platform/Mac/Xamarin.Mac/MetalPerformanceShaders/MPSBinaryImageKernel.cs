using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSBinaryImageKernel", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class MPSBinaryImageKernel : MPSKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClipRect = "clipRect";

	private static readonly IntPtr selClipRectHandle = Selector.GetHandle("clipRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_InPlacePrimaryTexture_SecondaryTexture_FallbackCopyAllocator_ = "encodeToCommandBuffer:inPlacePrimaryTexture:secondaryTexture:fallbackCopyAllocator:";

	private static readonly IntPtr selEncodeToCommandBuffer_InPlacePrimaryTexture_SecondaryTexture_FallbackCopyAllocator_Handle = Selector.GetHandle("encodeToCommandBuffer:inPlacePrimaryTexture:secondaryTexture:fallbackCopyAllocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationImage_ = "encodeToCommandBuffer:primaryImage:secondaryImage:destinationImage:";

	private static readonly IntPtr selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationImage_Handle = Selector.GetHandle("encodeToCommandBuffer:primaryImage:secondaryImage:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_PrimaryTexture_InPlaceSecondaryTexture_FallbackCopyAllocator_ = "encodeToCommandBuffer:primaryTexture:inPlaceSecondaryTexture:fallbackCopyAllocator:";

	private static readonly IntPtr selEncodeToCommandBuffer_PrimaryTexture_InPlaceSecondaryTexture_FallbackCopyAllocator_Handle = Selector.GetHandle("encodeToCommandBuffer:primaryTexture:inPlaceSecondaryTexture:fallbackCopyAllocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_PrimaryTexture_SecondaryTexture_DestinationTexture_ = "encodeToCommandBuffer:primaryTexture:secondaryTexture:destinationTexture:";

	private static readonly IntPtr selEncodeToCommandBuffer_PrimaryTexture_SecondaryTexture_DestinationTexture_Handle = Selector.GetHandle("encodeToCommandBuffer:primaryTexture:secondaryTexture:destinationTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ = "initWithDevice:";

	private static readonly IntPtr selInitWithDevice_Handle = Selector.GetHandle("initWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryEdgeMode = "primaryEdgeMode";

	private static readonly IntPtr selPrimaryEdgeModeHandle = Selector.GetHandle("primaryEdgeMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryOffset = "primaryOffset";

	private static readonly IntPtr selPrimaryOffsetHandle = Selector.GetHandle("primaryOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimarySourceRegionForDestinationSize_ = "primarySourceRegionForDestinationSize:";

	private static readonly IntPtr selPrimarySourceRegionForDestinationSize_Handle = Selector.GetHandle("primarySourceRegionForDestinationSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryEdgeMode = "secondaryEdgeMode";

	private static readonly IntPtr selSecondaryEdgeModeHandle = Selector.GetHandle("secondaryEdgeMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryOffset = "secondaryOffset";

	private static readonly IntPtr selSecondaryOffsetHandle = Selector.GetHandle("secondaryOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondarySourceRegionForDestinationSize_ = "secondarySourceRegionForDestinationSize:";

	private static readonly IntPtr selSecondarySourceRegionForDestinationSize_Handle = Selector.GetHandle("secondarySourceRegionForDestinationSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClipRect_ = "setClipRect:";

	private static readonly IntPtr selSetClipRect_Handle = Selector.GetHandle("setClipRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimaryEdgeMode_ = "setPrimaryEdgeMode:";

	private static readonly IntPtr selSetPrimaryEdgeMode_Handle = Selector.GetHandle("setPrimaryEdgeMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimaryOffset_ = "setPrimaryOffset:";

	private static readonly IntPtr selSetPrimaryOffset_Handle = Selector.GetHandle("setPrimaryOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondaryEdgeMode_ = "setSecondaryEdgeMode:";

	private static readonly IntPtr selSetSecondaryEdgeMode_Handle = Selector.GetHandle("setSecondaryEdgeMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondaryOffset_ = "setSecondaryOffset:";

	private static readonly IntPtr selSetSecondaryOffset_Handle = Selector.GetHandle("setSecondaryOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSBinaryImageKernel");

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
	public virtual MPSImageEdgeMode PrimaryEdgeMode
	{
		[Export("primaryEdgeMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSImageEdgeMode)Messaging.UInt64_objc_msgSend(base.Handle, selPrimaryEdgeModeHandle);
			}
			return (MPSImageEdgeMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPrimaryEdgeModeHandle);
		}
		[Export("setPrimaryEdgeMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetPrimaryEdgeMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetPrimaryEdgeMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSOffset PrimaryOffset
	{
		[Export("primaryOffset", ArgumentSemantic.Assign)]
		get
		{
			MPSOffset retval;
			if (base.IsDirectBinding)
			{
				Messaging.MPSOffset_objc_msgSend_stret(out retval, base.Handle, selPrimaryOffsetHandle);
			}
			else
			{
				Messaging.MPSOffset_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPrimaryOffsetHandle);
			}
			return retval;
		}
		[Export("setPrimaryOffset:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MPSOffset(base.Handle, selSetPrimaryOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MPSOffset(base.SuperHandle, selSetPrimaryOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImageEdgeMode SecondaryEdgeMode
	{
		[Export("secondaryEdgeMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSImageEdgeMode)Messaging.UInt64_objc_msgSend(base.Handle, selSecondaryEdgeModeHandle);
			}
			return (MPSImageEdgeMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSecondaryEdgeModeHandle);
		}
		[Export("setSecondaryEdgeMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetSecondaryEdgeMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetSecondaryEdgeMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSOffset SecondaryOffset
	{
		[Export("secondaryOffset", ArgumentSemantic.Assign)]
		get
		{
			MPSOffset retval;
			if (base.IsDirectBinding)
			{
				Messaging.MPSOffset_objc_msgSend_stret(out retval, base.Handle, selSecondaryOffsetHandle);
			}
			else
			{
				Messaging.MPSOffset_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSecondaryOffsetHandle);
			}
			return retval;
		}
		[Export("setSecondaryOffset:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MPSOffset(base.Handle, selSetSecondaryOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MPSOffset(base.SuperHandle, selSetSecondaryOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSBinaryImageKernel(NSCoder coder)
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
	protected MPSBinaryImageKernel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSBinaryImageKernel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCoder:device:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSBinaryImageKernel(NSCoder aDecoder, IMTLDevice device)
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

	[Export("initWithDevice:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSBinaryImageKernel(IMTLDevice device)
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

	[Export("encodeToCommandBuffer:primaryTexture:inPlaceSecondaryTexture:fallbackCopyAllocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual bool EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, IMTLTexture primaryTexture, out NSObject inPlaceSecondaryTexture, [BlockProxy(typeof(Trampolines.NIDMPSCopyAllocator))] MPSCopyAllocator? copyAllocator)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (primaryTexture == null)
		{
			throw new ArgumentNullException("primaryTexture");
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
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_PrimaryTexture_InPlaceSecondaryTexture_FallbackCopyAllocator_Handle, commandBuffer.Handle, primaryTexture.Handle, ref arg, (IntPtr)ptr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_PrimaryTexture_InPlaceSecondaryTexture_FallbackCopyAllocator_Handle, commandBuffer.Handle, primaryTexture.Handle, ref arg, (IntPtr)ptr));
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		inPlaceSecondaryTexture = Runtime.GetNSObject<NSObject>(arg);
		return result;
	}

	[Export("encodeToCommandBuffer:inPlacePrimaryTexture:secondaryTexture:fallbackCopyAllocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual bool EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, out NSObject inPlacePrimaryTexture, IMTLTexture secondaryTexture, [BlockProxy(typeof(Trampolines.NIDMPSCopyAllocator))] MPSCopyAllocator? copyAllocator)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (secondaryTexture == null)
		{
			throw new ArgumentNullException("secondaryTexture");
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
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_InPlacePrimaryTexture_SecondaryTexture_FallbackCopyAllocator_Handle, commandBuffer.Handle, ref arg, secondaryTexture.Handle, (IntPtr)ptr) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_InPlacePrimaryTexture_SecondaryTexture_FallbackCopyAllocator_Handle, commandBuffer.Handle, ref arg, secondaryTexture.Handle, (IntPtr)ptr));
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		inPlacePrimaryTexture = Runtime.GetNSObject<NSObject>(arg);
		return result;
	}

	[Export("encodeToCommandBuffer:primaryTexture:secondaryTexture:destinationTexture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, IMTLTexture primaryTexture, IMTLTexture secondaryTexture, IMTLTexture destinationTexture)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (primaryTexture == null)
		{
			throw new ArgumentNullException("primaryTexture");
		}
		if (secondaryTexture == null)
		{
			throw new ArgumentNullException("secondaryTexture");
		}
		if (destinationTexture == null)
		{
			throw new ArgumentNullException("destinationTexture");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_PrimaryTexture_SecondaryTexture_DestinationTexture_Handle, commandBuffer.Handle, primaryTexture.Handle, secondaryTexture.Handle, destinationTexture.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_PrimaryTexture_SecondaryTexture_DestinationTexture_Handle, commandBuffer.Handle, primaryTexture.Handle, secondaryTexture.Handle, destinationTexture.Handle);
		}
	}

	[Export("encodeToCommandBuffer:primaryImage:secondaryImage:destinationImage:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSImage primaryImage, MPSImage secondaryImage, MPSImage destinationImage)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (primaryImage == null)
		{
			throw new ArgumentNullException("primaryImage");
		}
		if (secondaryImage == null)
		{
			throw new ArgumentNullException("secondaryImage");
		}
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationImage_Handle, commandBuffer.Handle, primaryImage.Handle, secondaryImage.Handle, destinationImage.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_PrimaryImage_SecondaryImage_DestinationImage_Handle, commandBuffer.Handle, primaryImage.Handle, secondaryImage.Handle, destinationImage.Handle);
		}
	}

	[Export("primarySourceRegionForDestinationSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSRegion PrimarySourceRegionForDestinationSize(MTLSize destinationSize)
	{
		MPSRegion retval;
		if (base.IsDirectBinding)
		{
			Messaging.MPSRegion_objc_msgSend_stret_MTLSize(out retval, base.Handle, selPrimarySourceRegionForDestinationSize_Handle, destinationSize);
		}
		else
		{
			Messaging.MPSRegion_objc_msgSendSuper_stret_MTLSize(out retval, base.SuperHandle, selPrimarySourceRegionForDestinationSize_Handle, destinationSize);
		}
		return retval;
	}

	[Export("secondarySourceRegionForDestinationSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSRegion SecondarySourceRegionForDestinationSize(MTLSize destinationSize)
	{
		MPSRegion retval;
		if (base.IsDirectBinding)
		{
			Messaging.MPSRegion_objc_msgSend_stret_MTLSize(out retval, base.Handle, selSecondarySourceRegionForDestinationSize_Handle, destinationSize);
		}
		else
		{
			Messaging.MPSRegion_objc_msgSendSuper_stret_MTLSize(out retval, base.SuperHandle, selSecondarySourceRegionForDestinationSize_Handle, destinationSize);
		}
		return retval;
	}
}
