using System;
using Foundation;
using Metal;
using ObjCRuntime;

namespace CoreML;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
[Protocol(Name = "MLCustomLayer", WrapperType = typeof(MLCustomLayerWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetWeightData", Selector = "setWeightData:error:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSData[]),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, true })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetOutputShapes", Selector = "outputShapesForInputShapes:error:", ReturnType = typeof(NSArray[]), ParameterType = new Type[]
{
	typeof(NSArray[]),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, true })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "EvaluateOnCpu", Selector = "evaluateOnCPUWithInputs:outputs:error:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(MLMultiArray[]),
	typeof(MLMultiArray[]),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, true })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Encode", Selector = "encodeToCommandBuffer:inputs:outputs:error:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(IMTLCommandBuffer),
	typeof(IMTLTexture[]),
	typeof(IMTLTexture[]),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false, true })]
public interface IMLCustomLayer : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setWeightData:error:")]
	[Preserve(Conditional = true)]
	bool SetWeightData(NSData[] weights, out NSError? error);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("outputShapesForInputShapes:error:")]
	[Preserve(Conditional = true)]
	NSArray[]? GetOutputShapes(NSArray[] inputShapes, out NSError? error);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("evaluateOnCPUWithInputs:outputs:error:")]
	[Preserve(Conditional = true)]
	bool EvaluateOnCpu(MLMultiArray[] inputs, MLMultiArray[] outputs, out NSError? error);
}
