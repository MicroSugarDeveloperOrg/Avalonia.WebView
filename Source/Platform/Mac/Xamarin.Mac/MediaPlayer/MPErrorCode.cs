using ObjCRuntime;

namespace MediaPlayer;

[Introduced(PlatformName.MacOSX, 10, 14, 2, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
[Native]
public enum MPErrorCode : long
{
	Unknown,
	PermissionDenied,
	CloudServiceCapabilityMissing,
	NetworkConnectionFailed,
	NotFound,
	NotSupported,
	[Introduced(PlatformName.iOS, 10, 1, PlatformArchitecture.All, null)]
	Cancelled,
	RequestTimedOut
}
