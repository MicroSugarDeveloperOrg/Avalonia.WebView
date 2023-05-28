using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CITriangleKaleidoscope", WrapperType = typeof(CITriangleKaleidoscopeProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputPoint", Selector = "point", PropertyType = typeof(CGPoint), GetterSelector = "point", SetterSelector = "setPoint:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Size", Selector = "size", PropertyType = typeof(float), GetterSelector = "size", SetterSelector = "setSize:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Rotation", Selector = "rotation", PropertyType = typeof(float), GetterSelector = "rotation", SetterSelector = "setRotation:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Decay", Selector = "decay", PropertyType = typeof(float), GetterSelector = "decay", SetterSelector = "setDecay:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICITriangleKaleidoscopeProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	CGPoint InputPoint
	{
		[Export("point", ArgumentSemantic.Assign)]
		get;
		[Export("setPoint:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	float Size
	{
		[Export("size")]
		get;
		[Export("setSize:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Rotation
	{
		[Export("rotation")]
		get;
		[Export("setRotation:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Decay
	{
		[Export("decay")]
		get;
		[Export("setDecay:")]
		set;
	}
}
