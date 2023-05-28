using System;
using ObjCRuntime;

namespace AVFoundation;

[Flags]
[Native]
public enum AVAudioPlayerNodeBufferOptions : ulong
{
	Loops = 1uL,
	Interrupts = 2uL,
	InterruptsAtLoop = 4uL
}
