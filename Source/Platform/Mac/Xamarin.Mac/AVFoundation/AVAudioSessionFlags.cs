using System;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, null)]
[Flags]
[Native]
public enum AVAudioSessionFlags : ulong
{
	NotifyOthersOnDeactivation = 1uL
}
