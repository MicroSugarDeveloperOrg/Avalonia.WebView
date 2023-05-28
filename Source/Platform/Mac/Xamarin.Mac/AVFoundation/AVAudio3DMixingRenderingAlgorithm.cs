using ObjCRuntime;

namespace AVFoundation;

[Native]
public enum AVAudio3DMixingRenderingAlgorithm : long
{
	EqualPowerPanning = 0L,
	SphericalHead = 1L,
	HRTF = 2L,
	SoundField = 3L,
	StereoPassThrough = 5L
}
