using System;
using Foundation;

namespace GameKit;

public class GKMatchReceivedDataFromRemotePlayerEventArgs : EventArgs
{
	public NSData Data { get; set; }

	public GKPlayer Player { get; set; }

	public GKMatchReceivedDataFromRemotePlayerEventArgs(NSData data, GKPlayer player)
	{
		Data = data;
		Player = player;
	}
}
