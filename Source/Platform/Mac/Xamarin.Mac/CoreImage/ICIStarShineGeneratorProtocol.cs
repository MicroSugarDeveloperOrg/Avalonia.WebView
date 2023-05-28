using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIStarShineGenerator", WrapperType = typeof(CIStarShineGeneratorProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputCenter", Selector = "center", PropertyType = typeof(CGPoint), GetterSelector = "center", SetterSelector = "setCenter:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Color", Selector = "color", PropertyType = typeof(CIColor), GetterSelector = "color", SetterSelector = "setColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Radius", Selector = "radius", PropertyType = typeof(float), GetterSelector = "radius", SetterSelector = "setRadius:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CrossScale", Selector = "crossScale", PropertyType = typeof(float), GetterSelector = "crossScale", SetterSelector = "setCrossScale:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CrossAngle", Selector = "crossAngle", PropertyType = typeof(float), GetterSelector = "crossAngle", SetterSelector = "setCrossAngle:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CrossOpacity", Selector = "crossOpacity", PropertyType = typeof(float), GetterSelector = "crossOpacity", SetterSelector = "setCrossOpacity:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CrossWidth", Selector = "crossWidth", PropertyType = typeof(float), GetterSelector = "crossWidth", SetterSelector = "setCrossWidth:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Epsilon", Selector = "epsilon", PropertyType = typeof(float), GetterSelector = "epsilon", SetterSelector = "setEpsilon:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIStarShineGeneratorProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	float Radius
	{
		[Export("radius")]
		get;
		[Export("setRadius:")]
		set;
	}

	[Preserve(Conditional = true)]
	float CrossScale
	{
		[Export("crossScale")]
		get;
		[Export("setCrossScale:")]
		set;
	}

	[Preserve(Conditional = true)]
	float CrossAngle
	{
		[Export("crossAngle")]
		get;
		[Export("setCrossAngle:")]
		set;
	}

	[Preserve(Conditional = true)]
	float CrossOpacity
	{
		[Export("crossOpacity")]
		get;
		[Export("setCrossOpacity:")]
		set;
	}

	[Preserve(Conditional = true)]
	float CrossWidth
	{
		[Export("crossWidth")]
		get;
		[Export("setCrossWidth:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Epsilon
	{
		[Export("epsilon")]
		get;
		[Export("setEpsilon:")]
		set;
	}
}
