using System;

namespace AudioToolbox;

public enum AudioSessionProperty
{
	PreferredHardwareSampleRate = 1752658802,
	PreferredHardwareIOBufferDuration = 1768907364,
	AudioCategory = 1633902964,
	[Obsolete("Deprecated in iOS 5.0")]
	AudioRoute = 1919907188,
	AudioRouteChange = 1919902568,
	CurrentHardwareSampleRate = 1667789682,
	CurrentHardwareInputNumberChannels = 1667787107,
	CurrentHardwareOutputNumberChannels = 1667788643,
	CurrentHardwareOutputVolume = 1667788662,
	CurrentHardwareInputLatency = 1667853428,
	CurrentHardwareOutputLatency = 1668246644,
	CurrentHardwareIOBufferDuration = 1667785316,
	OtherAudioIsPlaying = 1869899890,
	OverrideAudioRoute = 1870033508,
	AudioInputAvailable = 1634296182,
	ServerDied = 1684628836,
	OtherMixableAudioShouldDuck = 1685414763,
	OverrideCategoryMixWithOthers = 1668114808,
	OverrideCategoryDefaultToSpeaker = 1668509803,
	OverrideCategoryEnableBluetoothInput = 1667394677,
	InterruptionType = 1954115685,
	Mode = 1836016741,
	InputSources = 1936876403,
	OutputDestinations = 1685288051,
	InputSource = 1769173603,
	OutputDestination = 1868854132,
	InputGainAvailable = 1768382838,
	InputGainScalar = 1768387427,
	AudioRouteDescription = 1668440434
}
