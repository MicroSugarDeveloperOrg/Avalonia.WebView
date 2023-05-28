using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSImageCopyToMatrix", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSImageCopyToMatrix : MPSKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataLayout = "dataLayout";

	private static readonly IntPtr selDataLayoutHandle = Selector.GetHandle("dataLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationMatrixBatchIndex = "destinationMatrixBatchIndex";

	private static readonly IntPtr selDestinationMatrixBatchIndexHandle = Selector.GetHandle("destinationMatrixBatchIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationMatrixOrigin = "destinationMatrixOrigin";

	private static readonly IntPtr selDestinationMatrixOriginHandle = Selector.GetHandle("destinationMatrixOrigin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_SourceImages_DestinationMatrix_ = "encodeBatchToCommandBuffer:sourceImages:destinationMatrix:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_SourceImages_DestinationMatrix_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:sourceImages:destinationMatrix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceImage_DestinationMatrix_ = "encodeToCommandBuffer:sourceImage:destinationMatrix:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceImage_DestinationMatrix_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceImage:destinationMatrix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_DataLayout_ = "initWithDevice:dataLayout:";

	private static readonly IntPtr selInitWithDevice_DataLayout_Handle = Selector.GetHandle("initWithDevice:dataLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDestinationMatrixBatchIndex_ = "setDestinationMatrixBatchIndex:";

	private static readonly IntPtr selSetDestinationMatrixBatchIndex_Handle = Selector.GetHandle("setDestinationMatrixBatchIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDestinationMatrixOrigin_ = "setDestinationMatrixOrigin:";

	private static readonly IntPtr selSetDestinationMatrixOrigin_Handle = Selector.GetHandle("setDestinationMatrixOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSImageCopyToMatrix");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSDataLayout DataLayout
	{
		[Export("dataLayout")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSDataLayout)Messaging.UInt64_objc_msgSend(base.Handle, selDataLayoutHandle);
			}
			return (MPSDataLayout)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDataLayoutHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint DestinationMatrixBatchIndex
	{
		[Export("destinationMatrixBatchIndex")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selDestinationMatrixBatchIndexHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDestinationMatrixBatchIndexHandle);
		}
		[Export("setDestinationMatrixBatchIndex:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetDestinationMatrixBatchIndex_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetDestinationMatrixBatchIndex_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLOrigin DestinationMatrixOrigin
	{
		[Export("destinationMatrixOrigin", ArgumentSemantic.Assign)]
		get
		{
			MTLOrigin retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLOrigin_objc_msgSend_stret(out retval, base.Handle, selDestinationMatrixOriginHandle);
			}
			else
			{
				Messaging.MTLOrigin_objc_msgSendSuper_stret(out retval, base.SuperHandle, selDestinationMatrixOriginHandle);
			}
			return retval;
		}
		[Export("setDestinationMatrixOrigin:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MTLOrigin(base.Handle, selSetDestinationMatrixOrigin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MTLOrigin(base.SuperHandle, selSetDestinationMatrixOrigin_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSImageCopyToMatrix(NSCoder coder)
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
	protected MPSImageCopyToMatrix(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSImageCopyToMatrix(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:dataLayout:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImageCopyToMatrix(IMTLDevice device, MPSDataLayout dataLayout)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selInitWithDevice_DataLayout_Handle, device.Handle, (ulong)dataLayout), "initWithDevice:dataLayout:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selInitWithDevice_DataLayout_Handle, device.Handle, (ulong)dataLayout), "initWithDevice:dataLayout:");
		}
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImageCopyToMatrix(NSCoder aDecoder, IMTLDevice device)
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

	[Export("encodeToCommandBuffer:sourceImage:destinationMatrix:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSMatrix destinationMatrix)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (destinationMatrix == null)
		{
			throw new ArgumentNullException("destinationMatrix");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_SourceImage_DestinationMatrix_Handle, commandBuffer.Handle, sourceImage.Handle, destinationMatrix.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_SourceImage_DestinationMatrix_Handle, commandBuffer.Handle, sourceImage.Handle, destinationMatrix.Handle);
		}
	}

	[Export("encodeBatchToCommandBuffer:sourceImages:destinationMatrix:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceImages, MPSMatrix destinationMatrix)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImages == null)
		{
			throw new ArgumentNullException("sourceImages");
		}
		if (destinationMatrix == null)
		{
			throw new ArgumentNullException("destinationMatrix");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeBatchToCommandBuffer_SourceImages_DestinationMatrix_Handle, commandBuffer.Handle, sourceImages.Handle, destinationMatrix.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeBatchToCommandBuffer_SourceImages_DestinationMatrix_Handle, commandBuffer.Handle, sourceImages.Handle, destinationMatrix.Handle);
		}
	}
}
