using ObjCRuntime;

namespace AppKit;

[Mac(10, 10)]
[Native]
public enum NSGestureRecognizerState : long
{
	Possible = 0L,
	Began = 1L,
	Changed = 2L,
	Ended = 3L,
	Cancelled = 4L,
	Failed = 5L,
	Recognized = 3L
}
