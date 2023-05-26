using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSUrlSessionTaskState : long
{
	Running,
	Suspended,
	Canceling,
	Completed
}
