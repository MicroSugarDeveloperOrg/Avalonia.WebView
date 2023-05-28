using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIHighlightShadowAdjust", WrapperType = typeof(CIHighlightShadowAdjustProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Radius", Selector = "radius", PropertyType = typeof(float), GetterSelector = "radius", SetterSelector = "setRadius:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ShadowAmount", Selector = "shadowAmount", PropertyType = typeof(float), GetterSelector = "shadowAmount", SetterSelector = "setShadowAmount:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "HighlightAmount", Selector = "highlightAmount", PropertyType = typeof(float), GetterSelector = "highlightAmount", SetterSelector = "setHighlightAmount:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIHighlightShadowAdjustProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	float ShadowAmount
	{
		[Export("shadowAmount")]
		get;
		[Export("setShadowAmount:")]
		set;
	}

	[Preserve(Conditional = true)]
	float HighlightAmount
	{
		[Export("highlightAmount")]
		get;
		[Export("setHighlightAmount:")]
		set;
	}
}
