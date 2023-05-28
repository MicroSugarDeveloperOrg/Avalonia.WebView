using System;

namespace AppKit;

public class NSAnimationEventArgs : EventArgs
{
	public float Progress { get; set; }

	public NSAnimationEventArgs(float progress)
	{
		Progress = progress;
	}
}
