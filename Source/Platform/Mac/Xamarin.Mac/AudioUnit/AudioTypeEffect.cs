using Foundation;
using ObjCRuntime;

namespace AudioUnit;

public enum AudioTypeEffect
{
	PeakLimiter = 1819112562,
	DynamicsProcessor = 1684237680,
	LowPassFilter = 1819304307,
	HighPassFilter = 1752195443,
	HighShelfFilter = 1752393830,
	LowShelfFilter = 1819502694,
	[Obsoleted(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	DCFilter = 1684235884,
	ParametricEQ = 1886217585,
	Delay = 1684368505,
	[iOS(8, 0)]
	SampleDelay = 1935961209,
	Distortion = 1684632436,
	BandPassFilter = 1651532147,
	GraphicEQ = 1735550321,
	MultiBandCompressor = 1835232624,
	MatrixReverb = 1836213622,
	Pitch = 1885959267,
	AUFilter = 1718185076,
	NetSend = 1853058660,
	RogerBeep = 1919903602,
	[Mac(10, 15)]
	[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
	[Advice("This API is not available when using UIKit on macOS.")]
	Reverb2 = 1920361010,
	NBandEq = 1851942257
}
