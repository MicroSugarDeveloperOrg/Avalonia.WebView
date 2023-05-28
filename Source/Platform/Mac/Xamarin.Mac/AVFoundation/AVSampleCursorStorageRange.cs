using ObjCRuntime;

namespace AVFoundation;

[Mac(10, 10)]
[NoiOS]
[NoWatch]
[NoTV]
public struct AVSampleCursorStorageRange
{
	public long Offset;

	public long Length;
}
