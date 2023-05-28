using ObjCRuntime;

namespace iTunesLibrary;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Native]
public enum ITLibMediaItemMediaKind : ulong
{
	Unknown = 1uL,
	Song = 2uL,
	Movie = 3uL,
	Podcast = 4uL,
	Audiobook = 5uL,
	PdfBooklet = 6uL,
	MusicVideo = 7uL,
	TVShow = 8uL,
	InteractiveBooklet = 9uL,
	HomeVideo = 12uL,
	Ringtone = 14uL,
	DigitalBooklet = 15uL,
	iOSApplication = 16uL,
	VoiceMemo = 17uL,
	iTunesU = 18uL,
	Book = 19uL,
	PdfBook = 20uL,
	AlertTone = 21uL
}
