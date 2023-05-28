using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIFourCoordinateGeometryFilter", WrapperType = typeof(CIFourCoordinateGeometryFilterProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputTopLeft", Selector = "topLeft", PropertyType = typeof(CGPoint), GetterSelector = "topLeft", SetterSelector = "setTopLeft:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputTopRight", Selector = "topRight", PropertyType = typeof(CGPoint), GetterSelector = "topRight", SetterSelector = "setTopRight:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputBottomRight", Selector = "bottomRight", PropertyType = typeof(CGPoint), GetterSelector = "bottomRight", SetterSelector = "setBottomRight:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputBottomLeft", Selector = "bottomLeft", PropertyType = typeof(CGPoint), GetterSelector = "bottomLeft", SetterSelector = "setBottomLeft:", ArgumentSemantic = ArgumentSemantic.Assign)]
public interface ICIFourCoordinateGeometryFilterProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	CGPoint InputTopLeft
	{
		[Export("topLeft", ArgumentSemantic.Assign)]
		get;
		[Export("setTopLeft:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	CGPoint InputTopRight
	{
		[Export("topRight", ArgumentSemantic.Assign)]
		get;
		[Export("setTopRight:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	CGPoint InputBottomRight
	{
		[Export("bottomRight", ArgumentSemantic.Assign)]
		get;
		[Export("setBottomRight:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	CGPoint InputBottomLeft
	{
		[Export("bottomLeft", ArgumentSemantic.Assign)]
		get;
		[Export("setBottomLeft:", ArgumentSemantic.Assign)]
		set;
	}
}
