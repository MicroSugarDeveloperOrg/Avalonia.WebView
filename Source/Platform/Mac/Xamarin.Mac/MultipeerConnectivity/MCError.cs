using ObjCRuntime;

namespace MultipeerConnectivity;

[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Native]
public enum MCError : long
{
	Unknown,
	NotConnected,
	InvalidParameter,
	Unsupported,
	TimedOut,
	Cancelled,
	Unavailable
}
