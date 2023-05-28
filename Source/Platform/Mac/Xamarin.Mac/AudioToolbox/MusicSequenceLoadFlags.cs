using System;

namespace AudioToolbox;

[Flags]
public enum MusicSequenceLoadFlags
{
	PreserveTracks = 0,
	ChannelsToTracks = 1
}
