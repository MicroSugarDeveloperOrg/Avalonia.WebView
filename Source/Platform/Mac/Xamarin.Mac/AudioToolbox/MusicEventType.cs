namespace AudioToolbox;

public enum MusicEventType : uint
{
	Null = 0u,
	ExtendedNote = 1u,
	ExtendedTempo = 3u,
	User = 4u,
	Meta = 5u,
	MidiNoteMessage = 6u,
	MidiChannelMessage = 7u,
	MidiRawData = 8u,
	Parameter = 9u,
	AUPreset = 10u
}
