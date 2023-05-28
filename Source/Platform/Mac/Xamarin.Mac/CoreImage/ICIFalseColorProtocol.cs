using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIFalseColor", WrapperType = typeof(CIFalseColorProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Color0", Selector = "color0", PropertyType = typeof(CIColor), GetterSelector = "color0", SetterSelector = "setColor0:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Color1", Selector = "color1", PropertyType = typeof(CIColor), GetterSelector = "color1", SetterSelector = "setColor1:", ArgumentSemantic = ArgumentSemantic.Retain)]
public interface ICIFalseColorProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	CIColor Color0
	{
		[Export("color0", ArgumentSemantic.Retain)]
		get;
		[Export("setColor0:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	CIColor Color1
	{
		[Export("color1", ArgumentSemantic.Retain)]
		get;
		[Export("setColor1:", ArgumentSemantic.Retain)]
		set;
	}
}
