using ObjCRuntime;

namespace AVFoundation;

[Since(4, 1)]
public enum AVAssetWriterStatus
{
	Unknown,
	Writing,
	Completed,
	Failed,
	Cancelled
}
