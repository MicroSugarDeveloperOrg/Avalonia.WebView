using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Protocol]
[Register("Xamarin_Mac__MetalPerformanceShaders_MPSCnnBatchNormalizationDataSource", false)]
[Model]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public abstract class MPSCnnBatchNormalizationDataSource : NSObject, IMPSCnnBatchNormalizationDataSource, INativeObject, IDisposable, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract IntPtr Beta
	{
		[Export("beta")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Epsilon
	{
		[Export("epsilon")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract IntPtr Gamma
	{
		[Export("gamma")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract string? Label
	{
		[Export("label")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract bool Load
	{
		[Export("load")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract IntPtr Mean
	{
		[Export("mean")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract nuint NumberOfFeatureChannels
	{
		[Export("numberOfFeatureChannels")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool SupportsSecureCoding
	{
		[Export("supportsSecureCoding")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract IntPtr Variance
	{
		[Export("variance")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected MPSCnnBatchNormalizationDataSource()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnBatchNormalizationDataSource(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnBatchNormalizationDataSource(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("initWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnBatchNormalizationDataSource(NSCoder decoder)
		: base(NSObjectFlag.Empty)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("copyWithZone:device:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual IMPSCnnBatchNormalizationDataSource Copy(NSZone? zone, IMTLDevice? device)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(NSCoder coder)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("purge")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void Purge();

	[Export("updateGammaAndBetaWithCommandBuffer:batchNormalizationState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnNormalizationGammaAndBetaState? UpdateGammaAndBeta(IMTLCommandBuffer commandBuffer, MPSCnnBatchNormalizationState batchNormalizationState)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("updateGammaAndBetaWithBatchNormalizationState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UpdateGammaAndBeta(MPSCnnBatchNormalizationState batchNormalizationState)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("updateMeanAndVarianceWithCommandBuffer:batchNormalizationState:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnNormalizationMeanAndVarianceState? UpdateMeanAndVariance(IMTLCommandBuffer commandBuffer, MPSCnnBatchNormalizationState batchNormalizationState)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("updateMeanAndVarianceWithBatchNormalizationState:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UpdateMeanAndVariance(MPSCnnBatchNormalizationState batchNormalizationState)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
