using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Native]
public enum AVCaptureExposureMode : long
{
	Locked,
	AutoExpose,
	ContinuousAutoExposure,
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	Custom
}
