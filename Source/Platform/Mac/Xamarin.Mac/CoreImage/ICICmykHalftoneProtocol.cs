using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CICMYKHalftone", WrapperType = typeof(CICmykHalftoneProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputCenter", Selector = "center", PropertyType = typeof(CGPoint), GetterSelector = "center", SetterSelector = "setCenter:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Width", Selector = "width", PropertyType = typeof(float), GetterSelector = "width", SetterSelector = "setWidth:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Angle", Selector = "angle", PropertyType = typeof(float), GetterSelector = "angle", SetterSelector = "setAngle:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Sharpness", Selector = "sharpness", PropertyType = typeof(float), GetterSelector = "sharpness", SetterSelector = "setSharpness:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "GrayComponentReplacement", Selector = "grayComponentReplacement", PropertyType = typeof(float), GetterSelector = "grayComponentReplacement", SetterSelector = "setGrayComponentReplacement:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "UnderColorRemoval", Selector = "underColorRemoval", PropertyType = typeof(float), GetterSelector = "underColorRemoval", SetterSelector = "setUnderColorRemoval:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICICmykHalftoneProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	CGPoint InputCenter
	{
		[Export("center", ArgumentSemantic.Assign)]
		get;
		[Export("setCenter:", ArgumentSemantic.Assign)]
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
	float Angle
	{
		[Export("angle")]
		get;
		[Export("setAngle:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Sharpness
	{
		[Export("sharpness")]
		get;
		[Export("setSharpness:")]
		set;
	}

	[Preserve(Conditional = true)]
	float GrayComponentReplacement
	{
		[Export("grayComponentReplacement")]
		get;
		[Export("setGrayComponentReplacement:")]
		set;
	}

	[Preserve(Conditional = true)]
	float UnderColorRemoval
	{
		[Export("underColorRemoval")]
		get;
		[Export("setUnderColorRemoval:")]
		set;
	}
}
