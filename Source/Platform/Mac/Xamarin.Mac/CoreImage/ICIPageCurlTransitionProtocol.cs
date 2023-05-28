using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIPageCurlTransition", WrapperType = typeof(CIPageCurlTransitionProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "BacksideImage", Selector = "backsideImage", PropertyType = typeof(CIImage), GetterSelector = "backsideImage", SetterSelector = "setBacksideImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ShadingImage", Selector = "shadingImage", PropertyType = typeof(CIImage), GetterSelector = "shadingImage", SetterSelector = "setShadingImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputExtent", Selector = "extent", PropertyType = typeof(CGRect), GetterSelector = "extent", SetterSelector = "setExtent:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Angle", Selector = "angle", PropertyType = typeof(float), GetterSelector = "angle", SetterSelector = "setAngle:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Radius", Selector = "radius", PropertyType = typeof(float), GetterSelector = "radius", SetterSelector = "setRadius:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIPageCurlTransitionProtocol : INativeObject, IDisposable, ICIFilterProtocol, ICITransitionFilterProtocol
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
	CIImage? ShadingImage
	{
		[Export("shadingImage", ArgumentSemantic.Retain)]
		get;
		[Export("setShadingImage:", ArgumentSemantic.Retain)]
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
}
