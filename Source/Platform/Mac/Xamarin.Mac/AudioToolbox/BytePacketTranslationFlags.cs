using System;

namespace AudioToolbox;

[Flags]
internal enum BytePacketTranslationFlags : uint
{
	IsEstimate = 1u
}
