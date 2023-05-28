using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNLocalContrastNormalizationGradientNode", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnLocalContrastNormalizationGradientNode : MPSNNGradientFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlpha = "alpha";

	private static readonly IntPtr selAlphaHandle = Selector.GetHandle("alpha");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeta = "beta";

	private static readonly IntPtr selBetaHandle = Selector.GetHandle("beta");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelta = "delta";

	private static readonly IntPtr selDeltaHandle = Selector.GetHandle("delta");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_ = "initWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:";

	private static readonly IntPtr selInitWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_Handle = Selector.GetHandle("initWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelHeight = "kernelHeight";

	private static readonly IntPtr selKernelHeightHandle = Selector.GetHandle("kernelHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelWidth = "kernelWidth";

	private static readonly IntPtr selKernelWidthHandle = Selector.GetHandle("kernelWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_ = "nodeWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:";

	private static readonly IntPtr selNodeWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_Handle = Selector.GetHandle("nodeWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selP0 = "p0";

	private static readonly IntPtr selP0Handle = Selector.GetHandle("p0");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPm = "pm";

	private static readonly IntPtr selPmHandle = Selector.GetHandle("pm");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPs = "ps";

	private static readonly IntPtr selPsHandle = Selector.GetHandle("ps");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlpha_ = "setAlpha:";

	private static readonly IntPtr selSetAlpha_Handle = Selector.GetHandle("setAlpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBeta_ = "setBeta:";

	private static readonly IntPtr selSetBeta_Handle = Selector.GetHandle("setBeta:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelta_ = "setDelta:";

	private static readonly IntPtr selSetDelta_Handle = Selector.GetHandle("setDelta:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetP0_ = "setP0:";

	private static readonly IntPtr selSetP0_Handle = Selector.GetHandle("setP0:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPm_ = "setPm:";

	private static readonly IntPtr selSetPm_Handle = Selector.GetHandle("setPm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPs_ = "setPs:";

	private static readonly IntPtr selSetPs_Handle = Selector.GetHandle("setPs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNLocalContrastNormalizationGradientNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Alpha
	{
		[Export("alpha")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selAlphaHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selAlphaHandle);
		}
		[Export("setAlpha:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetAlpha_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetAlpha_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Beta
	{
		[Export("beta")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selBetaHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selBetaHandle);
		}
		[Export("setBeta:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetBeta_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetBeta_Handle, value);
			}
		}
	}

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
		[Export("setDelta:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetDelta_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetDelta_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint KernelHeight
	{
		[Export("kernelHeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selKernelHeightHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selKernelHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint KernelWidth
	{
		[Export("kernelWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selKernelWidthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selKernelWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float P0
	{
		[Export("p0")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selP0Handle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selP0Handle);
		}
		[Export("setP0:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetP0_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetP0_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Pm
	{
		[Export("pm")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPmHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPmHandle);
		}
		[Export("setPm:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPm_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPm_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Ps
	{
		[Export("ps")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPsHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPsHandle);
		}
		[Export("setPs:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPs_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPs_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnLocalContrastNormalizationGradientNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnLocalContrastNormalizationGradientNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnLocalContrastNormalizationGradientNode(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState, nuint kernelWidth, nuint kernelHeight)
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint_nuint(base.Handle, selInitWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, kernelWidth, kernelHeight), "initWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_nuint_nuint(base.SuperHandle, selInitWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, kernelWidth, kernelHeight), "initWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:");
		}
	}

	[Export("nodeWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnLocalContrastNormalizationGradientNode Create(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState, nuint kernelWidth, nuint kernelHeight)
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
		return Runtime.GetNSObject<MPSCnnLocalContrastNormalizationGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint_nuint(class_ptr, selNodeWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, kernelWidth, kernelHeight));
	}
}
