using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIBicubicScaleTransform", WrapperType = typeof(CIBicubicScaleTransformProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Scale", Selector = "scale", PropertyType = typeof(float), GetterSelector = "scale", SetterSelector = "setScale:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AspectRatio", Selector = "aspectRatio", PropertyType = typeof(float), GetterSelector = "aspectRatio", SetterSelector = "setAspectRatio:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ParameterB", Selector = "parameterB", PropertyType = typeof(float), GetterSelector = "parameterB", SetterSelector = "setParameterB:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ParameterC", Selector = "parameterC", PropertyType = typeof(float), GetterSelector = "parameterC", SetterSelector = "setParameterC:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIBicubicScaleTransformProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	float Scale
	{
		[Export("scale")]
		get;
		[Export("setScale:")]
		set;
	}

	[Preserve(Conditional = true)]
	float AspectRatio
	{
		[Export("aspectRatio")]
		get;
		[Export("setAspectRatio:")]
		set;
	}

	[Preserve(Conditional = true)]
	float ParameterB
	{
		[Export("parameterB")]
		get;
		[Export("setParameterB:")]
		set;
	}

	[Preserve(Conditional = true)]
	float ParameterC
	{
		[Export("parameterC")]
		get;
		[Export("setParameterC:")]
		set;
	}
}
