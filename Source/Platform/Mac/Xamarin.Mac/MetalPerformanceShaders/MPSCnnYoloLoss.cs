using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSCNNYOLOLoss", true)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class MPSCnnYoloLoss : MPSCnnKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnchorBoxes = "anchorBoxes";

	private static readonly IntPtr selAnchorBoxesHandle = Selector.GetHandle("anchorBoxes");

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
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_LossDescriptor_ = "initWithDevice:lossDescriptor:";

	private static readonly IntPtr selInitWithDevice_LossDescriptor_Handle = Selector.GetHandle("initWithDevice:lossDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLossClasses = "lossClasses";

	private static readonly IntPtr selLossClassesHandle = Selector.GetHandle("lossClasses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLossConfidence = "lossConfidence";

	private static readonly IntPtr selLossConfidenceHandle = Selector.GetHandle("lossConfidence");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLossWH = "lossWH";

	private static readonly IntPtr selLossWHHandle = Selector.GetHandle("lossWH");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLossXY = "lossXY";

	private static readonly IntPtr selLossXYHandle = Selector.GetHandle("lossXY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxIOUForObjectAbsence = "maxIOUForObjectAbsence";

	private static readonly IntPtr selMaxIOUForObjectAbsenceHandle = Selector.GetHandle("maxIOUForObjectAbsence");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinIOUForObjectPresence = "minIOUForObjectPresence";

	private static readonly IntPtr selMinIOUForObjectPresenceHandle = Selector.GetHandle("minIOUForObjectPresence");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfAnchorBoxes = "numberOfAnchorBoxes";

	private static readonly IntPtr selNumberOfAnchorBoxesHandle = Selector.GetHandle("numberOfAnchorBoxes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReductionType = "reductionType";

	private static readonly IntPtr selReductionTypeHandle = Selector.GetHandle("reductionType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleClass = "scaleClass";

	private static readonly IntPtr selScaleClassHandle = Selector.GetHandle("scaleClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleNoObject = "scaleNoObject";

	private static readonly IntPtr selScaleNoObjectHandle = Selector.GetHandle("scaleNoObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleObject = "scaleObject";

	private static readonly IntPtr selScaleObjectHandle = Selector.GetHandle("scaleObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleWH = "scaleWH";

	private static readonly IntPtr selScaleWHHandle = Selector.GetHandle("scaleWH");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleXY = "scaleXY";

	private static readonly IntPtr selScaleXYHandle = Selector.GetHandle("scaleXY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNYOLOLoss");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData AnchorBoxes
	{
		[Export("anchorBoxes", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnchorBoxesHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnchorBoxesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnLoss LossClasses
	{
		[Export("lossClasses", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSCnnLoss>(Messaging.IntPtr_objc_msgSend(base.Handle, selLossClassesHandle));
			}
			return Runtime.GetNSObject<MPSCnnLoss>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLossClassesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnLoss LossConfidence
	{
		[Export("lossConfidence", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSCnnLoss>(Messaging.IntPtr_objc_msgSend(base.Handle, selLossConfidenceHandle));
			}
			return Runtime.GetNSObject<MPSCnnLoss>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLossConfidenceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnLoss LossWH
	{
		[Export("lossWH", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSCnnLoss>(Messaging.IntPtr_objc_msgSend(base.Handle, selLossWHHandle));
			}
			return Runtime.GetNSObject<MPSCnnLoss>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLossWHHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnLoss LossXY
	{
		[Export("lossXY", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSCnnLoss>(Messaging.IntPtr_objc_msgSend(base.Handle, selLossXYHandle));
			}
			return Runtime.GetNSObject<MPSCnnLoss>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLossXYHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MaxIouForObjectAbsence
	{
		[Export("maxIOUForObjectAbsence")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMaxIOUForObjectAbsenceHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMaxIOUForObjectAbsenceHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MinIouForObjectPresence
	{
		[Export("minIOUForObjectPresence")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMinIOUForObjectPresenceHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMinIOUForObjectPresenceHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NumberOfAnchorBoxes
	{
		[Export("numberOfAnchorBoxes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumberOfAnchorBoxesHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumberOfAnchorBoxesHandle);
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
	public virtual float ScaleClass
	{
		[Export("scaleClass")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selScaleClassHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selScaleClassHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ScaleNoObject
	{
		[Export("scaleNoObject")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selScaleNoObjectHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selScaleNoObjectHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ScaleObject
	{
		[Export("scaleObject")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selScaleObjectHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selScaleObjectHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ScaleWH
	{
		[Export("scaleWH")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selScaleWHHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selScaleWHHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ScaleXY
	{
		[Export("scaleXY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selScaleXYHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selScaleXYHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnYoloLoss(NSCoder coder)
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
	protected MPSCnnYoloLoss(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnYoloLoss(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:lossDescriptor:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnYoloLoss(IMTLDevice device, MPSCnnYoloLossDescriptor lossDescriptor)
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
	public MPSCnnYoloLoss(NSCoder decoder, IMTLDevice device)
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
