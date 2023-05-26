using System;

namespace CoreAnimation;

public class CAAnimationStateEventArgs : EventArgs
{
	public bool Finished { get; set; }

	public CAAnimationStateEventArgs(bool finished)
	{
		Finished = finished;
	}
}
