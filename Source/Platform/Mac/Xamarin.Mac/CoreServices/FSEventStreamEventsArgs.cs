using System;

namespace CoreServices;

public sealed class FSEventStreamEventsArgs : EventArgs
{
	public FSEvent[] Events { get; private set; }

	internal FSEventStreamEventsArgs(FSEvent[] events)
	{
		Events = events;
	}
}
