using System;

namespace AudioToolbox;

[Flags]
public enum AudioQueueProcessingTapFlags : uint
{
	PreEffects = 1u,
	PostEffects = 2u,
	Siphon = 4u,
	StartOfStream = 0x100u,
	EndOfStream = 0x200u
}
