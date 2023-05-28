using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Native]
public enum AVPlayerItemStatus : long
{
	Unknown,
	ReadyToPlay,
	Failed
}
