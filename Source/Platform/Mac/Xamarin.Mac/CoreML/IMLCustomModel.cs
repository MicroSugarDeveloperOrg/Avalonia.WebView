using System;
using Foundation;
using ObjCRuntime;

namespace CoreML;

[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MLCustomModel", WrapperType = typeof(MLCustomModelWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPrediction", Selector = "predictionFromFeatures:options:error:", ReturnType = typeof(IMLFeatureProvider), ParameterType = new Type[]
{
	typeof(IMLFeatureProvider),
	typeof(MLPredictionOptions),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, true })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPredictions", Selector = "predictionsFromBatch:options:error:", ReturnType = typeof(IMLBatchProvider), ParameterType = new Type[]
{
	typeof(IMLBatchProvider),
	typeof(MLPredictionOptions),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, true })]
public interface IMLCustomModel : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("predictionFromFeatures:options:error:")]
	[Preserve(Conditional = true)]
	IMLFeatureProvider? GetPrediction(IMLFeatureProvider inputFeatures, MLPredictionOptions options, out NSError error);
}
