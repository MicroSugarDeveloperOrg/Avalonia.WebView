using System;
using ObjCRuntime;

namespace AVFoundation;

[Flags]
[Native]
public enum AVAudioSessionCategoryOptions : ulong
{
	MixWithOthers = 1uL,
	DuckOthers = 2uL,
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	AllowBluetooth = 4uL,
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	DefaultToSpeaker = 8uL,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	InterruptSpokenAudioAndMixWithOthers = 0x11uL,
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	AllowBluetoothA2DP = 0x20uL,
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	AllowAirPlay = 0x40uL
}
