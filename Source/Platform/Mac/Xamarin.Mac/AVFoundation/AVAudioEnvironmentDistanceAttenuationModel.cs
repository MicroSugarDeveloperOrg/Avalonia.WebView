using ObjCRuntime;

namespace AVFoundation;

[Native]
public enum AVAudioEnvironmentDistanceAttenuationModel : long
{
	Exponential = 1L,
	Inverse,
	Linear
}
