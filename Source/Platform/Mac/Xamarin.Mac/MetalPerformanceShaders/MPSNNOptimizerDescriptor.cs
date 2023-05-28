using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNOptimizerDescriptor", true)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class MPSNNOptimizerDescriptor : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyGradientClipping = "applyGradientClipping";

	private static readonly IntPtr selApplyGradientClippingHandle = Selector.GetHandle("applyGradientClipping");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGradientClipMax = "gradientClipMax";

	private static readonly IntPtr selGradientClipMaxHandle = Selector.GetHandle("gradientClipMax");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGradientClipMin = "gradientClipMin";

	private static readonly IntPtr selGradientClipMinHandle = Selector.GetHandle("gradientClipMin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGradientRescale = "gradientRescale";

	private static readonly IntPtr selGradientRescaleHandle = Selector.GetHandle("gradientRescale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLearningRate_GradientRescale_ApplyGradientClipping_GradientClipMax_GradientClipMin_RegularizationType_RegularizationScale_ = "initWithLearningRate:gradientRescale:applyGradientClipping:gradientClipMax:gradientClipMin:regularizationType:regularizationScale:";

	private static readonly IntPtr selInitWithLearningRate_GradientRescale_ApplyGradientClipping_GradientClipMax_GradientClipMin_RegularizationType_RegularizationScale_Handle = Selector.GetHandle("initWithLearningRate:gradientRescale:applyGradientClipping:gradientClipMax:gradientClipMin:regularizationType:regularizationScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLearningRate_GradientRescale_RegularizationType_RegularizationScale_ = "initWithLearningRate:gradientRescale:regularizationType:regularizationScale:";

	private static readonly IntPtr selInitWithLearningRate_GradientRescale_RegularizationType_RegularizationScale_Handle = Selector.GetHandle("initWithLearningRate:gradientRescale:regularizationType:regularizationScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLearningRate = "learningRate";

	private static readonly IntPtr selLearningRateHandle = Selector.GetHandle("learningRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOptimizerDescriptorWithLearningRate_GradientRescale_ApplyGradientClipping_GradientClipMax_GradientClipMin_RegularizationType_RegularizationScale_ = "optimizerDescriptorWithLearningRate:gradientRescale:applyGradientClipping:gradientClipMax:gradientClipMin:regularizationType:regularizationScale:";

	private static readonly IntPtr selOptimizerDescriptorWithLearningRate_GradientRescale_ApplyGradientClipping_GradientClipMax_GradientClipMin_RegularizationType_RegularizationScale_Handle = Selector.GetHandle("optimizerDescriptorWithLearningRate:gradientRescale:applyGradientClipping:gradientClipMax:gradientClipMin:regularizationType:regularizationScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOptimizerDescriptorWithLearningRate_GradientRescale_RegularizationType_RegularizationScale_ = "optimizerDescriptorWithLearningRate:gradientRescale:regularizationType:regularizationScale:";

	private static readonly IntPtr selOptimizerDescriptorWithLearningRate_GradientRescale_RegularizationType_RegularizationScale_Handle = Selector.GetHandle("optimizerDescriptorWithLearningRate:gradientRescale:regularizationType:regularizationScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegularizationScale = "regularizationScale";

	private static readonly IntPtr selRegularizationScaleHandle = Selector.GetHandle("regularizationScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegularizationType = "regularizationType";

	private static readonly IntPtr selRegularizationTypeHandle = Selector.GetHandle("regularizationType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetApplyGradientClipping_ = "setApplyGradientClipping:";

	private static readonly IntPtr selSetApplyGradientClipping_Handle = Selector.GetHandle("setApplyGradientClipping:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGradientClipMax_ = "setGradientClipMax:";

	private static readonly IntPtr selSetGradientClipMax_Handle = Selector.GetHandle("setGradientClipMax:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGradientClipMin_ = "setGradientClipMin:";

	private static readonly IntPtr selSetGradientClipMin_Handle = Selector.GetHandle("setGradientClipMin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGradientRescale_ = "setGradientRescale:";

	private static readonly IntPtr selSetGradientRescale_Handle = Selector.GetHandle("setGradientRescale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLearningRate_ = "setLearningRate:";

	private static readonly IntPtr selSetLearningRate_Handle = Selector.GetHandle("setLearningRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRegularizationScale_ = "setRegularizationScale:";

	private static readonly IntPtr selSetRegularizationScale_Handle = Selector.GetHandle("setRegularizationScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRegularizationType_ = "setRegularizationType:";

	private static readonly IntPtr selSetRegularizationType_Handle = Selector.GetHandle("setRegularizationType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNOptimizerDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ApplyGradientClipping
	{
		[Export("applyGradientClipping")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selApplyGradientClippingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selApplyGradientClippingHandle);
		}
		[Export("setApplyGradientClipping:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetApplyGradientClipping_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetApplyGradientClipping_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GradientClipMax
	{
		[Export("gradientClipMax")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selGradientClipMaxHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selGradientClipMaxHandle);
		}
		[Export("setGradientClipMax:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetGradientClipMax_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetGradientClipMax_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GradientClipMin
	{
		[Export("gradientClipMin")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selGradientClipMinHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selGradientClipMinHandle);
		}
		[Export("setGradientClipMin:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetGradientClipMin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetGradientClipMin_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GradientRescale
	{
		[Export("gradientRescale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selGradientRescaleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selGradientRescaleHandle);
		}
		[Export("setGradientRescale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetGradientRescale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetGradientRescale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float LearningRate
	{
		[Export("learningRate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selLearningRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selLearningRateHandle);
		}
		[Export("setLearningRate:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetLearningRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetLearningRate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float RegularizationScale
	{
		[Export("regularizationScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRegularizationScaleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRegularizationScaleHandle);
		}
		[Export("setRegularizationScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetRegularizationScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetRegularizationScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSNNRegularizationType RegularizationType
	{
		[Export("regularizationType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSNNRegularizationType)Messaging.UInt64_objc_msgSend(base.Handle, selRegularizationTypeHandle);
			}
			return (MPSNNRegularizationType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRegularizationTypeHandle);
		}
		[Export("setRegularizationType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetRegularizationType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetRegularizationType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNNOptimizerDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNOptimizerDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithLearningRate:gradientRescale:regularizationType:regularizationScale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNOptimizerDescriptor(float learningRate, float gradientRescale, MPSNNRegularizationType regularizationType, float regularizationScale)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_float_float_UInt64_float(base.Handle, selInitWithLearningRate_GradientRescale_RegularizationType_RegularizationScale_Handle, learningRate, gradientRescale, (ulong)regularizationType, regularizationScale), "initWithLearningRate:gradientRescale:regularizationType:regularizationScale:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_float_float_UInt64_float(base.SuperHandle, selInitWithLearningRate_GradientRescale_RegularizationType_RegularizationScale_Handle, learningRate, gradientRescale, (ulong)regularizationType, regularizationScale), "initWithLearningRate:gradientRescale:regularizationType:regularizationScale:");
		}
	}

	[Export("initWithLearningRate:gradientRescale:applyGradientClipping:gradientClipMax:gradientClipMin:regularizationType:regularizationScale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNOptimizerDescriptor(float learningRate, float gradientRescale, bool applyGradientClipping, float gradientClipMax, float gradientClipMin, MPSNNRegularizationType regularizationType, float regularizationScale)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_float_float_bool_float_float_UInt64_float(base.Handle, selInitWithLearningRate_GradientRescale_ApplyGradientClipping_GradientClipMax_GradientClipMin_RegularizationType_RegularizationScale_Handle, learningRate, gradientRescale, applyGradientClipping, gradientClipMax, gradientClipMin, (ulong)regularizationType, regularizationScale), "initWithLearningRate:gradientRescale:applyGradientClipping:gradientClipMax:gradientClipMin:regularizationType:regularizationScale:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_float_float_bool_float_float_UInt64_float(base.SuperHandle, selInitWithLearningRate_GradientRescale_ApplyGradientClipping_GradientClipMax_GradientClipMin_RegularizationType_RegularizationScale_Handle, learningRate, gradientRescale, applyGradientClipping, gradientClipMax, gradientClipMin, (ulong)regularizationType, regularizationScale), "initWithLearningRate:gradientRescale:applyGradientClipping:gradientClipMax:gradientClipMin:regularizationType:regularizationScale:");
		}
	}

	[Export("optimizerDescriptorWithLearningRate:gradientRescale:regularizationType:regularizationScale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNOptimizerDescriptor Create(float learningRate, float gradientRescale, MPSNNRegularizationType regularizationType, float regularizationScale)
	{
		return Runtime.GetNSObject<MPSNNOptimizerDescriptor>(Messaging.IntPtr_objc_msgSend_float_float_UInt64_float(class_ptr, selOptimizerDescriptorWithLearningRate_GradientRescale_RegularizationType_RegularizationScale_Handle, learningRate, gradientRescale, (ulong)regularizationType, regularizationScale));
	}

	[Export("optimizerDescriptorWithLearningRate:gradientRescale:applyGradientClipping:gradientClipMax:gradientClipMin:regularizationType:regularizationScale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNOptimizerDescriptor Create(float learningRate, float gradientRescale, bool applyGradientClipping, float gradientClipMax, float gradientClipMin, MPSNNRegularizationType regularizationType, float regularizationScale)
	{
		return Runtime.GetNSObject<MPSNNOptimizerDescriptor>(Messaging.IntPtr_objc_msgSend_float_float_bool_float_float_UInt64_float(class_ptr, selOptimizerDescriptorWithLearningRate_GradientRescale_ApplyGradientClipping_GradientClipMax_GradientClipMin_RegularizationType_RegularizationScale_Handle, learningRate, gradientRescale, applyGradientClipping, gradientClipMax, gradientClipMin, (ulong)regularizationType, regularizationScale));
	}
}
