using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CITransitionFilter", WrapperType = typeof(CITransitionFilterProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "TargetImage", Selector = "targetImage", PropertyType = typeof(CIImage), GetterSelector = "targetImage", SetterSelector = "setTargetImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Time", Selector = "time", PropertyType = typeof(float), GetterSelector = "time", SetterSelector = "setTime:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICITransitionFilterProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	CIImage? TargetImage
	{
		[Export("targetImage", ArgumentSemantic.Retain)]
		get;
		[Export("setTargetImage:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	float Time
	{
		[Export("time")]
		get;
		[Export("setTime:")]
		set;
	}
}
