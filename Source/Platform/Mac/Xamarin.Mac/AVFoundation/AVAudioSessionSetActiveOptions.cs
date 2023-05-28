using System;
using ObjCRuntime;

namespace AVFoundation;

[Flags]
[Native]
public enum AVAudioSessionSetActiveOptions : ulong
{
	NotifyOthersOnDeactivation = 1uL
}
