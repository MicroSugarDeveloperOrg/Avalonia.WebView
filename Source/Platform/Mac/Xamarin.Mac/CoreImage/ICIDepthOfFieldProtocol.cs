using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIDepthOfField", WrapperType = typeof(CIDepthOfFieldProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputPoint0", Selector = "point0", PropertyType = typeof(CGPoint), GetterSelector = "point0", SetterSelector = "setPoint0:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputPoint1", Selector = "point1", PropertyType = typeof(CGPoint), GetterSelector = "point1", SetterSelector = "setPoint1:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Saturation", Selector = "saturation", PropertyType = typeof(float), GetterSelector = "saturation", SetterSelector = "setSaturation:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "UnsharpMaskRadius", Selector = "unsharpMaskRadius", PropertyType = typeof(float), GetterSelector = "unsharpMaskRadius", SetterSelector = "setUnsharpMaskRadius:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "UnsharpMaskIntensity", Selector = "unsharpMaskIntensity", PropertyType = typeof(float), GetterSelector = "unsharpMaskIntensity", SetterSelector = "setUnsharpMaskIntensity:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Radius", Selector = "radius", PropertyType = typeof(float), GetterSelector = "radius", SetterSelector = "setRadius:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIDepthOfFieldProtocol : INativeObject, IDisposable, ICIFilterProtocol
{
	[Preserve(Conditional = true)]
	CIImage? InputImage
	{
		[Export("inputImage", ArgumentSemantic.Retain)]
		get;
		[Export("setInputImage:", ArgumentSemantic.Retain)]
		set;
	}

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
	float Saturation
	{
		[Export("saturation")]
		get;
		[Export("setSaturation:")]
		set;
	}

	[Preserve(Conditional = true)]
	float UnsharpMaskRadius
	{
		[Export("unsharpMaskRadius")]
		get;
		[Export("setUnsharpMaskRadius:")]
		set;
	}

	[Preserve(Conditional = true)]
	float UnsharpMaskIntensity
	{
		[Export("unsharpMaskIntensity")]
		get;
		[Export("setUnsharpMaskIntensity:")]
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
