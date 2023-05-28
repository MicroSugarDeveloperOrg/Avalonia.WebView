using ObjCRuntime;

namespace AVFoundation;

[Native]
public enum AVAudioUnitEQFilterType : long
{
	Parametric,
	LowPass,
	HighPass,
	ResonantLowPass,
	ResonantHighPass,
	BandPass,
	BandStop,
	LowShelf,
	HighShelf,
	ResonantLowShelf,
	ResonantHighShelf
}
