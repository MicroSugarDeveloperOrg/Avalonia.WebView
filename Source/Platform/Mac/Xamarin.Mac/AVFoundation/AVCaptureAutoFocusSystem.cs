using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Native]
public enum AVCaptureAutoFocusSystem : long
{
	None,
	ContrastDetection,
	PhaseDetection
}
