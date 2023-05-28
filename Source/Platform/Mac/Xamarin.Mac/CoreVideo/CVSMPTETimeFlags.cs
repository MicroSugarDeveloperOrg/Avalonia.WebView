using System;
using ObjCRuntime;

namespace CoreVideo;

[Flags]
[Watch(4, 0)]
public enum CVSMPTETimeFlags : uint
{
	Valid = 1u,
	Running = 2u
}
