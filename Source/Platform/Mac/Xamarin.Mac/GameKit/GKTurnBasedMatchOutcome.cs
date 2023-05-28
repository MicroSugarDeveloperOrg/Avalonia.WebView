using ObjCRuntime;

namespace GameKit;

[Native]
public enum GKTurnBasedMatchOutcome : long
{
	None = 0L,
	Quit = 1L,
	Won = 2L,
	Lost = 3L,
	Tied = 4L,
	TimeExpired = 5L,
	First = 6L,
	Second = 7L,
	Third = 8L,
	Fourth = 9L,
	CustomRange = 16711680L
}
