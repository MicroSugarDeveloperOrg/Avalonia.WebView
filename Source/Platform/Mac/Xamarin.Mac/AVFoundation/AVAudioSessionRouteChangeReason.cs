using ObjCRuntime;

namespace AVFoundation;

[Native]
public enum AVAudioSessionRouteChangeReason : ulong
{
	Unknown = 0uL,
	NewDeviceAvailable = 1uL,
	OldDeviceUnavailable = 2uL,
	CategoryChange = 3uL,
	Override = 4uL,
	WakeFromSleep = 6uL,
	NoSuitableRouteForCategory = 7uL,
	RouteConfigurationChange = 8uL
}
