using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIPerspectiveRotate", WrapperType = typeof(CIPerspectiveRotateProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "FocalLength", Selector = "focalLength", PropertyType = typeof(float), GetterSelector = "focalLength", SetterSelector = "setFocalLength:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Pitch", Selector = "pitch", PropertyType = typeof(float), GetterSelector = "pitch", SetterSelector = "setPitch:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Yaw", Selector = "yaw", PropertyType = typeof(float), GetterSelector = "yaw", SetterSelector = "setYaw:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Roll", Selector = "roll", PropertyType = typeof(float), GetterSelector = "roll", SetterSelector = "setRoll:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIPerspectiveRotateProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	float FocalLength
	{
		[Export("focalLength")]
		get;
		[Export("setFocalLength:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Pitch
	{
		[Export("pitch")]
		get;
		[Export("setPitch:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Yaw
	{
		[Export("yaw")]
		get;
		[Export("setYaw:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Roll
	{
		[Export("roll")]
		get;
		[Export("setRoll:")]
		set;
	}
}
