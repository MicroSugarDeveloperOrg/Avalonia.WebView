using System;

namespace GameKit;

public class GKPlayerEventArgs : EventArgs
{
	public string PlayerID { get; set; }

	public GKPlayerEventArgs(string playerID)
	{
		PlayerID = playerID;
	}
}
