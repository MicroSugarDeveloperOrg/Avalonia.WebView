using System;
using ObjCRuntime;

namespace AVFoundation;

[Flags]
[Native]
public enum AVAudioSessionInterruptionOptions : ulong
{
	ShouldResume = 1uL
}
