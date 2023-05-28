using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNOptimizer", true)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class MPSNNOptimizer : MPSKernel
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
	private const string selLearningRate = "learningRate";

	private static readonly IntPtr selLearningRateHandle = Selector.GetHandle("learningRate");

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
	private const string selSetLearningRate_ = "setLearningRate:";

	private static readonly IntPtr selSetLearningRate_Handle = Selector.GetHandle("setLearningRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNOptimizer");

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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSNNRegularizationType RegularizationType
	{
		[Export("regularizationType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSNNRegularizationType)Messaging.UInt64_objc_msgSend(base.Handle, selRegularizationTypeHandle);
			}
			return (MPSNNRegularizationType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRegularizationTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSNNOptimizer(NSCoder coder)
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
	protected MPSNNOptimizer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNOptimizer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setLearningRate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetLearningRate(float newLearningRate)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float(base.Handle, selSetLearningRate_Handle, newLearningRate);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetLearningRate_Handle, newLearningRate);
		}
	}
}
