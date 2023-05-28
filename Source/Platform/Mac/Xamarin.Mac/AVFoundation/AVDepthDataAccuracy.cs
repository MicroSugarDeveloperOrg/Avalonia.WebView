using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Native]
public enum AVDepthDataAccuracy : long
{
	Relative,
	Absolute
}
