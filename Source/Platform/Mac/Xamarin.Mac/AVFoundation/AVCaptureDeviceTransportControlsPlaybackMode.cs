using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Native]
public enum AVCaptureDeviceTransportControlsPlaybackMode : long
{
	NotPlaying,
	Playing
}
