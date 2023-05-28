using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIPageCurlWithShadowTransition", WrapperType = typeof(CIPageCurlWithShadowTransitionProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "BacksideImage", Selector = "backsideImage", PropertyType = typeof(CIImage), GetterSelector = "backsideImage", SetterSelector = "setBacksideImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputExtent", Selector = "extent", PropertyType = typeof(CGRect), GetterSelector = "extent", SetterSelector = "setExtent:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Angle", Selector = "angle", PropertyType = typeof(float), GetterSelector = "angle", SetterSelector = "setAngle:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Radius", Selector = "radius", PropertyType = typeof(float), GetterSelector = "radius", SetterSelector = "setRadius:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ShadowSize", Selector = "shadowSize", PropertyType = typeof(float), GetterSelector = "shadowSize", SetterSelector = "setShadowSize:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ShadowAmount", Selector = "shadowAmount", PropertyType = typeof(float), GetterSelector = "shadowAmount", SetterSelector = "setShadowAmount:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputShadowExtent", Selector = "shadowExtent", PropertyType = typeof(CGRect), GetterSelector = "shadowExtent", SetterSelector = "setShadowExtent:", ArgumentSemantic = ArgumentSemantic.Assign)]
public interface ICIPageCurlWithShadowTransitionProtocol : INativeObject, IDisposable, ICIFilterProtocol, ICITransitionFilterProtocol
{
	[Preserve(Conditional = true)]
	CIImage? BacksideImage
	{
		[Export("backsideImage", ArgumentSemantic.Retain)]
		get;
		[Export("setBacksideImage:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	CGRect InputExtent
	{
		[Export("extent", ArgumentSemantic.Assign)]
		get;
		[Export("setExtent:", ArgumentSemantic.Assign)]
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
	float Radius
	{
		[Export("radius")]
		get;
		[Export("setRadius:")]
		set;
	}

	[Preserve(Conditional = true)]
	float ShadowSize
	{
		[Export("shadowSize")]
		get;
		[Export("setShadowSize:")]
		set;
	}

	[Preserve(Conditional = true)]
	float ShadowAmount
	{
		[Export("shadowAmount")]
		get;
		[Export("setShadowAmount:")]
		set;
	}

	[Preserve(Conditional = true)]
	CGRect InputShadowExtent
	{
		[Export("shadowExtent", ArgumentSemantic.Assign)]
		get;
		[Export("setShadowExtent:", ArgumentSemantic.Assign)]
		set;
	}
}
