using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Native]
public enum AVAudioEngineManualRenderingStatus : long
{
	Error = -1L,
	Success,
	InsufficientDataFromInputNode,
	CannotDoInCurrentContext
}
