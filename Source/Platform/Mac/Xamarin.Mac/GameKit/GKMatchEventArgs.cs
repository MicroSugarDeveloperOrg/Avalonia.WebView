using System;

namespace GameKit;

public class GKMatchEventArgs : EventArgs
{
	public GKMatch Match { get; set; }

	public GKMatchEventArgs(GKMatch match)
	{
		Match = match;
	}
}
