using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNSpatialNormalizationGradientNode", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnSpatialNormalizationGradientNode : MPSNNGradientFilterNode
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
	private const string selInitWithSourceGradient_SourceImage_GradientState_KernelSize_ = "initWithSourceGradient:sourceImage:gradientState:kernelSize:";

	private static readonly IntPtr selInitWithSourceGradient_SourceImage_GradientState_KernelSize_Handle = Selector.GetHandle("initWithSourceGradient:sourceImage:gradientState:kernelSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelHeight = "kernelHeight";

	private static readonly IntPtr selKernelHeightHandle = Selector.GetHandle("kernelHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelWidth = "kernelWidth";

	private static readonly IntPtr selKernelWidthHandle = Selector.GetHandle("kernelWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSourceGradient_SourceImage_GradientState_KernelSize_ = "nodeWithSourceGradient:sourceImage:gradientState:kernelSize:";

	private static readonly IntPtr selNodeWithSourceGradient_SourceImage_GradientState_KernelSize_Handle = Selector.GetHandle("nodeWithSourceGradient:sourceImage:gradientState:kernelSize:");

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
	private const string selSetKernelHeight_ = "setKernelHeight:";

	private static readonly IntPtr selSetKernelHeight_Handle = Selector.GetHandle("setKernelHeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKernelWidth_ = "setKernelWidth:";

	private static readonly IntPtr selSetKernelWidth_Handle = Selector.GetHandle("setKernelWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNSpatialNormalizationGradientNode");

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
		[Export("setKernelHeight:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetKernelHeight_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetKernelHeight_Handle, value);
			}
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
		[Export("setKernelWidth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetKernelWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetKernelWidth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnSpatialNormalizationGradientNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnSpatialNormalizationGradientNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSourceGradient:sourceImage:gradientState:kernelSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnSpatialNormalizationGradientNode(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState, nuint kernelSize)
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint(base.Handle, selInitWithSourceGradient_SourceImage_GradientState_KernelSize_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, kernelSize), "initWithSourceGradient:sourceImage:gradientState:kernelSize:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_nuint(base.SuperHandle, selInitWithSourceGradient_SourceImage_GradientState_KernelSize_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, kernelSize), "initWithSourceGradient:sourceImage:gradientState:kernelSize:");
		}
	}

	[Export("nodeWithSourceGradient:sourceImage:gradientState:kernelSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnSpatialNormalizationGradientNode Create(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState, nuint kernelSize)
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
		return Runtime.GetNSObject<MPSCnnSpatialNormalizationGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint(class_ptr, selNodeWithSourceGradient_SourceImage_GradientState_KernelSize_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, kernelSize));
	}
}
