using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIColorCubesMixedWithMask", WrapperType = typeof(CIColorCubesMixedWithMaskProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaskImage", Selector = "maskImage", PropertyType = typeof(CIImage), GetterSelector = "maskImage", SetterSelector = "setMaskImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CubeDimension", Selector = "cubeDimension", PropertyType = typeof(float), GetterSelector = "cubeDimension", SetterSelector = "setCubeDimension:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Cube0Data", Selector = "cube0Data", PropertyType = typeof(NSData), GetterSelector = "cube0Data", SetterSelector = "setCube0Data:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Cube1Data", Selector = "cube1Data", PropertyType = typeof(NSData), GetterSelector = "cube1Data", SetterSelector = "setCube1Data:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ColorSpace", Selector = "colorSpace", PropertyType = typeof(CGColorSpace), GetterSelector = "colorSpace", SetterSelector = "setColorSpace:", ArgumentSemantic = ArgumentSemantic.Assign)]
public interface ICIColorCubesMixedWithMaskProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	CIImage? MaskImage
	{
		[Export("maskImage", ArgumentSemantic.Retain)]
		get;
		[Export("setMaskImage:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	float CubeDimension
	{
		[Export("cubeDimension")]
		get;
		[Export("setCubeDimension:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSData Cube0Data
	{
		[Export("cube0Data", ArgumentSemantic.Retain)]
		get;
		[Export("setCube0Data:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	NSData Cube1Data
	{
		[Export("cube1Data", ArgumentSemantic.Retain)]
		get;
		[Export("setCube1Data:", ArgumentSemantic.Retain)]
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
