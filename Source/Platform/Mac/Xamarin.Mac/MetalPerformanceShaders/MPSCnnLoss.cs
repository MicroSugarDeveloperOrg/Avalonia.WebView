using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNLoss", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnLoss : MPSCnnKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelta = "delta";

	private static readonly IntPtr selDeltaHandle = Selector.GetHandle("delta");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_SourceImages_Labels_ = "encodeBatchToCommandBuffer:sourceImages:labels:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_SourceImages_Labels_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:sourceImages:labels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_SourceImages_Labels_DestinationImages_ = "encodeBatchToCommandBuffer:sourceImages:labels:destinationImages:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_SourceImages_Labels_DestinationImages_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:sourceImages:labels:destinationImages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceImage_Labels_ = "encodeToCommandBuffer:sourceImage:labels:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceImage_Labels_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceImage:labels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceImage_Labels_DestinationImage_ = "encodeToCommandBuffer:sourceImage:labels:destinationImage:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceImage_Labels_DestinationImage_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceImage:labels:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEpsilon = "epsilon";

	private static readonly IntPtr selEpsilonHandle = Selector.GetHandle("epsilon");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_LossDescriptor_ = "initWithDevice:lossDescriptor:";

	private static readonly IntPtr selInitWithDevice_LossDescriptor_Handle = Selector.GetHandle("initWithDevice:lossDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabelSmoothing = "labelSmoothing";

	private static readonly IntPtr selLabelSmoothingHandle = Selector.GetHandle("labelSmoothing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLossType = "lossType";

	private static readonly IntPtr selLossTypeHandle = Selector.GetHandle("lossType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfClasses = "numberOfClasses";

	private static readonly IntPtr selNumberOfClassesHandle = Selector.GetHandle("numberOfClasses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReductionType = "reductionType";

	private static readonly IntPtr selReductionTypeHandle = Selector.GetHandle("reductionType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWeight = "weight";

	private static readonly IntPtr selWeightHandle = Selector.GetHandle("weight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNLoss");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Delta
	{
		[Export("delta")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selDeltaHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selDeltaHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Epsilon
	{
		[Export("epsilon")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selEpsilonHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selEpsilonHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float LabelSmoothing
	{
		[Export("labelSmoothing")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selLabelSmoothingHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selLabelSmoothingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnLossType LossType
	{
		[Export("lossType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSCnnLossType)Messaging.UInt32_objc_msgSend(base.Handle, selLossTypeHandle);
			}
			return (MPSCnnLossType)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selLossTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NumberOfClasses
	{
		[Export("numberOfClasses")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumberOfClassesHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumberOfClassesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnReductionType ReductionType
	{
		[Export("reductionType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSCnnReductionType)Messaging.int_objc_msgSend(base.Handle, selReductionTypeHandle);
			}
			return (MPSCnnReductionType)Messaging.int_objc_msgSendSuper(base.SuperHandle, selReductionTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Weight
	{
		[Export("weight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selWeightHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selWeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnLoss(NSCoder coder)
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
	protected MPSCnnLoss(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnLoss(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:lossDescriptor:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnLoss(IMTLDevice device, MPSCnnLossDescriptor lossDescriptor)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (lossDescriptor == null)
		{
			throw new ArgumentNullException("lossDescriptor");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDevice_LossDescriptor_Handle, device.Handle, lossDescriptor.Handle), "initWithDevice:lossDescriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_LossDescriptor_Handle, device.Handle, lossDescriptor.Handle), "initWithDevice:lossDescriptor:");
		}
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnLoss(NSCoder decoder, IMTLDevice device)
		: base(NSObjectFlag.Empty)
	{
		if (decoder == null)
		{
			throw new ArgumentNullException("decoder");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCoder_Device_Handle, decoder.Handle, device.Handle), "initWithCoder:device:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCoder_Device_Handle, decoder.Handle, device.Handle), "initWithCoder:device:");
		}
	}

	[Export("encodeToCommandBuffer:sourceImage:labels:destinationImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSCnnLossLabels labels, MPSImage destinationImage)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_SourceImage_Labels_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, labels.Handle, destinationImage.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_SourceImage_Labels_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, labels.Handle, destinationImage.Handle);
		}
	}

	[Export("encodeToCommandBuffer:sourceImage:labels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImage Encode(IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSCnnLossLabels labels)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_SourceImage_Labels_Handle, commandBuffer.Handle, sourceImage.Handle, labels.Handle));
		}
		return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_SourceImage_Labels_Handle, commandBuffer.Handle, sourceImage.Handle, labels.Handle));
	}

	[Export("encodeBatchToCommandBuffer:sourceImages:labels:destinationImages:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceImage, NSArray<MPSCnnLossLabels> labels, NSArray<MPSImage> destinationImage)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeBatchToCommandBuffer_SourceImages_Labels_DestinationImages_Handle, commandBuffer.Handle, sourceImage.Handle, labels.Handle, destinationImage.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeBatchToCommandBuffer_SourceImages_Labels_DestinationImages_Handle, commandBuffer.Handle, sourceImage.Handle, labels.Handle, destinationImage.Handle);
		}
	}

	[Export("encodeBatchToCommandBuffer:sourceImages:labels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray<MPSImage> EncodeBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceImage, NSArray<MPSCnnLossLabels> labels)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeBatchToCommandBuffer_SourceImages_Labels_Handle, commandBuffer.Handle, sourceImage.Handle, labels.Handle));
		}
		return Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeBatchToCommandBuffer_SourceImages_Labels_Handle, commandBuffer.Handle, sourceImage.Handle, labels.Handle));
	}
}
