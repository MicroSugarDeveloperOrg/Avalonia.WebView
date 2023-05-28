using System;

namespace VideoToolbox;

[Flags]
public enum VTEncodeInfoFlags : uint
{
	Asynchronous = 1u,
	FrameDropped = 2u
}
