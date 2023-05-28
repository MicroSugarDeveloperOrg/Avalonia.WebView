using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNArithmeticGradientNode", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSNNArithmeticGradientNode : MPSNNGradientFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBias = "bias";

	private static readonly IntPtr selBiasHandle = Selector.GetHandle("bias");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithGradientImages_ForwardFilter_IsSecondarySourceFilter_ = "initWithGradientImages:forwardFilter:isSecondarySourceFilter:";

	private static readonly IntPtr selInitWithGradientImages_ForwardFilter_IsSecondarySourceFilter_Handle = Selector.GetHandle("initWithGradientImages:forwardFilter:isSecondarySourceFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSourceGradient_SourceImage_GradientState_IsSecondarySourceFilter_ = "initWithSourceGradient:sourceImage:gradientState:isSecondarySourceFilter:";

	private static readonly IntPtr selInitWithSourceGradient_SourceImage_GradientState_IsSecondarySourceFilter_Handle = Selector.GetHandle("initWithSourceGradient:sourceImage:gradientState:isSecondarySourceFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSecondarySourceFilter = "isSecondarySourceFilter";

	private static readonly IntPtr selIsSecondarySourceFilterHandle = Selector.GetHandle("isSecondarySourceFilter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumValue = "maximumValue";

	private static readonly IntPtr selMaximumValueHandle = Selector.GetHandle("maximumValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumValue = "minimumValue";

	private static readonly IntPtr selMinimumValueHandle = Selector.GetHandle("minimumValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSourceGradient_SourceImage_GradientState_IsSecondarySourceFilter_ = "nodeWithSourceGradient:sourceImage:gradientState:isSecondarySourceFilter:";

	private static readonly IntPtr selNodeWithSourceGradient_SourceImage_GradientState_IsSecondarySourceFilter_Handle = Selector.GetHandle("nodeWithSourceGradient:sourceImage:gradientState:isSecondarySourceFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryScale = "primaryScale";

	private static readonly IntPtr selPrimaryScaleHandle = Selector.GetHandle("primaryScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryScale = "secondaryScale";

	private static readonly IntPtr selSecondaryScaleHandle = Selector.GetHandle("secondaryScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryStrideInFeatureChannels = "secondaryStrideInFeatureChannels";

	private static readonly IntPtr selSecondaryStrideInFeatureChannelsHandle = Selector.GetHandle("secondaryStrideInFeatureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryStrideInPixelsX = "secondaryStrideInPixelsX";

	private static readonly IntPtr selSecondaryStrideInPixelsXHandle = Selector.GetHandle("secondaryStrideInPixelsX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryStrideInPixelsY = "secondaryStrideInPixelsY";

	private static readonly IntPtr selSecondaryStrideInPixelsYHandle = Selector.GetHandle("secondaryStrideInPixelsY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBias_ = "setBias:";

	private static readonly IntPtr selSetBias_Handle = Selector.GetHandle("setBias:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumValue_ = "setMaximumValue:";

	private static readonly IntPtr selSetMaximumValue_Handle = Selector.GetHandle("setMaximumValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumValue_ = "setMinimumValue:";

	private static readonly IntPtr selSetMinimumValue_Handle = Selector.GetHandle("setMinimumValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimaryScale_ = "setPrimaryScale:";

	private static readonly IntPtr selSetPrimaryScale_Handle = Selector.GetHandle("setPrimaryScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondaryScale_ = "setSecondaryScale:";

	private static readonly IntPtr selSetSecondaryScale_Handle = Selector.GetHandle("setSecondaryScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondaryStrideInFeatureChannels_ = "setSecondaryStrideInFeatureChannels:";

	private static readonly IntPtr selSetSecondaryStrideInFeatureChannels_Handle = Selector.GetHandle("setSecondaryStrideInFeatureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondaryStrideInPixelsX_ = "setSecondaryStrideInPixelsX:";

	private static readonly IntPtr selSetSecondaryStrideInPixelsX_Handle = Selector.GetHandle("setSecondaryStrideInPixelsX:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondaryStrideInPixelsY_ = "setSecondaryStrideInPixelsY:";

	private static readonly IntPtr selSetSecondaryStrideInPixelsY_Handle = Selector.GetHandle("setSecondaryStrideInPixelsY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNArithmeticGradientNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Bias
	{
		[Export("bias")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selBiasHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selBiasHandle);
		}
		[Export("setBias:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetBias_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetBias_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsSecondarySourceFilter
	{
		[Export("isSecondarySourceFilter")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSecondarySourceFilterHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSecondarySourceFilterHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MaximumValue
	{
		[Export("maximumValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMaximumValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMaximumValueHandle);
		}
		[Export("setMaximumValue:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMaximumValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMaximumValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MinimumValue
	{
		[Export("minimumValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMinimumValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMinimumValueHandle);
		}
		[Export("setMinimumValue:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMinimumValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMinimumValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float PrimaryScale
	{
		[Export("primaryScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPrimaryScaleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPrimaryScaleHandle);
		}
		[Export("setPrimaryScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPrimaryScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPrimaryScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float SecondaryScale
	{
		[Export("secondaryScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selSecondaryScaleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selSecondaryScaleHandle);
		}
		[Export("setSecondaryScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetSecondaryScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetSecondaryScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SecondaryStrideInFeatureChannels
	{
		[Export("secondaryStrideInFeatureChannels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSecondaryStrideInFeatureChannelsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSecondaryStrideInFeatureChannelsHandle);
		}
		[Export("setSecondaryStrideInFeatureChannels:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSecondaryStrideInFeatureChannels_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSecondaryStrideInFeatureChannels_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SecondaryStrideInPixelsX
	{
		[Export("secondaryStrideInPixelsX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSecondaryStrideInPixelsXHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSecondaryStrideInPixelsXHandle);
		}
		[Export("setSecondaryStrideInPixelsX:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSecondaryStrideInPixelsX_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSecondaryStrideInPixelsX_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SecondaryStrideInPixelsY
	{
		[Export("secondaryStrideInPixelsY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSecondaryStrideInPixelsYHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSecondaryStrideInPixelsYHandle);
		}
		[Export("setSecondaryStrideInPixelsY:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSecondaryStrideInPixelsY_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSecondaryStrideInPixelsY_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNNArithmeticGradientNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNArithmeticGradientNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSourceGradient:sourceImage:gradientState:isSecondarySourceFilter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNArithmeticGradientNode(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNBinaryGradientStateNode gradientState, bool isSecondarySourceFilter)
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
		if (gradientState == null)
		{
			throw new ArgumentNullException("gradientState");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_bool(base.Handle, selInitWithSourceGradient_SourceImage_GradientState_IsSecondarySourceFilter_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, isSecondarySourceFilter), "initWithSourceGradient:sourceImage:gradientState:isSecondarySourceFilter:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool(base.SuperHandle, selInitWithSourceGradient_SourceImage_GradientState_IsSecondarySourceFilter_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, isSecondarySourceFilter), "initWithSourceGradient:sourceImage:gradientState:isSecondarySourceFilter:");
		}
	}

	[Export("initWithGradientImages:forwardFilter:isSecondarySourceFilter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNArithmeticGradientNode(MPSNNImageNode[] gradientImages, MPSNNFilterNode filter, bool isSecondarySourceFilter)
		: base(NSObjectFlag.Empty)
	{
		if (gradientImages == null)
		{
			throw new ArgumentNullException("gradientImages");
		}
		if (filter == null)
		{
			throw new ArgumentNullException("filter");
		}
		NSArray nSArray = NSArray.FromNSObjects(gradientImages);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, selInitWithGradientImages_ForwardFilter_IsSecondarySourceFilter_Handle, nSArray.Handle, filter.Handle, isSecondarySourceFilter), "initWithGradientImages:forwardFilter:isSecondarySourceFilter:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool(base.SuperHandle, selInitWithGradientImages_ForwardFilter_IsSecondarySourceFilter_Handle, nSArray.Handle, filter.Handle, isSecondarySourceFilter), "initWithGradientImages:forwardFilter:isSecondarySourceFilter:");
		}
		nSArray.Dispose();
	}

	[Export("nodeWithSourceGradient:sourceImage:gradientState:isSecondarySourceFilter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNArithmeticGradientNode Create(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNBinaryGradientStateNode gradientState, bool isSecondarySourceFilter)
	{
		if (sourceGradient == null)
		{
			throw new ArgumentNullException("sourceGradient");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (gradientState == null)
		{
			throw new ArgumentNullException("gradientState");
		}
		return Runtime.GetNSObject<MPSNNArithmeticGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_bool(class_ptr, selNodeWithSourceGradient_SourceImage_GradientState_IsSecondarySourceFilter_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, isSecondarySourceFilter));
	}
}
