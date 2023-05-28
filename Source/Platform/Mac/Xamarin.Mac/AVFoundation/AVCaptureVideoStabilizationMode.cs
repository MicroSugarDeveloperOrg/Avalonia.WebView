using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Native]
public enum AVCaptureVideoStabilizationMode : long
{
	Off = 0L,
	Standard = 1L,
	Cinematic = 2L,
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	CinematicExtended = 3L,
	Auto = -1L
}
