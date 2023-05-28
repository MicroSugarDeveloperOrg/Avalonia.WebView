using ObjCRuntime;

namespace Intents;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Native]
public enum INRecurrenceFrequency : long
{
	Unknown,
	Minute,
	Hourly,
	Daily,
	Weekly,
	Monthly,
	Yearly
}
