using ObjCRuntime;

namespace AVFoundation;

[Since(4, 0)]
public enum AVKeyValueStatus
{
	Unknown,
	Loading,
	Loaded,
	Failed,
	Cancelled
}
