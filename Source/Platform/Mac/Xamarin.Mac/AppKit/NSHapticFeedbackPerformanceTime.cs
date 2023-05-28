using ObjCRuntime;

namespace AppKit;

[Mac(10, 11)]
[Native]
public enum NSHapticFeedbackPerformanceTime : ulong
{
	Default,
	Now,
	DrawCompleted
}
