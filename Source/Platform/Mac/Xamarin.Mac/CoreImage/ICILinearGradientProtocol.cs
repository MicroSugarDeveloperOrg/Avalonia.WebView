using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CILinearGradient", WrapperType = typeof(CILinearGradientProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputPoint0", Selector = "point0", PropertyType = typeof(CGPoint), GetterSelector = "point0", SetterSelector = "setPoint0:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputPoint1", Selector = "point1", PropertyType = typeof(CGPoint), GetterSelector = "point1", SetterSelector = "setPoint1:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Color0", Selector = "color0", PropertyType = typeof(CIColor), GetterSelector = "color0", SetterSelector = "setColor0:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Color1", Selector = "color1", PropertyType = typeof(CIColor), GetterSelector = "color1", SetterSelector = "setColor1:", ArgumentSemantic = ArgumentSemantic.Retain)]
public interface ICILinearGradientProtocol : INativeObject, IDisposable, ICIFilterProtocol
{
	[Preserve(Conditional = true)]
	CGPoint InputPoint0
	{
		[Export("point0", ArgumentSemantic.Assign)]
		get;
		[Export("setPoint0:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	CGPoint InputPoint1
	{
		[Export("point1", ArgumentSemantic.Assign)]
		get;
		[Export("setPoint1:", ArgumentSemantic.Assign)]
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
