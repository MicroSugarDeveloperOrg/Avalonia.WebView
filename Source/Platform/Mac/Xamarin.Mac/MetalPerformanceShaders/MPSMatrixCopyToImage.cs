using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSMatrixCopyToImage", true)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class MPSMatrixCopyToImage : MPSKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataLayout = "dataLayout";

	private static readonly IntPtr selDataLayoutHandle = Selector.GetHandle("dataLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_SourceMatrix_DestinationImages_ = "encodeBatchToCommandBuffer:sourceMatrix:destinationImages:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_SourceMatrix_DestinationImages_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:sourceMatrix:destinationImages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceMatrix_DestinationImage_ = "encodeToCommandBuffer:sourceMatrix:destinationImage:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceMatrix_DestinationImage_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceMatrix:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_DataLayout_ = "initWithDevice:dataLayout:";

	private static readonly IntPtr selInitWithDevice_DataLayout_Handle = Selector.GetHandle("initWithDevice:dataLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceMatrixBatchIndex_ = "setSourceMatrixBatchIndex:";

	private static readonly IntPtr selSetSourceMatrixBatchIndex_Handle = Selector.GetHandle("setSourceMatrixBatchIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceMatrixOrigin_ = "setSourceMatrixOrigin:";

	private static readonly IntPtr selSetSourceMatrixOrigin_Handle = Selector.GetHandle("setSourceMatrixOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceMatrixBatchIndex = "sourceMatrixBatchIndex";

	private static readonly IntPtr selSourceMatrixBatchIndexHandle = Selector.GetHandle("sourceMatrixBatchIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceMatrixOrigin = "sourceMatrixOrigin";

	private static readonly IntPtr selSourceMatrixOriginHandle = Selector.GetHandle("sourceMatrixOrigin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSMatrixCopyToImage");

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
	public virtual nuint SourceMatrixBatchIndex
	{
		[Export("sourceMatrixBatchIndex")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSourceMatrixBatchIndexHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSourceMatrixBatchIndexHandle);
		}
		[Export("setSourceMatrixBatchIndex:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSourceMatrixBatchIndex_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSourceMatrixBatchIndex_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLOrigin SourceMatrixOrigin
	{
		[Export("sourceMatrixOrigin", ArgumentSemantic.Assign)]
		get
		{
			MTLOrigin retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLOrigin_objc_msgSend_stret(out retval, base.Handle, selSourceMatrixOriginHandle);
			}
			else
			{
				Messaging.MTLOrigin_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSourceMatrixOriginHandle);
			}
			return retval;
		}
		[Export("setSourceMatrixOrigin:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MTLOrigin(base.Handle, selSetSourceMatrixOrigin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MTLOrigin(base.SuperHandle, selSetSourceMatrixOrigin_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSMatrixCopyToImage(NSCoder coder)
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
	protected MPSMatrixCopyToImage(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSMatrixCopyToImage(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:dataLayout:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixCopyToImage(IMTLDevice device, MPSDataLayout dataLayout)
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
	public MPSMatrixCopyToImage(NSCoder aDecoder, IMTLDevice device)
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

	[Export("encodeToCommandBuffer:sourceMatrix:destinationImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSMatrix sourceMatrix, MPSImage destinationImage)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceMatrix == null)
		{
			throw new ArgumentNullException("sourceMatrix");
		}
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_SourceMatrix_DestinationImage_Handle, commandBuffer.Handle, sourceMatrix.Handle, destinationImage.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_SourceMatrix_DestinationImage_Handle, commandBuffer.Handle, sourceMatrix.Handle, destinationImage.Handle);
		}
	}

	[Export("encodeBatchToCommandBuffer:sourceMatrix:destinationImages:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSMatrix sourceMatrix, NSArray<MPSImage> destinationImages)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceMatrix == null)
		{
			throw new ArgumentNullException("sourceMatrix");
		}
		if (destinationImages == null)
		{
			throw new ArgumentNullException("destinationImages");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeBatchToCommandBuffer_SourceMatrix_DestinationImages_Handle, commandBuffer.Handle, sourceMatrix.Handle, destinationImages.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeBatchToCommandBuffer_SourceMatrix_DestinationImages_Handle, commandBuffer.Handle, sourceMatrix.Handle, destinationImages.Handle);
		}
	}
}
