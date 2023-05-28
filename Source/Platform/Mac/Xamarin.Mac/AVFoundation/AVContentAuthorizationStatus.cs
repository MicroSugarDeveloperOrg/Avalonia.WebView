using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Native]
public enum AVContentAuthorizationStatus : long
{
	Unknown,
	Completed,
	Cancelled,
	TimedOut,
	Busy,
	NotAvailable,
	NotPossible
}
