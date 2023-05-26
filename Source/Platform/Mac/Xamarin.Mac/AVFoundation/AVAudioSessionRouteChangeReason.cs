namespace AVFoundation;

public enum AVAudioSessionRouteChangeReason
{
	Unknown,
	NewDeviceAvailable,
	OldDeviceUnavailable,
	CategoryChange,
	Override,
	WakeFromSleep,
	NoSuitableRouteForCategory
}
