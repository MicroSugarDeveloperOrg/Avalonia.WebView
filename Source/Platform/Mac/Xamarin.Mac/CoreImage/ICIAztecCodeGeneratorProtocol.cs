using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIAztecCodeGenerator", WrapperType = typeof(CIAztecCodeGeneratorProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Message", Selector = "message", PropertyType = typeof(NSData), GetterSelector = "message", SetterSelector = "setMessage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CorrectionLevel", Selector = "correctionLevel", PropertyType = typeof(float), GetterSelector = "correctionLevel", SetterSelector = "setCorrectionLevel:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputLayers", Selector = "layers", PropertyType = typeof(float), GetterSelector = "layers", SetterSelector = "setLayers:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputCompactStyle", Selector = "compactStyle", PropertyType = typeof(float), GetterSelector = "compactStyle", SetterSelector = "setCompactStyle:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIAztecCodeGeneratorProtocol : INativeObject, IDisposable, ICIFilterProtocol
{
	[Preserve(Conditional = true)]
	NSData Message
	{
		[Export("message", ArgumentSemantic.Retain)]
		get;
		[Export("setMessage:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	float CorrectionLevel
	{
		[Export("correctionLevel")]
		get;
		[Export("setCorrectionLevel:")]
		set;
	}

	[Preserve(Conditional = true)]
	float InputLayers
	{
		[Export("layers")]
		get;
		[Export("setLayers:")]
		set;
	}

	[Preserve(Conditional = true)]
	float InputCompactStyle
	{
		[Export("compactStyle")]
		get;
		[Export("setCompactStyle:")]
		set;
	}
}
