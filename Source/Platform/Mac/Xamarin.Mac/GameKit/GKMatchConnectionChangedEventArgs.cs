using System;

namespace GameKit;

public class GKMatchConnectionChangedEventArgs : EventArgs
{
	public GKPlayer Player { get; set; }

	public GKPlayerConnectionState State { get; set; }

	public GKMatchConnectionChangedEventArgs(GKPlayer player, GKPlayerConnectionState state)
	{
		Player = player;
		State = state;
	}
}
