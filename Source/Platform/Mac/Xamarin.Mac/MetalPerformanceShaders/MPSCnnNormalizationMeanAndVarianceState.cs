using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNNormalizationMeanAndVarianceState", true)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class MPSCnnNormalizationMeanAndVarianceState : MPSState
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMean_Variance_ = "initWithMean:variance:";

	private static readonly IntPtr selInitWithMean_Variance_Handle = Selector.GetHandle("initWithMean:variance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMean = "mean";

	private static readonly IntPtr selMeanHandle = Selector.GetHandle("mean");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryStateWithCommandBuffer_NumberOfFeatureChannels_ = "temporaryStateWithCommandBuffer:numberOfFeatureChannels:";

	private static readonly IntPtr selTemporaryStateWithCommandBuffer_NumberOfFeatureChannels_Handle = Selector.GetHandle("temporaryStateWithCommandBuffer:numberOfFeatureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVariance = "variance";

	private static readonly IntPtr selVarianceHandle = Selector.GetHandle("variance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNNormalizationMeanAndVarianceState");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLBuffer Mean
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
	public virtual IMTLBuffer Variance
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
	protected MPSCnnNormalizationMeanAndVarianceState(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnNormalizationMeanAndVarianceState(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMean:variance:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnNormalizationMeanAndVarianceState(IMTLBuffer mean, IMTLBuffer variance)
		: base(NSObjectFlag.Empty)
	{
		if (mean == null)
		{
			throw new ArgumentNullException("mean");
		}
		if (variance == null)
		{
			throw new ArgumentNullException("variance");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithMean_Variance_Handle, mean.Handle, variance.Handle), "initWithMean:variance:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithMean_Variance_Handle, mean.Handle, variance.Handle), "initWithMean:variance:");
		}
	}

	[Export("temporaryStateWithCommandBuffer:numberOfFeatureChannels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnNormalizationMeanAndVarianceState GetTemporaryState(IMTLCommandBuffer commandBuffer, nuint numberOfFeatureChannels)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		return Runtime.GetNSObject<MPSCnnNormalizationMeanAndVarianceState>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(class_ptr, selTemporaryStateWithCommandBuffer_NumberOfFeatureChannels_Handle, commandBuffer.Handle, numberOfFeatureChannels));
	}
}
