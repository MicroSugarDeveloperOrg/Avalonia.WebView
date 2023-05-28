using ObjCRuntime;

namespace GameKit;

[Native]
public enum GKTurnBasedParticipantStatus : long
{
	Unknown,
	Invited,
	Declined,
	Matching,
	Active,
	Done
}
