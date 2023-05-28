using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CILineOverlay", WrapperType = typeof(CILineOverlayProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "NRNoiseLevel", Selector = "NRNoiseLevel", PropertyType = typeof(float), GetterSelector = "NRNoiseLevel", SetterSelector = "setNRNoiseLevel:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "NRSharpness", Selector = "NRSharpness", PropertyType = typeof(float), GetterSelector = "NRSharpness", SetterSelector = "setNRSharpness:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "EdgeIntensity", Selector = "edgeIntensity", PropertyType = typeof(float), GetterSelector = "edgeIntensity", SetterSelector = "setEdgeIntensity:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Threshold", Selector = "threshold", PropertyType = typeof(float), GetterSelector = "threshold", SetterSelector = "setThreshold:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Contrast", Selector = "contrast", PropertyType = typeof(float), GetterSelector = "contrast", SetterSelector = "setContrast:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICILineOverlayProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	float NRNoiseLevel
	{
		[Export("NRNoiseLevel")]
		get;
		[Export("setNRNoiseLevel:")]
		set;
	}

	[Preserve(Conditional = true)]
	float NRSharpness
	{
		[Export("NRSharpness")]
		get;
		[Export("setNRSharpness:")]
		set;
	}

	[Preserve(Conditional = true)]
	float EdgeIntensity
	{
		[Export("edgeIntensity")]
		get;
		[Export("setEdgeIntensity:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Threshold
	{
		[Export("threshold")]
		get;
		[Export("setThreshold:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Contrast
	{
		[Export("contrast")]
		get;
		[Export("setContrast:")]
		set;
	}
}
