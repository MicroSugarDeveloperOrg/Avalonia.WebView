using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Native]
public enum AVPlayerActionAtItemEnd : long
{
	Advance,
	Pause,
	None
}
