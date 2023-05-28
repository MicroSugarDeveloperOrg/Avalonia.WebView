using System;
using ObjCRuntime;

namespace MediaPlayer;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum MPMediaType : ulong
{
	Music = 1uL,
	Podcast = 2uL,
	AudioBook = 4uL,
	AudioITunesU = 8uL,
	AnyAudio = 0xFFuL,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	Movie = 0x100uL,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TVShow = 0x200uL,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	VideoPodcast = 0x400uL,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	MusicVideo = 0x800uL,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	VideoITunesU = 0x1000uL,
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	HomeVideo = 0x2000uL,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TypeAnyVideo = 0xFF00uL,
	Any = ulong.MaxValue
}
