using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Protocol]
[Register("Xamarin_Mac__MetalPerformanceShaders_MPSCnnInstanceNormalizationDataSource", false)]
[Model]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public abstract class MPSCnnInstanceNormalizationDataSource : NSObject, IMPSCnnInstanceNormalizationDataSource, INativeObject, IDisposable, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract IntPtr Beta
	{
		[Export("beta")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract IntPtr Gamma
	{
		[Export("gamma")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract string Label
	{
		[Export("label")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract nuint NumberOfFeatureChannels
	{
		[Export("numberOfFeatureChannels")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected MPSCnnInstanceNormalizationDataSource()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnInstanceNormalizationDataSource(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnInstanceNormalizationDataSource(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("initWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnInstanceNormalizationDataSource(NSCoder decoder)
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
	public virtual IMPSCnnInstanceNormalizationDataSource Copy(NSZone? zone, IMTLDevice? device)
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

	[Export("epsilon")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GetEpsilon()
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("updateGammaAndBetaWithCommandBuffer:instanceNormalizationStateBatch:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnNormalizationGammaAndBetaState? UpdateGammaAndBeta(IMTLCommandBuffer commandBuffer, MPSCnnInstanceNormalizationGradientState[] instanceNormalizationStateBatch)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("updateGammaAndBetaWithInstanceNormalizationStateBatch:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UpdateGammaAndBeta(MPSCnnInstanceNormalizationGradientState[] instanceNormalizationStateBatch)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
