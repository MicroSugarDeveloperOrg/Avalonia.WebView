using ObjCRuntime;

namespace iTunesLibrary;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Native]
public enum ITLibDistinguishedPlaylistKind : ulong
{
	None = 0uL,
	Movies = 1uL,
	TVShows = 2uL,
	Music = 3uL,
	Audiobooks = 4uL,
	Books = 4uL,
	Ringtones = 5uL,
	Podcasts = 7uL,
	VoiceMemos = 14uL,
	Purchases = 16uL,
	iTunesU = 26uL,
	NightiesMusic = 42uL,
	MyTopRated = 43uL,
	Top25MostPlayed = 44uL,
	RecentlyPlayed = 45uL,
	RecentlyAdded = 46uL,
	MusicVideos = 47uL,
	ClassicalMusic = 48uL,
	LibraryMusicVideos = 49uL,
	HomeVideos = 50uL,
	Applications = 51uL,
	LovedSongs = 52uL,
	MusicShowsAndMovies = 53uL
}
