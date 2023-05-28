using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIFilter", WrapperType = typeof(CIFilterProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputImage", Selector = "outputImage", PropertyType = typeof(CIImage), GetterSelector = "outputImage", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = true, Name = "CustomAttributes", Selector = "customAttributes", PropertyType = typeof(NSDictionary<NSString, NSObject>), GetterSelector = "customAttributes", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIFilterProtocol : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	CIImage? OutputImage
	{
		[Export("outputImage")]
		get;
	}
}
