using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIColorMonochrome", WrapperType = typeof(CIColorMonochromeProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Color", Selector = "color", PropertyType = typeof(CIColor), GetterSelector = "color", SetterSelector = "setColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Intensity", Selector = "intensity", PropertyType = typeof(float), GetterSelector = "intensity", SetterSelector = "setIntensity:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIColorMonochromeProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	CIColor Color
	{
		[Export("color", ArgumentSemantic.Retain)]
		get;
		[Export("setColor:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	float Intensity
	{
		[Export("intensity")]
		get;
		[Export("setIntensity:")]
		set;
	}
}
