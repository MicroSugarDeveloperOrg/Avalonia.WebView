using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CISpotLight", WrapperType = typeof(CISpotLightProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "LightPosition", Selector = "lightPosition", PropertyType = typeof(CIVector), GetterSelector = "lightPosition", SetterSelector = "setLightPosition:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "LightPointsAt", Selector = "lightPointsAt", PropertyType = typeof(CIVector), GetterSelector = "lightPointsAt", SetterSelector = "setLightPointsAt:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Brightness", Selector = "brightness", PropertyType = typeof(float), GetterSelector = "brightness", SetterSelector = "setBrightness:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Concentration", Selector = "concentration", PropertyType = typeof(float), GetterSelector = "concentration", SetterSelector = "setConcentration:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Color", Selector = "color", PropertyType = typeof(CIColor), GetterSelector = "color", SetterSelector = "setColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
public interface ICISpotLightProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	CIVector LightPosition
	{
		[Export("lightPosition", ArgumentSemantic.Retain)]
		get;
		[Export("setLightPosition:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	CIVector LightPointsAt
	{
		[Export("lightPointsAt", ArgumentSemantic.Retain)]
		get;
		[Export("setLightPointsAt:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	float Brightness
	{
		[Export("brightness")]
		get;
		[Export("setBrightness:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Concentration
	{
		[Export("concentration")]
		get;
		[Export("setConcentration:")]
		set;
	}

	[Preserve(Conditional = true)]
	CIColor Color
	{
		[Export("color", ArgumentSemantic.Retain)]
		get;
		[Export("setColor:", ArgumentSemantic.Retain)]
		set;
	}
}
