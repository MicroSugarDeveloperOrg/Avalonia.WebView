using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "AVAudioMixing", WrapperType = typeof(AVAudioMixingWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DestinationForMixer", Selector = "destinationForMixer:bus:", ReturnType = typeof(AVAudioMixingDestination), ParameterType = new Type[]
{
	typeof(AVAudioNode),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Volume", Selector = "volume", PropertyType = typeof(float), GetterSelector = "volume", SetterSelector = "setVolume:", ArgumentSemantic = ArgumentSemantic.None)]
public interface IAVAudioMixing : INativeObject, IDisposable, IAVAudio3DMixing, IAVAudioStereoMixing
{
	[Preserve(Conditional = true)]
	float Volume
	{
		[Export("volume")]
		get;
		[Export("setVolume:")]
		set;
	}
}
