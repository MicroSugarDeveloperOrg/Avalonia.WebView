using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIPaletteCentroid", WrapperType = typeof(CIPaletteCentroidProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "PaletteImage", Selector = "paletteImage", PropertyType = typeof(CIImage), GetterSelector = "paletteImage", SetterSelector = "setPaletteImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Perceptual", Selector = "perceptual", PropertyType = typeof(bool), GetterSelector = "perceptual", SetterSelector = "setPerceptual:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIPaletteCentroidProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	CIImage? PaletteImage
	{
		[Export("paletteImage", ArgumentSemantic.Retain)]
		get;
		[Export("setPaletteImage:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	bool Perceptual
	{
		[Export("perceptual")]
		get;
		[Export("setPerceptual:")]
		set;
	}
}
