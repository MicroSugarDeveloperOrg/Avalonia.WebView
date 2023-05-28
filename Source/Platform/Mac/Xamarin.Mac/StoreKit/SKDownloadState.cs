using ObjCRuntime;

namespace StoreKit;

[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
[Native]
public enum SKDownloadState : long
{
	Waiting,
	Active,
	Paused,
	Finished,
	Failed,
	Cancelled
}
