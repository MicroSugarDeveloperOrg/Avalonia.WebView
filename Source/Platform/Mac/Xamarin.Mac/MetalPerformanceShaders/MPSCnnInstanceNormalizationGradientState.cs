using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNInstanceNormalizationGradientState", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnInstanceNormalizationGradientState : MPSNNGradientState
{
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
	private const string selInstanceNormalization = "instanceNormalization";

	private static readonly IntPtr selInstanceNormalizationHandle = Selector.GetHandle("instanceNormalization");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNInstanceNormalizationGradientState");

	public override IntPtr ClassHandle => class_ptr;

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
	public virtual IMTLBuffer GradientForBeta
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
	public virtual IMTLBuffer GradientForGamma
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
	public virtual MPSCnnInstanceNormalization InstanceNormalization
	{
		[Export("instanceNormalization", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSCnnInstanceNormalization>(Messaging.IntPtr_objc_msgSend(base.Handle, selInstanceNormalizationHandle));
			}
			return Runtime.GetNSObject<MPSCnnInstanceNormalization>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInstanceNormalizationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnInstanceNormalizationGradientState(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnInstanceNormalizationGradientState(IntPtr handle)
		: base(handle)
	{
	}
}
