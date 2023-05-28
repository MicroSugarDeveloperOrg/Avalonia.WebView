using ObjCRuntime;

namespace CoreVideo;

[Watch(4, 0)]
[iOS(9, 0)]
[Mac(10, 11)]
public enum CVPixelBufferPoolFlushFlags : ulong
{
	FlushExcessBuffers = 1uL
}
