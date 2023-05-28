using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CISunbeamsGenerator", WrapperType = typeof(CISunbeamsGeneratorProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputCenter", Selector = "center", PropertyType = typeof(CGPoint), GetterSelector = "center", SetterSelector = "setCenter:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Color", Selector = "color", PropertyType = typeof(CIColor), GetterSelector = "color", SetterSelector = "setColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "SunRadius", Selector = "sunRadius", PropertyType = typeof(float), GetterSelector = "sunRadius", SetterSelector = "setSunRadius:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaxStriationRadius", Selector = "maxStriationRadius", PropertyType = typeof(float), GetterSelector = "maxStriationRadius", SetterSelector = "setMaxStriationRadius:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "StriationStrength", Selector = "striationStrength", PropertyType = typeof(float), GetterSelector = "striationStrength", SetterSelector = "setStriationStrength:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "StriationContrast", Selector = "striationContrast", PropertyType = typeof(float), GetterSelector = "striationContrast", SetterSelector = "setStriationContrast:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Time", Selector = "time", PropertyType = typeof(float), GetterSelector = "time", SetterSelector = "setTime:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICISunbeamsGeneratorProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	CIColor Color
	{
		[Export("color", ArgumentSemantic.Retain)]
		get;
		[Export("setColor:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	float SunRadius
	{
		[Export("sunRadius")]
		get;
		[Export("setSunRadius:")]
		set;
	}

	[Preserve(Conditional = true)]
	float MaxStriationRadius
	{
		[Export("maxStriationRadius")]
		get;
		[Export("setMaxStriationRadius:")]
		set;
	}

	[Preserve(Conditional = true)]
	float StriationStrength
	{
		[Export("striationStrength")]
		get;
		[Export("setStriationStrength:")]
		set;
	}

	[Preserve(Conditional = true)]
	float StriationContrast
	{
		[Export("striationContrast")]
		get;
		[Export("setStriationContrast:")]
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
