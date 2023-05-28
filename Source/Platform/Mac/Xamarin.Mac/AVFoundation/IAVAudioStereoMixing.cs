using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "AVAudioStereoMixing", WrapperType = typeof(AVAudioStereoMixingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Pan", Selector = "pan", PropertyType = typeof(float), GetterSelector = "pan", SetterSelector = "setPan:", ArgumentSemantic = ArgumentSemantic.None)]
public interface IAVAudioStereoMixing : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	float Pan
	{
		[Export("pan")]
		get;
		[Export("setPan:")]
		set;
	}
}
