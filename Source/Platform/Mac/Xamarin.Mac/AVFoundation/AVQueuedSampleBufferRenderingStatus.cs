using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Native]
public enum AVQueuedSampleBufferRenderingStatus : long
{
	Unknown,
	Rendering,
	Failed
}
