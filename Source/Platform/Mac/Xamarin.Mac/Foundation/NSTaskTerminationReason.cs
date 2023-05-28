using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSTaskTerminationReason : long
{
	Exit = 1L,
	UncaughtSignal
}
