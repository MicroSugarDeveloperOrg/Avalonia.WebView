using System;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "VNFaceObservationAccepting", WrapperType = typeof(VNFaceObservationAcceptingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputFaceObservations", Selector = "inputFaceObservations", PropertyType = typeof(VNFaceObservation[]), GetterSelector = "inputFaceObservations", SetterSelector = "setInputFaceObservations:", ArgumentSemantic = ArgumentSemantic.Copy)]
public interface IVNFaceObservationAccepting : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	VNFaceObservation[]? InputFaceObservations
	{
		[Export("inputFaceObservations", ArgumentSemantic.Copy)]
		get;
		[Export("setInputFaceObservations:", ArgumentSemantic.Copy)]
		set;
	}
}
