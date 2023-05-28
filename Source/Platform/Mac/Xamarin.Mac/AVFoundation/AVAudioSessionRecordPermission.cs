using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
[Native]
public enum AVAudioSessionRecordPermission : ulong
{
	Undetermined = 1970168948uL,
	Denied = 1684369017uL,
	Granted = 1735552628uL
}
