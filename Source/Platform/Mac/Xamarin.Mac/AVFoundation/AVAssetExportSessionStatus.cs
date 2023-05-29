using ObjCRuntime;

namespace AVFoundation;

[Since(4, 0)]
public enum AVAssetExportSessionStatus
{
	Unknown,
	Waiting,
	Exporting,
	Completed,
	Failed,
	Cancelled
}
