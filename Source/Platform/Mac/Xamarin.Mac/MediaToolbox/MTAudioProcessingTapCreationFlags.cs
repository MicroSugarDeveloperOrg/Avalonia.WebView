using System;

namespace MediaToolbox;

[Flags]
public enum MTAudioProcessingTapCreationFlags : uint
{
	PreEffects = 1u,
	PostEffects = 2u
}
