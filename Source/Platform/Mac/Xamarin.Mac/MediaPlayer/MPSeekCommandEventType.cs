using ObjCRuntime;

namespace MediaPlayer;

[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
[Native]
public enum MPSeekCommandEventType : ulong
{
	BeginSeeking,
	EndSeeking
}
