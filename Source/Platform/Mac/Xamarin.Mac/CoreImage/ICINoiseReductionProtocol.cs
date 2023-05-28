using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CINoiseReduction", WrapperType = typeof(CINoiseReductionProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "NoiseLevel", Selector = "noiseLevel", PropertyType = typeof(float), GetterSelector = "noiseLevel", SetterSelector = "setNoiseLevel:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Sharpness", Selector = "sharpness", PropertyType = typeof(float), GetterSelector = "sharpness", SetterSelector = "setSharpness:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICINoiseReductionProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	float NoiseLevel
	{
		[Export("noiseLevel")]
		get;
		[Export("setNoiseLevel:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Sharpness
	{
		[Export("sharpness")]
		get;
		[Export("setSharpness:")]
		set;
	}
}
