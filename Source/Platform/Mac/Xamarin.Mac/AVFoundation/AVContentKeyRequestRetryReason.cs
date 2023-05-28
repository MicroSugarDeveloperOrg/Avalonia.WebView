using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public enum AVContentKeyRequestRetryReason
{
	TimedOut,
	ReceivedResponseWithExpiredLease,
	ReceivedObsoleteContentKey
}
