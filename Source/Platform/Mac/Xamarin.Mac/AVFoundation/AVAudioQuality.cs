using ObjCRuntime;

namespace AVFoundation;

[Native]
public enum AVAudioQuality : long
{
	Min = 0L,
	Low = 32L,
	Medium = 64L,
	High = 96L,
	Max = 127L
}
