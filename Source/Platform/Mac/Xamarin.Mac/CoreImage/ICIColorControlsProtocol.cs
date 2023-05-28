using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIColorControls", WrapperType = typeof(CIColorControlsProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Saturation", Selector = "saturation", PropertyType = typeof(float), GetterSelector = "saturation", SetterSelector = "setSaturation:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Brightness", Selector = "brightness", PropertyType = typeof(float), GetterSelector = "brightness", SetterSelector = "setBrightness:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Contrast", Selector = "contrast", PropertyType = typeof(float), GetterSelector = "contrast", SetterSelector = "setContrast:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIColorControlsProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	float Saturation
	{
		[Export("saturation")]
		get;
		[Export("setSaturation:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Brightness
	{
		[Export("brightness")]
		get;
		[Export("setBrightness:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Contrast
	{
		[Export("contrast")]
		get;
		[Export("setContrast:")]
		set;
	}
}
