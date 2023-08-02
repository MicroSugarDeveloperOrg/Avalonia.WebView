namespace AppKit;

public enum NSTouchPhase : ulong
{
	Began = 1uL,
	Moved = 2uL,
	Stationary = 4uL,
	Ended = 8uL,
	Cancelled = 16uL,
	Touching = 7uL,
	Any = ulong.MaxValue
}
