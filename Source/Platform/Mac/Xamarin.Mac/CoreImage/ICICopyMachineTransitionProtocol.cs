using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CICopyMachineTransition", WrapperType = typeof(CICopyMachineTransitionProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Extent", Selector = "extent", PropertyType = typeof(CGRect), GetterSelector = "extent", SetterSelector = "setExtent:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Color", Selector = "color", PropertyType = typeof(CIColor), GetterSelector = "color", SetterSelector = "setColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Angle", Selector = "angle", PropertyType = typeof(float), GetterSelector = "angle", SetterSelector = "setAngle:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Width", Selector = "width", PropertyType = typeof(float), GetterSelector = "width", SetterSelector = "setWidth:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Opacity", Selector = "opacity", PropertyType = typeof(float), GetterSelector = "opacity", SetterSelector = "setOpacity:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICICopyMachineTransitionProtocol : INativeObject, IDisposable, ICIFilterProtocol
{
	[Preserve(Conditional = true)]
	CGRect Extent
	{
		[Export("extent", ArgumentSemantic.Assign)]
		get;
		[Export("setExtent:", ArgumentSemantic.Assign)]
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
	float Angle
	{
		[Export("angle")]
		get;
		[Export("setAngle:")]
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
	float Opacity
	{
		[Export("opacity")]
		get;
		[Export("setOpacity:")]
		set;
	}
}
