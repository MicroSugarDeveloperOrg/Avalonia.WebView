using ObjCRuntime;

namespace Foundation;

[Since(4, 0)]
public enum NSOperationQueuePriority : long
{
	VeryLow = -8L,
	Low = -4L,
	Normal = 0L,
	High = 4L,
	VeryHigh = 8L
}
