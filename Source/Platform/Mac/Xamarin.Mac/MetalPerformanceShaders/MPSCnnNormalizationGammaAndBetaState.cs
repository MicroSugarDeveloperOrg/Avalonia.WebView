using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSCNNNormalizationGammaAndBetaState", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnNormalizationGammaAndBetaState : MPSState
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeta = "beta";

	private static readonly IntPtr selBetaHandle = Selector.GetHandle("beta");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGamma = "gamma";

	private static readonly IntPtr selGammaHandle = Selector.GetHandle("gamma");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithGamma_Beta_ = "initWithGamma:beta:";

	private static readonly IntPtr selInitWithGamma_Beta_Handle = Selector.GetHandle("initWithGamma:beta:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryStateWithCommandBuffer_NumberOfFeatureChannels_ = "temporaryStateWithCommandBuffer:numberOfFeatureChannels:";

	private static readonly IntPtr selTemporaryStateWithCommandBuffer_NumberOfFeatureChannels_Handle = Selector.GetHandle("temporaryStateWithCommandBuffer:numberOfFeatureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNNormalizationGammaAndBetaState");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLBuffer Beta
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
	public virtual IMTLBuffer Gamma
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnNormalizationGammaAndBetaState(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnNormalizationGammaAndBetaState(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithGamma:beta:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnNormalizationGammaAndBetaState(IMTLBuffer gamma, IMTLBuffer beta)
		: base(NSObjectFlag.Empty)
	{
		if (gamma == null)
		{
			throw new ArgumentNullException("gamma");
		}
		if (beta == null)
		{
			throw new ArgumentNullException("beta");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithGamma_Beta_Handle, gamma.Handle, beta.Handle), "initWithGamma:beta:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithGamma_Beta_Handle, gamma.Handle, beta.Handle), "initWithGamma:beta:");
		}
	}

	[Export("temporaryStateWithCommandBuffer:numberOfFeatureChannels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnNormalizationGammaAndBetaState GetTemporaryState(IMTLCommandBuffer commandBuffer, nuint numberOfFeatureChannels)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		return Runtime.GetNSObject<MPSCnnNormalizationGammaAndBetaState>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(class_ptr, selTemporaryStateWithCommandBuffer_NumberOfFeatureChannels_Handle, commandBuffer.Handle, numberOfFeatureChannels));
	}
}
