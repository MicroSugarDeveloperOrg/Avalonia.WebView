using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNDropoutGradientNode", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnDropoutGradientNode : MPSNNGradientFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSourceGradient_SourceImage_GradientState_KeepProbability_Seed_MaskStrideInPixels_ = "initWithSourceGradient:sourceImage:gradientState:keepProbability:seed:maskStrideInPixels:";

	private static readonly IntPtr selInitWithSourceGradient_SourceImage_GradientState_KeepProbability_Seed_MaskStrideInPixels_Handle = Selector.GetHandle("initWithSourceGradient:sourceImage:gradientState:keepProbability:seed:maskStrideInPixels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeepProbability = "keepProbability";

	private static readonly IntPtr selKeepProbabilityHandle = Selector.GetHandle("keepProbability");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaskStrideInPixels = "maskStrideInPixels";

	private static readonly IntPtr selMaskStrideInPixelsHandle = Selector.GetHandle("maskStrideInPixels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSourceGradient_SourceImage_GradientState_KeepProbability_Seed_MaskStrideInPixels_ = "nodeWithSourceGradient:sourceImage:gradientState:keepProbability:seed:maskStrideInPixels:";

	private static readonly IntPtr selNodeWithSourceGradient_SourceImage_GradientState_KeepProbability_Seed_MaskStrideInPixels_Handle = Selector.GetHandle("nodeWithSourceGradient:sourceImage:gradientState:keepProbability:seed:maskStrideInPixels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeed = "seed";

	private static readonly IntPtr selSeedHandle = Selector.GetHandle("seed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNDropoutGradientNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float KeepProbability
	{
		[Export("keepProbability")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selKeepProbabilityHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selKeepProbabilityHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLSize MaskStrideInPixels
	{
		[Export("maskStrideInPixels")]
		get
		{
			MTLSize retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLSize_objc_msgSend_stret(out retval, base.Handle, selMaskStrideInPixelsHandle);
			}
			else
			{
				Messaging.MTLSize_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMaskStrideInPixelsHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Seed
	{
		[Export("seed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSeedHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSeedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnDropoutGradientNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnDropoutGradientNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSourceGradient:sourceImage:gradientState:keepProbability:seed:maskStrideInPixels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnDropoutGradientNode(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState, float keepProbability, nuint seed, MTLSize maskStrideInPixels)
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_float_nuint_MTLSize(base.Handle, selInitWithSourceGradient_SourceImage_GradientState_KeepProbability_Seed_MaskStrideInPixels_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, keepProbability, seed, maskStrideInPixels), "initWithSourceGradient:sourceImage:gradientState:keepProbability:seed:maskStrideInPixels:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_float_nuint_MTLSize(base.SuperHandle, selInitWithSourceGradient_SourceImage_GradientState_KeepProbability_Seed_MaskStrideInPixels_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, keepProbability, seed, maskStrideInPixels), "initWithSourceGradient:sourceImage:gradientState:keepProbability:seed:maskStrideInPixels:");
		}
	}

	[Export("nodeWithSourceGradient:sourceImage:gradientState:keepProbability:seed:maskStrideInPixels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnDropoutGradientNode Create(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState, float keepProbability, nuint seed, MTLSize maskStrideInPixels)
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
		return Runtime.GetNSObject<MPSCnnDropoutGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_float_nuint_MTLSize(class_ptr, selNodeWithSourceGradient_SourceImage_GradientState_KeepProbability_Seed_MaskStrideInPixels_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, keepProbability, seed, maskStrideInPixels));
	}
}
