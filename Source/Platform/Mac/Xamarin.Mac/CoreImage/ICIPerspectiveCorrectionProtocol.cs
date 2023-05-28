using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIPerspectiveCorrection", WrapperType = typeof(CIPerspectiveCorrectionProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Crop", Selector = "crop", PropertyType = typeof(bool), GetterSelector = "crop", SetterSelector = "setCrop:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIPerspectiveCorrectionProtocol : INativeObject, IDisposable, ICIFilterProtocol, ICIFourCoordinateGeometryFilterProtocol
{
	[Preserve(Conditional = true)]
	bool Crop
	{
		[Export("crop")]
		get;
		[Export("setCrop:")]
		set;
	}
}
