using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Native]
public enum AVCaptureVideoOrientation : long
{
	Portrait = 1L,
	PortraitUpsideDown,
	LandscapeRight,
	LandscapeLeft
}
