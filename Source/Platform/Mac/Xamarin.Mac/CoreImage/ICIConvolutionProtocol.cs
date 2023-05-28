using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIConvolution", WrapperType = typeof(CIConvolutionProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Weights", Selector = "weights", PropertyType = typeof(CIVector), GetterSelector = "weights", SetterSelector = "setWeights:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Bias", Selector = "bias", PropertyType = typeof(float), GetterSelector = "bias", SetterSelector = "setBias:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIConvolutionProtocol : INativeObject, IDisposable, ICIFilterProtocol
{
	[Preserve(Conditional = true)]
	CIImage? InputImage
	{
		[Export("inputImage", ArgumentSemantic.Retain)]
		get;
		[Export("setInputImage:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	CIVector Weights
	{
		[Export("weights", ArgumentSemantic.Retain)]
		get;
		[Export("setWeights:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	float Bias
	{
		[Export("bias")]
		get;
		[Export("setBias:")]
		set;
	}
}
