using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIToneCurve", WrapperType = typeof(CIToneCurveProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputPoint0", Selector = "point0", PropertyType = typeof(CGPoint), GetterSelector = "point0", SetterSelector = "setPoint0:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputPoint1", Selector = "point1", PropertyType = typeof(CGPoint), GetterSelector = "point1", SetterSelector = "setPoint1:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputPoint2", Selector = "point2", PropertyType = typeof(CGPoint), GetterSelector = "point2", SetterSelector = "setPoint2:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputPoint3", Selector = "point3", PropertyType = typeof(CGPoint), GetterSelector = "point3", SetterSelector = "setPoint3:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputPoint4", Selector = "point4", PropertyType = typeof(CGPoint), GetterSelector = "point4", SetterSelector = "setPoint4:", ArgumentSemantic = ArgumentSemantic.Assign)]
public interface ICIToneCurveProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	CGPoint InputPoint2
	{
		[Export("point2", ArgumentSemantic.Assign)]
		get;
		[Export("setPoint2:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	CGPoint InputPoint3
	{
		[Export("point3", ArgumentSemantic.Assign)]
		get;
		[Export("setPoint3:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	CGPoint InputPoint4
	{
		[Export("point4", ArgumentSemantic.Assign)]
		get;
		[Export("setPoint4:", ArgumentSemantic.Assign)]
		set;
	}
}
