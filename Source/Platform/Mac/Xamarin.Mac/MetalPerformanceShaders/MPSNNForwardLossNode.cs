using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNForwardLossNode", true)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MPSNNForwardLossNode : MPSNNFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelta = "delta";

	private static readonly IntPtr selDeltaHandle = Selector.GetHandle("delta");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEpsilon = "epsilon";

	private static readonly IntPtr selEpsilonHandle = Selector.GetHandle("epsilon");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGradientFilterWithSource_ = "gradientFilterWithSource:";

	private static readonly IntPtr selGradientFilterWithSource_Handle = Selector.GetHandle("gradientFilterWithSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGradientFilterWithSources_ = "gradientFilterWithSources:";

	private static readonly IntPtr selGradientFilterWithSources_Handle = Selector.GetHandle("gradientFilterWithSources:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGradientFiltersWithSource_ = "gradientFiltersWithSource:";

	private static readonly IntPtr selGradientFiltersWithSource_Handle = Selector.GetHandle("gradientFiltersWithSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGradientFiltersWithSources_ = "gradientFiltersWithSources:";

	private static readonly IntPtr selGradientFiltersWithSources_Handle = Selector.GetHandle("gradientFiltersWithSources:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_Labels_LossDescriptor_ = "initWithSource:labels:lossDescriptor:";

	private static readonly IntPtr selInitWithSource_Labels_LossDescriptor_Handle = Selector.GetHandle("initWithSource:labels:lossDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_Labels_Weights_LossDescriptor_ = "initWithSource:labels:weights:lossDescriptor:";

	private static readonly IntPtr selInitWithSource_Labels_Weights_LossDescriptor_Handle = Selector.GetHandle("initWithSource:labels:weights:lossDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSources_LossDescriptor_ = "initWithSources:lossDescriptor:";

	private static readonly IntPtr selInitWithSources_LossDescriptor_Handle = Selector.GetHandle("initWithSources:lossDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabelSmoothing = "labelSmoothing";

	private static readonly IntPtr selLabelSmoothingHandle = Selector.GetHandle("labelSmoothing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLossType = "lossType";

	private static readonly IntPtr selLossTypeHandle = Selector.GetHandle("lossType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_Labels_LossDescriptor_ = "nodeWithSource:labels:lossDescriptor:";

	private static readonly IntPtr selNodeWithSource_Labels_LossDescriptor_Handle = Selector.GetHandle("nodeWithSource:labels:lossDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_Labels_Weights_LossDescriptor_ = "nodeWithSource:labels:weights:lossDescriptor:";

	private static readonly IntPtr selNodeWithSource_Labels_Weights_LossDescriptor_Handle = Selector.GetHandle("nodeWithSource:labels:weights:lossDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSources_LossDescriptor_ = "nodeWithSources:lossDescriptor:";

	private static readonly IntPtr selNodeWithSources_LossDescriptor_Handle = Selector.GetHandle("nodeWithSources:lossDescriptor:");

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
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNForwardLossNode");

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
	protected MPSNNForwardLossNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNForwardLossNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:labels:weights:lossDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNForwardLossNode(MPSNNImageNode source, MPSNNImageNode labels, MPSNNImageNode? weights, MPSCnnLossDescriptor descriptor)
		: base(NSObjectFlag.Empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithSource_Labels_Weights_LossDescriptor_Handle, source.Handle, labels.Handle, weights?.Handle ?? IntPtr.Zero, descriptor.Handle), "initWithSource:labels:weights:lossDescriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithSource_Labels_Weights_LossDescriptor_Handle, source.Handle, labels.Handle, weights?.Handle ?? IntPtr.Zero, descriptor.Handle), "initWithSource:labels:weights:lossDescriptor:");
		}
	}

	[Export("initWithSource:labels:lossDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNForwardLossNode(MPSNNImageNode source, MPSNNImageNode labels, MPSCnnLossDescriptor descriptor)
		: base(NSObjectFlag.Empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithSource_Labels_LossDescriptor_Handle, source.Handle, labels.Handle, descriptor.Handle), "initWithSource:labels:lossDescriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithSource_Labels_LossDescriptor_Handle, source.Handle, labels.Handle, descriptor.Handle), "initWithSource:labels:lossDescriptor:");
		}
	}

	[Export("initWithSources:lossDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNForwardLossNode(MPSNNImageNode[] sourceNodes, MPSCnnLossDescriptor descriptor)
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithSources_LossDescriptor_Handle, nSArray.Handle, descriptor.Handle), "initWithSources:lossDescriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithSources_LossDescriptor_Handle, nSArray.Handle, descriptor.Handle), "initWithSources:lossDescriptor:");
		}
		nSArray.Dispose();
	}

	[Export("nodeWithSource:labels:weights:lossDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNForwardLossNode Create(MPSNNImageNode source, MPSNNImageNode labels, MPSNNImageNode weights, MPSCnnLossDescriptor descriptor)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
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
		return Runtime.GetNSObject<MPSNNForwardLossNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(class_ptr, selNodeWithSource_Labels_Weights_LossDescriptor_Handle, source.Handle, labels.Handle, weights.Handle, descriptor.Handle));
	}

	[Export("nodeWithSource:labels:lossDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNForwardLossNode Create(MPSNNImageNode source, MPSNNImageNode labels, MPSCnnLossDescriptor descriptor)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		return Runtime.GetNSObject<MPSNNForwardLossNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selNodeWithSource_Labels_LossDescriptor_Handle, source.Handle, labels.Handle, descriptor.Handle));
	}

	[Export("nodeWithSources:lossDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNForwardLossNode Create(MPSNNImageNode[] sourceNodes, MPSCnnLossDescriptor descriptor)
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
		MPSNNForwardLossNode nSObject = Runtime.GetNSObject<MPSNNForwardLossNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selNodeWithSources_LossDescriptor_Handle, nSArray.Handle, descriptor.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("gradientFilterWithSources:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual MPSNNLossGradientNode GetFilter(MPSNNImageNode[] sourceGradient)
	{
		if (sourceGradient == null)
		{
			throw new ArgumentNullException("sourceGradient");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceGradient);
		MPSNNLossGradientNode result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MPSNNLossGradientNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGradientFilterWithSources_Handle, nSArray.Handle)) : Runtime.GetNSObject<MPSNNLossGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGradientFilterWithSources_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("gradientFilterWithSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual MPSNNLossGradientNode GetFilter(MPSNNImageNode sourceGradient)
	{
		if (sourceGradient == null)
		{
			throw new ArgumentNullException("sourceGradient");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSNNLossGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGradientFilterWithSource_Handle, sourceGradient.Handle));
		}
		return Runtime.GetNSObject<MPSNNLossGradientNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGradientFilterWithSource_Handle, sourceGradient.Handle));
	}

	[Export("gradientFiltersWithSources:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual MPSNNLossGradientNode[] GetFilters(MPSNNImageNode[] sourceGradient)
	{
		if (sourceGradient == null)
		{
			throw new ArgumentNullException("sourceGradient");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceGradient);
		MPSNNLossGradientNode[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<MPSNNLossGradientNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGradientFiltersWithSources_Handle, nSArray.Handle)) : NSArray.ArrayFromHandle<MPSNNLossGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGradientFiltersWithSources_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("gradientFiltersWithSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual MPSNNLossGradientNode[] GetFilters(MPSNNImageNode sourceGradient)
	{
		if (sourceGradient == null)
		{
			throw new ArgumentNullException("sourceGradient");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<MPSNNLossGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGradientFiltersWithSource_Handle, sourceGradient.Handle));
		}
		return NSArray.ArrayFromHandle<MPSNNLossGradientNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGradientFiltersWithSource_Handle, sourceGradient.Handle));
	}
}
