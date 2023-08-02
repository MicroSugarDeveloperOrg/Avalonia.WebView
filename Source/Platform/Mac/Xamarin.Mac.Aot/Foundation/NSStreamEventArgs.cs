using System;

namespace Foundation;

public class NSStreamEventArgs : EventArgs
{
	public NSStreamEvent StreamEvent { get; set; }

	public NSStreamEventArgs(NSStreamEvent streamEvent)
	{
		StreamEvent = streamEvent;
	}
}
