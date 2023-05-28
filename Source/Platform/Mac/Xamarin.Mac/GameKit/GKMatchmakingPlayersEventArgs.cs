using System;

namespace GameKit;

public class GKMatchmakingPlayersEventArgs : EventArgs
{
	public GKPlayer[] PlayerIDs { get; set; }

	public GKMatchmakingPlayersEventArgs(GKPlayer[] playerIDs)
	{
		PlayerIDs = playerIDs;
	}
}
