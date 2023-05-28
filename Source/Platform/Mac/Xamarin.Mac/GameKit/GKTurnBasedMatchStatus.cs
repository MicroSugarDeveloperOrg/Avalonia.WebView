using ObjCRuntime;

namespace GameKit;

[Native]
public enum GKTurnBasedMatchStatus : long
{
	Unknown,
	Open,
	Ended,
	Matching
}
