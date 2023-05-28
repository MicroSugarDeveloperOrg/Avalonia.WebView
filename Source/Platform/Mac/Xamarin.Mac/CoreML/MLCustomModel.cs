using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreML;

[Protocol]
[Register("Xamarin_Mac__CoreML_MLCustomModel", false)]
[Model]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public abstract class MLCustomModel : NSObject, IMLCustomModel, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected MLCustomModel()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MLCustomModel(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MLCustomModel(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("initWithModelDescription:parameterDictionary:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MLCustomModel(MLModelDescription modelDescription, NSDictionary<NSString, NSObject> parameters, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("predictionFromFeatures:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract IMLFeatureProvider? GetPrediction(IMLFeatureProvider inputFeatures, MLPredictionOptions options, out NSError error);

	[Export("predictionsFromBatch:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMLBatchProvider? GetPredictions(IMLBatchProvider inputBatch, MLPredictionOptions options, out NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
