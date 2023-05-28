using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Native]
public enum AVAudioEnvironmentOutputType : long
{
	Auto,
	Headphones,
	BuiltInSpeakers,
	ExternalSpeakers
}
