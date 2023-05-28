using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIAttributedTextImageGenerator", WrapperType = typeof(CIAttributedTextImageGeneratorProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Text", Selector = "text", PropertyType = typeof(NSAttributedString), GetterSelector = "text", SetterSelector = "setText:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ScaleFactor", Selector = "scaleFactor", PropertyType = typeof(float), GetterSelector = "scaleFactor", SetterSelector = "setScaleFactor:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIAttributedTextImageGeneratorProtocol : INativeObject, IDisposable, ICIFilterProtocol
{
	[Preserve(Conditional = true)]
	NSAttributedString Text
	{
		[Export("text", ArgumentSemantic.Retain)]
		get;
		[Export("setText:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	float ScaleFactor
	{
		[Export("scaleFactor")]
		get;
		[Export("setScaleFactor:")]
		set;
	}
}
