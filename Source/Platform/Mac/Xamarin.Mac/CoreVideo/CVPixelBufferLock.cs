using System;
using ObjCRuntime;

namespace CoreVideo;

[Flags]
[Watch(4, 0)]
public enum CVPixelBufferLock : uint
{
	None = 0u,
	ReadOnly = 1u
}
