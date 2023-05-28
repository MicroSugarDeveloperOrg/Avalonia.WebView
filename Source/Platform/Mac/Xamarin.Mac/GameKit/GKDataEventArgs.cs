using System;
using Foundation;

namespace GameKit;

public class GKDataEventArgs : EventArgs
{
	public NSData Data { get; set; }

	public string PlayerId { get; set; }

	public GKDataEventArgs(NSData data, string playerId)
	{
		Data = data;
		PlayerId = playerId;
	}
}
