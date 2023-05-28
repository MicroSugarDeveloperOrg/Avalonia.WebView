using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public enum AVAudioEngineManualRenderingError
{
	InvalidMode = -80800,
	Initialized = -80801,
	NotRunning = -80802
}
