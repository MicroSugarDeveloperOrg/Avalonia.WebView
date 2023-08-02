using System;

namespace AVFoundation;

public class AVSampleRateEventArgs : EventArgs
{
	public double SampleRate { get; private set; }

	public AVSampleRateEventArgs(double sampleRate)
	{
		SampleRate = sampleRate;
	}
}
