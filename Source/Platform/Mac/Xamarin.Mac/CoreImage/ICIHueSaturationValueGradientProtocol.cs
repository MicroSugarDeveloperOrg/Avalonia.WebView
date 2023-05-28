using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIHueSaturationValueGradient", WrapperType = typeof(CIHueSaturationValueGradientProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Value", Selector = "value", PropertyType = typeof(float), GetterSelector = "value", SetterSelector = "setValue:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Radius", Selector = "radius", PropertyType = typeof(float), GetterSelector = "radius", SetterSelector = "setRadius:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Softness", Selector = "softness", PropertyType = typeof(float), GetterSelector = "softness", SetterSelector = "setSoftness:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Dither", Selector = "dither", PropertyType = typeof(float), GetterSelector = "dither", SetterSelector = "setDither:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ColorSpace", Selector = "colorSpace", PropertyType = typeof(CGColorSpace), GetterSelector = "colorSpace", SetterSelector = "setColorSpace:", ArgumentSemantic = ArgumentSemantic.Assign)]
public interface ICIHueSaturationValueGradientProtocol : INativeObject, IDisposable, ICIFilterProtocol
{
	[Preserve(Conditional = true)]
	float Value
	{
		[Export("value")]
		get;
		[Export("setValue:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Radius
	{
		[Export("radius")]
		get;
		[Export("setRadius:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Softness
	{
		[Export("softness")]
		get;
		[Export("setSoftness:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Dither
	{
		[Export("dither")]
		get;
		[Export("setDither:")]
		set;
	}

	[Preserve(Conditional = true)]
	CGColorSpace? ColorSpace
	{
		[Export("colorSpace", ArgumentSemantic.Assign)]
		get;
		[Export("setColorSpace:", ArgumentSemantic.Assign)]
		set;
	}
}
