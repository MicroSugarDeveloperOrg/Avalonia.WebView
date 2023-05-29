using System;

namespace AVFoundation;

[Flags]
public enum AVAudioSessionCategoryOptions
{
	MixWithOthers = 1,
	DuckOthers = 2,
	AllowBluetooth = 4,
	DefaultToSpeaker = 8
}
