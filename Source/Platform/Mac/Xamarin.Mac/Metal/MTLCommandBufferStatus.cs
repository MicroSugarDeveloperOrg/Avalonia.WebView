using ObjCRuntime;

namespace Metal;

[Native]
public enum MTLCommandBufferStatus : ulong
{
	NotEnqueued,
	Enqueued,
	Committed,
	Scheduled,
	Completed,
	Error
}
