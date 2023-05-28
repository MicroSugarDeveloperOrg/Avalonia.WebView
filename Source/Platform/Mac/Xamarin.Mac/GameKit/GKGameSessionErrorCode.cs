using ObjCRuntime;

namespace GameKit;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, null)]
[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Native]
public enum GKGameSessionErrorCode : long
{
	Unknown = 1L,
	NotAuthenticated,
	SessionConflict,
	SessionNotShared,
	ConnectionCancelledByUser,
	ConnectionFailed,
	SessionHasMaxConnectedPlayers,
	SendDataNotConnected,
	SendDataNoRecipients,
	SendDataNotReachable,
	SendRateLimitReached,
	BadContainer,
	CloudQuotaExceeded,
	NetworkFailure,
	CloudDriveDisabled,
	InvalidSession
}
