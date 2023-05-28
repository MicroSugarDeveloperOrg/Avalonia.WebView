using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIColorClamp", WrapperType = typeof(CIColorClampProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "MinComponents", Selector = "minComponents", PropertyType = typeof(CIVector), GetterSelector = "minComponents", SetterSelector = "setMinComponents:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaxComponents", Selector = "maxComponents", PropertyType = typeof(CIVector), GetterSelector = "maxComponents", SetterSelector = "setMaxComponents:", ArgumentSemantic = ArgumentSemantic.Retain)]
public interface ICIColorClampProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	CIVector MinComponents
	{
		[Export("minComponents", ArgumentSemantic.Retain)]
		get;
		[Export("setMinComponents:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	CIVector MaxComponents
	{
		[Export("maxComponents", ArgumentSemantic.Retain)]
		get;
		[Export("setMaxComponents:", ArgumentSemantic.Retain)]
		set;
	}
}
