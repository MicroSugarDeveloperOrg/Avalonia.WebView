using System;

namespace AudioToolbox;

[Flags]
public enum AudioFileRegionFlags : uint
{
	LoopEnable = 1u,
	PlayForward = 2u,
	PlayBackward = 4u
}
