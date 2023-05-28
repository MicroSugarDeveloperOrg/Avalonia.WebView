using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CITemperatureAndTint", WrapperType = typeof(CITemperatureAndTintProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Neutral", Selector = "neutral", PropertyType = typeof(CIVector), GetterSelector = "neutral", SetterSelector = "setNeutral:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "TargetNeutral", Selector = "targetNeutral", PropertyType = typeof(CIVector), GetterSelector = "targetNeutral", SetterSelector = "setTargetNeutral:", ArgumentSemantic = ArgumentSemantic.Retain)]
public interface ICITemperatureAndTintProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	CIVector Neutral
	{
		[Export("neutral", ArgumentSemantic.Retain)]
		get;
		[Export("setNeutral:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	CIVector TargetNeutral
	{
		[Export("targetNeutral", ArgumentSemantic.Retain)]
		get;
		[Export("setTargetNeutral:", ArgumentSemantic.Retain)]
		set;
	}
}
