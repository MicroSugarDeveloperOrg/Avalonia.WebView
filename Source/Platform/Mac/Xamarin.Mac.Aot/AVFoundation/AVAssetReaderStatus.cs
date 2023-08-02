using ObjCRuntime;

namespace AVFoundation;

[Since(4, 0)]
public enum AVAssetReaderStatus
{
	Unknown,
	Reading,
	Completed,
	Failed,
	Cancelled
}
