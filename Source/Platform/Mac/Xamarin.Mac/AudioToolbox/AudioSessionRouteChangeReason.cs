namespace AudioToolbox;

public enum AudioSessionRouteChangeReason
{
	Unknown = 0,
	NewDeviceAvailable = 1,
	OldDeviceUnavailable = 2,
	CategoryChange = 3,
	Override = 4,
	WakeFromSleep = 6,
	NoSuitableRouteForCategory = 7
}
