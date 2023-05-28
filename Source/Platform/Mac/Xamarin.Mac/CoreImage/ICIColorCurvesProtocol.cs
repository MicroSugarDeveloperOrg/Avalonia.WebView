using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIColorCurves", WrapperType = typeof(CIColorCurvesProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CurvesData", Selector = "curvesData", PropertyType = typeof(NSData), GetterSelector = "curvesData", SetterSelector = "setCurvesData:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CurvesDomain", Selector = "curvesDomain", PropertyType = typeof(CIVector), GetterSelector = "curvesDomain", SetterSelector = "setCurvesDomain:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ColorSpace", Selector = "colorSpace", PropertyType = typeof(CGColorSpace), GetterSelector = "colorSpace", SetterSelector = "setColorSpace:", ArgumentSemantic = ArgumentSemantic.Assign)]
public interface ICIColorCurvesProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	NSData CurvesData
	{
		[Export("curvesData", ArgumentSemantic.Retain)]
		get;
		[Export("setCurvesData:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	CIVector CurvesDomain
	{
		[Export("curvesDomain", ArgumentSemantic.Retain)]
		get;
		[Export("setCurvesDomain:", ArgumentSemantic.Retain)]
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
