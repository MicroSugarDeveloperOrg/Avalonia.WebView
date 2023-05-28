using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIShadedMaterial", WrapperType = typeof(CIShadedMaterialProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ShadingImage", Selector = "shadingImage", PropertyType = typeof(CIImage), GetterSelector = "shadingImage", SetterSelector = "setShadingImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Scale", Selector = "scale", PropertyType = typeof(float), GetterSelector = "scale", SetterSelector = "setScale:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIShadedMaterialProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	CIImage? ShadingImage
	{
		[Export("shadingImage", ArgumentSemantic.Retain)]
		get;
		[Export("setShadingImage:", ArgumentSemantic.Retain)]
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
}
