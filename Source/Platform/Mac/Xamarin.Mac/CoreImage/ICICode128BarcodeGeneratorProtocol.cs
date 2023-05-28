using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CICode128BarcodeGenerator", WrapperType = typeof(CICode128BarcodeGeneratorProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Message", Selector = "message", PropertyType = typeof(NSData), GetterSelector = "message", SetterSelector = "setMessage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "QuietSpace", Selector = "quietSpace", PropertyType = typeof(float), GetterSelector = "quietSpace", SetterSelector = "setQuietSpace:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "BarcodeHeight", Selector = "barcodeHeight", PropertyType = typeof(float), GetterSelector = "barcodeHeight", SetterSelector = "setBarcodeHeight:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICICode128BarcodeGeneratorProtocol : INativeObject, IDisposable, ICIFilterProtocol
{
	[Preserve(Conditional = true)]
	NSData Message
	{
		[Export("message", ArgumentSemantic.Retain)]
		get;
		[Export("setMessage:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	float QuietSpace
	{
		[Export("quietSpace")]
		get;
		[Export("setQuietSpace:")]
		set;
	}

	[Preserve(Conditional = true)]
	float BarcodeHeight
	{
		[Export("barcodeHeight")]
		get;
		[Export("setBarcodeHeight:")]
		set;
	}
}
