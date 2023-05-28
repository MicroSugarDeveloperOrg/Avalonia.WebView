using System;
using ObjCRuntime;

namespace GameKit;

[Native]
public enum GKError : long
{
	None = 0L,
	Unknown = 1L,
	Cancelled = 2L,
	CommunicationsFailure = 3L,
	UserDenied = 4L,
	InvalidCredentials = 5L,
	NotAuthenticated = 6L,
	AuthenticationInProgress = 7L,
	InvalidPlayer = 8L,
	ScoreNotSet = 9L,
	ParentalControlsBlocked = 10L,
	PlayerStatusExceedsMaximumLength = 11L,
	PlayerStatusInvalid = 12L,
	MatchRequestInvalid = 13L,
	Underage = 14L,
	GameUnrecognized = 15L,
	NotSupported = 16L,
	InvalidParameter = 17L,
	UnexpectedConnection = 18L,
	ChallengeInvalid = 19L,
	TurnBasedMatchDataTooLarge = 20L,
	TurnBasedTooManySessions = 21L,
	TurnBasedInvalidParticipant = 22L,
	TurnBasedInvalidTurn = 23L,
	TurnBasedInvalidState = 24L,
	[Obsolete("This value was re-used on macOS only and removed later.", false)]
	Offline = 25L,
	InvitationsDisabled = 25L,
	PlayerPhotoFailure = 26L,
	UbiquityContainerUnavailable = 27L,
	MatchNotConnected = 28L,
	GameSessionRequestInvalid = 29L,
	RestrictedToAutomatch = 30L,
	ApiNotAvailable = 31L
}
