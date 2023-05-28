using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNLossGradientNode", true)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MPSNNLossGradientNode : MPSNNGradientFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelta = "delta";

	private static readonly IntPtr selDeltaHandle = Selector.GetHandle("delta");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEpsilon = "epsilon";

	private static readonly IntPtr selEpsilonHandle = Selector.GetHandle("epsilon");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSourceGradient_SourceImage_Labels_GradientState_LossDescriptor_IsLabelsGradientFilter_ = "initWithSourceGradient:sourceImage:labels:gradientState:lossDescriptor:isLabelsGradientFilter:";

	private static readonly IntPtr selInitWithSourceGradient_SourceImage_Labels_GradientState_LossDescriptor_IsLabelsGradientFilter_Handle = Selector.GetHandle("initWithSourceGradient:sourceImage:labels:gradientState:lossDescriptor:isLabelsGradientFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSourceGradient_SourceImage_Labels_Weights_GradientState_LossDescriptor_IsLabelsGradientFilter_ = "initWithSourceGradient:sourceImage:labels:weights:gradientState:lossDescriptor:isLabelsGradientFilter:";

	private static readonly IntPtr selInitWithSourceGradient_SourceImage_Labels_Weights_GradientState_LossDescriptor_IsLabelsGradientFilter_Handle = Selector.GetHandle("initWithSourceGradient:sourceImage:labels:weights:gradientState:lossDescriptor:isLabelsGradientFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSources_GradientState_LossDescriptor_IsLabelsGradientFilter_ = "initWithSources:gradientState:lossDescriptor:isLabelsGradientFilter:";

	private static readonly IntPtr selInitWithSources_GradientState_LossDescriptor_IsLabelsGradientFilter_Handle = Selector.GetHandle("initWithSources:gradientState:lossDescriptor:isLabelsGradientFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLabelsGradientFilter = "isLabelsGradientFilter";

	private static readonly IntPtr selIsLabelsGradientFilterHandle = Selector.GetHandle("isLabelsGradientFilter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabelSmoothing = "labelSmoothing";

	private static readonly IntPtr selLabelSmoothingHandle = Selector.GetHandle("labelSmoothing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLossType = "lossType";

	private static readonly IntPtr selLossTypeHandle = Selector.GetHandle("lossType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSourceGradient_SourceImage_Labels_GradientState_LossDescriptor_IsLabelsGradientFilter_ = "nodeWithSourceGradient:sourceImage:labels:gradientState:lossDescriptor:isLabelsGradientFilter:";

	private static readonly IntPtr selNodeWithSourceGradient_SourceImage_Labels_GradientState_LossDescriptor_IsLabelsGradientFilter_Handle = Selector.GetHandle("nodeWithSourceGradient:sourceImage:labels:gradientState:lossDescriptor:isLabelsGradientFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSourceGradient_SourceImage_Labels_Weights_GradientState_LossDescriptor_IsLabelsGradientFilter_ = "nodeWithSourceGradient:sourceImage:labels:weights:gradientState:lossDescriptor:isLabelsGradientFilter:";

	private static readonly IntPtr selNodeWithSourceGradient_SourceImage_Labels_Weights_GradientState_LossDescriptor_IsLabelsGradientFilter_Handle = Selector.GetHandle("nodeWithSourceGradient:sourceImage:labels:weights:gradientState:lossDescriptor:isLabelsGradientFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSources_GradientState_LossDescriptor_IsLabelsGradientFilter_ = "nodeWithSources:gradientState:lossDescriptor:isLabelsGradientFilter:";

	private static readonly IntPtr selNodeWithSources_GradientState_LossDescriptor_IsLabelsGradientFilter_Handle = Selector.GetHandle("nodeWithSources:gradientState:lossDescriptor:isLabelsGradientFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfClasses = "numberOfClasses";

	private static readonly IntPtr selNumberOfClassesHandle = Selector.GetHandle("numberOfClasses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertyCallBack = "propertyCallBack";

	private static readonly IntPtr selPropertyCallBackHandle = Selector.GetHandle("propertyCallBack");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReductionType = "reductionType";

	private static readonly IntPtr selReductionTypeHandle = Selector.GetHandle("reductionType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPropertyCallBack_ = "setPropertyCallBack:";

	private static readonly IntPtr selSetPropertyCallBack_Handle = Selector.GetHandle("setPropertyCallBack:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWeight = "weight";

	private static readonly IntPtr selWeightHandle = Selector.GetHandle("weight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNLossGradientNode");

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
	public virtual bool IsLabelsGradientFilter
	{
		[Export("isLabelsGradientFilter")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLabelsGradientFilterHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLabelsGradientFilterHandle);
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
	public virtual IMPSNNLossCallback? PropertyCallBack
	{
		[Export("propertyCallBack", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSNNLossCallback>(Messaging.IntPtr_objc_msgSend(base.Handle, selPropertyCallBackHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSNNLossCallback>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPropertyCallBackHandle), owns: false);
		}
		[Export("setPropertyCallBack:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPropertyCallBack_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPropertyCallBack_Handle, value?.Handle ?? IntPtr.Zero);
			}
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNNLossGradientNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNLossGradientNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSourceGradient:sourceImage:labels:weights:gradientState:lossDescriptor:isLabelsGradientFilter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNLossGradientNode(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNImageNode labels, MPSNNImageNode? weights, MPSNNGradientStateNode? gradientState, MPSCnnLossDescriptor descriptor, bool isLabelsGradientFilter)
		: base(NSObjectFlag.Empty)
	{
		if (sourceGradient == null)
		{
			throw new ArgumentNullException("sourceGradient");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool(base.Handle, selInitWithSourceGradient_SourceImage_Labels_Weights_GradientState_LossDescriptor_IsLabelsGradientFilter_Handle, sourceGradient.Handle, sourceImage.Handle, labels.Handle, weights?.Handle ?? IntPtr.Zero, gradientState?.Handle ?? IntPtr.Zero, descriptor.Handle, isLabelsGradientFilter), "initWithSourceGradient:sourceImage:labels:weights:gradientState:lossDescriptor:isLabelsGradientFilter:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool(base.SuperHandle, selInitWithSourceGradient_SourceImage_Labels_Weights_GradientState_LossDescriptor_IsLabelsGradientFilter_Handle, sourceGradient.Handle, sourceImage.Handle, labels.Handle, weights?.Handle ?? IntPtr.Zero, gradientState?.Handle ?? IntPtr.Zero, descriptor.Handle, isLabelsGradientFilter), "initWithSourceGradient:sourceImage:labels:weights:gradientState:lossDescriptor:isLabelsGradientFilter:");
		}
	}

	[Export("initWithSourceGradient:sourceImage:labels:gradientState:lossDescriptor:isLabelsGradientFilter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNLossGradientNode(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNImageNode labels, MPSNNGradientStateNode? gradientState, MPSCnnLossDescriptor descriptor, bool isLabelsGradientFilter)
		: base(NSObjectFlag.Empty)
	{
		if (sourceGradient == null)
		{
			throw new ArgumentNullException("sourceGradient");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool(base.Handle, selInitWithSourceGradient_SourceImage_Labels_GradientState_LossDescriptor_IsLabelsGradientFilter_Handle, sourceGradient.Handle, sourceImage.Handle, labels.Handle, gradientState?.Handle ?? IntPtr.Zero, descriptor.Handle, isLabelsGradientFilter), "initWithSourceGradient:sourceImage:labels:gradientState:lossDescriptor:isLabelsGradientFilter:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool(base.SuperHandle, selInitWithSourceGradient_SourceImage_Labels_GradientState_LossDescriptor_IsLabelsGradientFilter_Handle, sourceGradient.Handle, sourceImage.Handle, labels.Handle, gradientState?.Handle ?? IntPtr.Zero, descriptor.Handle, isLabelsGradientFilter), "initWithSourceGradient:sourceImage:labels:gradientState:lossDescriptor:isLabelsGradientFilter:");
		}
	}

	[Export("initWithSources:gradientState:lossDescriptor:isLabelsGradientFilter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNLossGradientNode(MPSNNImageNode[] sourceNodes, MPSNNGradientStateNode? gradientState, MPSCnnLossDescriptor descriptor, bool isLabelsGradientFilter)
		: base(NSObjectFlag.Empty)
	{
		if (sourceNodes == null)
		{
			throw new ArgumentNullException("sourceNodes");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceNodes);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_bool(base.Handle, selInitWithSources_GradientState_LossDescriptor_IsLabelsGradientFilter_Handle, nSArray.Handle, gradientState?.Handle ?? IntPtr.Zero, descriptor.Handle, isLabelsGradientFilter), "initWithSources:gradientState:lossDescriptor:isLabelsGradientFilter:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool(base.SuperHandle, selInitWithSources_GradientState_LossDescriptor_IsLabelsGradientFilter_Handle, nSArray.Handle, gradientState?.Handle ?? IntPtr.Zero, descriptor.Handle, isLabelsGradientFilter), "initWithSources:gradientState:lossDescriptor:isLabelsGradientFilter:");
		}
		nSArray.Dispose();
	}

	[Export("nodeWithSourceGradient:sourceImage:labels:weights:gradientState:lossDescriptor:isLabelsGradientFilter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNLossGradientNode Create(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNImageNode labels, MPSNNImageNode weights, MPSNNGradientStateNode? gradientState, MPSCnnLossDescriptor descriptor, bool isLabelsGradientFilter)
	{
		if (sourceGradient == null)
		{
			throw new ArgumentNullException("sourceGradient");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		return Runtime.GetNSObject<MPSNNLossGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool(class_ptr, selNodeWithSourceGradient_SourceImage_Labels_Weights_GradientState_LossDescriptor_IsLabelsGradientFilter_Handle, sourceGradient.Handle, sourceImage.Handle, labels.Handle, weights.Handle, gradientState?.Handle ?? IntPtr.Zero, descriptor.Handle, isLabelsGradientFilter));
	}

	[Export("nodeWithSourceGradient:sourceImage:labels:gradientState:lossDescriptor:isLabelsGradientFilter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNLossGradientNode Create(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNImageNode labels, MPSNNGradientStateNode? gradientState, MPSCnnLossDescriptor descriptor, bool isLabelsGradientFilter)
	{
		if (sourceGradient == null)
		{
			throw new ArgumentNullException("sourceGradient");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		return Runtime.GetNSObject<MPSNNLossGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool(class_ptr, selNodeWithSourceGradient_SourceImage_Labels_GradientState_LossDescriptor_IsLabelsGradientFilter_Handle, sourceGradient.Handle, sourceImage.Handle, labels.Handle, gradientState?.Handle ?? IntPtr.Zero, descriptor.Handle, isLabelsGradientFilter));
	}

	[Export("nodeWithSources:gradientState:lossDescriptor:isLabelsGradientFilter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNLossGradientNode Create(MPSNNImageNode[] sourceNodes, MPSNNGradientStateNode? gradientState, MPSCnnLossDescriptor descriptor, bool isLabelsGradientFilter)
	{
		if (sourceNodes == null)
		{
			throw new ArgumentNullException("sourceNodes");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceNodes);
		MPSNNLossGradientNode nSObject = Runtime.GetNSObject<MPSNNLossGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_bool(class_ptr, selNodeWithSources_GradientState_LossDescriptor_IsLabelsGradientFilter_Handle, nSArray.Handle, gradientState?.Handle ?? IntPtr.Zero, descriptor.Handle, isLabelsGradientFilter));
		nSArray.Dispose();
		return nSObject;
	}
}
