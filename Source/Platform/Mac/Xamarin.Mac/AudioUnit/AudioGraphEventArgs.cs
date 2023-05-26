using System;
using AudioToolbox;

namespace AudioUnit;

[Obsolete]
public class AudioGraphEventArgs : AudioUnitEventArgs
{
	public AudioGraphEventArgs(AudioUnitRenderActionFlags actionFlags, AudioTimeStamp timeStamp, int busNumber, int numberFrames, AudioBufferList data)
		: base(actionFlags, timeStamp, busNumber, numberFrames, data)
	{
	}
}
