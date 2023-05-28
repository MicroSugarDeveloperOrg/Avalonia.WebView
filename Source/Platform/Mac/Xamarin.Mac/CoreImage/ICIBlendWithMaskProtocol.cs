using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIBlendWithMask", WrapperType = typeof(CIBlendWithMaskProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "BackgroundImage", Selector = "backgroundImage", PropertyType = typeof(CIImage), GetterSelector = "backgroundImage", SetterSelector = "setBackgroundImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaskImage", Selector = "maskImage", PropertyType = typeof(CIImage), GetterSelector = "maskImage", SetterSelector = "setMaskImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
public interface ICIBlendWithMaskProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	CIImage? BackgroundImage
	{
		[Export("backgroundImage", ArgumentSemantic.Retain)]
		get;
		[Export("setBackgroundImage:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	CIImage? MaskImage
	{
		[Export("maskImage", ArgumentSemantic.Retain)]
		get;
		[Export("setMaskImage:", ArgumentSemantic.Retain)]
		set;
	}
}
