using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIBokehBlur", WrapperType = typeof(CIBokehBlurProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Radius", Selector = "radius", PropertyType = typeof(float), GetterSelector = "radius", SetterSelector = "setRadius:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "RingAmount", Selector = "ringAmount", PropertyType = typeof(float), GetterSelector = "ringAmount", SetterSelector = "setRingAmount:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "RingSize", Selector = "ringSize", PropertyType = typeof(float), GetterSelector = "ringSize", SetterSelector = "setRingSize:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Softness", Selector = "softness", PropertyType = typeof(float), GetterSelector = "softness", SetterSelector = "setSoftness:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIBokehBlurProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	float Radius
	{
		[Export("radius")]
		get;
		[Export("setRadius:")]
		set;
	}

	[Preserve(Conditional = true)]
	float RingAmount
	{
		[Export("ringAmount")]
		get;
		[Export("setRingAmount:")]
		set;
	}

	[Preserve(Conditional = true)]
	float RingSize
	{
		[Export("ringSize")]
		get;
		[Export("setRingSize:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Softness
	{
		[Export("softness")]
		get;
		[Export("setSoftness:")]
		set;
	}
}
