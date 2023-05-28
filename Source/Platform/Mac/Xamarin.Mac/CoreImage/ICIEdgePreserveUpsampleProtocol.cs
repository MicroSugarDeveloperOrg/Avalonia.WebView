using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIEdgePreserveUpsample", WrapperType = typeof(CIEdgePreserveUpsampleProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "SmallImage", Selector = "smallImage", PropertyType = typeof(CIImage), GetterSelector = "smallImage", SetterSelector = "setSmallImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "SpatialSigma", Selector = "spatialSigma", PropertyType = typeof(float), GetterSelector = "spatialSigma", SetterSelector = "setSpatialSigma:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "LumaSigma", Selector = "lumaSigma", PropertyType = typeof(float), GetterSelector = "lumaSigma", SetterSelector = "setLumaSigma:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIEdgePreserveUpsampleProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	CIImage? SmallImage
	{
		[Export("smallImage", ArgumentSemantic.Retain)]
		get;
		[Export("setSmallImage:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	float SpatialSigma
	{
		[Export("spatialSigma")]
		get;
		[Export("setSpatialSigma:")]
		set;
	}

	[Preserve(Conditional = true)]
	float LumaSigma
	{
		[Export("lumaSigma")]
		get;
		[Export("setLumaSigma:")]
		set;
	}
}
