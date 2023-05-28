using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CILenticularHaloGenerator", WrapperType = typeof(CILenticularHaloGeneratorProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputCenter", Selector = "center", PropertyType = typeof(CGPoint), GetterSelector = "center", SetterSelector = "setCenter:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Color", Selector = "color", PropertyType = typeof(CIColor), GetterSelector = "color", SetterSelector = "setColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "HaloRadius", Selector = "haloRadius", PropertyType = typeof(float), GetterSelector = "haloRadius", SetterSelector = "setHaloRadius:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "HaloWidth", Selector = "haloWidth", PropertyType = typeof(float), GetterSelector = "haloWidth", SetterSelector = "setHaloWidth:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "HaloOverlap", Selector = "haloOverlap", PropertyType = typeof(float), GetterSelector = "haloOverlap", SetterSelector = "setHaloOverlap:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "StriationStrength", Selector = "striationStrength", PropertyType = typeof(float), GetterSelector = "striationStrength", SetterSelector = "setStriationStrength:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "StriationContrast", Selector = "striationContrast", PropertyType = typeof(float), GetterSelector = "striationContrast", SetterSelector = "setStriationContrast:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Time", Selector = "time", PropertyType = typeof(float), GetterSelector = "time", SetterSelector = "setTime:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICILenticularHaloGeneratorProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	float HaloRadius
	{
		[Export("haloRadius")]
		get;
		[Export("setHaloRadius:")]
		set;
	}

	[Preserve(Conditional = true)]
	float HaloWidth
	{
		[Export("haloWidth")]
		get;
		[Export("setHaloWidth:")]
		set;
	}

	[Preserve(Conditional = true)]
	float HaloOverlap
	{
		[Export("haloOverlap")]
		get;
		[Export("setHaloOverlap:")]
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
