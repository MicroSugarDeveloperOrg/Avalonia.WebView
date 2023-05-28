using ObjCRuntime;

namespace MediaPlayer;

[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
[Native]
public enum MPRemoteCommandHandlerStatus : long
{
	Success = 0L,
	NoSuchContent = 100L,
	[Introduced(PlatformName.iOS, 9, 1, PlatformArchitecture.All, null)]
	NoActionableNowPlayingItem = 110L,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	DeviceNotFound = 120L,
	CommandFailed = 200L
}
