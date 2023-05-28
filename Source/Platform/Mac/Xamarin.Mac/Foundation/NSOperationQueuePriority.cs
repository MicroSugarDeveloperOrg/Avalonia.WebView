using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSOperationQueuePriority : long
{
	VeryLow = -8L,
	Low = -4L,
	Normal = 0L,
	High = 4L,
	VeryHigh = 8L
}
