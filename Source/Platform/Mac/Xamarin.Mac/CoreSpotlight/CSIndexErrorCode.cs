using ObjCRuntime;

namespace CoreSpotlight;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Native]
public enum CSIndexErrorCode : long
{
	UnknownError = -1L,
	IndexUnavailableError = -1000L,
	InvalidItemError = -1001L,
	InvalidClientStateError = -1002L,
	RemoteConnectionError = -1003L,
	QuotaExceeded = -1004L,
	IndexingUnsupported = -1005L
}
