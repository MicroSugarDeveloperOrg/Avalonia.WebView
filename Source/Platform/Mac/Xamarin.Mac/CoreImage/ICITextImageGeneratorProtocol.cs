using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CITextImageGenerator", WrapperType = typeof(CITextImageGeneratorProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Text", Selector = "text", PropertyType = typeof(string), GetterSelector = "text", SetterSelector = "setText:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "FontName", Selector = "fontName", PropertyType = typeof(string), GetterSelector = "fontName", SetterSelector = "setFontName:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "FontSize", Selector = "fontSize", PropertyType = typeof(float), GetterSelector = "fontSize", SetterSelector = "setFontSize:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ScaleFactor", Selector = "scaleFactor", PropertyType = typeof(float), GetterSelector = "scaleFactor", SetterSelector = "setScaleFactor:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICITextImageGeneratorProtocol : INativeObject, IDisposable, ICIFilterProtocol
{
	[Preserve(Conditional = true)]
	string Text
	{
		[Export("text", ArgumentSemantic.Retain)]
		get;
		[Export("setText:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	string FontName
	{
		[Export("fontName", ArgumentSemantic.Retain)]
		get;
		[Export("setFontName:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	float FontSize
	{
		[Export("fontSize")]
		get;
		[Export("setFontSize:")]
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
