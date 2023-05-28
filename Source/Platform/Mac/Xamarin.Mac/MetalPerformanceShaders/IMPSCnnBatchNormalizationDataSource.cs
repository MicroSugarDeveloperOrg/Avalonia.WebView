using System;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
[Protocol(Name = "MPSCNNBatchNormalizationDataSource", WrapperType = typeof(MPSCnnBatchNormalizationDataSourceWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Purge", Selector = "purge")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateGammaAndBeta", Selector = "updateGammaAndBetaWithCommandBuffer:batchNormalizationState:", ReturnType = typeof(MPSCnnNormalizationGammaAndBetaState), ParameterType = new Type[]
{
	typeof(IMTLCommandBuffer),
	typeof(MPSCnnBatchNormalizationState)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateMeanAndVariance", Selector = "updateMeanAndVarianceWithCommandBuffer:batchNormalizationState:", ReturnType = typeof(MPSCnnNormalizationMeanAndVarianceState), ParameterType = new Type[]
{
	typeof(IMTLCommandBuffer),
	typeof(MPSCnnBatchNormalizationState)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateGammaAndBeta", Selector = "updateGammaAndBetaWithBatchNormalizationState:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(MPSCnnBatchNormalizationState) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateMeanAndVariance", Selector = "updateMeanAndVarianceWithBatchNormalizationState:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(MPSCnnBatchNormalizationState) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Encode", Selector = "encodeWithCoder:", ParameterType = new Type[] { typeof(NSCoder) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Copy", Selector = "copyWithZone:device:", ReturnType = typeof(IMPSCnnBatchNormalizationDataSource), ParameterType = new Type[]
{
	typeof(NSZone),
	typeof(IMTLDevice)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "NumberOfFeatureChannels", Selector = "numberOfFeatureChannels", PropertyType = typeof(nuint), GetterSelector = "numberOfFeatureChannels", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Gamma", Selector = "gamma", PropertyType = typeof(IntPtr), GetterSelector = "gamma", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Beta", Selector = "beta", PropertyType = typeof(IntPtr), GetterSelector = "beta", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Mean", Selector = "mean", PropertyType = typeof(IntPtr), GetterSelector = "mean", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Variance", Selector = "variance", PropertyType = typeof(IntPtr), GetterSelector = "variance", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Load", Selector = "load", PropertyType = typeof(bool), GetterSelector = "load", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof(string), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Epsilon", Selector = "epsilon", PropertyType = typeof(float), GetterSelector = "epsilon", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = true, Name = "SupportsSecureCoding", Selector = "supportsSecureCoding", PropertyType = typeof(bool), GetterSelector = "supportsSecureCoding", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMPSCnnBatchNormalizationDataSource : INativeObject, IDisposable, INSCopying
{
	[Preserve(Conditional = true)]
	nuint NumberOfFeatureChannels
	{
		[Export("numberOfFeatureChannels")]
		get;
	}

	[Preserve(Conditional = true)]
	IntPtr Gamma
	{
		[Export("gamma")]
		get;
	}

	[Preserve(Conditional = true)]
	IntPtr Beta
	{
		[Export("beta")]
		get;
	}

	[Preserve(Conditional = true)]
	IntPtr Mean
	{
		[Export("mean")]
		get;
	}

	[Preserve(Conditional = true)]
	IntPtr Variance
	{
		[Export("variance")]
		get;
	}

	[Preserve(Conditional = true)]
	bool Load
	{
		[Export("load")]
		get;
	}

	[Preserve(Conditional = true)]
	string? Label
	{
		[Export("label")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("purge")]
	[Preserve(Conditional = true)]
	void Purge();
}
