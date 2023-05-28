using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Native]
public enum AVCaptureLensStabilizationStatus : long
{
	Unsupported,
	Off,
	Active,
	OutOfRange,
	Unavailable
}
