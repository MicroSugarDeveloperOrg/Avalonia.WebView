using System;

namespace GameKit;

public class GKMatchmakingPlayerEventArgs : EventArgs
{
	public GKPlayer PlayerID { get; set; }

	public GKMatchmakingPlayerEventArgs(GKPlayer playerID)
	{
		PlayerID = playerID;
	}
}
