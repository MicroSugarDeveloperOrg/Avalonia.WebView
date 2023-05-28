using ObjCRuntime;

namespace AVFoundation;

[Native]
public enum AVAudioSessionPortOverride : ulong
{
	None = 0uL,
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	Speaker = 1936747378uL
}
