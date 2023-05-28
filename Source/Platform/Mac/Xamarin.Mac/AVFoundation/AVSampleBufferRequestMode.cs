using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Native]
public enum AVSampleBufferRequestMode : long
{
	Immediate,
	Scheduled
}
