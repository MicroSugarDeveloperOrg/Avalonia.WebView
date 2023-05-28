using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIKeystoneCorrectionCombined", WrapperType = typeof(CIKeystoneCorrectionCombinedProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "FocalLength", Selector = "focalLength", PropertyType = typeof(float), GetterSelector = "focalLength", SetterSelector = "setFocalLength:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIKeystoneCorrectionCombinedProtocol : INativeObject, IDisposable, ICIFilterProtocol, ICIFourCoordinateGeometryFilterProtocol
{
	[Preserve(Conditional = true)]
	float FocalLength
	{
		[Export("focalLength")]
		get;
		[Export("setFocalLength:")]
		set;
	}
}
