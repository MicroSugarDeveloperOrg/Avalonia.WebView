using System;

namespace GameKit;

public class GKPlayersEventArgs : EventArgs
{
	public string[] PlayerIDs { get; set; }

	public GKPlayersEventArgs(string[] playerIDs)
	{
		PlayerIDs = playerIDs;
	}
}
