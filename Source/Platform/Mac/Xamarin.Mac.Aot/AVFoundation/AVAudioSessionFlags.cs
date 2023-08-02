using System;
using ObjCRuntime;

namespace AVFoundation;

[Flags]
[Since(4, 0)]
public enum AVAudioSessionFlags
{
	NotifyOthersOnDeactivation = 1
}
