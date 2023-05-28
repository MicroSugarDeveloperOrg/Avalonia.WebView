using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSTextMovement : long
{
	Other = 0L,
	Return = 16L,
	Tab = 17L,
	Backtab = 18L,
	Left = 19L,
	Right = 20L,
	Up = 21L,
	Down = 22L,
	Cancel = 23L
}
