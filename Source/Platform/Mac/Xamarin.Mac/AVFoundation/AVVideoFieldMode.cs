using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Native]
public enum AVVideoFieldMode : long
{
	Both,
	TopOnly,
	BottomOnly,
	Deinterlace
}
