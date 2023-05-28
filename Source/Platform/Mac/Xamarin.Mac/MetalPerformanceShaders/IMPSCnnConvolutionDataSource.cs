using System;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MPSCNNConvolutionDataSource", WrapperType = typeof(MPSCnnConvolutionDataSourceWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Purge", Selector = "purge")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRangesForUInt8Kernel", Selector = "rangesForUInt8Kernel", ReturnType = typeof(IntPtr))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetLookupTableForUInt8Kernel", Selector = "lookupTableForUInt8Kernel", ReturnType = typeof(IntPtr))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetWeightsQuantizationType", Selector = "weightsQuantizationType", ReturnType = typeof(MPSCnnWeightsQuantizationType))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Update", Selector = "updateWithCommandBuffer:gradientState:sourceState:", ReturnType = typeof(MPSCnnConvolutionWeightsAndBiasesState), ParameterType = new Type[]
{
	typeof(IMTLCommandBuffer),
	typeof(MPSCnnConvolutionGradientState),
	typeof(MPSCnnConvolutionWeightsAndBiasesState)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Update", Selector = "updateWithGradientState:sourceState:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(MPSCnnConvolutionGradientState),
	typeof(MPSCnnConvolutionWeightsAndBiasesState)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Copy", Selector = "copyWithZone:device:", ReturnType = typeof(IMPSCnnConvolutionDataSource), ParameterType = new Type[]
{
	typeof(NSZone),
	typeof(IMTLDevice)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "DataType", Selector = "dataType", PropertyType = typeof(MPSDataType), GetterSelector = "dataType", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Descriptor", Selector = "descriptor", PropertyType = typeof(MPSCnnConvolutionDescriptor), GetterSelector = "descriptor", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Weights", Selector = "weights", PropertyType = typeof(IntPtr), GetterSelector = "weights", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "BiasTerms", Selector = "biasTerms", PropertyType = typeof(IntPtr), GetterSelector = "biasTerms", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Load", Selector = "load", PropertyType = typeof(bool), GetterSelector = "load", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof(string), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMPSCnnConvolutionDataSource : INativeObject, IDisposable, INSCopying
{
	[Preserve(Conditional = true)]
	MPSDataType DataType
	{
		[Export("dataType")]
		get;
	}

	[Preserve(Conditional = true)]
	MPSCnnConvolutionDescriptor Descriptor
	{
		[Export("descriptor")]
		get;
	}

	[Preserve(Conditional = true)]
	IntPtr Weights
	{
		[Export("weights")]
		get;
	}

	[Preserve(Conditional = true)]
	IntPtr BiasTerms
	{
		[Export("biasTerms")]
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
