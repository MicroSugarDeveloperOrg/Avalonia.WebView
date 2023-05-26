using System;
using AudioToolbox;

namespace AudioUnit;

[Obsolete]
public class AudioUnitEventArgs : EventArgs
{
	public readonly AudioUnitRenderActionFlags ActionFlags;

	public readonly AudioTimeStamp TimeStamp;

	public readonly int BusNumber;

	public readonly int NumberFrames;

	public readonly AudioBufferList Data;

	public AudioUnitEventArgs(AudioUnitRenderActionFlags actionFlags, AudioTimeStamp timestamp, int busNumber, int frames, AudioBufferList data)
	{
		ActionFlags = actionFlags;
		TimeStamp = timestamp;
		BusNumber = busNumber;
		NumberFrames = frames;
		Data = data;
	}
}
