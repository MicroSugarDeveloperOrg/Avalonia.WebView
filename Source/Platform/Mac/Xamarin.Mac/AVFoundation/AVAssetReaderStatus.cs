using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Native]
public enum AVAssetReaderStatus : long
{
	Unknown,
	Reading,
	Completed,
	Failed,
	Cancelled
}
