using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNBatchNormalizationState", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnBatchNormalizationState : MPSNNGradientState
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBatchNormalization = "batchNormalization";

	private static readonly IntPtr selBatchNormalizationHandle = Selector.GetHandle("batchNormalization");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeta = "beta";

	private static readonly IntPtr selBetaHandle = Selector.GetHandle("beta");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGamma = "gamma";

	private static readonly IntPtr selGammaHandle = Selector.GetHandle("gamma");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGradientForBeta = "gradientForBeta";

	private static readonly IntPtr selGradientForBetaHandle = Selector.GetHandle("gradientForBeta");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGradientForGamma = "gradientForGamma";

	private static readonly IntPtr selGradientForGammaHandle = Selector.GetHandle("gradientForGamma");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMean = "mean";

	private static readonly IntPtr selMeanHandle = Selector.GetHandle("mean");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReset = "reset";

	private static readonly IntPtr selResetHandle = Selector.GetHandle("reset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVariance = "variance";

	private static readonly IntPtr selVarianceHandle = Selector.GetHandle("variance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNBatchNormalizationState");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnBatchNormalization BatchNormalization
	{
		[Export("batchNormalization", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSCnnBatchNormalization>(Messaging.IntPtr_objc_msgSend(base.Handle, selBatchNormalizationHandle));
			}
			return Runtime.GetNSObject<MPSCnnBatchNormalization>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBatchNormalizationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLBuffer? Beta
	{
		[Export("beta")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selBetaHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBetaHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLBuffer? Gamma
	{
		[Export("gamma")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selGammaHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGammaHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLBuffer? GradientForBeta
	{
		[Export("gradientForBeta")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selGradientForBetaHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGradientForBetaHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLBuffer? GradientForGamma
	{
		[Export("gradientForGamma")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selGradientForGammaHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGradientForGammaHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLBuffer? Mean
	{
		[Export("mean")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selMeanHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMeanHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLBuffer? Variance
	{
		[Export("variance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selVarianceHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVarianceHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnBatchNormalizationState(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnBatchNormalizationState(IntPtr handle)
		: base(handle)
	{
	}

	[Export("reset")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Reset()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetHandle);
		}
	}
}
