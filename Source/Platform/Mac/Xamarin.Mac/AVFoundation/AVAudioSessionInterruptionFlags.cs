using System;
using ObjCRuntime;

namespace AVFoundation;

[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, null)]
[Flags]
[Native]
public enum AVAudioSessionInterruptionFlags : ulong
{
	ShouldResume = 1uL
}
