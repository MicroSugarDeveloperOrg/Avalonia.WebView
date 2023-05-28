namespace AudioToolbox;

public enum MusicPlayerStatus
{
	Success = 0,
	InvalidSequenceType = -10846,
	TrackIndexError = -10859,
	TrackNotFound = -10858,
	EndOfTrack = -10857,
	StartOfTrack = -10856,
	IllegalTrackDestination = -10855,
	NoSequence = -10854,
	InvalidEventType = -10853,
	InvalidPlayerState = -10852,
	CannotDoInCurrentContext = -10863,
	NoTrackDestination = -66720
}
