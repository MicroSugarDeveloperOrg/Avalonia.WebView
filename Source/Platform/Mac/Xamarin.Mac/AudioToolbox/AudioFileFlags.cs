using System;

namespace AudioToolbox;

[Flags]
public enum AudioFileFlags
{
	EraseFlags = 1,
	DontPageAlignAudioData = 2
}
