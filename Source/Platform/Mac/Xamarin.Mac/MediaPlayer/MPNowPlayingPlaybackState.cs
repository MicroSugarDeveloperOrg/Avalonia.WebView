using ObjCRuntime;

namespace MediaPlayer;

[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Native]
public enum MPNowPlayingPlaybackState : ulong
{
	Unknown,
	Playing,
	Paused,
	Stopped,
	Interrupted
}
