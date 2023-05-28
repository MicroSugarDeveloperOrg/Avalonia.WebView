using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIColorCrossPolynomial", WrapperType = typeof(CIColorCrossPolynomialProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "RedCoefficients", Selector = "redCoefficients", PropertyType = typeof(CIVector), GetterSelector = "redCoefficients", SetterSelector = "setRedCoefficients:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "GreenCoefficients", Selector = "greenCoefficients", PropertyType = typeof(CIVector), GetterSelector = "greenCoefficients", SetterSelector = "setGreenCoefficients:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "BlueCoefficients", Selector = "blueCoefficients", PropertyType = typeof(CIVector), GetterSelector = "blueCoefficients", SetterSelector = "setBlueCoefficients:", ArgumentSemantic = ArgumentSemantic.Retain)]
public interface ICIColorCrossPolynomialProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	CIVector RedCoefficients
	{
		[Export("redCoefficients", ArgumentSemantic.Retain)]
		get;
		[Export("setRedCoefficients:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	CIVector GreenCoefficients
	{
		[Export("greenCoefficients", ArgumentSemantic.Retain)]
		get;
		[Export("setGreenCoefficients:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	CIVector BlueCoefficients
	{
		[Export("blueCoefficients", ArgumentSemantic.Retain)]
		get;
		[Export("setBlueCoefficients:", ArgumentSemantic.Retain)]
		set;
	}
}
