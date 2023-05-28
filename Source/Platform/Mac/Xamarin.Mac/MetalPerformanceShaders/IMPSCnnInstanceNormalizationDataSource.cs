using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
[Protocol(Name = "MPSCNNInstanceNormalizationDataSource", WrapperType = typeof(MPSCnnInstanceNormalizationDataSourceWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateGammaAndBeta", Selector = "updateGammaAndBetaWithCommandBuffer:instanceNormalizationStateBatch:", ReturnType = typeof(MPSCnnNormalizationGammaAndBetaState), ParameterType = new Type[]
{
	typeof(IMTLCommandBuffer),
	typeof(MPSCnnInstanceNormalizationGradientState[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateGammaAndBeta", Selector = "updateGammaAndBetaWithInstanceNormalizationStateBatch:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(MPSCnnInstanceNormalizationGradientState[]) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetEpsilon", Selector = "epsilon", ReturnType = typeof(float))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Encode", Selector = "encodeWithCoder:", ParameterType = new Type[] { typeof(NSCoder) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Copy", Selector = "copyWithZone:device:", ReturnType = typeof(IMPSCnnInstanceNormalizationDataSource), ParameterType = new Type[]
{
	typeof(NSZone),
	typeof(IMTLDevice)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Gamma", Selector = "gamma", PropertyType = typeof(IntPtr), GetterSelector = "gamma", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Beta", Selector = "beta", PropertyType = typeof(IntPtr), GetterSelector = "beta", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "NumberOfFeatureChannels", Selector = "numberOfFeatureChannels", PropertyType = typeof(nuint), GetterSelector = "numberOfFeatureChannels", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof(string), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMPSCnnInstanceNormalizationDataSource : INativeObject, IDisposable, INSCopying
{
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
	nuint NumberOfFeatureChannels
	{
		[Export("numberOfFeatureChannels")]
		get;
	}

	[Preserve(Conditional = true)]
	string Label
	{
		[Export("label")]
		get;
	}
}
