using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIQRCodeGenerator", WrapperType = typeof(CIQRCodeGeneratorProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Message", Selector = "message", PropertyType = typeof(NSData), GetterSelector = "message", SetterSelector = "setMessage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CorrectionLevel", Selector = "correctionLevel", PropertyType = typeof(string), GetterSelector = "correctionLevel", SetterSelector = "setCorrectionLevel:", ArgumentSemantic = ArgumentSemantic.Retain)]
public interface ICIQRCodeGeneratorProtocol : INativeObject, IDisposable, ICIFilterProtocol
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
	string CorrectionLevel
	{
		[Export("correctionLevel", ArgumentSemantic.Retain)]
		get;
		[Export("setCorrectionLevel:", ArgumentSemantic.Retain)]
		set;
	}
}
