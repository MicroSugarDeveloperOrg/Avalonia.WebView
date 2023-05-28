using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIStripesGenerator", WrapperType = typeof(CIStripesGeneratorProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputCenter", Selector = "center", PropertyType = typeof(CGPoint), GetterSelector = "center", SetterSelector = "setCenter:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Color0", Selector = "color0", PropertyType = typeof(CIColor), GetterSelector = "color0", SetterSelector = "setColor0:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Color1", Selector = "color1", PropertyType = typeof(CIColor), GetterSelector = "color1", SetterSelector = "setColor1:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Width", Selector = "width", PropertyType = typeof(float), GetterSelector = "width", SetterSelector = "setWidth:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Sharpness", Selector = "sharpness", PropertyType = typeof(float), GetterSelector = "sharpness", SetterSelector = "setSharpness:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIStripesGeneratorProtocol : INativeObject, IDisposable, ICIFilterProtocol
{
	[Preserve(Conditional = true)]
	CGPoint InputCenter
	{
		[Export("center", ArgumentSemantic.Assign)]
		get;
		[Export("setCenter:", ArgumentSemantic.Assign)]
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

	[Preserve(Conditional = true)]
	float Width
	{
		[Export("width")]
		get;
		[Export("setWidth:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Sharpness
	{
		[Export("sharpness")]
		get;
		[Export("setSharpness:")]
		set;
	}
}
