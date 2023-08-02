using System;

namespace AVFoundation;

public class AVChannelsEventArgs : EventArgs
{
	public int NumberOfChannels { get; private set; }

	public AVChannelsEventArgs(int numberOfChannels)
	{
		NumberOfChannels = numberOfChannels;
	}
}
