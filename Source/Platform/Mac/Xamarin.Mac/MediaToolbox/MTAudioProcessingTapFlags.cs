using System;

namespace MediaToolbox;

[Flags]
public enum MTAudioProcessingTapFlags : uint
{
	StartOfStream = 0x100u,
	EndOfStream = 0x200u
}
