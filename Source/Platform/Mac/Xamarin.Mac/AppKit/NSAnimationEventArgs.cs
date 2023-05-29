using System;

namespace AppKit;

public class NSAnimationEventArgs : EventArgs
{
	public double Progress { get; set; }

	public NSAnimationEventArgs(double progress)
	{
		Progress = progress;
	}
}
