using System;

namespace GameKit;

public class GKStateEventArgs : EventArgs
{
	public string PlayerId { get; set; }

	public GKPlayerConnectionState State { get; set; }

	public GKStateEventArgs(string playerId, GKPlayerConnectionState state)
	{
		PlayerId = playerId;
		State = state;
	}
}
