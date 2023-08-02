using System;

namespace AppKit;

public class NSWindowDurationEventArgs : EventArgs
{
	public double Duration { get; set; }

	public NSWindowDurationEventArgs(double duration)
	{
		Duration = duration;
	}
}
